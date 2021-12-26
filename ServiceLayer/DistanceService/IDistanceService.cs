using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.RouteService
{
    public interface IDistanceService
    { 
        IEnumerable<Distance> GetAllDistance();
        Distance GetDistance(int id);
        void InsertDistance(Distance distance);
        void UpdateDistance(Distance distance);
        void DeleteDistance(int id);
    }
}
