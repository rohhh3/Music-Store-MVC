using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;
using MusicStore.Services;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Pdf;

namespace MusicStore.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IItemRepository _itemRepository;

        public CategoriesController(ICategoryRepository categoryRepository, IItemRepository itemRepository)
        {
            _categoryRepository = categoryRepository;
            _itemRepository = itemRepository;
        }

        public IActionResult GeneratePdf(string categoryName)
        {
            GlobalFontSettings.FontResolver = FontResolver.GetInstance();

            var items = _itemRepository.GetItemsByCategoryByName(categoryName);

            var pdfDocument = new PdfDocument();

            PdfPage pdfPage = pdfDocument.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(pdfPage);

            XFont font = new XFont("Arial", 12);

            gfx.DrawString($"{categoryName} - Item List", font, XBrushes.Black, new XRect(10, 10, pdfPage.Width.Point, 20), XStringFormats.TopLeft);

            // naglowek
            DrawTableRow(gfx, font, 10, 40, "Name", "Price in PLN");

            // wiersze
            int yPosition = 60;
            foreach (var item in items)
            {
                DrawTableRow(gfx, font, 10, yPosition, item.Name, item.Price.ToString());
                yPosition += 20;
            }

            var pdfStream = new MemoryStream();
            pdfDocument.Save(pdfStream, false);
            return File(pdfStream.ToArray(), "application/pdf", $"{categoryName}ItemList.pdf");
        }

        private void DrawTableRow(XGraphics gfx, XFont font, double xPosition, double yPosition, params string[] columns)
        {
            double xStart = xPosition;

            double nameWidth = 250;
            double priceWidth = 50;

            gfx.DrawString(columns[0], font, XBrushes.Black, new XRect(xStart, yPosition, nameWidth, 20), XStringFormats.TopLeft);
            xStart += nameWidth;

            xStart += 50;

            gfx.DrawString(columns[1], font, XBrushes.Black, new XRect(xStart, yPosition, priceWidth, 20), XStringFormats.TopLeft);
        }

    }
}
