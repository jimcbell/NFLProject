using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query; // EnableQuery
using Microsoft.AspNetCore.OData.Routing.Controllers; // ODataController
using Microsoft.EntityFrameworkCore;
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
        return Ok(_context.NflPlays.Include(x => x.OffensiveTeam).Include(x => x.DefensiveTeam).Include(x => x.NflPlayType).Include(x => x.NflPassType));
    }
}
