using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using OnBreak.Bussines;

namespace OnBreak.ViewModelCliente
{
    public class ClienteVM : INotifyPropertyChanged
    {
        private Cliente _cliente;
        private ActividadEmpresa _actividadEmpresa;
        private TipoEmpresa _tipoEmpresa;
        private int _selectedIndexCliente;
        private int _selectedFilter;
        private string _alert;
        public event PropertyChangedEventHandler PropertyChanged;
        public Command CreateClientCommand { get; set; }
        public Command ReadClientCommand { get; set; }
        public Command UpdateClientCommand { get; set; }
        public Command DeleteClientCommand { get; set; }
        public Command RdrutCommand { get; set; }
        public Command Clear { get; set; }
        
        public ClienteVM()
        {
            _cliente = new Cliente();
            _actividadEmpresa = new ActividadEmpresa();
            _tipoEmpresa = new TipoEmpresa();
            CreateClientCommand = new Command(CreateClient, canExecuteAlways);
            ReadClientCommand = new Command(ReadClient, canExecuteAlways);
            UpdateClientCommand = new Command(UpdateClient, canExecuteAlways);
            DeleteClientCommand = new Command(DeleteClient, canExecuteAlways);
            RdrutCommand = new Command(ReadRut, canExecuteAlways);
            Clear = new Command(ExecuteClear, canExecuteAlways);
        }

        public List<Cliente> Clientes
        {
            get
            {
                if (SelectedFilter != -1)
                {
                    if (SelectedFilter == 0)
                    {
                        return _cliente.GetClients();
                    }
                    return _cliente.GetClients(SelectedFilter);
                }
                return _cliente.GetClients();
            }
        }
        
        public int SelectedFilter
        {
            get { return _selectedFilter; }
            set { _selectedFilter = value; OnPropertyChanged("Clientes"); Alert = "Filtrado Realizado Satisfactoriamente :)"; }
        }

        public string RutCliente
        {
            get { return _cliente.RutCliente; }
            set { _cliente.RutCliente = value; }
        }
        
        public string RazonSocial
        {
            get { return _cliente.RazonSocial; }
            set { _cliente.RazonSocial = value; }
        }

        public string NombreContacto
        {
            get { return _cliente.NombreContacto; }
            set { _cliente.NombreContacto = value; }
        }

        public string MailContacto
        {
            get { return _cliente.MailContacto; }
            set { _cliente.MailContacto = value; }
        }

        public string Direccion
        {
            get { return _cliente.Direccion; }
            set { _cliente.Direccion = value; }
        }

        public string Telefono
        {
            get { return _cliente.Telefono; }
            set { _cliente.Telefono = value; }
        }
        
        public List<ActividadEmpresa> Actividades
        {
            get
            {
                ActividadEmpresa all = new ActividadEmpresa() { Descripcion = "Seleccione" };
                List<ActividadEmpresa> activitys = new List<ActividadEmpresa>();
                activitys.Add(all);
                foreach (ActividadEmpresa activity in _actividadEmpresa.GetActividadEmpresas())
                {
                    activitys.Add(activity);
                }
                return activitys;
            }
        }

        private int _selectedIndexActivity;

        public int SelectedIndexActivity
        {
            get
            {
                try
                {
                    ActividadEmpresa actividadempresa = Actividades.First(c => c.IdActividadEmpresa == _cliente.ActividadEmpresaId);
                    for (int i = 0; i < Actividades.Count; i++)
                    {
                        if (Actividades[i].IdActividadEmpresa == actividadempresa.IdActividadEmpresa)
                        {
                            return i;
                        }
                    }
                }
                catch (Exception)
                {
                    
                }
                return -1;
            }
            set
            {
                _selectedIndexActivity = value;
                if (value != -1)
                {
                    ActividadEmpresa actividadempresa = Actividades[value];
                    _cliente.ActividadEmpresaId = actividadempresa.IdActividadEmpresa;
                }
            }
        }

        public List<TipoEmpresa> Tipos
        {
            get
            {
                TipoEmpresa all = new TipoEmpresa() { Descripcion = "Seleccione" };
                List<TipoEmpresa> types = new List<TipoEmpresa>();
                types.Add(all);
                foreach (TipoEmpresa type in _tipoEmpresa.GetTipoEmpresas())
                {
                    types.Add(type);
                }
                return types;
            }
        }

        private int _selectedIndexType;

        public int SelectedIndexType
        {
            get
            {
                try
                {
                    TipoEmpresa tipoempresa = Tipos.First(c => c.IdTipoEmpresa == _cliente.TipoEmpresaId);
                    for (int i = 0; i < Tipos.Count; i++)
                    {
                        if (Tipos[i].IdTipoEmpresa == tipoempresa.IdTipoEmpresa)
                        {
                            return i;
                        }
                    }
                }
                catch (Exception)
                {

                }
                return -1;
            }
            set
            {
                _selectedIndexType = value;
                if (value != -1)
                {
                    TipoEmpresa tipoempresa = Tipos[value];
                    _cliente.TipoEmpresaId = tipoempresa.IdTipoEmpresa;
                }
            }
        }
        
        public int SelectedIndexCliente
        {
            get { return _selectedIndexCliente; }
            set
            {
                _selectedIndexCliente = value;
                if (value != -1)
                {
                    _cliente = Clientes[_selectedIndexCliente];
                    OnPropertyChanged("RutCliente");
                    OnPropertyChanged("RazonSocial");
                    OnPropertyChanged("NombreContacto");
                    OnPropertyChanged("MailContacto");
                    OnPropertyChanged("Direccion");
                    OnPropertyChanged("Telefono");
                    OnPropertyChanged("SelectedIndexActivity");
                    OnPropertyChanged("SelectedIndexType");
                }
            }
        }

        public string Alert
        {
            get { return _alert; }
            set { _alert = value; OnPropertyChanged("Alert"); }
        }

        public bool canExecuteAlways(Object obj)
        {
            return true;
        }

        public void CreateClient(Object obj)
        {
            if (ValidarCampos())
            {
                Alert = "Los Campos no Pueden Estar Vacios X(";
                return;
            }

            if (_cliente.Create())
            {
                Alert = "Cliente Creado Satisfactoriamente :)";
                OnPropertyChanged("Clientes");
            }
            else
            {
                Alert = "No se Pudo Crear al Cliente :(";
            }
        }

        public void ReadClient(Object obj)
        {
            if (_cliente.Read())
            {
                Alert = "Cliente Encontrado Satisfactoriamente :)";
                OnPropertyChanged("RutCliente");
                OnPropertyChanged("RazonSocial");
                OnPropertyChanged("NombreContacto");
                OnPropertyChanged("MailContacto");
                OnPropertyChanged("Direccion");
                OnPropertyChanged("Telefono");
                OnPropertyChanged("SelectedIndexActivity");
                OnPropertyChanged("SelectedIndexType");
                OnPropertyChanged("Clientes");
            }
            else
            {
                Alert = "No se Pudo Encontrar al Cliente :(";
            }
        }

        public void UpdateClient(Object obj)
        {
            if (_cliente.Update())
            {
                Alert = "Cliente Actualizado Satisfactoriamente :)";
                OnPropertyChanged("Clientes");
            }
            else
            {
                Alert = "Cliente no Actualizado :(";
            }
        }

        public void DeleteClient(Object obj)
        {

            Alert = "¿Desea Eliminar al Cliente Definitivamente?";
            
            Contrato contract = new Contrato();
            List<Contrato> _contracts = contract.GetContracts();
            bool contratos = false;
            for (int i = 0; i < _contracts.Count; i++)
            {
                if (_contracts[i].RutCliente == _cliente.RutCliente)
                {
                    contratos = true;
                }
            }
            if (contratos)
            {
                Alert = "Cliente no se Puede Eliminar, Tiene un Contrato con Nuestra Empresa ;)";
            }
            else

            if (_cliente.Delete())
            {

                Alert = "Cliente Eliminado Satisfactoriamente ;)";
                OnPropertyChanged("Clientes");
            }
        }

        public void ExecuteClear(object obj)
        {
            _cliente.RutCliente = "";
            _cliente.RazonSocial = "";
            _cliente.NombreContacto = "";
            _cliente.MailContacto = "";
            _cliente.Direccion = "";
            _cliente.Telefono = "";
            _cliente.ActividadEmpresaId = 0;
            _cliente.TipoEmpresaId = 0;
            _cliente.ActividadEmpresaId = 0;
            _cliente.TipoEmpresaId = 0;
            OnPropertyChanged("RutCliente");
            OnPropertyChanged("RazonSocial");
            OnPropertyChanged("NombreContacto");
            OnPropertyChanged("MailContacto");
            OnPropertyChanged("Direccion");
            OnPropertyChanged("Telefono");
            OnPropertyChanged("SelectedIndexActivity");
            OnPropertyChanged("SelectedIndexType");
            OnPropertyChanged("Actividades");
            OnPropertyChanged("Tipos");
        }

        private bool ValidarCampos()
        {
            if (_cliente.RutCliente == "" ||
            _cliente.RazonSocial == "" ||
            _cliente.NombreContacto == "" ||
            _cliente.MailContacto == "" ||
            _cliente.Direccion == "" ||
            _cliente.Telefono == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ReadRut(Object obj)
        {
            List<Cliente> client = new List<Cliente>();
            client = _cliente.GetClients();
            Cliente cliente = new Cliente() { RutCliente = _cliente.RutCliente };
            if (cliente.Read())
            {
                List<Cliente> _clientesrut = new List<Cliente>();
                _clientesrut = cliente.GetClients();
                List<Cliente> listacliente = new List<Cliente>();
                for (int i = 0; i < _clientesrut.Count; i++)
                {
                    if (_cliente.RutCliente == _clientesrut[i].RutCliente)
                    {
                        listacliente.Add(_clientesrut[i]);
                    }
                }
                client = listacliente;
                OnPropertyChanged("Clientes");
                Alert = "Rut Filtrado Satisfactoriamente :)";
            }
            else
            {
                Alert = "No se Pudo Encontrar al Cliente :(";
            }
        }

        public void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
            