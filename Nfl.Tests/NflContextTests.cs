using Microsoft.EntityFrameworkCore;
using Nfl.SqlServer.DataContext.Entities;
using NFL.SqlServer.DataContext;

namespace Nfl.Tests;

public class NflContextTests
{
    private static readonly int _recordId = 12727;
    [Fact]
    public void Play_IncludesPlayTypePassType()
    {
        using (NFLDataContext context = new NFLDataContext())
        {
            int recordId = 12727;
            NflPlay? nflPlay = context.NflPlays.Include(x => x.NflPlayType).Include(x => x.NflPassType).Where(x => x.PlayId == _recordId).FirstOrDefault();
            Assert.NotNull(nflPlay);
            Assert.NotNull(nflPlay.NflPassType);
            Assert.NotNull(nflPlay.NflPlayType);
        }

    }
    [Fact]
    public void Play_IncludesTeams()
    {
        int _recordId = 12727;
        using (NFLDataContext context = new NFLDataContext())
        {
            int recordId = 12727;
            NflPlay? nflPlay = context.NflPlays.Include(x => x.OffensiveTeam).Include(x => x.DefensiveTeam).Where(x => x.PlayId == _recordId).FirstOrDefault();
            Assert.NotNull(nflPlay);
            Assert.NotNull(nflPlay.OffensiveTeam);
            Assert.NotNull(nflPlay.DefensiveTeam);
        }
    }
}