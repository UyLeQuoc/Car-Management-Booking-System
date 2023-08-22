using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class ModelDAO
    {
        private ModelDAO() { }
        private static ModelDAO instance = null;
        private static readonly object instanceLock = new object();
        public static ModelDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ModelDAO();
                    }
                    return instance;
                }
            }
        }

        public List<TblModel> GetAllList()
        {
            try
            {
                List<TblModel> cars = null;
                var context = new CarBookingManagementContext();
                cars = context.TblModels.ToList();
                return cars;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TblModel GetModel(int id)
        {
            TblModel Model = null;

            try
            {
                var context = GetAllList();
                Model = context.SingleOrDefault(item => item.ModelId == id);

            }
            catch (Exception ex)
            {
                throw new Exception("Model does not exist!!");
            }

            return Model;
        }
        public void Create(TblModel ModelCurrent)
        {
            if (ModelCurrent == null)
            {
                throw new Exception("Model is undefined!!");
            }
            try
            {
                var context = new CarBookingManagementContext();
                // check duplicate of email
                var checkDuplicate = context.TblModels.SingleOrDefault(us => us.ModelName.Equals(ModelCurrent.ModelName));
                if (checkDuplicate != null)
                {
                    throw new Exception("Model Name has already existed!");
                }
                context.TblModels.Add(ModelCurrent);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(TblModel ModelCurrent)
        {
            if (ModelCurrent == null)
            {
                throw new Exception("Model is undefined!!");
            }
            try
            {
                TblModel _Model = GetModel(ModelCurrent.ModelId);
                if (_Model != null)
                {
                    var context = new CarBookingManagementContext();
                    context.TblModels.Update(ModelCurrent);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Model does not exist!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var context = new CarBookingManagementContext();
                TblModel Model = context.TblModels.FirstOrDefault(x => x.ModelId == id);
                context.TblModels.Remove(Model);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("There are a car with this model in store! Cannot Delete!");
            }
        }

        public IEnumerable<TblModel> GetAllModels()
        {
            try
            {
                var context = new CarBookingManagementContext();
                IEnumerable<TblModel> models = context.TblModels;
                return models;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
