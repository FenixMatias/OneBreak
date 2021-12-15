using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.Bussines
{
    public class ActividadEmpresa
    {
        public int IdActividadEmpresa { get; set; }
        public string Descripcion { get; set; }

        public ActividadEmpresa()
        {
            IdActividadEmpresa = 0;
            Descripcion = "";
        }

        public List<ActividadEmpresa> GetActividadEmpresas()
        {
            return (
                from companyactivity in Connection._ONBREAK.ActividadEmpresa
                select new ActividadEmpresa()
                {
                    IdActividadEmpresa = companyactivity.IdActividadEmpresa,
                    Descripcion = companyactivity.Descripcion
                }
            ).ToList();
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }

}

