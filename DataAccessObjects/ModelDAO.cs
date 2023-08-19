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
