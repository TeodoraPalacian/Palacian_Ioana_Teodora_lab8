using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Palacian_Ioana_Teodora_lab8.Models
{
    public class BookCategory
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
