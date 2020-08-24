using Ehs.Reporting.MR.Models;
using Ehs.Reporting.MR.Repository;
using Microsoft.Extensions.Logging;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace Ehs.Reporting.Test
{
    public class ClientRepositoryTest
    {
        //ILogger<ClientRepository> mock = Mock.Of<ILogger<ClientRepository>>();

        //[Fact]
        //public void GetMRActiveClientsForTranslatedLangTest()
        //{
        //    IList<Client> result = null;
        //    using (var context = new EhsSqlContext(DbOptionsFactory.DbContextOptions))
        //    {
        //        IClientRepository repo = new ClientRepository(context, mock);
        //        result = repo.GetMRActiveClientsForTranslatedLang();
        //    }

        //    Assert.NotNull(result);
        //    Assert.True(result.Count > 0);
        //}

        //[Fact]
        //public void GetAllClientsTest()
        //{
        //    IList<Client> result = null;
        //    using (var context = new EhsSqlContext(DbOptionsFactory.DbContextOptions))
        //    {
        //        IClientRepository repo = new ClientRepository(context, mock);
        //        result = repo.GetAllClients();

        //    }

        //    Assert.NotNull(result);
        //    Assert.True(result.Count > 0);
        //}

        //[Fact]
        //public void GetMRActiveClientsForEnglishLangTest()
        //{
        //    using (var context = new EhsSqlContext(DbOptionsFactory.DbContextOptions))
        //    {
        //        IClientRepository repo = new ClientRepository(context, mock);
        //        var result = repo.GetMRActiveClientsForEnglishLang();
        //        Assert.NotNull(result);
        //        Assert.True(result.Count > 0);
        //    }
        //}

        //[Fact]
        //public void GetMaxEndDeliveryDateForClientsTest()
        //{
        //    var list = new List<int> { 880 };
        //    using (var context = new EhsSqlContext(DbOptionsFactory.DbContextOptions))
        //    {
        //        IClientRepository repo = new ClientRepository(context, mock);

        //        var result = repo.GetMaxEndDeliveryDateForClients(list);
        //        Assert.NotNull(result);
        //        Assert.True(result.Count > 0);
        //    }
        //}
    }
}
