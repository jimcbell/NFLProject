using Microsoft.OData.Edm; // ODataConventionModelBuilder
using Microsoft.OData.ModelBuilder;
using NFL.SqlServer.DataContext.Entities; // IEdmModel

namespace NFL.OData.Service.Models;

public static class EDMModels
{
    public static IEdmModel GetEdmModelForNFLPlay()
    {
        var builder = new ODataConventionModelBuilder();
        builder.EntitySet<NFLPlay>("NFLPlay");
        return builder.GetEdmModel();
    }
}
