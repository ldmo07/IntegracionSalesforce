namespace Modelo.Integracion2
{
    public partial class ModeloIntegracion2
    {
        public Programas Programas { get; set; }
        public Operacion Operacion { get; set; }
    }
    public partial class Operacion
    {
        public string tipo { get; set; }
    }
    public partial class Programas
    {
        public string codigoCortoPrograma { get; set; }
        public string descripcionPrograma { get; set; }
        public string codigoLargoPrograma { get; set; }
        public string nivelAcademico { get; set; }
        public string codigoRectoria { get; set; }
        public string codigoSede { get; set; }
        public long snies { get; set; }
        public string fechaInicioRegistroCalificado { get; set; }
        public string fechaVencimientoRegistroCalificado { get; set; }
        public long numeroResolucion { get; set; }
        public string codigoModalidad { get; set; }
        public string descripcionModalidad { get; set; }
        public long codigoFacultad { get; set; }
        public string descripcionfacultad { get; set; }
        public long cupo { get; set; }
        public long codigoStarric { get; set; }
    }
}
