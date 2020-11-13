using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        Peliculas ObtenerDatosPeliculas(Peliculas pelicula);

        [OperationContract]
        Peliculas BuscaPeliculas(string nomPelicula);

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        Alumno BuscarAlumno(int numCont);

        [OperationContract]
        Operacion elevarCuadrado(int numero);

        [OperationContract]
        string ComparaNum(int valor);
    }

    // TODO: agregue aquí sus operaciones de servicio



    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    public class Alumno
    {
        [DataMember]

        public string nombre { get; set; }
        [DataMember]
        public string apellido { get; set; }
        [DataMember]
        public string carrera { get; set; }
        [DataMember]
        public int semestre { get; set; }
        [DataMember]
        public char grupo { get; set; }
        internal string Error;

    }

    [DataContract]
    public class Operacion
    {
        [DataMember]
        public int num1 { get; set; }
    }

    [DataContract]
    public class Peliculas
    {
        string nombre;
        string director;
        float duracion;
        int calificacion;
        string desconocida;

        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        [DataMember]
        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        [DataMember]
        public float Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }
        [DataMember]
        public int Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }

        [DataMember]
        public string Error
        {
            get { return desconocida; }
            set { desconocida = value; }
        }

    }

   
   
}





