using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
    class AlumnosRepo
    {

        private AppDBContext _Contexto ;

        public AlumnosRepo()
        {

            _Contexto = new AppDBContext();
        }

        public void Agregar (Alumno alumno)
    {
        _Contexto.Alumnos.Add(alumno);
        _Contexto.SaveChanges();

    }

        public void Borrar(Alumno alumno)
        {
            _Contexto.Alumnos.Remove(alumno);
            _Contexto.SaveChanges();

        }
//select * front Alumno orden by nocontrol
        public List<Alumno> TraerTodo()
        {
            return _Contexto.Alumnos.OrderBy(x => x.NoControl).ToList();

        }
        //select * from alumno where Id = 3
        public Alumno TraerId( int id)
        {
            return _Contexto.Alumnos.FirstOrDefault(x => x.Id == id);
        }
    

    }
}
