#nullable enable

namespace Qdrant.JsonConverters
{
    /// <inheritdoc />
    public sealed class BinaryQuantizationQueryEncodingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Qdrant.BinaryQuantizationQueryEncoding>
    {
        /// <inheritdoc />
        public override global::Qdrant.BinaryQuantizationQueryEncoding Read(
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
                        return global::Qdrant.BinaryQuantizationQueryEncodingExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Qdrant.BinaryQuantizationQueryEncoding)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Qdrant.BinaryQuantizationQueryEncoding);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Qdrant.BinaryQuantizationQueryEncoding value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Qdrant.BinaryQuantizationQueryEncodingExtensions.ToValueString(value));
        }
    }
}
