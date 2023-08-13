using System.Text.Json;

namespace Ashion.WebApi.Extensions
{
    public static class SessionExtension
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T? Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value != null ? JsonSerializer.Deserialize<T>(value) : default;
        }
    }
}
