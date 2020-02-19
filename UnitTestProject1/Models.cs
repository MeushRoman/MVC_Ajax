using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class Models
    {
    }
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Service
    {
        private List<string> _arr = new List<string>();
        public Service(int iCount)
        {            
            for (int i = 0; i < iCount; i++)
            {
                _arr.Add(i.ToString());
            }
        }

        public List<string> getArray
        {
            get
            {
                return _arr;
            }
        }

        public List<City> Cities()
        {
            return new List<City>
            {
                new City{Id = 1, Name = "Almaty"},
                new City{Id = 2, Name = "Astana"},
                new City{Id = 3, Name = "Atyray"}
            };
        }
    }

}
