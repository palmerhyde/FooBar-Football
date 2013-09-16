﻿using FooBarFootball.Models;
using FooBarFootball.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FooBarFootball.Web.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public HttpResponseMessage Get()
        {
            CardsViewModel vm = new CardsViewModel();
            vm.Cards = new List<Card>();
            Green card1 = new Green();
            Green card2 = new Green();
            vm.Cards.Add(card1);
            vm.Cards.Add(card2);
            return Request.CreateResponse(HttpStatusCode.OK, vm);
        }
    }
}