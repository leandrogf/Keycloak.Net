﻿using Newtonsoft.Json;

namespace Keycloak.ApiClient.Net.Models.AuthorizationScopes
{
    public class AuthorizationScope
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
