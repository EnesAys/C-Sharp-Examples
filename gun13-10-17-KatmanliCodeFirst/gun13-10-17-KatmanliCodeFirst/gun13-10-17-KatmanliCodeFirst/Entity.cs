using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gun13_10_17_KatmanliCodeFirst
{
   public class Entity
    {
        public Entity()
        {
            CreatedDate = DateTime.Now;
        }
        public DateTime CreatedDate { get; set; }
        public int ID { get; set; }
    }
}
