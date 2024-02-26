using System.Globalization;

namespace MusicStore.Models
{
    public static class SessionExtensions
    {
        public static void SetDecimal(this ISession session, string key, decimal value)
        {
            session.SetString(key, value.ToString(CultureInfo.InvariantCulture));
        }

        public static decimal GetDecimal(this ISession session, string key)
        {
            string value = session.GetString(key);
            return value == null ? 0M : decimal.Parse(value, CultureInfo.InvariantCulture);
        }
    }
}
