
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Storage in memory maps (gridstore storage)
    /// </summary>
    public enum SparseVectorStorageTypeEnum
    {
        /// <summary>
        ///
        /// </summary>
        Mmap,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SparseVectorStorageTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SparseVectorStorageTypeEnum value)
        {
            return value switch
            {
                SparseVectorStorageTypeEnum.Mmap => "mmap",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SparseVectorStorageTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "mmap" => SparseVectorStorageTypeEnum.Mmap,
                _ => null,
            };
        }
    }
}