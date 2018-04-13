﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Productor.Model;
using Productor.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Productor.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        //private readonly IMapper _mapper;
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            //_mapper = mapper;
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult Get(string orderNo)
        {
            return Json(_orderService.GetOrderInfo(orderNo));
        }

        [HttpPost]
        public IActionResult Order([FromBody]OrderInput input)
        {
            return Json();
        }
    }
}