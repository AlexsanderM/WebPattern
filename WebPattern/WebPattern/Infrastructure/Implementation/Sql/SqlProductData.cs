using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DAL.Context;
using WebStore.Domain.Model;

namespace WebPattern.Infrastructure.Implementation.Sql
{
    public class SqlProductData : IProductData
    {
        private readonly WebStoreContext _context;
        public SqlProductData(WebStoreContext context)
        {
            _context = context;
        }
        public IEnumerable<Section> GetSections()
        {
            //return _context.Sections.ToList();
            return _context.Sections.AsQueryable().ToList();


        }
        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brand.ToList();
        }        

        
    }
}
