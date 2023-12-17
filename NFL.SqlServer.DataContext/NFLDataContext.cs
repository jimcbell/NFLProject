using Microsoft.EntityFrameworkCore;
using NFL.SqlServer.DataContext.Entities;

namespace NFL.SqlServer.DataContext
{
    public partial class NFLDataContext : DbContext
    {
        public virtual DbSet<NFLPlay> NFLPlays { get; set; }
        public NFLDataContext()
        {
            
        }
        public NFLDataContext(DbContextOptions<NFLDataContext> options)
        : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Should be configured from app that runs the libray, else defaulting to local connection string.
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=NFL;Integrated Security=true;TrustServerCertificate=true;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NFLPlay>(entity =>
            {
                entity.HasKey(e => e.PlayId);
                entity.HasIndex(e => e.PlayId).IsUnique(true);
                entity.Property(e => e.PlayId).ValueGeneratedOnAdd();
                entity.Property(e => e.PlayId).HasColumnName("RecordID");
                entity.Property(e => e.GameId).HasColumnName("GameID");
                entity.Property(e => e.GameDate).HasColumnName("GameDate");
                entity.Property(e => e.Quarter).HasColumnName("Quarter");
                entity.Property(e => e.Minute).HasColumnName("Minute");
                entity.Property(e => e.Second).HasColumnName("Second");
                entity.Property(e => e.OffenseTeam).HasColumnName("OffenseTeam");
                entity.Property(e => e.DefenseTeam).HasColumnName("DefenseTeam");
                entity.Property(e => e.Down).HasColumnName("Down");
                entity.Property(e => e.ToGo).HasColumnName("ToGo");
                entity.Property(e => e.YardLine).HasColumnName("YardLine");
                entity.Property(e => e.SeriesFirstDown).HasColumnName("SeriesFirstDown");
                entity.Property(e => e.NextScore).HasColumnName("NextScore");
                entity.Property(e => e.Description).HasColumnName("Description");
                entity.Property(e => e.TeamWin).HasColumnName("TeamWin");
                entity.Property(e => e.SeasonYear).HasColumnName("SeasonYear");
                entity.Property(e => e.Yards).HasColumnName("Yards");
                entity.Property(e => e.Formation).HasColumnName("Formation");
                entity.Property(e => e.PlayType).HasColumnName("PlayType");
                entity.Property(e => e.IsRush).HasColumnName("IsRush");
                entity.Property(e => e.IsPass).HasColumnName("IsPass");
                entity.Property(e => e.IsIncomplete).HasColumnName("IsIncomplete");
                entity.Property(e => e.IsTouchdown).HasColumnName("IsTouchdown");
                entity.Property(e => e.PassType).HasColumnName("PassType");
                entity.Property(e => e.IsSack).HasColumnName("IsSack");
                entity.Property(e => e.IsChallenge).HasColumnName("IsChallenge");
                entity.Property(e => e.IsChallengeReversed).HasColumnName("IsChallengeReversed");
                entity.Property(e => e.IsMeasurement).HasColumnName("IsMeasurement");
                entity.Property(e => e.IsInterception).HasColumnName("IsInterception");
                entity.Property(e => e.IsFumble).HasColumnName("IsFumble");
                entity.Property(e => e.IsPenalty).HasColumnName("IsPenalty");
                entity.Property(e => e.IsTwoPointConversion).HasColumnName("IsTwoPointConversion");
                entity.Property(e => e.IsTwoPointConversionSuccessful).HasColumnName("TwoPointConSuccess");
                entity.ToTable("NFLPlay");
                OnModelCreatingPartial(modelBuilder);
            });
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
