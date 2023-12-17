using Microsoft.OData.Edm; // ODataConventionModelBuilder
using Microsoft.OData.ModelBuilder; // IEdmModel
using Nfl.SqlServer.DataContext.Entities;

namespace NFL.OData.Service.Models;

public static class EDMModels
{
    public static IEdmModel GetEdmModelForNFLPlay()
    {
        var builder = new ODataConventionModelBuilder();
        builder.EntitySet<NflPlay>("NFLPlay");
        return builder.GetEdmModel();
    }
}
