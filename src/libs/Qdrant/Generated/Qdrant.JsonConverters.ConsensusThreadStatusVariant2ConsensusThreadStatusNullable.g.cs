#nullable enable

namespace Qdrant.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConsensusThreadStatusVariant2ConsensusThreadStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Qdrant.ConsensusThreadStatusVariant2ConsensusThreadStatus?>
    {
        /// <inheritdoc />
        public override global::Qdrant.ConsensusThreadStatusVariant2ConsensusThreadStatus? Read(
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
                        return global::Qdrant.ConsensusThreadStatusVariant2ConsensusThreadStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Qdrant.ConsensusThreadStatusVariant2ConsensusThreadStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Qdrant.ConsensusThreadStatusVariant2ConsensusThreadStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Qdrant.ConsensusThreadStatusVariant2ConsensusThreadStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Qdrant.ConsensusThreadStatusVariant2ConsensusThreadStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
