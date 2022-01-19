using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEstt
{
    public  class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CategoryId { get; set; }
       


    }

    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
    public class Json
    {

        public List <Product> Products { get; set; }
        public List <Categories> Categories { get; set; }
    }
}
