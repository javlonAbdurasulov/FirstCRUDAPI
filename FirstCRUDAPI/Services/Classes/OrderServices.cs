using FirstCRUDAPI.Context;
using FirstCRUDAPI.Models;
using FirstCRUDAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FirstCRUDAPI.Services.Classes
{
    public class OrderServices : IOrderServices
    {
        private readonly SofiaDbContext _context;
        public OrderServices(IConfiguration configuration) {
            _context = new SofiaDbContext(configuration);
        }
        [HttpPost]
        public string create(Order model)
        {
            _context.Orders.Add(model);
            _context.SaveChanges();
            return "create!";
        }
        [HttpDelete]
        public string delete(int id)
        {
            _context.Orders.Remove(_context.Orders.Find(id));
            _context.SaveChanges();
            return "create!";
        }
        [HttpGet]
        public IEnumerable<Order> read()
        {
            return _context.Orders.ToList();
        }
        [HttpPut]
        public string update(Order model)
        {
            _context.Orders.Update(model);
            _context.SaveChanges();
            return "update!";
        }
    }
}
