﻿using Newtonsoft.Json;

namespace Keycloak.ApiClient.Net.Models.Root
{
    public class EventsListenerProviders
    {
        [JsonProperty("jboss-logging")]
        public HasOrder JbossLogging { get; set; }

        [JsonProperty("email")]
        public HasOrder Email { get; set; }
    }
}