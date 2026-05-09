using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
        //clase de pedidos
        public class pedido
        {
            public int id { get; set; }
            public DateTime fecha { get; set; }
            public string cliente { get; set; }
            public string productos { get; set; }
            public string estado { get; set; }
        }
}