namespace Modelo.Integracion4
{
    public partial class ModeloIntegracion4
    {
        public CambioEstadoBanner CambioEstadoBanner { get; set; }
    }

    public partial class CambioEstadoBanner
    {
        public InformacionEstadoBanner InformacionEstadoBanner { get; set; }
    }

    public partial class InformacionEstadoBanner
    {
        public string idEstudiante { get; set; }
        public string status { get; set; }
        public string codigoCortoPrograma { get; set; }
        public string descripcionPrograma { get; set; }
        public string codigoSede { get; set; }
        public string descripcionSede { get; set; }
        public string codigoRectoria { get; set; }
        public string descripcionRectoria { get; set; }
        public string nivelAcademico { get; set; }
        public string codigoJornada { get; set; }
        public string descripcionJornada { get; set; }
        public string codigoMetodologia { get; set; }
        public string descripcionMetodologia { get; set; }
        public long periodoAcademico { get; set; }
        public string estadoSolicitud { get; set; }
        public string fechaCambioEstado { get; set; }
        public string numeroSolicitud { get; set; }
        public long preferenciaSolicitud { get; set; }
        public bool campoOrigen { get; set; }
        public string usuario { get; set; }
        public string fechaRecepcionCurricula { get; set; }
    }
}
