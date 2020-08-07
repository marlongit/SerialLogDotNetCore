using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SerialLogCore.Business;
using SerialLogCore.Models;

namespace SerialLogCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase
    {
        [HttpPost]
        public string Post(EventModel model)
        {
            return EventBusiness.Instance.Save(model);
        }

        [HttpGet]        
        public object Get()
        {
            EventModel model = new EventModel
            {
                Data = DateTime.Now.AddDays(10),
                Description = "Teste do Serial Log",
                Name = "Método Get",
                Local = "localhost",
                Id = new Random(99).Next(1, 100)
            };

            EventBusiness.Instance.Save(model);

            return model;
        }
    }
}
