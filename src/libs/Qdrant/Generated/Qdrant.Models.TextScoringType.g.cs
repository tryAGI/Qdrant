
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// How a text index ranks documents.
    /// </summary>
    public enum TextScoringType
    {
        /// <summary>
        ///
        /// </summary>
        Bm25,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextScoringTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextScoringType value)
        {
            return value switch
            {
                TextScoringType.Bm25 => "bm25",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextScoringType? ToEnum(string value)
        {
            return value switch
            {
                "bm25" => TextScoringType.Bm25,
                _ => null,
            };
        }
    }
}