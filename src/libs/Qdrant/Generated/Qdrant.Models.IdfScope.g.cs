
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Named IDF scope without a corpus filter.
    /// </summary>
    public enum IdfScope
    {
        /// <summary>
        /// 
        /// </summary>
        Global,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IdfScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdfScope value)
        {
            return value switch
            {
                IdfScope.Global => "global",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdfScope? ToEnum(string value)
        {
            return value switch
            {
                "global" => IdfScope.Global,
                _ => null,
            };
        }
    }
}