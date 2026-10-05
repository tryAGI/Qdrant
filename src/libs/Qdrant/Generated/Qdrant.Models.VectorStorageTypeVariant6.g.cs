
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Vectors are inlined in the HNSW links file, not in a dedicated storage. Not appendable.
    /// </summary>
    public enum VectorStorageTypeVariant6
    {
        /// <summary>
        ///
        /// </summary>
        GraphInline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStorageTypeVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStorageTypeVariant6 value)
        {
            return value switch
            {
                VectorStorageTypeVariant6.GraphInline => "GraphInline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStorageTypeVariant6? ToEnum(string value)
        {
            return value switch
            {
                "GraphInline" => VectorStorageTypeVariant6.GraphInline,
                _ => null,
            };
        }
    }
}