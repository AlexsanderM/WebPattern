using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Model;

namespace WebPattern.Infrastructure.Implementation
{
    public class InMemoryProductData : IProductData
    {
        private readonly List<Section> _sections;
        private readonly List<Section> _brands;

        public InMemoryProductData()
        {
            _sections = new List<Section>()
            {
                new Section()
                {
                    Id = 1,
                    Name = "first",
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
                }
            };
        }

        public IEnumerable<Brand> GetBrands()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Section> GetSections()
        {
            return _sections;
        }
    }
}
