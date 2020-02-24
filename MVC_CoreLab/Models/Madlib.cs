using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CoreLab.Models
{
    public class Madlib
    {
        public string Name { set; get; }
        public string Transport { set; get; }
        public string City { set; get; }
        public string TimeOfDay { set; get; }
        public string ClassName { set; get; }
        public string Emotion { set; get; }
        public string Adverb { set; get; }
        public string Adjective { set; get; }
        public string Exclamation { set; get; }

        public Madlib() { }

        public Madlib(string name, string transport, string city, string timeofday, string classname, string emotion, string adverb, string adjective, string exclamation)
        {
            Name = name;
            Transport = transport;
            City = city;
            TimeOfDay = timeofday;
            ClassName = classname;
            Emotion = emotion;
            Adverb = adverb;
            Adjective = adjective;
            Exclamation = exclamation;
        }
    }
}
