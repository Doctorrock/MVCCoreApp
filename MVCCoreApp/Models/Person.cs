using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreApp.Models
{
    public class Person
    {
        private string name;
        private readonly List<string> specialNames = new List<string>() { "Paweł", "Martyna", "Zuzia" };

        public int ID { get; set; }

        public DateTime CreationTime { get; set; }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if(specialNames.Contains(value) )
                {
                    name = value + " xD";
                }
                else
                {
                    name = value;
                }
                
            }
        }

    }
}
