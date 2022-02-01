﻿using Bitrix24RestApiClient.src.Models.Crm.Core.Client;

namespace Bitrix24ApiClient.src
{
    public class Crm
    {
        public Crm(IBitrix24Client client)
        {
            Leads = new Leads(client);
            Deals = new Deals(client);
            Companies = new Companies(client);
            Contacts = new Contacts(client);
            Timeline = new Timeline(client);
        }
        public Companies Companies { get; private set; }
        public Leads Leads { get; private set; }
        public Deals Deals { get; private set; }
        public Contacts Contacts { get; private set; }
        public Timeline Timeline { get; private set; }
    }
}