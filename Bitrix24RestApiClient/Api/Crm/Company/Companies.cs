﻿using Bitrix24ApiClient.src.Models;
using Bitrix24RestApiClient.src.Core;
using Bitrix24RestApiClient.src.Models.Crm.Core.Client;

namespace Bitrix24ApiClient.src
{
    public class Companies : AbstractEntity<Company>
    {
        public Companies(IBitrix24Client client)
            : base(client, EntityTypePrefix.Company)
        {
        }
    }
}