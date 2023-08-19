using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BrandRepository : IBrandRepository
    {
        public IEnumerable<TblBrand> GetAllBrands() => BrandDAO.Instance.GetAllBrands();
    }
}
