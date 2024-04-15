using GoCompareShop.Models;
using System.Collections.Generic;
using Moq;
using NUnit;
using RichardSzalay.MockHttp;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Extensions.Options;
using Castle.Components.DictionaryAdapter.Xml;
using GoCompareShop.DAL;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.Data.Sqlite;
using GoCompareShop.Services;
using GCBasket.Models;
using GoComparedDiscounts.Service;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using static GoCompareShop.Models.Enums;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using static GoComparedDiscounts.Service.GoComparedDiscountsService;
namespace GoCompareShop.Tests
{
    public class GoCompareShopDiscountTests : IDisposable
    {
        private bool _useSqlite;

        private SqliteConnection _connection;
        private DbContextOptions _options;

        public GoCompareShopDiscountTests()
        {
            _connection = new SqliteConnection("datasource=:memory:");
            _connection.Open();

            _options = new DbContextOptionsBuilder()
                .UseSqlite(_connection)
                .Options;
            using (var context = new ApplicationDBContext(_options))
                context.Database.EnsureCreated();
        }

        [Test]
        [TestCase("", 0)]
        [TestCase("A", 50)]
        [TestCase("AB", 80)]
        [TestCase("CDBA", 115)]
        [TestCase("AA", 100)]
        [TestCase("AAA", 130)]
        [TestCase("AAABB", 175)]
        public void Ensure_MultiByDiscount_IsApplied(string products, decimal? expectedTotal)
        {
            
            using (var context2 = new ApplicationDBContext(_options))
            {
                
                context2.PriceLists.AddRange(
                    new PriceList {  Sku = "A", Price = 50 },
                    new PriceList { Sku = "B", Price = 30 },
                    new PriceList {  Sku = "C", Price = 20 },
                    new PriceList { Sku = "D", Price = 15 });

                context2.DiscountGroups.AddRange(
                    new DiscountGroup { SKU = "A", DiscountQuantity = 3, DiscountPrice = 130, IsActive = true, IsDeleted = false },
                    new DiscountGroup { SKU = "B", DiscountQuantity = 2, DiscountPrice = 45, IsActive = true, IsDeleted = false },
                    new DiscountGroup { SKU = "C", DiscountQuantity = 0, DiscountPrice = 0, IsActive = true, IsDeleted = false },
                    new DiscountGroup { SKU = "D", DiscountQuantity = 0, DiscountPrice = 0, IsActive = true, IsDeleted = false }
                    );

                context2.SaveChanges();


                var service = new GoComparedDiscountsService(context2);

                service.AddPricesBySkus("ABCD");


                var act = service.ApplyDiscounts(products , DiscountTypeEnum.MultiBuy);

                Console.WriteLine($"Total price for items ({products}): ${act.Data}");


                Assert.That(expectedTotal, Is.EqualTo(act.Data));
                // Assert
                //  Assert.AreEqual(act.Data, expectedCount);
            }
        }


 
        public void Dispose()
        {

        }

        public void UseSqlite()
        {
            throw new NotImplementedException();
        }
        public async Task<ApplicationDBContext> GetDbContext()
        {
            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();
            if (_useSqlite)
            {
                // Use Sqlite DB.
                builder.UseSqlite("DataSource=:memory:", x => { });
            }


            var dbContext = new ApplicationDBContext(builder.Options);
            if (_useSqlite)
            {
                // SQLite needs to open connection to the DB.
                // Not required for in-memory-database and MS SQL.
                await dbContext.Database.OpenConnectionAsync();
            }

            await dbContext.Database.EnsureCreatedAsync();

            return dbContext;
        }

    }


}