using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.Bussines
{
    public class TipoEmpresa
    {
        public int IdTipoEmpresa { get; set; }
        public string Descripcion { get; set; }

        public TipoEmpresa()
        {
            IdTipoEmpresa = 0;
            Descripcion = "";
        }

        public List<TipoEmpresa> GetTipoEmpresas()
        {
            List<TipoEmpresa> tipos = new List<TipoEmpresa>();

            foreach (Data.TipoEmpresa type in Connection._ONBREAK.TipoEmpresa.ToList())
            {
                tipos.Add(new TipoEmpresa()
                {

                    IdTipoEmpresa = type.IdTipoEmpresa,
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

    
