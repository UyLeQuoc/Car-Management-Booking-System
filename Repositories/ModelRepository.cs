using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ModelRepository : IModelRepository
    {
        public void Create(TblModel Model) => ModelDAO.Instance.Create(Model);

        public void Delete(int id) => ModelDAO.Instance.Delete(id);

        public List<TblModel> GetAllList() => ModelDAO.Instance.GetAllList();

        public TblModel GetModel(int id) => ModelDAO.Instance.GetModel(id);

        public void Update(TblModel Model) => ModelDAO.Instance.Update(Model);

        public IEnumerable<TblModel> GetAllModels() => ModelDAO.Instance.GetAllModels();
    }
}
