using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query; // EnableQuery
using Microsoft.AspNetCore.OData.Routing.Controllers; // ODataController
using NFL.SqlServer.DataContext;

namespace NFL.OData.Service.Controllers;

public class NFLPlayController : ODataController
{
    protected readonly NFLDataContext _context;
    public NFLPlayController(NFLDataContext context)
    {
        _context = context;
    }
    [EnableQuery(PageSize = 50)]
    public IActionResult Get()
    {
        return Ok(_context.NFLPlays);
    }
}
