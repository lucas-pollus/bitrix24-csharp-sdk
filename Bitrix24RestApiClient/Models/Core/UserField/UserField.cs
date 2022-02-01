﻿using Bitrix24ApiClient.src.Models.Crm;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bitrix24ApiClient.src.Models
{
    public class UserField
    {
        [JsonProperty(UserFieldFields.Id)]
        public string Id { get; set; }

        [JsonProperty(UserFieldFields.FieldName)]
        public string FieldName { get; set; }

        [JsonProperty(UserFieldFields.EntityId)]
        public string EntityId { get; set; }

        [JsonProperty(UserFieldFields.UserTypeId)]
        public string UserTypeId { get; set; }

        [JsonProperty(UserFieldFields.List)]
        public List<UserFieldList> List { get; set; }
    }
}