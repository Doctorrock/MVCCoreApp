using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreApp.Models
{
    public class Person
    {
        private string name;
        private List<string> specialNames = new List<string>() { "Paweł", "Martyna", "Zuzia" };

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
                    name = value + "xD";
                }
                else
                {
                    name = value;
                }
                
            }
        }

        public string ComputeName(string name)
        {
            if (specialNames.Contains(name))
            {
                return name + "xD";
            }

            return name;
        }
    }
}
