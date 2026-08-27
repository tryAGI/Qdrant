
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Tag selecting the explicit "no stemming" algorithm.
    /// </summary>
    public enum NoStemmer
    {
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NoStemmerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NoStemmer value)
        {
            return value switch
            {
                NoStemmer.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NoStemmer? ToEnum(string value)
        {
            return value switch
            {
                "none" => NoStemmer.None,
                _ => null,
            };
        }
    }
}