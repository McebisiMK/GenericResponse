namespace GenericResponse.Extensions
{
    public static class CustomExtensions
    {
        public static bool HasValue(this string value) => !IsEmpty(value);

        public static bool IsEmpty(this string value) => string.IsNullOrWhiteSpace(value);

        public static void Clear<T>(this List<T> list)
        {
            list = new List<T>();
        }
    }
}