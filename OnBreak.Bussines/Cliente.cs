using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnBreak.Data;

namespace OnBreak.Bussines
{
    public class Cliente
    {
        public string RutCliente { get; set; }
        public string RazonSocial { get; set; }
        public string NombreContacto { get; set; }
        public string MailContacto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int ActividadEmpresaId { get; set; }
        public string ActividadEmpresaDescripcion { get; set; }
        public int TipoEmpresaId { get; set; }
        public string TipoEmpresaDescripcion { get; set; }

        public Cliente()
        {
            RutCliente = "";
            RazonSocial = "";
            NombreContacto = "";
            MailContacto = "";
            Direccion = "";
            Telefono = "";
            ActividadEmpresaId = 1;
            TipoEmpresaId = 10;
        }

        public bool Create()
        {
            try
            {
                Data.Cliente client = new Data.Cliente()
                {
                    RutCliente = RutCliente,
                    RazonSocial = RazonSocial,
                    NombreContacto = NombreContacto,
                    MailContacto = MailContacto,
                    Direccion = Direccion,
                    Telefono = Telefono,
                    IdActividadEmpresa = ActividadEmpresaId,
                    IdTipoEmpresa = TipoEmpresaId
                };
                Connection._ONBREAK.Cliente.Add(client);
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
                Data.Cliente client = Connection._ONBREAK.Cliente.First(r => r.RutCliente == RutCliente);
                RutCliente = client.RutCliente;
                RazonSocial = client.RazonSocial;
                NombreContacto = client.NombreContacto;
                MailContacto = client.MailContacto;
                Direccion = client.Direccion;
                Telefono = client.Telefono;
                ActividadEmpresaId = client.IdActividadEmpresa;
                TipoEmpresaId = client.IdTipoEmpresa;
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
                Data.Cliente client = Connection._ONBREAK.Cliente.First(r => r.IdActividadEmpresa == ActividadEmpresaId);

                RutCliente = client.RutCliente;
                RazonSocial = client.RazonSocial;
                NombreContacto = client.NombreContacto;
                MailContacto = client.MailContacto;
                Direccion = client.Direccion;
                Telefono = client.Telefono;
                ActividadEmpresaId = client.IdActividadEmpresa;
                TipoEmpresaId = client.IdTipoEmpresa;
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
                Data.Cliente client = Connection._ONBREAK.Cliente.First(r => r.RutCliente == RutCliente);
                client.RutCliente = RutCliente;
                client.RazonSocial = RazonSocial;
                client.NombreContacto = NombreContacto;
                client.MailContacto = MailContacto;
                client.Direccion = Direccion;
                client.Telefono = Telefono;
                client.IdActividadEmpresa = ActividadEmpresaId;
                client.IdTipoEmpresa = TipoEmpresaId;
                
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
                Data.Cliente client = Connection._ONBREAK.Cliente.First(r => r.RutCliente == RutCliente);
                Connection._ONBREAK.Cliente.Remove(client);
                Connection._ONBREAK.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Cliente> GetClients()
        {
            List<Cliente> clientes = new List<Cliente>();
            List<Data.Cliente> DataClientes = Connection._ONBREAK.Cliente.ToList();
            foreach (Data.Cliente client in DataClientes)
            {
                Cliente cliente = new Cliente()
                {
                    RutCliente = client.RutCliente,
                    RazonSocial = client.RazonSocial,
                    NombreContacto = client.NombreContacto,
                    MailContacto = client.MailContacto,
                    Direccion = client.Direccion,
                    Telefono = client.Telefono,
                    ActividadEmpresaId = client.IdActividadEmpresa,
                    TipoEmpresaId = client.IdTipoEmpresa

                };

                if (client.ActividadEmpresa != null)
                {
                    cliente.ActividadEmpresaDescripcion = client.ActividadEmpresa.Descripcion;
                }
                if (client.TipoEmpresa != null)
                {
                    cliente.TipoEmpresaDescripcion = client.TipoEmpresa.Descripcion;
                }
                clientes.Add(cliente);
                
            }
            return clientes;
        }

        public List<Cliente> GetClients(int actividadempresa)
        {
            return (
                from client in Connection._ONBREAK.Cliente
                where client.IdActividadEmpresa == actividadempresa 
                select new Cliente()
                {
                    RutCliente = client.RutCliente,
                    RazonSocial = client.RazonSocial,
                    NombreContacto = client.NombreContacto,
                    MailContacto = client.MailContacto,
                    Direccion = client.Direccion,
                    Telefono = client.Telefono,
                    ActividadEmpresaId = client.IdActividadEmpresa,
                    ActividadEmpresaDescripcion = client.ActividadEmpresa.Descripcion,
                    TipoEmpresaId = client.IdTipoEmpresa,
                    TipoEmpresaDescripcion = client.TipoEmpresa.Descripcion,
                }
                ).ToList();
        }
    }
}
