using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Microservice.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Entities.Customer> Customers{ get; set; }
        Task<int> SaveChanges();
    }
}
