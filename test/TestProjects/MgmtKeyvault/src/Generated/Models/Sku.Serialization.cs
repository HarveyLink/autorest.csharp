// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtKeyvault.Models
{
    public partial class Sku : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("family");
            writer.WriteStringValue(Family.ToString());
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name.ToSerialString());
            writer.WriteEndObject();
        }

        internal static Sku DeserializeSku(JsonElement element)
        {
            SkuFamily family = default;
            SkuName name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("family"))
                {
                    family = new SkuFamily(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString().ToSkuName();
                    continue;
                }
            }
            return new Sku(family, name);
        }
    }
}
