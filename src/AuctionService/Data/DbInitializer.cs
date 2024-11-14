
using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data
{
    public class DbInitializer
    {
        public static void InitDb(WebApplication app)
        {
            using var scope = app.Services.CreateScope();// here service lifetime
            SeedData(scope.ServiceProvider.GetService<AuctionDbContext>());
        }

        private static void SeedData(AuctionDbContext context)
        {
            context.Database.Migrate();
            if (context.Auctions.Any()) {
                return;
            }
            var auctions = new List<Auction>()
            {
                //Auctions
            };
            context.Auctions.AddRange(auctions);
        }
    }
}
