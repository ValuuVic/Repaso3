using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Repaso3
{
    class ArchivoPropiedad
    {
        public void guardar(String archivo, List<Propiedad> propiedades)
        {
            string json = JsonConvert.SerializeObject(propiedades);
            System.IO.File.WriteAllText(archivo, json);
        }
        public List<Propiedad> Leer(string archivo)
        {
            List<Propiedad> lista = new List<Propiedad>();
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            lista = JsonConvert.DeserializeObject<List<Propiedad>>(json);
            return lista;
        }
    }
}
