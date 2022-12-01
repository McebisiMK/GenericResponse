namespace GenericValidatableResponse.Extensions
{
    public static class CustomExtensions
    {
        public static bool IsEmpty(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool HasValue(this string value)
        {
            return !IsEmpty(value);
        }

        public static void Clear<T>(this List<T> list)
        {
            list = new List<T>();
        }
    }
}