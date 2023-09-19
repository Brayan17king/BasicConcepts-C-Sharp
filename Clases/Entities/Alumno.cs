using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clases.Entities
{
    public class Alumno
    {
        private string idAlumno;
        private string nombre;
        private string email;
        private int edad;

        
        public string IdAlumno { get => idAlumno; set => idAlumno = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public int Edad { get => edad; set => edad = value; }
        public Alumno(string _nombreAlumno)
        {
            this.IdAlumno = Guid.NewGuid().ToString();
            this.IdAlumno = _nombreAlumno;
        }


        //public Alumno () => idAlumno = Guid.NewGuid().ToString();

        /*En resumen, el código define la clase Alumno con propiedades para almacenar información
        sobre un estudiante y un constructor que genera un identificador único para cada instancia de
        la clase Alumno.*/

    }

}