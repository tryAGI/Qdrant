#nullable enable

namespace Qdrant.JsonConverters
{
    /// <inheritdoc />
    public sealed class TurboQuantBitSizeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Qdrant.TurboQuantBitSize>
    {
        /// <inheritdoc />
        public override global::Qdrant.TurboQuantBitSize Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Qdrant.TurboQuantBitSizeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Qdrant.TurboQuantBitSize)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Qdrant.TurboQuantBitSize);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Qdrant.TurboQuantBitSize value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Qdrant.TurboQuantBitSizeExtensions.ToValueString(value));
        }
    }
}
