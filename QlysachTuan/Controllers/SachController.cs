using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using QlysachTuan.Models;

namespace QlysachTuan.Controllers
{
    public class SachController : ApiController
    {
        // GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
        //bailam
        Sach[] sachs = new Sach[]   
        {            
            new Sach { Id = 1, Title = "Tôi thấy hoa vàng trên cỏ xanh", AuthorName = "Nguyễn Nhật Ánh", Price=1 , Content="Truyện kể về Tuổi thơ..." },

            new Sach { Id = 2, Title = "Pro ASP.NET MVC5", AuthorName = "Adam Freeman", Content="The ASP.NET MVC 5 Framework is the latest evolution of Microsoft’s ASP.NET web platform.",  Price = 3.75M },

            new Sach { Id = 3, Title = "Có Chàng trai viết lên cây", AuthorName = "Hoàng Nghĩa Tuấn", Content="The ASP.NET MVC 5 Framework is the latest evolution of Microsoft’s ASP.NET web platform.",  Price = 4 },
        };

        public IEnumerable<Sach> GetAll()
        {
            return sachs; 
        }

        public IHttpActionResult GetSach(int id) 
        { 
            var sach = sachs.FirstOrDefault((p) => p.Id == id); 
            if (sach == null)
            { 
                return NotFound(); 
            } 
            return Ok(sach);
        }
    }
}
