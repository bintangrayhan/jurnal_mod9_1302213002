using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace jurnaal_mod9_1302213002.Properties
{
    public class Movie
    {
        public String title { get; private set; };
        public String director { get; private set; }
        public String stars { get; private set; } 
        public String description { get; private set; }   
    }
}
