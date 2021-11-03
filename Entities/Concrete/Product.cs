using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public int SubCategoryId { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public string Picture3 { get; set; }
        public string øD { get; set; }
        public string Ødmax { get; set; }
        public string ød1 { get; set; }
        public string ød2 { get; set; }
        public string L { get; set; }
        public string L1 { get; set; }
        public string I1 { get; set; }
        public string I2 { get; set; }
        public string V { get; set; }
        public string R { get; set; }
        public string h1 { get; set; }
        public string b { get; set; }
        public string K { get; set; }
    }
}
