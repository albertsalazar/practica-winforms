using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class Vuelo
    {
        public int? Id { get; set; }

        public string origen { get; set; }

        public string destino { get; set; }
        
        public DateTime fecha { get; set; }

        public int pasajeros { get; set; }
    }
}
