using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Nfl.SqlServer.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nfl.SqlServer.DataContext.Entities
{
    public class NflPlay
    {
        [Key]
        public int PlayId { get; set; }
        public int GameId { get; set; }
        public DateOnly GameDate { get; set; }
        public int Quarter { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        // No longer need this column as we have a navigation property to Offensive Team. If need to rerun import this can be uncommented (table update), then recommented after scripts are ran.
        //public string? OffenseTeam { get; set; }
        // No longer need this column as we have a navigation property to Defensive Team. If need to rerun import this can be uncommented (table update), then recommented after scripts are ran.
        //public string? DefenseTeam { get; set; }
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
        // No longer need this column as we have a navigation property to play type. If need to rerun import this can be uncommented (table update), then recommented after scripts are ran.
        //public string? PlayType { get; set; } 
        public bool IsRush { get; set; }
        public bool IsPass { get; set; }
        public bool IsIncomplete { get; set; }
        public bool IsTouchdown { get; set; }
        // No longer need this column as we have a navigation property to pass type. If need to rerun import this can be uncommented (table update), then recommented after scripts are ran.
        //public string? PassType { get; set; }
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

        // Navigations (Explicitly set the foreign keys)

        // Play Type

        // EFCore conventions will look for the foreign key, the <entity> - Id is one that it will auto recognize
        //public int? NflPlayTypeId { get; set; }
        // By EFCore conventions this will be auto recognized as the one side of a one to many relationship
        public NflPlayType? NflPlayType { get; set; }

        //Pass Type
        //public int? NflPassTypeId { get; set; }  
        public NflPassType? NflPassType { get; set; }
        [ForeignKey("OffensiveTeamId")]
        public NflTeam? OffensiveTeam { get; set; }
        [ForeignKey("DefensiveTeamId")]
        public NflTeam? DefensiveTeam { get; set; }

    }
}
