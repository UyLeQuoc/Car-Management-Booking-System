using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IBrandRepository
    { 
        public List<TblBrand> GetAllList();
        public TblBrand GetBrand(int id);
        public void Update(TblBrand brand);
        public void Delete(int id);
        public void Create(TblBrand brand);
        public IEnumerable<TblBrand> GetAllBrands();
    }
}
