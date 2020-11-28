using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Palacian_Ioana_Teodora_lab8.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        public ICollection<Book> Books{get;set;}

    }
}
