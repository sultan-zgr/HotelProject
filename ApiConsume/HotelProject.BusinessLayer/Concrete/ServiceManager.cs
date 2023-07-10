using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServicesDal _servicesDal;

        public ServiceManager(IServicesDal servicesDal)
        {
            _servicesDal = servicesDal;
        }

        public void TDelete(Service t)
        {
            throw new NotImplementedException();
        }

        public Service TGetByID(int id)
        {
            return _servicesDal.GetByID(id);
        }

        public List<Service> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Service t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Service t)
        {
            throw new NotImplementedException();
        }
    }
}
