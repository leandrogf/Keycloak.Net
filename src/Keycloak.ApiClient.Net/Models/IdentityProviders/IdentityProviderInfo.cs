﻿using Newtonsoft.Json;

namespace Keycloak.ApiClient.Net.Models.IdentityProviders
{
    public class IdentityProviderInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
