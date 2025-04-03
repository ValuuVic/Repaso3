using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso3
{
    class Propietario
    {
        public string nombre {  get; set; }
        public string apellido { get; set; }
        public string DPI {  get; set; }
        public string NombreCompleto
        {
            get
            {
                return (nombre + ", " + apellido);
            }
        }
    }
}
