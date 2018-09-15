using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DAL.Context;
using WebStore.Domain.Model;

namespace WebPattern.Data
{
    public static class DbInitializer
    {
        public static void Initialize(WebStoreContext context)
        {
            context.Database.EnsureCreated();
            // Look for any products.
            if (context.Sections.Any())
            {
                return;
            }

            var sections = new List<Section>()
            {
                new Section()
                {
                    Id = 1,
                    Name = "firs",
                    Order= 0,
                    ParentId = null
                },
                new Section()
                {
                    Id = 2,
                    Name = "two",
                    Order = 1,
                    ParentId = 1
                },
                new Section()
                {
                    Id = 3,
                    Name = "three",
                    Order = 0,
                    ParentId = 1
                },
                new Section()
                {
                    Id = 4,
                    Name = "first, parent 2",
                    Order = 0,
                    ParentId = null
                },
                new Section()
                {
                    Id = 5,
                    Name = "first",
                    Order = 1,
                    ParentId = 4
                },
                new Section()
                {
                    Id = 7,
                    Name = "test",
                    Order = 2,
                    ParentId = 4
                }
            };
            using (var trans = context.Database.BeginTransaction())
            {
                foreach (var section in sections)
                {
                    context.Sections.Add(section);
                }
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Sections] ON");
                context.SaveChanges();
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Sections] OFF");
                trans.Commit();
            }
            var brands = new List<Brand>();
            using (var trans = context.Database.BeginTransaction())
            {
                foreach (var brand in brands)
                {
                    context.Brand.Add(brand);
                }
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Brands] ON");
                context.SaveChanges();
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Brands] OFF");
                trans.Commit();
            }            
        }
    }
}
