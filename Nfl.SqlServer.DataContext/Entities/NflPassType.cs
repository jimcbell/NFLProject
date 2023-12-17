using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nfl.SqlServer.DataContext.Entities;

public class NflPassType
{
    [Key]
    public int Id { get; set; } 
    public string? Description { get; set; }
    public virtual ICollection<NflPlay> NflPlays { get; set; }  = new List<NflPlay>();
}
