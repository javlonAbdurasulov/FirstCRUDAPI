﻿using FirstCRUDAPI.Context;
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



    }
}
