﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bitrix24ApiClient.src.Models
{
    public class CrmEntityGetRequestArgs {
        // Идентификатор выбираемой сущности
        [JsonProperty("ID")]
        public int Id { get; set; }

        // Список полей, значения которых надо вернуть
        [JsonProperty("fields")]
        public List<string> Fields { get; set; } = new List<string>();
    }
}