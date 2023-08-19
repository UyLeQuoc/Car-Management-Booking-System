using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IModelRepository
    { 
        public List<TblModel> GetAllList();
        public TblModel GetModel(int id);
        public void Update(TblModel Model);
        public void Delete(int id);
        public void Create(TblModel Model);
        IEnumerable<TblModel> GetAllModels();
    }
}
