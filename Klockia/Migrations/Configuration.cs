namespace Klockia.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Klockia.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Klockia.Models.ApplicationDbContext context)
        {

            context.Types.AddOrUpdate(pt => pt.Id,
                new Models.ProductType
                {
                    Id = 1,
                    Name = "Damklockor"
                },
                new Models.ProductType
                {
                    Id = 2,
                    Name = "Herrklockor"
                },
                new Models.ProductType
                {
                    Id = 3,
                    Name = "Accessoarer"
                });
            context.SaveChanges();


            context.Product.AddOrUpdate(p => p.Id,
           

                  new Models.Product
                  {
                      Id = 1,
                      Name = "Mickael Kors Klassik",
                      Price = 1199,
                      Description = "Analog",
                      ImageUrl = "https://www.klockia.se/static/files/237/mk3833.jpg",
                      Brand = "Mickael Kors",
                      Color = "Gold",
                      ProductTypeId = 1
                  },


              new Models.Product
              {
                  Id = 2,
                  Name = "Name:Hybrid Smartwatch",
                  Price =1600,
                  Description = "Analog Quartzverk",
                  ImageUrl = "https://www.klockia.se/static/files/180/skt1100.jpg",
                  Brand = "Skagen",
                  Color = "Silver",
                  ProductTypeId = 2
              },

              new Models.Product
              {
                  Id = 3,
                  Name = "Rasp",
                  Price = 1490,
                  Description = "Analog Quartzverk",
                  ImageUrl = "https://www.klockia.se/static/files/178/dz4456.jpg",
                  Brand = "Diesel",
                  Color = "Blå",
                  ProductTypeId = 2
              },


               new Models.Product
               {
                   Id = 4,
                   Name = "Rado Coupole",
                   Price = 10800,
                   Description = "Classic Automatic",
                   ImageUrl = "https://www.klockia.se/static/files/198/r22861165.jpg",
                   Brand = "Rado Coupole",
                   Color = "Brun",
                   ProductTypeId = 2
               },


                new Models.Product
                {
                    Id = 5,
                    Name = "Kronaby",
                    Price = 4990,
                    Description = "Apex 43mm",
                    ImageUrl = "https://www.klockia.se/static/files/263/a1000-1399.jpg",
                    Brand = "Kronaby Sweden",
                    Color = "Black",
                    ProductTypeId = 2
                },


                 new Models.Product
                 {
                     Id = 6,
                     Name = "Commuter Hybrid Smartwatch",
                     Price = 4990,
                     Description = "Apex 42mm",
                     ImageUrl = "https://www.klockia.se/static/files/179/ftw1149.jpg",
                     Brand = "Fossil Q",
                     Color = "Brun",
                     ProductTypeId = 2
                 },


                new Models.Product
                {
                    Id = 7,
                    Name = "Minimal 40",
                    Price = 1790,
                    Description = "Analog Quartzverk",
                    ImageUrl = "https://www.klockia.se/static/files/235/k3m21126.jpg",
                    Brand = "Calvin Klein",
                    Color = "Silver",
                    ProductTypeId = 1
                },


                  new Models.Product
                  {
                      Id = 8,
                      Name = "Klassisk Calvin",
                      Price = 3500,
                      Description = "Analog Quartzverk",
                      ImageUrl = "https://www.klockia.se/static/files/183/suob725.jpg",
                      Brand = "Calvin Clein",
                      Color = "Silver",
                      ProductTypeId = 1
                  },


                    new Models.Product
                    {
                        Id = 9,
                        Name = "Crosswalk",
                        Price = 450,
                        Description = "Urverk:Analog Quartzverk",
                        ImageUrl = "https://www.klockia.se/static/files/175/ny2171.jpg",
                        Brand = "DNK",
                        Color = "Guld",
                        ProductTypeId = 1
                    },

                     new Models.Product
                     {
                         Id = 10,
                         Name = "Richmond",
                         Price = 1696,
                         Description = "Analog Quartzverk",
                         ImageUrl = "https://www.klockia.se/static/files/265/hl25-m-0022.jpg",
                         Brand = "Henry London ",
                         Color = "Rose",
                         ProductTypeId = 1
                     },

            new Models.Product
            {
                Id = 11,
                Name = "City Chrono",
                Price = 2400,
                Description = "Analog Quartzverk",
                ImageUrl = "https://www.klockia.se/static/files/16/k2g276g3_2.jpg",
                Brand = "Calvin Klein",
                Color = "Brun",
                ProductTypeId = 2
            },


             new Models.Product
             {
                 Id = 12,
                 Name = "Kronaby Classic",
                 Price = 800,
                 Description = "Analog Quartzverk",
                 ImageUrl = "https://www.klockia.se/static/files/263/a1000-0713.jpg",
                 Brand = "Kronaby",
                 Color = "Brun",
                 ProductTypeId = 2
             },


              new Models.Product
              {
                  Id = 13,
                  Name = "Explorist Smartwatch",
                  Price = 2990,
                  Description = "Analog Quartzverk",
                  ImageUrl = "https://www.klockia.se/static/files/179/ftw4001.jpg",
                  Brand = "Fossil",
                  Color = "Grå",
                  ProductTypeId = 2
              },


               new Models.Product
               {
                   Id = 14,
                   Name = "Hybrid smartwatch ",
                   Price = 3100,
                   Description = "Analog Quartzverk",
                   ImageUrl = "https://www.klockia.se/static/files/176/art3009.jpg",
                   Brand = "Emporio Armani",
                   Color = "Blå",
                   ProductTypeId = 2
               },



               new Models.Product
               {
                   Id = 15,
                   Name = "Cardprodector ",
                   Price = 350,
                   Description = "Kort",
                   ImageUrl = "https://www.klockia.se/static/files/207/c-red.jpg",
                   Brand = "Secrid",
                   Color = "Röd",
                   ProductTypeId = 3
               },


               new Models.Product
               {
                   Id = 16,
                   Name = "Cardprodector ",
                   Price = 299,
                   Description = "Kort",
                   ImageUrl = "https://www.klockia.se/static/files/207/c-black_2.jpg",
                   Brand = "Secrid",
                   Color = "Svart",
                   ProductTypeId = 3
               },





                 new Models.Product
                 {
                     Id = 17,
                     Name = "Secrid Miniwallet ",
                     Price = 489,
                     Description = "Guld",
                     ImageUrl = "https://www.klockia.se/static/files/207/front_m-crisple-black-gold.jpg",
                     Brand = "Crisple",
                     Color = "Svart",
                     ProductTypeId = 3
                 },



                  new Models.Product
                  {
                      Id = 18,
                      Name = " Secrid Moneyband",
                      Price = 489,
                      ImageUrl = "https://www.klockia.se/static/files/207/moneyband_yellow-cab.jpg",
                      Brand = "Cab",
                      Color = "Yellow",
                      ProductTypeId = 3
                  },

            new Models.Product
            {
                Id = 19,
                Name = "Secrid Miniwallet ",
                Price = 450,
                Description = "Description:Läder",
                ImageUrl = "https://www.klockia.se/static/files/207/m-vintage-cognac.jpg",
                Brand = "Vintage Cognac",
                Color = "Brun",
                ProductTypeId = 3
            });



            context.SaveChanges();




        }
    }


}


