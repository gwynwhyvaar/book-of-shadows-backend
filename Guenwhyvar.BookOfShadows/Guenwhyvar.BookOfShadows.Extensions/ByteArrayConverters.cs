namespace Guenwhyvar.BookOfShadows.Extensions
{
    public static class ByteArrayConverters
    {
        public static byte[] GetByteArray(this string inputString) => System.Text.Encoding.UTF8.GetBytes(inputString);
        public static string GetStringFromByteArray(this byte[] data) => System.Text.Encoding.UTF8.GetString(data);
    }
}
