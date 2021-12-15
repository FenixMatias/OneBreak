using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.Bussines
{
    public class Contrato
    {
        public string Numero { get; set; }
        public DateTime Creacion { get; set; }
        public DateTime Termino { get; set; }
        public string RutCliente { get; set; }
        public string IdModalidad { get; set; }
        public int IdTipoEvento { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraTermino { get; set; }
        public int Asistentes { get; set; }
        public int PersonalAdicional { get; set; }
        public bool Realizado { get; set; }
        public double ValorTotalContrato { get; set; }
        public string Observaciones { get; set; }

        public Contrato()
        {
            Numero = "";
            Creacion = DateTime.Now;
            Termino = DateTime.Now;
            RutCliente = "";
            IdModalidad = "";
            IdTipoEvento = 0;
            FechaHoraInicio = DateTime.Now;
            FechaHoraTermino = DateTime.Now;
            Asistentes = 0;
            PersonalAdicional = 0;
            Realizado = false;
            ValorTotalContrato = 0;
            Observaciones = "";
        }

        public bool Create()
        {
            try
            {
                Data.Contrato contract = new Data.Contrato()
                {
                    Numero = Numero,
                    Creacion = Creacion,
                    Termino = Termino,
                    RutCliente = RutCliente,
                    IdModalidad = IdModalidad,
                    IdTipoEvento = IdTipoEvento,
                    FechaHoraInicio = FechaHoraInicio,
                    FechaHoraTermino = FechaHoraTermino,
                    Asistentes = Asistentes,
                    PersonalAdicional = PersonalAdicional,
                    Realizado = Realizado,
                    ValorTotalContrato = ValorTotalContrato,
                    Observaciones = Observaciones,
                };
                Connection._ONBREAK.Contrato.Add(contract);
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
                Data.Contrato contract = Connection._ONBREAK.Contrato.First(n => n.Numero == Numero);
                Numero = contract.Numero;
                Creacion = contract.Creacion;
                Termino = contract.Termino;
                RutCliente = contract.RutCliente;
                IdModalidad = contract.IdModalidad;
                IdTipoEvento = contract.IdTipoEvento;
                FechaHoraInicio = contract.FechaHoraInicio;
                FechaHoraTermino = contract.FechaHoraTermino;
                Asistentes = contract.Asistentes;
                PersonalAdicional = contract.PersonalAdicional;
                Realizado = contract.Realizado;
                ValorTotalContrato = contract.ValorTotalContrato;
                Observaciones = contract.Observaciones;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Read2()
        {
            try
            {
                Data.Contrato contract = Connection._ONBREAK.Contrato.First(n => n.RutCliente == RutCliente);
                Numero = contract.Numero;
                Creacion = contract.Creacion;
                Termino = contract.Termino;
                RutCliente = contract.RutCliente;
                IdModalidad = contract.IdModalidad;
                IdTipoEvento = contract.IdTipoEvento;
                FechaHoraInicio = contract.FechaHoraInicio;
                FechaHoraTermino = contract.FechaHoraTermino;
                Asistentes = contract.Asistentes;
                PersonalAdicional = contract.PersonalAdicional;
                Realizado = contract.Realizado;
                ValorTotalContrato = contract.ValorTotalContrato;
                Observaciones = contract.Observaciones;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        

        public bool Read3()
        {
            try
            {
                Data.Contrato contract = Connection._ONBREAK.Contrato.First(n => n.IdTipoEvento == IdTipoEvento);
                Numero = contract.Numero;
                Creacion = contract.Creacion;
                Termino = contract.Termino;
                RutCliente = contract.RutCliente;
                IdModalidad = contract.IdModalidad;
                IdTipoEvento = contract.IdTipoEvento;
                FechaHoraInicio = contract.FechaHoraInicio;
                FechaHoraTermino = contract.FechaHoraTermino;
                Asistentes = contract.Asistentes;
                PersonalAdicional = contract.PersonalAdicional;
                Realizado = contract.Realizado;
                ValorTotalContrato = contract.ValorTotalContrato;
                Observaciones = contract.Observaciones;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }







        public bool Read4()
        {
            try
            {
                ModalidadServicio mod = new ModalidadServicio();

                Data.Contrato contract = Connection._ONBREAK.Contrato.First(n => n.IdModalidad == IdModalidad);
                Numero = contract.Numero;
                Creacion = contract.Creacion;
                Termino = contract.Termino;
                RutCliente = contract.RutCliente;
                IdModalidad = contract.IdModalidad;
                IdTipoEvento = contract.IdTipoEvento;
                FechaHoraInicio = contract.FechaHoraInicio;
                FechaHoraTermino = contract.FechaHoraTermino;
                Asistentes = contract.Asistentes;
                PersonalAdicional = contract.PersonalAdicional;
                Realizado = contract.Realizado;
                ValorTotalContrato = contract.ValorTotalContrato;
                Observaciones = contract.Observaciones;
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
                Data.Contrato contract = Connection._ONBREAK.Contrato.First(n => n.Numero == Numero);
                contract.Numero = Numero;
                contract.Creacion = Creacion;
                contract.Termino = Termino;
                contract.RutCliente = RutCliente;
                contract.IdModalidad = IdModalidad;
                contract.FechaHoraInicio = FechaHoraInicio;
                contract.FechaHoraTermino = FechaHoraTermino;
                contract.Asistentes = Asistentes;
                contract.PersonalAdicional = PersonalAdicional;
                contract.Realizado = Realizado;
                contract.ValorTotalContrato = ValorTotalContrato;
                contract.Observaciones = Observaciones;

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
                Data.Contrato contract = Connection._ONBREAK.Contrato.First(n => n.Numero == Numero);
                Connection._ONBREAK.Contrato.Remove(contract);
                Connection._ONBREAK.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Contrato> GetContracts()
        {
            List<Contrato> contratos = new List<Contrato>();

            foreach (Data.Contrato contract in Connection._ONBREAK.Contrato.ToList())
            {
                contratos.Add(new Contrato()
                {
                    Numero = contract.Numero,
                    Creacion = contract.Creacion,
                    Termino = contract.Termino,
                    RutCliente = contract.RutCliente,
                    IdModalidad = contract.IdModalidad,
                    IdTipoEvento = contract.IdTipoEvento,
                    FechaHoraInicio = contract.FechaHoraInicio,
                    FechaHoraTermino = contract.FechaHoraTermino,
                    Asistentes = contract.Asistentes,
                    PersonalAdicional = contract.PersonalAdicional,
                    Realizado = contract.Realizado,
                    ValorTotalContrato = contract.ValorTotalContrato,
                    Observaciones = contract.Observaciones
                });
            }
            return contratos;
        }

        public List<Contrato> GetContractsTypeEvent(int idevento)
        {
            List<Contrato> contratos = new List<Contrato>();

            foreach (Data.Contrato contract in Connection._ONBREAK.Contrato.ToList())
            {
                if (contract.IdTipoEvento == idevento)
                {
                    contratos.Add(new Contrato()
                    {
                        Numero = contract.Numero,
                        Creacion = contract.Creacion,
                        Termino = contract.Termino,
                        RutCliente = contract.RutCliente,
                        IdModalidad = contract.IdModalidad,
                        IdTipoEvento = contract.IdTipoEvento,
                        FechaHoraInicio = contract.FechaHoraInicio,
                        FechaHoraTermino = contract.FechaHoraTermino,
                        Asistentes = contract.Asistentes,
                        PersonalAdicional = contract.PersonalAdicional,
                        Realizado = contract.Realizado,
                        ValorTotalContrato = contract.ValorTotalContrato,
                        Observaciones = contract.Observaciones
                    });
                }
            }
            return contratos;
        }

        public double ValorAsitente()
        {
            double va = 0;
            double uf = 27741.019;
            if (Asistentes >= 1 && Asistentes <= 20)
            {
                va = 3*uf;
            }
            if (Asistentes >= 21 && Asistentes <= 50)
            {
                va = 5*uf;
            }
            if (Asistentes > 50)
            {
                for (int i = 0; i <= PersonalAdicional; i++)
                {
                    if (i == 20)
                    {
                        va = 2*uf;
                    }
                }
            }
            return va;
        }

        public double ValorPersonal()
        {
            double vp = 0;
            double uf = 27741.019;
            if (PersonalAdicional == 2)
            {
                vp = 2*uf;
            }
            if (PersonalAdicional == 3)
            {
                vp = 3*uf;
            }
            if (PersonalAdicional == 4)
            {
                vp = 3.5*uf;
            }
            if (PersonalAdicional > 4)
            {
                vp = 3.5+(0.5*PersonalAdicional)*uf;
            }
            return vp;
        }
    }

    
}
