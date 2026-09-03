
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Container runtime Qdrant is running under (`none` if bare metal).
    /// </summary>
    public enum ContainerRuntime
    {
        /// <summary>
        ///
        /// </summary>
        Docker,
        /// <summary>
        ///
        /// </summary>
        Kubernetes,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainerRuntimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerRuntime value)
        {
            return value switch
            {
                ContainerRuntime.Docker => "docker",
                ContainerRuntime.Kubernetes => "kubernetes",
                ContainerRuntime.None => "none",
                ContainerRuntime.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerRuntime? ToEnum(string value)
        {
            return value switch
            {
                "docker" => ContainerRuntime.Docker,
                "kubernetes" => ContainerRuntime.Kubernetes,
                "none" => ContainerRuntime.None,
                "other" => ContainerRuntime.Other,
                _ => null,
            };
        }
    }
}