
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Memory placement of a component's data.<br/>
    /// Data is always persisted on disk regardless of this setting; it only controls how the data is held in RAM.<br/>
    /// Options:<br/>
    /// * `Cold` - Data is not pre-loaded from disk to RAM. Preferred for rarely queried components or components larger than RAM size. First request might be slow, but data is cached with usage.<br/>
    /// * `Cached` - Data is pre-loaded into disk-cache RAM on start. First request is fast, but data may be evicted if there is not enough memory and some other component's data is used more frequently.<br/>
    /// * `Pinned` - Data is loaded in RAM and never evicted. First request is fast, but the component must fit in RAM at all times. Recommended for frequently queried small components like quantized vectors or primary indexes.
    /// </summary>
    public enum Memory
    {
        /// <summary>
        /// 
        /// </summary>
        Cached,
        /// <summary>
        /// 
        /// </summary>
        Cold,
        /// <summary>
        /// 
        /// </summary>
        Pinned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MemoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Memory value)
        {
            return value switch
            {
                Memory.Cached => "cached",
                Memory.Cold => "cold",
                Memory.Pinned => "pinned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Memory? ToEnum(string value)
        {
            return value switch
            {
                "cached" => Memory.Cached,
                "cold" => Memory.Cold,
                "pinned" => Memory.Pinned,
                _ => null,
            };
        }
    }
}