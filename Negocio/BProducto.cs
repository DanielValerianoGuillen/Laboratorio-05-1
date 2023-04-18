using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class BProducto
    {
        DProducto datos = new DProducto();

        public List<Producto> Listar(string nombre)
        {


            var productos = datos.Listar();
            var result = productos.Where(x => x.Nombre == nombre
            || string.IsNullOrEmpty(nombre)
            ).ToList();
            return result;

        }

        public List<Producto> ListasNombre(string nombre)
        {


            var productos = datos.Listar();
            var result = productos.Where(x => x.Nombre == nombre
            || string.IsNullOrEmpty(nombre)
            ).ToList();
            return result;

        }


        public void Insertar(Producto producto)
        {
            try
            {
                
                
              
                datos.Insertar(producto);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
