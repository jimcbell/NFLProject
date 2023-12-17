using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nfl.SqlServer.DataContext.Entities;
// Not added in yet
public class NflTeam
{
    [Key]
    public int Id { get; set; }
    public string ShortName { get; set; } = string.Empty;
    [InverseProperty("OffensiveTeam")]
    public virtual ICollection<NflPlay> OffensiveTeamPlays { get; set; } = new List<NflPlay>();
    [InverseProperty("DefensiveTeam")]
    public virtual ICollection<NflPlay> DefensiveTeamPlays { get; set; } = new List<NflPlay>();   

}
