// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtRenameRules.Models
{
    public partial class VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("domainNameLabel");
            writer.WriteStringValue(DomainNameLabel);
            writer.WriteEndObject();
        }

        internal static VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings DeserializeVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings(JsonElement element)
        {
            string domainNameLabel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainNameLabel"))
                {
                    domainNameLabel = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings(domainNameLabel);
        }
    }
}
