using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {

        public Peliculas ObtenerDatosPeliculas(Peliculas pelicula)
        {
            return pelicula;
        }
        public Peliculas BuscaPeliculas(string nomPelicula)
        {
            Peliculas pelicula1 = new Peliculas();
            pelicula1.Nombre = "Petter Rabit";
            pelicula1.Director = "Will Gluck";
            pelicula1.Duracion = 2;
            pelicula1.Calificacion = 5;
    
            Peliculas pelicula2 = new Peliculas();
            pelicula2.Nombre = "La Bella y la Bestia";
            pelicula2.Director = "Bill Condon";
            pelicula2.Duracion = 3;
            pelicula2.Calificacion = 4;

            Peliculas pelicula3 = new Peliculas();
            pelicula3.Nombre = "Avengers";
            pelicula3.Director = "Joe y Anthony Russo";
            pelicula3.Duracion = 3;
            pelicula3.Calificacion = 5;

            Peliculas noEncontrada = new Peliculas();
            noEncontrada.Error = "Pelicula No Encontrada";

            if (nomPelicula == "Petter Rabit")
            {
                return pelicula1;
            }
            else
                 if (nomPelicula == "Avengers")
            {
                return pelicula3;
            }
            else
                 if (nomPelicula == "La Bella y la Bestia")
            {
                return pelicula2;
            }
            else
            {
                return noEncontrada;
            }           
        }


        public string ComparaNum(int valor)
        {
            if (valor > 100)
            {
                return string.Format("El numero ingresado: " + valor +"es mayor a 100");
            }
            else
                if (valor < 100)
            {
                return string.Format("El numero ingresado: " +valor +"es menor a 100");

            }
            else
            {
                return string.Format("El numero ingresado: "+ valor +"es igual a 100");
            }
        }
        public Operacion elevarCuadrado(int numero)
        {
            return new Operacion() { num1=numero*numero} ;
        }

        public Alumno BuscarAlumno(int numCont)
        {
            if (numCont == 17030086)
            {
                return new Alumno() { nombre = "Gabriela", apellido = "Gramillo", carrera = "Informática", semestre=7, grupo = 'U' };
            }
            else if (numCont == 17030084)
            {
                return new Alumno() { nombre = "Karla", apellido = "García", carrera = "Informática", semestre=7, grupo = 'U' };

            }
            else if (numCont == 17030083)
            {
                return new Alumno() { nombre = "Jaqueline", apellido = "Fernandez", carrera = "Informática", semestre=7, grupo = 'U' };

            }
            else
            {
                return new Alumno { Error = "El numero no corresponde a ningun alumno registrado" };
            }

        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
