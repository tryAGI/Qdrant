
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Placeholder storage: contains no data, all vectors reported as deleted. Used for newly created named vectors on immutable segments. No files on disk, reconstructed from config on load.
    /// </summary>
    public enum VectorStorageTypeVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        Empty,
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
                VectorStorageTypeVariant6.Empty => "Empty",
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
                "Empty" => VectorStorageTypeVariant6.Empty,
                _ => null,
            };
        }
    }
}