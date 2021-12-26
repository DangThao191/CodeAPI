using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.VehicleService
{
    public class VehicleService : IVehicleService
    {
        private IRepository<Vehicle> repo;
        public VehicleService(IRepository<Vehicle> repo)
        {
            this.repo = repo;
        }
        public void DeleteVehicle(int id)
        {
            Vehicle vehicle = GetVehicle(id);
            repo.Remove(vehicle);
            repo.SaveChanges();
        }

        public IEnumerable<Vehicle> GetAllVehicle()
        {
            return repo.GetAll();
        }

        public Vehicle GetVehicle(int id)
        {
            return repo.Get(id);
        }

        public void InsertVehicle(Vehicle vehicle)
        {
            repo.Insert(vehicle);
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            repo.Update(vehicle);
        }
    }
}
