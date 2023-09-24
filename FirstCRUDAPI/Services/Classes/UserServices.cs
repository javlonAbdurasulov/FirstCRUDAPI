using FirstCRUDAPI.Context;
using FirstCRUDAPI.Models;
using FirstCRUDAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FirstCRUDAPI.Services.Classes
{
    public class UserServices : IUserServices
    {
        private readonly SofiaDbContext _context;
        public UserServices(IConfiguration configuration)
        {
            _context = new SofiaDbContext(configuration);
        }
        [HttpPost]
        public string create(User model)
        {
            _context.Users.Add(model);
            _context.SaveChanges();
            return "create!";
        }
        [HttpDelete]
        public string delete(int id)
        {
            _context.Users.Remove(_context.Users.Find(id));
            _context.SaveChanges();

            return "delete!";
        }
        [HttpGet("read")]
        public IEnumerable<User> read()
        {
            return _context.Users.ToList();
        }
        [HttpPut]
        public string update(User model)
        {
            _context.Users.Update(model);
            _context.SaveChanges();
            return "update!";
        }
    }
}
