using Refit;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using static PlannerQueries.Model.TaskDetails;

namespace PlannerQueries
{
    internal class SerializationHelper
    {
        public static IHttpContentSerializer GetContentSerializer()
        {
            return new MyHttpContentSerializer();
        }
    }

    internal class MyHttpContentSerializer : IHttpContentSerializer
    {
        public async Task<T?> FromHttpContentAsync<T>(HttpContent content, CancellationToken cancellationToken = default)
        {
            var jsonText = await content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            var item = JsonSerializer.Deserialize<T>(jsonText, GetOptions());
            return item;
        }

        private JsonSerializerOptions? GetOptions()
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(GetConverter());
            return options;
        }

        private JsonConverter GetConverter()
        {
            return new Conv();
        }

        public string? GetFieldNameForProperty(PropertyInfo propertyInfo)
        {
            throw new NotImplementedException();
        }

        public HttpContent ToHttpContent<T>(T item)
        {
            throw new NotImplementedException();
        }
    }

    internal class Conv : JsonConverter<Dictionary<string, CheckListItem>>
    {
        public override Dictionary<string, CheckListItem>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            Dictionary<string, CheckListItem> items = new();

            CheckListItem currentItem = new();

            string key = null;

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    if(string.IsNullOrEmpty(key))
                    {
                        throw new JsonException("No proper value found in json.");
                    }

                    items.Add(key, currentItem);
                    currentItem = new CheckListItem();
                    reader.Read();
                    reader.Read();

                    if(reader.TokenType == JsonTokenType.EndObject)
                    {
                        return items;
                    }
                }

                key = reader.GetString();

                reader.Read();

                if (reader.TokenType != JsonTokenType.StartObject)
                {
                    throw new JsonException("Invalid Json reader value. Expected StartObject.");
                }

                while (reader.TokenType != JsonTokenType.EndObject)
                {
                    reader.Read();
                    var propertyName = reader.GetString();
                    reader.Read();

                    switch (propertyName)
                    {
                        case "@odata.type":
                            currentItem.odatatype = reader.GetString();
                            break;
                        case "isChecked":
                            currentItem.isChecked = reader.GetBoolean();
                            break;
                        case "title":
                            currentItem.Name = reader.GetString();
                            break;
                        case "orderHint":
                            currentItem.orderHint = reader.GetString();
                            break;
                        case "lastModifiedDateTime":
                            currentItem.lastModifiedDateTime = reader.GetDateTime();
                            break;
                        case "lastModifiedBy":
                            User user = ReadUser(ref reader);
                            currentItem.lastModifiedBy = user;
                            break;
                        default:
                            throw new JsonException("Unhandled Json reader value.");
                    }
                }
            }

            throw new JsonException();
        }

        private User ReadUser(ref Utf8JsonReader reader)
        {
            User user = new();

            reader.Read();

            string sectionName = reader.GetString();

            if(sectionName != "user")
            {
                throw new JsonException("Invalid Json reader value. Expected 'user' section.");
            }

            reader.Read();

            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException("Invalid Json reader value. Expected StartObject.");
            }

            reader.Read(); 

            while (reader.TokenType != JsonTokenType.EndObject)
            {
                var propertyName = reader.GetString();
                reader.Read();

                switch (propertyName)
                {
                    case "displayName":
                        user.Name = reader.GetString();
                        break;
                    case "id":
                        user.Id = reader.GetString();
                        break;
                    default:
                        throw new JsonException("Unhandled Json reader value.");
                }

                reader.Read();
            }

            return user;
        }

        public override void Write(Utf8JsonWriter writer, Dictionary<string, CheckListItem> value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}