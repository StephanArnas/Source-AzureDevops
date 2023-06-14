namespace Source.DevOps.Common
{
    public static class StringExtension
    {
        public static string ToUpperFirstChar(this string source)
        {
            return string.IsNullOrEmpty(source) ? string.Empty : $"{char.ToUpper(source[0])}{source[1..]}";
        }

        public static string ToUpperEachWord(this string source, bool formatToLower = true)
        {
            if (string.IsNullOrEmpty(source))
                return string.Empty;

            var array = formatToLower
                ? source.ToLower().ToCharArray()
                : source.ToCharArray();

            for (var i = 0; i < array.Length; i++)
                array[i] = i == 0 || array[i - 1] == ' ' ? char.ToUpper(array[i]) : array[i];

            return new string(array);
        }

        public static string ToLowerEachWord(this string source)
        {
            if (string.IsNullOrEmpty(source))
                return string.Empty;

            var array = source.ToLower().ToCharArray();

            for (var i = 0; i < array.Length; i++)
            {
                if (i == 0 || array[i - 1] == ' ')
                    array[i] = char.ToLower(array[i]);
            }

            return new string(array);
        }
    }
}