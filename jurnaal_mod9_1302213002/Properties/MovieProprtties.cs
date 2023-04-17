using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace jurnaal_mod9_1302213002.Properties
{
    public class MovieProprtties
    {
        public String title { get;  set; }
        public String director { get;  set; }
        public List<string> stars { get;  set; } 
        public String description { get;  set; }

        public MovieProprtties(string title, string director, List<string> stars, string description) 
        {
            this.stars = stars;
            this.title = title;
            this.director = director;
            this.description = description;
        }
        
    }
}
