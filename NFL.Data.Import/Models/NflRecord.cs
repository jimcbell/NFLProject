using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLDataImport.Models;

public partial class NflRecord
{
    [Ignore]
    public int RecordId { get; set; }
    public int GameId { get; set; }
    public DateOnly GameDate { get; set; }
    public int Quarter { get; set; }    
    public int Minute { get; set; } 
    public int Second { get; set; }
    [StringLength(3)]
    public string? OffenseTeam { get; set; }
    [StringLength(3)]
    public string? DefenseTeam { get; set; }
    public int Down { get; set; }   
    public int ToGo { get; set; }
    public int YardLine { get; set; }   
    public bool SeriesFirstDown { get; set; }
    public bool NextScore { get; set; }
    public string? Description { get; set; }
    public bool TeamWin { get; set; }
    public int SeasonYear { get; set; }
    public int Yards { get; set; }
    public string? Formation { get; set; }
    public string ? PlayType { get; set; }
    public bool IsRush { get; set; }
    public bool IsPass { get; set; }
    public bool IsIncomplete { get; set; }
    public bool IsTouchdown { get; set; }
    public string? PassType { get; set; }
    public bool IsSack { get; set; }
    public bool IsChallenge { get; set; }
    public bool IsChallengeReversed { get; set; }
    public bool IsMeasurement { get; set; }  
    public bool IsInterception { get; set; }
    public bool IsFumble { get; set; }
    public bool IsPenalty { get; set; }
    public bool IsTwoPointConversion { get; set; }
    public bool IsTwoPointConversionSuccessful { get; set; }
    public string? RushDirection { get; set; } 
    public int YardLineFixed { get; set; }
    public bool IsPenaltyAccepted { get; set; }
    public string? PenaltyTeam { get; set; }
    public bool IsNoPlay { get; set; }  
    public string? PenaltyType { get; set; }
    public int PenaltyYards { get; set; }



}

