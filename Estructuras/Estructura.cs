

namespace Estructuras
{
    public struct Empleado
    {
        //En las estructuras las variables son llamadas campos
        //Los campos no toman valores por default
        public string nombre;
        public byte edad;
        public byte antiguedad;
        public Direccion direccion;
        public Empleado(string nombre, byte edad, byte antiguedad, Direccion direccion )
        {
            this.nombre = nombre;
            this.edad = edad;
            this.antiguedad = antiguedad;
            this.direccion.codigoPostal = direccion.codigoPostal;
            this.direccion.calle = direccion.calle;
        }
    }

    public struct Direccion
    {
        public string codigoPostal;
        public string calle;        
    }
}
