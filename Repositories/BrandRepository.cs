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
        public void Create(TblBrand brand) => BrandDAO.Instance.Create(brand);

        public void Delete(int id) => BrandDAO.Instance.Delete(id);

        public List<TblBrand> GetAllList() => BrandDAO.Instance.GetAllList();

        public TblBrand GetBrand(int id) => BrandDAO.Instance.GetBrand(id);

        public void Update(TblBrand brand) => BrandDAO.Instance.Update(brand);

        public IEnumerable<TblBrand> GetAllBrands() => BrandDAO.Instance.GetAllBrands();
    }
}
