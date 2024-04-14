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
namespace GoCompareShop.Tests
{
    public class BookingServicesTests : IDisposable
    {
        private bool _useSqlite;

        private SqliteConnection _connection;
        private DbContextOptions _options;

        public BookingServicesTests()
        {
            _connection = new SqliteConnection("datasource=:memory:");
            _connection.Open();

            _options = new DbContextOptionsBuilder()
                .UseSqlite(_connection)
                .Options;
            using (var context = new ApplicationDBContext(_options))
                context.Database.EnsureCreated();
        }


        public void Ensure_GroupDiscountIs_Applied()
        {
            using (var context2 = new ApplicationDBContext(_options))
            {
                Basket basket = new Basket();
                basket = GenTestData();
               
                var service = new GoComparedDiscountsService(context2);
               
                DateTime returnDate = DateTime.Now;

                // ACT
                var act = service.ApplyMultiBuyDiscount(basket,1);


                // Assert
              //  Assert.AreEqual(act.Data, expectedCount);
            }

        }

        public Basket GenTestData()
        {
            Basket basket = new Basket();
            basket.Total = 150;
            basket.Id = 1;

            basket.Status = 1;
            basket.Items = new List<BasketItem> {  new BasketItem { SKU="A",Description="Test Basket Item",LinePrice=50.00m,Quantity=4,IsActive=true,IsDeleted=false},
             new BasketItem { SKU="A",Description="Test Basket Item 2",LinePrice=30.00m,Quantity=5,IsActive=true,IsDeleted=false},
            new BasketItem { SKU="B",Description="Test Basket Item 2",LinePrice=30.00m,Quantity=9,IsActive=true,IsDeleted=false}
            };

            basket.IsActive = true;
            basket.IsDeleted = false;

            return basket;
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