﻿using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BloodDoantee.Controllers
{
    public class DonorController : ApiController
    {

        [Route("api/donors")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = DonorService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/donors/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = DonorService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/donors/add")]
        [HttpPost]
        public HttpResponseMessage Add(DonorDTO donor)
        {
            

                var data = DonorService.Add(donor);
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            
            
        }
    }
