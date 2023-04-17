using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;
using jurnaal_mod9_1302213002;
using jurnaal_mod9_1302213002.Properties;
using System.IO;
using System.Runtime.InteropServices;


namespace jurnaal_mod9_1302213002.Controllers.Movie
{
    [ApiController]
    [Route("api/controller")]
    public class Movie : ControllerBase
    {
        public static List<MovieProprtties> data = new List<MovieProprtties>()
        {
            new MovieProprtties("upin ipin", "supri", new List<string>(){"upri,jenap"}, "bla bla"), 


        };
        [HttpGet]
        public IEnumerable<MovieProprtties> Get()
        {
            return data;
        }
        [HttpGet("{judul}")]
        public MovieProprtties Get(int id)
        {
            return data[id];
        }
        [HttpPost]
        public void Post([FromBody]MovieProprtties value) 
        { 
            data.Add(value);
        
        }
        [HttpDelete]
        public void Delete(int jdl)
        {
            if (jdl < 0 || jdl >= data.Count) 
            {
                NotFound();
            }
            data.RemoveAt(jdl);
        }
        private void NotFound()
        {
            throw new NotImplementedException();    
        }
    }
       
}