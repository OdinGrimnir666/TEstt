using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEstt
{
    public  class Product
    {
        [JsonProperty]
        public int Id { get; set; }
        [JsonProperty]
        public string Name { get; set; }
        [JsonProperty]

        public int CategoryId { get; set; }

        [JsonIgnoreAttribute]
        public Categories Category { get; set; }

    }

    public class Categories
    {
        [JsonProperty]
        public int Id { get; set; }
        [JsonProperty]
        public string Name { get; set; }

    }
    public class Json
    {

        public List <Product> Products { get; set; }
        public List <Categories> Categories { get; set; }

}
