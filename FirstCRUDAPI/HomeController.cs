using FirstCRUDAPI.Context;
using FirstCRUDAPI.Models;
using FirstCRUDAPI.Services.Classes;
using FirstCRUDAPI.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstCRUDAPI
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    //[ApiController]
    public class HomeController
    {
        private readonly UserServices _userServices;
        private readonly OrderServices _orderServices;
        public HomeController(IConfiguration configuration)
        {
            _userServices = new UserServices(configuration);
            _orderServices = new OrderServices(configuration);
        }

        [Microsoft.AspNetCore.Mvc.Route("st")]
        [HttpGet("start")]
        public string Start()
        {
            var userList = _userServices.read();
            string outPut = "";
            foreach (var user in userList)
            {
                outPut += user.ToString();
                outPut += "\n";
            }
            return outPut;
        }
        [Route("cr")]
        [HttpPost]
        public User created(User user)
        {
            var userList = _userServices.create(user);
            return user;
        }



    }
}
