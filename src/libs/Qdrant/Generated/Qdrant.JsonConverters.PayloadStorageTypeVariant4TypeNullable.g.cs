#nullable enable

namespace Qdrant.JsonConverters
{
    /// <inheritdoc />
    public sealed class PayloadStorageTypeVariant4TypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Qdrant.PayloadStorageTypeVariant4Type?>
    {
        /// <inheritdoc />
        public override global::Qdrant.PayloadStorageTypeVariant4Type? Read(
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
                        return global::Qdrant.PayloadStorageTypeVariant4TypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Qdrant.PayloadStorageTypeVariant4Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Qdrant.PayloadStorageTypeVariant4Type?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Qdrant.PayloadStorageTypeVariant4Type? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Qdrant.PayloadStorageTypeVariant4TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
