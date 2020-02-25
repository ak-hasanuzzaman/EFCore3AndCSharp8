using EFCore3AndCSharp8.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace EFCore3AndCSharp8.Data
{
    public class CatsDbContext : DbContext
    {
        public static readonly ILoggerFactory MyLoggerFactory
            = LoggerFactory.Create(builder => {
                builder
                    .AddFilter((category, level) =>
                        category == DbLoggerCategory.Database.Command.Name
                        && level == LogLevel.Information)
                    .AddConsole();
            });

        public DbSet<Cat> Cats { get; set; }
        public DbSet<Owner> Owners { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(MyLoggerFactory)  //tie-up DbContext with LoggerFactory object
                .EnableSensitiveDataLogging().UseSqlServer(@"Server=.\SQLEXPRESS;Database=CatsDemoDb;integrated Security=SSPI");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

            modelBuilder
                .Entity<Cat>()
                .HasOne(c => c.Owner)
                .WithMany(o => o.Cats)
                .HasForeignKey(c => c.OwnerId);
        }
    }
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>().HasData(
                new Owner
                {
                    OwnerId = 1,
                    Name = "Hasan"
                },
                new Owner
                {
                    OwnerId = 2,
                    Name = "Faisan"
                }
                ,
                new Owner
                {
                    OwnerId = 3,
                    Name = "Parvez"
                }
                ,
                new Owner
                {
                    OwnerId = 4,
                    Name = "Rina"
                }
                ,
                new Owner
                {
                    OwnerId = 5,
                    Name = "Adnin"
                },
            new Owner
            {
                OwnerId = 6,
                Name = "Mahin"
            },
            new Owner
            {
                OwnerId = 7,
                Name = "Aurin"
            }
            );
            modelBuilder.Entity<Cat>().HasData(
                new Cat { CatId = 1, OwnerId = 1, Name = "Hamlet" },
                new Cat { CatId = 2, OwnerId = 1, Name = "King Lear" },
                new Cat { CatId = 3, OwnerId = 1, Name = "Othello" },
                new Cat { CatId = 4, OwnerId = 2, Name = "Hamlet1" },
                new Cat { CatId = 5, OwnerId = 2, Name = "King Lear1" },
                new Cat { CatId = 6, OwnerId = 1, Name = "Hamlet" },
                new Cat { CatId = 7, OwnerId = 1, Name = "King Lear" },
                new Cat { CatId = 8, OwnerId = 1, Name = "Othello" },
                new Cat { CatId = 9, OwnerId = 2, Name = "Hamlet1" },
                new Cat { CatId = 10, OwnerId = 2, Name = "King Lear1" },
                new Cat { CatId = 11, OwnerId = 1, Name = "Hamlet" },
                new Cat { CatId = 12, OwnerId = 1, Name = "King Lear" },
                new Cat { CatId = 13, OwnerId = 1, Name = "Othello" },
                new Cat { CatId = 14, OwnerId = 2, Name = "Hamlet1" },
                new Cat { CatId = 15, OwnerId = 2, Name = "King Lear1" },
                new Cat { CatId = 16, OwnerId = 1, Name = "Hamlet" },
                new Cat { CatId = 17, OwnerId = 1, Name = "King Lear" },
                new Cat { CatId = 18, OwnerId = 1, Name = "Othello" },
                new Cat { CatId = 19, OwnerId = 2, Name = "Hamlet1" },
                new Cat { CatId = 20, OwnerId = 2, Name = "King Lear1" },
                new Cat { CatId = 21, OwnerId = 1, Name = "Hamlet" },
                new Cat { CatId = 22, OwnerId = 1, Name = "King Lear" },
                new Cat { CatId = 23, OwnerId = 1, Name = "Othello" },
                new Cat { CatId = 24, OwnerId = 2, Name = "Hamlet1" },
                new Cat { CatId = 25, OwnerId = 2, Name = "King Lear1" },
                new Cat { CatId = 26, OwnerId = 1, Name = "Hamlet" },
                new Cat { CatId = 27, OwnerId = 1, Name = "King Lear" },
                new Cat { CatId = 28, OwnerId = 1, Name = "Othello" },
                new Cat { CatId = 29, OwnerId = 2, Name = "Hamlet1" },
                new Cat { CatId = 30, OwnerId = 2, Name = "King Lear1" },
                new Cat { CatId = 31, OwnerId = 1, Name = "Hamlet" },
                new Cat { CatId = 32, OwnerId = 1, Name = "King Lear" },
                new Cat { CatId = 33, OwnerId = 1, Name = "Othello" },
                new Cat { CatId = 34, OwnerId = 2, Name = "Hamlet1" },
                new Cat { CatId = 35, OwnerId = 2, Name = "King Lear1" },
                new Cat { CatId = 36, OwnerId = 1, Name = "Hamlet" },
                new Cat { CatId = 37, OwnerId = 1, Name = "King Lear" },
                new Cat { CatId = 38, OwnerId = 1, Name = "Othello" },
                new Cat { CatId = 39, OwnerId = 2, Name = "Hamlet1" },
                new Cat { CatId = 40, OwnerId = 2, Name = "King Lear1" },
                new Cat { CatId = 41, OwnerId = 1, Name = "Hamlet" },
                new Cat { CatId = 42, OwnerId = 1, Name = "King Lear" },
                new Cat { CatId = 43, OwnerId = 1, Name = "Othello" },
                new Cat { CatId = 44, OwnerId = 2, Name = "Hamlet1" },
                new Cat { CatId = 45, OwnerId = 2, Name = "King Lear1" },
                new Cat { CatId = 46, OwnerId = 1, Name = "Hamlet" },
                new Cat { CatId = 47, OwnerId = 1, Name = "King Lear" },
                new Cat { CatId = 48, OwnerId = 1, Name = "Othello" },
                new Cat { CatId = 49, OwnerId = 2, Name = "Hamlet1" },
                new Cat { CatId = 50, OwnerId = 2, Name = "King Lear1" },
                new Cat { CatId = 51, OwnerId = 1, Name = "Hamlet" },
                new Cat { CatId = 52, OwnerId = 1, Name = "King Lear" },
                new Cat { CatId = 53, OwnerId = 1, Name = "Othello" },
                new Cat { CatId = 54, OwnerId = 2, Name = "Hamlet1" },
                new Cat { CatId = 55, OwnerId = 2, Name = "King Lear1" },
                new Cat { CatId = 56, OwnerId = 1, Name = "Hamlet" },
                new Cat { CatId = 57, OwnerId = 1, Name = "King Lear" },
                new Cat { CatId = 58, OwnerId = 1, Name = "Othello" },
                new Cat { CatId = 59, OwnerId = 2, Name = "Hamlet1" },
                new Cat { CatId = 60, OwnerId = 2, Name = "King Lear1" },
                new Cat { CatId = 61, OwnerId = 1, Name = "Hamlet" },
                new Cat { CatId = 62, OwnerId = 1, Name = "King Lear" },
                new Cat { CatId = 63, OwnerId = 1, Name = "Othello" },
                new Cat { CatId = 64, OwnerId = 2, Name = "Hamlet1" },
                new Cat { CatId = 65, OwnerId = 2, Name = "King Lear1" },
                new Cat { CatId = 66, OwnerId = 1, Name = "Hamlet" },
                new Cat { CatId = 67, OwnerId = 1, Name = "King Lear" },
                new Cat { CatId = 68, OwnerId = 1, Name = "Othello" },
                new Cat { CatId = 69, OwnerId = 2, Name = "Hamlet1" },
                new Cat { CatId = 70, OwnerId = 2, Name = "King Lear1" },
                new Cat { CatId = 71, OwnerId = 1, Name = "Hamlet" },
                new Cat { CatId = 72, OwnerId = 1, Name = "King Lear" },
                new Cat { CatId = 73, OwnerId = 1, Name = "Othello" },
                new Cat { CatId = 74, OwnerId = 2, Name = "Hamlet1" },
                new Cat { CatId = 75, OwnerId = 2, Name = "King Lear1" },
                new Cat { CatId = 76, OwnerId = 1, Name = "Hamlet" },
                new Cat { CatId = 77, OwnerId = 1, Name = "King Lear" },
                new Cat { CatId = 78, OwnerId = 1, Name = "Othello" },
                new Cat { CatId = 79, OwnerId = 2, Name = "Hamlet1" },
                new Cat { CatId = 80, OwnerId = 2, Name = "King Lear1" },
                new Cat { CatId = 81, OwnerId = 1, Name = "Hamlet" },
                new Cat { CatId = 82, OwnerId = 1, Name = "King Lear" },
                new Cat { CatId = 83, OwnerId = 1, Name = "Othello" },
                new Cat { CatId = 84, OwnerId = 2, Name = "Hamlet1" },
                new Cat { CatId = 85, OwnerId = 2, Name = "King Lear1" },
                new Cat { CatId = 86, OwnerId = 1, Name = "Hamlet" },
                new Cat { CatId = 87, OwnerId = 1, Name = "King Lear" },
                new Cat { CatId = 88, OwnerId = 1, Name = "Othello" },
                new Cat { CatId = 89, OwnerId = 2, Name = "Hamlet1" },
                new Cat { CatId = 90, OwnerId = 2, Name = "King Lear1" },
                new Cat { CatId = 91, OwnerId = 1, Name = "Hamlet" },
                new Cat { CatId = 92, OwnerId = 1, Name = "King Lear" },
                new Cat { CatId = 93, OwnerId = 1, Name = "Othello" },
                new Cat { CatId = 94, OwnerId = 2, Name = "Hamlet1" },
                new Cat { CatId = 95, OwnerId = 2, Name = "King Lear1" },
                new Cat { CatId = 96, OwnerId = 1, Name = "Hamlet" },
                new Cat { CatId = 97, OwnerId = 1, Name = "King Lear" },
                new Cat { CatId = 98, OwnerId = 1, Name = "Othello" },
                new Cat { CatId = 99, OwnerId = 2, Name = "Hamlet1" },
                new Cat { CatId = 100, OwnerId = 2, Name = "King Lear1" }
            );
        }
    }
}
