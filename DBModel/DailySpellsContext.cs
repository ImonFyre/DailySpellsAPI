using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace DailySpellsAPI.DBModel
{
	public partial class DailySpellsContext : DbContext
    {
        
        public DailySpellsContext()
        {
        }

        public DailySpellsContext(DbContextOptions<DailySpellsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<CharacterClass> CharacterClasses { get; set; }
        public virtual DbSet<CharacterStat> CharacterStats { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Race> Races { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                optionsBuilder.UseNpgsql(configuration.GetConnectionString("DailySpells"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "English_United States.1252");

            modelBuilder.Entity<Character>(entity =>
            {
                entity.ToTable("Character", "DailySpells");

                entity.HasIndex(e => e.RaceId, "fki_PK_Race");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.RaceId).HasColumnName("raceId");

                entity.HasOne(d => d.Race)
                    .WithMany(p => p.Characters)
                    .HasForeignKey(d => d.RaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK_Character_Race");
            });

            modelBuilder.Entity<CharacterClass>(entity =>
            {
                entity.ToTable("CharacterClass", "DailySpells");

                entity.HasIndex(e => e.ClassId, "fki_PK_CharacterClass_Classes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CharacterId).HasColumnName("characterId");

                entity.Property(e => e.ClassId).HasColumnName("classId");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.CharacterClasses)
                    .HasForeignKey(d => d.CharacterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharacterClass_Character");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.CharacterClasses)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("PK_CharacterClass_Classes");
            });

            modelBuilder.Entity<CharacterStat>(entity =>
            {
                entity.ToTable("CharacterStats", "DailySpells");

                entity.HasIndex(e => e.CharacterId, "fki_FK_CharacterStats_Character");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cha).HasColumnName("cha");

                entity.Property(e => e.CharacterId).HasColumnName("characterId");

                entity.Property(e => e.Con).HasColumnName("con");

                entity.Property(e => e.Dex).HasColumnName("dex");

                entity.Property(e => e.Int).HasColumnName("int");

                entity.Property(e => e.Str).HasColumnName("str");

                entity.Property(e => e.Wis).HasColumnName("wis");

                entity.HasOne(d => d.Character)
                    .WithOne(p => p.CharacterStats)
                    
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharacterStats_Character");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Classes", "DailySpells");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Race>(entity =>
            {
                entity.ToTable("Races", "DailySpells");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
