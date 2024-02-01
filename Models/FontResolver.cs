using PdfSharp.Fonts;
using PdfSharp.Pdf;

namespace MusicStore.Models
{
    public class FontResolver : IFontResolver
    {
        private FontResolver() { }
        private static FontResolver? _instance;
        public static FontResolver GetInstance()
        {             
            if (_instance == null)
            {
                _instance = new FontResolver();
            }
            return _instance;
        }
        public byte[] GetFont(string faceName)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                //moze potrzebowac absolute path
                var fontBytes = System.IO.File.ReadAllBytes("arial.ttf");
                ms.Write(fontBytes, 0, fontBytes.Length);
                return ms.ToArray();
            }
        }

        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            return new FontResolverInfo("Arial#");
        }
    }
}
