
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Universal I/O backend that is used to read files.<br/>
    /// Decided when the component is opened based on `storage.performance.io_uring` option, component memory placement and kernel io_uring support.<br/>
    /// Options:<br/>
    /// * `Mmap` - Reads are served by the page cache through a memory mapping.<br/>
    /// * `IoUring` - Reads are submitted to the kernel with io_uring.
    /// </summary>
    public enum IoBackend
    {
        /// <summary>
        ///
        /// </summary>
        IoUring,
        /// <summary>
        ///
        /// </summary>
        Mmap,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IoBackendExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IoBackend value)
        {
            return value switch
            {
                IoBackend.IoUring => "io_uring",
                IoBackend.Mmap => "mmap",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IoBackend? ToEnum(string value)
        {
            return value switch
            {
                "io_uring" => IoBackend.IoUring,
                "mmap" => IoBackend.Mmap,
                _ => null,
            };
        }
    }
}