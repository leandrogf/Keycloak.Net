﻿using Newtonsoft.Json;

namespace Keycloak.ApiClient.Net.Models.AuthenticationManagement
{
    public class AuthenticationExecutionExport : AuthenticationExecutionBase
    {
        [JsonProperty("flowAlias")]
        public string FlowAlias { get; set; }
        [JsonProperty("userSetupAllowed")]
        public bool? UserSetupAllowed { get; set; }
    }
}
