﻿using Newtonsoft.Json;

namespace Keycloak.ApiClient.Net.Models.Root
{
    public class ConnectionsJpaUpdater
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ConnectionsJpaUpdaterProviders Providers { get; set; }
    }
}