
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Placeholder storage: contains no data, all vectors reported as deleted. Used for newly created sparse named vectors on immutable segments.
    /// </summary>
    public enum SparseVectorStorageTypeVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Empty,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SparseVectorStorageTypeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SparseVectorStorageTypeVariant2 value)
        {
            return value switch
            {
                SparseVectorStorageTypeVariant2.Empty => "empty",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SparseVectorStorageTypeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "empty" => SparseVectorStorageTypeVariant2.Empty,
                _ => null,
            };
        }
    }
}