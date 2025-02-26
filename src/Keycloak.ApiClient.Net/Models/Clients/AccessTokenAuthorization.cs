﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.ApiClient.Net.Models.Clients
{
    public class AccessTokenAuthorization
    {
        [JsonProperty("permissions")]
        public IEnumerable<Permission> Permissions { get; set; }
    }
}
