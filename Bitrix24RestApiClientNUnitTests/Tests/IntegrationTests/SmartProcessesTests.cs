﻿using Bitrix24RestApiClientNUnitTests.Utilities;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;
using Bitrix24RestApiClient.Core.Models.Enums;
using Bitrix24RestApiClient.Api.Crm.CrmDeal.Models;

namespace Bitrix24RestApiClientNUnitTests.Tests.IntegrationTests
{
    public class SmartProcessesTests : AbstractTest
    {
        [Test]
        public async Task SmartProcessesListTest()
        {
            var data = await bitrix24.Crm.SmartProcesses
                .ByEntityId(EntityTypeIdEnum.Deal.EntityTypeId)
                .List<Deal>();
        }
    }
}