using NFL.SqlServer.DataContext.Entities;
using System.Data.Services.Client;

namespace NFL.OData.Client.Mvc.Services;

public class NFLPlayContainer : DataServiceContext
{
    public DataServiceQuery<NFLPlay> NFLPlays { get; }
    public NFLPlayContainer(Uri serviceRoot) : base(serviceRoot)
    {
        this.NFLPlays = base.CreateQuery<NFLPlay>("NFLPlay");
    }
}
