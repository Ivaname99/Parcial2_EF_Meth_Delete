using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ProductoRepository
    {
        public Parcial02Entities contexto = new Parcial02Entities();

        public List<Productos> ObtenerTodos()
        {
            var Productos = from item in contexto.Productos select item;
            return Productos.ToList();
        }

        public Productos ObtenerPorID(int id)
        {
            var productos = from item in contexto.Productos where item.Id == id select item;
            return productos.FirstOrDefault();
        }

        public int DeleteCliente(int id)
        {
            var registro = ObtenerPorID(id);
            if (registro != null)
            {
                contexto.Productos.Remove(registro);
                return contexto.SaveChanges();
            }
            return 0;
        }
    }
}
