using Nfl.SqlServer.DataContext.Entities;
using NFL.SqlServer.DataContext;
using System.Linq;
namespace NFL.OData.Client.Mvc.Models;

public class HomeIndexViewModel
{

    public List<NflPlay> NFLPlays { get; set; } = [];
    public List<NflPlayType> NflPlayTypes { get; set; } = new();
    public List<NflPassType> NflPassTypes { get; set; } = new();
    public List<NflTeam> NflTeams { get; set; } = new();
    public int YardsGained { get; set; }
    public int ToGo { get; set; }
    public bool IsRush { get; set; }
    public bool IsPass { get; set; }
    public NflQuery Query { get; set; } = new();
    public IEnumerable<int> Quarters { get; set; } = Enumerable.Range(1,4);  
    public IEnumerable<int> Downs { get; set; } = Enumerable.Range(1,4);
    //public HomeIndexViewModel(NFLDataContext context)
    //{
    //    NflPlayTypes = context.NflPlayTypes.ToList();
    //    NflPassTypes = context.NflPassTypes.ToList();
    //    NflTeams = context.NflTeams.ToList();
    //}


}
public class NflQuery
{
    public List<int> Downs { get; set; } = new();
    public List<int> PlayTypes = new();
    public List<string> FilterFields { get; set; } = new();
    public List<string> SelectFields { get; set; } = new(); 
    public NflQuery()
    {
        
    }
}
