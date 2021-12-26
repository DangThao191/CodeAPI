using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.RouteService
{
    public class DistanceService : IDistanceService
    {
        private IRepository<Distance> repo;
        public DistanceService(IRepository<Distance> repo)
        {
            this.repo = repo;

        }
        public void DeleteDistance(int id)
        {
            Distance distance = GetDistance(id);
            repo.Remove(distance);
            repo.SaveChanges();
        }

        public IEnumerable<Distance> GetAllDistance()
        {
            return repo.GetAll();
        }

        public Distance GetDistance(int id)
        {
            return repo.Get(id);
        }

        public void InsertDistance(Distance distance)
        {
            repo.Insert(distance);
        }

        public void UpdateDistance(Distance distance)
        {
            repo.Update(distance);
        }
    }
}
