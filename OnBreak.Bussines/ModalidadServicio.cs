using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.Bussines
{
    public class ModalidadServicio
    {
        public string IdModalidad { get; set; }
        public int IdTipoEvento { get; set; }
        public string Nombre { get; set; }
        public double ValorBase { get; set; }
        public int PersonalBase { get; set; }

        public ModalidadServicio()
        {
            IdModalidad = "";
            IdTipoEvento = 0;
            Nombre = "";
            ValorBase = 0;
            PersonalBase = 0;
        }

        public bool Create()
        {
            try
            {
                Data.ModalidadServicio modalityservice = new Data.ModalidadServicio()
                {
                    IdModalidad = IdModalidad,
                    IdTipoEvento = IdTipoEvento,
                    Nombre = Nombre,
                    ValorBase = ValorBase,
                    PersonalBase = PersonalBase,
                };
                Connection._ONBREAK.ModalidadServicio.Add(modalityservice);
                Connection._ONBREAK.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Read()
        {
            try
            {
                Data.ModalidadServicio modalityservice = Connection._ONBREAK.ModalidadServicio.First(i => i.IdModalidad == IdModalidad);
                IdModalidad = modalityservice.IdModalidad;
                IdTipoEvento = modalityservice.IdTipoEvento;
                Nombre = modalityservice.Nombre;
                ValorBase = modalityservice.ValorBase;
                PersonalBase = modalityservice.PersonalBase;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                Data.ModalidadServicio modalityservice = Connection._ONBREAK.ModalidadServicio.First(i => i.IdModalidad == IdModalidad);
                modalityservice.IdModalidad = IdModalidad;
                modalityservice.IdTipoEvento = IdTipoEvento;
                modalityservice.Nombre = Nombre;
                modalityservice.ValorBase = ValorBase;
                modalityservice.PersonalBase = PersonalBase;

                Connection._ONBREAK.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                Data.ModalidadServicio modalityservice = Connection._ONBREAK.ModalidadServicio.First(i => i.IdModalidad == IdModalidad);
                Connection._ONBREAK.ModalidadServicio.Remove(modalityservice);
                Connection._ONBREAK.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ModalidadServicio> GetModalityService()
        {
            List<ModalidadServicio> modalidadservicios = new List<ModalidadServicio>();

            foreach (Data.ModalidadServicio modalityservice in Connection._ONBREAK.ModalidadServicio.ToList())
            {
                modalidadservicios.Add(new ModalidadServicio()
                {
                    IdModalidad = modalityservice.IdModalidad,
                    IdTipoEvento = modalityservice.IdTipoEvento,
                    Nombre = modalityservice.Nombre,
                    ValorBase = modalityservice.ValorBase,
                    PersonalBase = modalityservice.PersonalBase,
                });
            }
            return modalidadservicios;
        }

        public override string ToString()
        {

            return Nombre;
        }
    }

   
}
