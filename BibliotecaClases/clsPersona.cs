namespace BibliotecaClases
{
    public class clsPersona
    {
        #region atributos
        private String nombre;
        private String apellidos;
        #endregion

        #region constructores
        #endregion

        public clsPersona()
        {
            nombre = "";
            apellidos = "";
        }
        public clsPersona(string nombre, string apellidos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
        }

        #region propiedades
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
       

        public String Direccion { get; set; }
        public string NombreCompleto
        {
            get { return $"El nombre completo es : {nombre} {apellidos}"; }
                
        }
        #endregion
        #region funciones y metodos
        #endregion
    }
}