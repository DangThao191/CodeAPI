using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.VehicleService
{
    public interface IVehicleService
    {
        IEnumerable<Vehicle> GetAllVehicle();
        Vehicle GetVehicle(int id);
        void InsertVehicle(Vehicle vehicle);
        void UpdateVehicle(Vehicle vehicle);
        void DeleteVehicle(int id);
        
    }
}
