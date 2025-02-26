﻿using Newtonsoft.Json;

namespace Keycloak.ApiClient.Net.Models.Root
{
    public class StorageProviders
    {
        [JsonProperty("ldap")]
        public HasOrder Ldap { get; set; }

        [JsonProperty("kerberos")]
        public HasOrder Kerberos { get; set; }
    }
}