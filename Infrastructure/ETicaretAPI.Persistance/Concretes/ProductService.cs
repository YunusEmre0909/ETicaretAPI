using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistance.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        => new() 
        { 
            new() {Id=Guid.NewGuid(),Name="Laptop",Price=20000,Stock=5,CreateDate=DateTime.Now},
            new() {Id=Guid.NewGuid(),Name="Mouse",Price=250,Stock=6,CreateDate=DateTime.Now},
            new() {Id=Guid.NewGuid(),Name="Keyboard",Price=300,Stock=4,CreateDate=DateTime.Now},
            new() {Id=Guid.NewGuid(),Name="Monitor",Price=5000,Stock=10,CreateDate=DateTime.Now}
        };
    }
}
