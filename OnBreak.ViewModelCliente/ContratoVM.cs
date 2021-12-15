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
    public class AmiContratoVM : INotifyPropertyChanged
    {
        private Contrato _contract;
        private Cliente _cliente;
        private ModalidadServicio _moda;
        private TipoEvento _tipoevento;
        private int _selectedrut;
        private int _selectedIndexeven;
        private int _selectedIndexContrato;
        private string _alert;
        private bool _rut = false;
        private bool _evento = false;
        private bool _contra = false;
        private bool _modas = false;
        public event PropertyChangedEventHandler PropertyChanged;

        public double ValorModalidad()
        {
            double recargopersonal = 0;
            List<ModalidadServicio> _services = new List<ModalidadServicio>();
            ModalidadServicio service = new ModalidadServicio();
            _services = service.GetModalityService();
            foreach (ModalidadServicio modaserv in service.GetModalityService())
            {
                _services.Add(modaserv);
            }

            for (int i = 0; i < _services.Count; i++)
            {
                if (Modalidad == _services[i].IdModalidad)
                {
                    recargopersonal = _services[i].ValorBase;

                }
            }
            return recargopersonal * 1000;
        }

        public double Valormoda()
        {
            double total = 0;
            if (_contract.IdModalidad == "CB001")
            {
                total = 81000;
            }

            if (_contract.IdModalidad == "CB002")
            {
                total = 216000;
            }
            if (_contract.IdModalidad == "CB003")
            {
                total = 324000;
            }
            if (_contract.IdModalidad == "CE001")
            {
                total = 675000;
            }
            if (_contract.IdModalidad == "CE002")
            {
                total = 945000;
            }
            if (_contract.IdModalidad == "CO001")
            {
                total = 162000;
            }
            if (_contract.IdModalidad == "CO002")
            {
                total = 270000;

            }
            return total;
        }

        public bool chkrut
        {
            get { return _rut; }
            set { _rut = value; }
        }

        public bool chkevento
        {
            get { return _evento; }
            set { _evento = value; }
        }

        public bool chknumcontra
        {
            get { return _contra; }
            set { _contra = value; }
        }

        public bool chkmodalidad
        {
            get { return _modas; }
            set { _modas = value; }
        }

        public List<Contrato> Datagrids()
        {
            List<Contrato> contra = new List<Contrato>();

            if (chkrut == false && chkevento == false && chknumcontra == false && chkmodalidad == false)
            {
                contra = _contract.GetContracts();
            }
            if (chkrut == false && chkevento == false && chknumcontra == true && chkmodalidad == false)
            {
                Contrato contrato = new Contrato() { Numero = _contract.Numero };
                if (contrato.Read())
                {
                    List<Contrato> _contratonumero = new List<Contrato>();
                    _contratonumero = contrato.GetContracts();
                    List<Contrato> listacontrato = new List<Contrato>();
                    for (int i = 0; i < _contratonumero.Count; i++)
                    {
                        if (_contract.Numero == _contratonumero[i].Numero)
                        {
                            listacontrato.Add(_contratonumero[i]);
                        }
                    }
                    contra = listacontrato;
                }
            }
            if (chkrut == true && chkevento == false && chknumcontra == false && chkmodalidad == false)
            {
                Contrato contrato = new Contrato() { RutCliente = _contract.RutCliente };
                if (contrato.Read2())
                {
                    List<Contrato> _rutcliente = new List<Contrato>();
                    _rutcliente = contrato.GetContracts();
                    List<Contrato> listacontrato = new List<Contrato>();
                    for (int i = 0; i < _rutcliente.Count; i++)
                    {
                        if (_contract.RutCliente == _rutcliente[i].RutCliente)
                        {
                            listacontrato.Add(_rutcliente[i]);
                        }
                    }
                    contra = listacontrato;

                }
            }
            if (chkrut == false && chkevento == true && chknumcontra == false && chkmodalidad == false)
            {
                Contrato contrato = new Contrato() { IdTipoEvento = (int)_contract.IdTipoEvento };
                if (contrato.Read3())
                {
                    List<Contrato> _tipoevento = new List<Contrato>();
                    _tipoevento = contrato.GetContractsTypeEvent((int)_contract.IdTipoEvento);
                    contra = _tipoevento;
                }
            }
            if (chkrut == false && chkevento == false && chknumcontra == false && chkmodalidad == true)
            {
                Contrato contrato = new Contrato() { IdModalidad = _contract.IdModalidad };
                if (contrato.Read4())
                {
                    Contrato contr = new Contrato() { IdModalidad = _contract.IdModalidad };
                    if (contrato.Read4())
                    {
                        List<Contrato> _contratonumero = new List<Contrato>();
                        _contratonumero = contrato.GetContracts();
                        List<Contrato> listacontrato = new List<Contrato>();
                        for (int i = 0; i < _contratonumero.Count; i++)
                        {
                            if (_contract.IdModalidad == _contratonumero[i].IdModalidad)
                            {
                                listacontrato.Add(_contratonumero[i]);
                            }
                            contra = listacontrato;
                        }
                    }
                }
            }
            return contra;
        }

        public int SelectedIndexEven
        {
            get
            {
                try
                {
                    TipoEvento eventoempresa = Even.First(c => c.IdTipoEvento == _contract.IdTipoEvento);
                    for (int i = 0; i < Even.Count; i++)
                    {
                        if (Even[i].IdTipoEvento == eventoempresa.IdTipoEvento)
                        {
                            return i;
                            OnPropertyChanged("Newmoda");
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
                _selectedIndexeven = value;
                if (value != -1)
                {
                    TipoEvento eventoempresa = Even[value];
                    _contract.IdTipoEvento = eventoempresa.IdTipoEvento; OnPropertyChanged("Newmoda");
                }
            }
        }

        public List<string> clientrt
        {
            get
            {
                List<Cliente> cli = new List<Cliente>();
                List<string> rut = new List<string>();
                Cliente clis = new Cliente();
                cli = clis.GetClients();
                foreach (Cliente clist in cli)
                {
                    rut.Add(clist.RutCliente);
                }
                return rut;
            }
        }

        public List<TipoEvento> Even
        {
            get
            {
                TipoEvento all = new TipoEvento() { Descripcion = "Seleccione" };
                List<TipoEvento> evet = new List<TipoEvento>();
                evet.Add(all);
                foreach (TipoEvento activity in _tipoevento.GetTipoEventos())
                {
                    evet.Add(activity);
                }
                return evet;
            }
        }

        public List<Contrato> Contralist
        {
            get { return Datagrids(); }

        }

        public List<string> Moda
        {
            get
            {
                List<ModalidadServicio> modalityservice = new List<ModalidadServicio>();
                List<string> nombreservicio = new List<string>();
                ModalidadServicio modalidadservicio = new ModalidadServicio();
                modalityservice = modalidadservicio.GetModalityService();
                foreach (ModalidadServicio servis in modalityservice)
                {
                    nombreservicio.Add(servis.Nombre);
                }
                return nombreservicio;
            }
        }

        public List<Contrato> contracts
        {
            get { return _contract.GetContracts(); }

        }

        public List<Cliente> client
        {
            get { return _cliente.GetClients(); }
        }

        public List<string> Newmoda
        {
            get
            {
                List<string> nombreservicio = new List<string>();
                if (_contract.IdTipoEvento == 10)
                {
                    nombreservicio.Add("Light Break");
                    nombreservicio.Add("Journal Break");
                    nombreservicio.Add("Day Break");
                    nombreservicio.Remove("Quick Cocktail");
                    nombreservicio.Remove("Ambient Cocktail");
                    nombreservicio.Remove("Ejecutiva");
                    nombreservicio.Remove("Celebración");
                }
                if (_contract.IdTipoEvento == 20)
                {
                    nombreservicio.Remove("Light Break");
                    nombreservicio.Remove("Journal Break");
                    nombreservicio.Remove("Day Break");
                    nombreservicio.Add("Quick Cocktail");
                    nombreservicio.Add("Ambient Cocktail");
                    nombreservicio.Remove("Ejecutiva");
                    nombreservicio.Remove("Celebración");
                }
                if (_contract.IdTipoEvento == 30)
                {
                    nombreservicio.Remove("Light Break");
                    nombreservicio.Remove("Journal Break");
                    nombreservicio.Remove("Day Break");
                    nombreservicio.Remove("Quick Cocktail");
                    nombreservicio.Remove("Ambient Cocktail");
                    nombreservicio.Add("Ejecutiva");
                    nombreservicio.Add("Celebración");
                }
                return nombreservicio;
            }
        }

        public String EventoM
        {
            get { return _contract.IdTipoEvento.ToString(); }
            set
            {
                if (value == "CoffeBreak")
                {
                    value = "10";
                }
                if (value == "Cocktail")
                {
                    value = "20";
                }
                if (value == "Cenas")
                {
                    value = "30";
                }
                _contract.IdTipoEvento = int.Parse(value);
            }
        }

        private string NumeroContrato()
        {
            string id = DateTime.Now.ToString("yyyyMMddhhmm");
            return id;
        }

        public int TerSegundo
        {
            get { return _contract.FechaHoraTermino.Minute; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value > 59)
                {
                    value = 59;
                }
                _contract.FechaHoraTermino = new DateTime(_contract.FechaHoraTermino.Year, _contract.FechaHoraTermino.Month, _contract.FechaHoraTermino.Day, _contract.FechaHoraTermino.Hour, _contract.FechaHoraTermino.Minute, value);
            }
        }

        public int IniSegundo
        {
            get { return _contract.FechaHoraInicio.Second; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value > 59)
                {
                    value = 59;
                }
                _contract.FechaHoraInicio = new DateTime(_contract.FechaHoraInicio.Year, _contract.FechaHoraInicio.Month, _contract.FechaHoraInicio.Day, _contract.FechaHoraInicio.Hour, _contract.FechaHoraInicio.Minute, value);
            }
        }

        public List<Contrato> Contras
        {
            get
            {
                return Datagrid();
            }
        }

        public DateTime Creacion
        {
            get { return _contract.Creacion; }
            set { _contract.Creacion = value; }
        }

        public DateTime Termino
        {
            get { return _contract.Termino; }
            set { _contract.Termino = value; }
        }

        public string Alert
        {
            get { return _alert; }
            set { _alert = value; OnPropertyChanged("Alert"); }
        }

        public string NumContra
        {
            get { return _contract.Numero; }
            set { _contract.Numero = value; }
        }

        public bool Realizado
        {
            get { return _contract.Realizado; }
            set { _contract.Realizado = value; }
        }

        public int SelectedRut
        {
            get { return _selectedrut; }
            set
            {
                _selectedrut = value;
                if (value != -1)
                {
                    _cliente = client[value];
                    OnPropertyChanged("RutCliente");
                }
            }
        }

        public DateTime Terminofecha
        {
            get { return _contract.FechaHoraTermino; }
            set
            {
                _contract.FechaHoraTermino = new DateTime(value.Year, value.Month, value.Day, TerHour, Terminute, _contract.FechaHoraTermino.Second);
            }
        }

        public DateTime InicioFecha
        {
            get { return _contract.FechaHoraInicio; }
            set
            {
                _contract.FechaHoraInicio = new DateTime(value.Year, value.Month, value.Day, IniHour, Iniminute, _contract.FechaHoraInicio.Second);

            }
        }

        public int IniHour
        {
            get { return _contract.FechaHoraInicio.Hour; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value > 23)
                {
                    value = 23;
                }
                _contract.FechaHoraInicio = new DateTime(_contract.FechaHoraInicio.Year, _contract.FechaHoraInicio.Month, _contract.FechaHoraInicio.Day, value, _contract.FechaHoraInicio.Minute, _contract.FechaHoraInicio.Second);
            }
        }

        public int Iniminute
        {
            get { return _contract.FechaHoraInicio.Minute; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value > 59)
                {
                    value = 59;
                }
                _contract.FechaHoraInicio = new DateTime(_contract.FechaHoraInicio.Year, _contract.FechaHoraInicio.Month, _contract.FechaHoraInicio.Day, _contract.FechaHoraInicio.Hour, value, _contract.FechaHoraInicio.Second);
            }
        }

        public int Terminute
        {
            get { return _contract.FechaHoraTermino.Minute; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value > 59)
                {
                    value = 59;
                }
                _contract.FechaHoraTermino = new DateTime(_contract.FechaHoraTermino.Year, _contract.FechaHoraTermino.Month, _contract.FechaHoraTermino.Day, _contract.FechaHoraTermino.Hour, value, _contract.FechaHoraTermino.Second);

            }
        }

        public int TerHour
        {
            get { return _contract.FechaHoraTermino.Hour; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value > 23)
                {
                    value = 23;
                }
                _contract.FechaHoraTermino = new DateTime(_contract.FechaHoraTermino.Year, _contract.FechaHoraTermino.Month, _contract.FechaHoraTermino.Day, value, _contract.FechaHoraTermino.Minute, _contract.FechaHoraTermino.Second);
            }
        }

        public String RutCliente
        {
            get { return _cliente.RutCliente; }
            set { _cliente.RutCliente = value; }
        }

        public String Rut
        {
            get { return _contract.RutCliente; }
            set { _contract.RutCliente = value; }
        }

        public string Modalidad
        {
            get { return _contract.IdModalidad; }
            set
            {
                if (value == "Light Break")
                {
                    value = "CB001";
                }

                if (value == "Journal Break")
                {
                    value = "CB002";
                }

                if (value == "Day Break")
                {
                    value = "CB003";
                }

                if (value == "Ejecutiva")
                {
                    value = "CE001";
                }

                if (value == "Celebración")
                {
                    value = "CE002";
                }

                if (value == "Quick Cocktail")
                {
                    value = "CO001";
                }

                if (value == "Ambient Cocktail")
                {
                    value = "CO002";
                }
                _contract.IdModalidad = value;
            }
        }

        public int SelectedIndexContrato
        {
            get { return _selectedIndexContrato; }
            set
            {
                _selectedIndexContrato = value;
                if (value != -1)
                {
                    _contract = contracts[_selectedIndexContrato];
                    OnPropertyChanged("Rut");
                    OnPropertyChanged("NumContra");
                    OnPropertyChanged("Realizado");
                    OnPropertyChanged("Terminofecha");
                    OnPropertyChanged("InicioFecha");
                    OnPropertyChanged("Creacion");
                    OnPropertyChanged("Termino");
                    OnPropertyChanged("SelectedIndexEven");
                    OnPropertyChanged("Newmoda");
                    OnPropertyChanged("Observaciones");
                    OnPropertyChanged("Asistentes");
                    OnPropertyChanged("Valor");
                    OnPropertyChanged("PerAdicional");
                }
            }
        }

        public int Asistentes
        {
            get { return _contract.Asistentes; }
            set { _contract.Asistentes = value; }
        }

        public int PerAdicional
        {
            get { return _contract.PersonalAdicional; }
            set { _contract.PersonalAdicional = value; }
        }

        public string Observaciones
        {
            get { return _contract.Observaciones; }
            set { _contract.Observaciones = value; }
        }

        public double Valor
        {
            get { return _contract.ValorTotalContrato; }
            set
            {
                _contract.ValorTotalContrato = value;
            }
        }

        public List<Contrato> Datagrid()
        {
            List<Contrato> contra = new List<Contrato>();
            {
                Contrato contrato = new Contrato() { Numero = _contract.Numero };
                if (contrato.Read())
                {
                    List<Contrato> _contratonumero = new List<Contrato>();
                    _contratonumero = contrato.GetContracts();
                    List<Contrato> listacontrato = new List<Contrato>();
                    for (int i = 0; i < _contratonumero.Count; i++)
                    {
                        if (_contract.Numero == _contratonumero[i].Numero)
                        {
                            listacontrato.Add(_contratonumero[i]);
                        }
                    }
                    contra = listacontrato;
                }
            }
            return contra;
        }

        public Command AddCommand { get; set; }
        public Command CalCommand { get; set; }
        public Command Refreshcomand { get; set; }
        public Command Ischeckcommand { get; set; }
        public Command IniDate { get; set; }
        public Command Clear { get; set; }
        public Command chkrutco { get; set; }
        public Command chkeven { get; set; }
        public Command chkmoda { get; set; }
        public Command chknum { get; set; }
        public Command Buscar { get; set; }
        public Command Update { get; set; }
        public Command Delete { get; set; }
        public Command Eventus { get; set; }
        public Command Modalidatus { get; set; }
        public Command Rutus { get; set; }
        public Command Numcontratus { get; set; }
        public Command ReadNumConCommand { get; set; }
        public Command TerNumConCommand { get; set; }
        public Command Te { get; set; }
        public void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public AmiContratoVM()
        {
            _contract = new Contrato();
            _cliente = new Cliente();
            _moda = new ModalidadServicio();
            _tipoevento = new TipoEvento();
            AddCommand = new Command(ExecuteAdd, CanExecute);
            CalCommand = new Command(ExecuteCal, CanExecute);
            Ischeckcommand = new Command(Executecheck, CanExecute);
            IniDate = new Command(ExecuteDate, CanExecute);
            Clear = new Command(ExecuteClear, CanExecute);
            Update = new Command(ExecuteUpdate, CanExecute);
            Rutus = new Command(Executerut, CanExecute);
            Eventus = new Command(Executeevento, CanExecute);
            Numcontratus = new Command(Executnumcontra, CanExecute);
            Modalidatus = new Command(Executemodus, CanExecute);
            ReadNumConCommand = new Command(ReadNumCon, CanExecute);
            TerNumConCommand = new Command(TerminoContract, CanExecute);
        }

        public bool CanExecute(object f)
        {
            return true;
        }

        public void ExecuteAdd(object f)
        {
            bool test;
            
            if (_contract.FechaHoraInicio < DateTime.Now)
            {
                Alert = "La fecha/hora de inicio no puede ser menor a hoy :c";
            }
            else if (_contract.FechaHoraInicio > DateTime.Now.AddMonths(10))
            {
                Alert = "La fecha/hora de inicio no puede ser mayor a 10 meses :c";
            }
            else if (_contract.FechaHoraTermino.AddDays(2) < _contract.FechaHoraInicio)
            {
                Alert = "el evento no puede durar mas de 24 horas :c";
            }else if (_contract.Create())
            {
                Alert = "Contrato Ingresado Satisfactoriamente :)";
                OnPropertyChanged("contracts");
            }
            else
            {
                Alert = "Contrato no Ingresado :(";
            }
            OnPropertyChanged("contracts");
        }

        public void ExecuteCal(object f)
        {
            _contract.ValorTotalContrato = _contract.ValorAsitente() + _contract.ValorPersonal() + ValorModalidad() + Valormoda();
            OnPropertyChanged("Valor");
            OnPropertyChanged("InicioFecha");
        }

        public void Executecheck(object f)
        {
            if (_contract.Realizado == false)
            {
                _contract.Realizado = true;
            }
            else
            {
                _contract.Realizado = false;
            }
        }

        public void ExecuteDate(object f)
        {
            string date, terdate;

            date = "" + InicioFecha;
            terdate = "" + Terminofecha;
            _contract.FechaHoraInicio = DateTime.Parse(date);
            _contract.FechaHoraTermino = DateTime.Parse(terdate);
            _contract.Numero = NumeroContrato();
            _contract.Creacion = DateTime.Parse(date);
            _contract.Termino = DateTime.Parse(terdate);
            OnPropertyChanged("NumContra");
        }

        public void ExecuteClear(object f)
        {
            _contract.Numero = "";
            _contract.Creacion = DateTime.Now;
            _contract.Termino = DateTime.Now;
            _contract.RutCliente = "";
            _contract.IdModalidad = "";
            _contract.IdTipoEvento = 0;
            _contract.FechaHoraInicio = DateTime.Now;
            _contract.FechaHoraTermino = DateTime.Now;
            _contract.Asistentes = 0;
            _contract.PersonalAdicional = 0;
            _contract.Realizado = false;
            _contract.ValorTotalContrato = 0;
            Observaciones = "";
            _contract.IdModalidad = "";
            _contract.IdTipoEvento = 0;
            OnPropertyChanged("Rut");
            OnPropertyChanged("NumContra");
            OnPropertyChanged("Realizado");
            OnPropertyChanged("Terminofecha");
            OnPropertyChanged("InicioFecha");
            OnPropertyChanged("Creacion");
            OnPropertyChanged("Termino");
            OnPropertyChanged("Even");
            OnPropertyChanged("Modalidad");
            OnPropertyChanged("Observaciones");
            OnPropertyChanged("Asistentes");
            OnPropertyChanged("Valor");
            OnPropertyChanged("PerAdicional");
            OnPropertyChanged("Moda");
            OnPropertyChanged("Even");
        }

        public void ExecuteBuscar(object f)
        {
            OnPropertyChanged("Contras");
        }

        public void ExecuteUpdate(object f)
        {
            if (_contract.FechaHoraTermino < DateTime.Now)
            {
                Alert = "El Contrato ya ha terminado y no puede ser editado :(";
            }else if (_contract.Update())
            {
                Alert = "Contrato Actualizado Satisfactoriamente :)";
                OnPropertyChanged("contracts");
            }
            else
            {
                Alert = "Contrato no Actualizado :(";
            }
        }

        public void Executeevento(object f)
        {
            
            _rut = false;
            _evento = true;
            _contra = false;
            _modas = false;
            OnPropertyChanged("Contralist");
            Alert = "Evento Filtrado Satisfactoriamente :)";
        }

        public void Executnumcontra(object f)
        {
            _rut = false;
            _evento = false;
            _contra = true;
            _modas = false;
            OnPropertyChanged("Contralist");
            Alert = "Numero de Contrato Filtrado Satisfactoriamente :)";
        }

        public void Executerut(object f)
        {
            _rut = true;
            _evento = false;
            _contra = false;
            _modas = false;
            OnPropertyChanged("Contralist");
            Alert = "Rut Filtrado Satisfactoriamente :)";
        }

        public void Executemodus(object f)
        {
            _rut = false;
            _evento = false;
            _contra = false;
            _modas = true;
            OnPropertyChanged("Contralist");
            Alert = "Modalidad Filtrada Satisfactoriamente :)";
        }

        public void ReadNumCon(Object obj)
        {
            if (_contract.Read())
            {
                Alert = "Contrato Encontrado Satisfactoriamente :)";
                OnPropertyChanged("Rut");
                OnPropertyChanged("NumContra");
                OnPropertyChanged("Realizado");
                OnPropertyChanged("Terminofecha");
                OnPropertyChanged("InicioFecha");
                OnPropertyChanged("Creacion");
                OnPropertyChanged("Termino");
                OnPropertyChanged("SelectedIndexEven");
                OnPropertyChanged("Newmoda");
                OnPropertyChanged("Observaciones");
                OnPropertyChanged("Asistentes");
                OnPropertyChanged("Valor");
                OnPropertyChanged("PerAdicional");
            }
            else
            {
                Alert = "No se Pudo Encontrar al Cliente :(";
            }

        }

        public void TerminoContract(Object obj)
        {
            DateTime Term = DateTime.Now;
            if (_contract.FechaHoraInicio < Term)
            {
                _contract.Realizado = true;
                _contract.FechaHoraTermino = Term;
                Alert = "¿Desea Terminar el Contrato Definitivamente?";
                if (_contract.Update())
                {
                    Alert = "Contrato Terminado :)";
                }
                else { Alert = "El contrato no se pudo terminar :("; }
                
            }
            else if (_contract.FechaHoraInicio > Term)
            {
                _contract.Realizado = false;
                _contract.FechaHoraTermino = Term;
                Alert = "¿Desea Terminar el Contrato Definitivamente?";
                if (_contract.Update())
                {
                    Alert = "Contrato Terminado :)";
                }
                else { Alert = "El contrato no se pudo terminar :("; }
            }

            

         
        }
    }
}