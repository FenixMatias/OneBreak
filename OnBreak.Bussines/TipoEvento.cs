using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.Bussines
{
    public class TipoEvento
    {
        public int IdTipoEvento { get; set; }
        public string Descripcion { get; set; }

        public TipoEvento()
        {
            IdTipoEvento = 0;
            Descripcion = "";
        }

        public List<TipoEvento> GetTipoEventos()
        {
            List<TipoEvento> tipos = new List<TipoEvento>();

            foreach (Data.TipoEvento type in Connection._ONBREAK.TipoEvento.ToList())
            {
                tipos.Add(new TipoEvento()
                {

                    IdTipoEvento = type.IdTipoEvento,
                    Descripcion = type.Descripcion
                });
            }
            return tipos;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}