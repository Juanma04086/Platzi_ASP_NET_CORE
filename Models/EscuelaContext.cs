using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Platzi_ASP_NET_CORE.Models
{
    public class EscuelaContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Evaluación> Evaluaciones { get; set; }

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public EscuelaContext(DbContextOptions<EscuelaContext> options) : base(options)
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.

        {

        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var escuela = new Escuela();
            escuela.AñoDeCreación = 2005;
            escuela.Id = Guid.NewGuid().ToString();
            escuela.Nombre = " Platzi School";
            escuela.Ciudad = " Bogota";
            escuela.Pais = " Colombia";
            escuela.Dirección = " Avda siempre viva";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            modelBuilder.Entity<Escuela>().HasData(escuela);
            //Cargar Cursos de la Escuela capitulo 24 de platzi
            var cursos = CargarCursos(escuela);


            // Por cada curso vamos asignar asignaturas

            var asignaturas = CargarAsignaturas(cursos);

            // Por cada curso vamos a cargar alumnos
            var alumnos = CargarAlumnos(cursos);

            modelBuilder.Entity<Escuela>().HasData(escuela);
            modelBuilder.Entity<Curso>().HasData(cursos.ToArray());
            modelBuilder.Entity<Asignatura>().HasData(asignaturas.ToArray());
            modelBuilder.Entity<Alumno>().HasData(alumnos.ToArray());
        }
        private List<Alumno> CargarAlumnos(List<Curso>cursos)
        {
            var listaAlumnos = new List<Alumno>();
            Random rand = new Random();
            foreach(var curso in cursos)
            {
                int cantRandom = rand.Next(5,20);
                var tmplist = GenerarAlumnosAlAzar(curso, cantRandom);
                listaAlumnos.AddRange(tmplist);
            }
            return listaAlumnos;
        }

        private static List<Asignatura> CargarAsignaturas(List<Curso> cursos)
        {
            var listaCompleta = new List<Asignatura>();
            foreach (var curso in cursos)
            {
                var tmpList = new List<Asignatura>{
                    new Asignatura { Id = Guid.NewGuid().ToString(), CursoId = curso.Id, Nombre = "Matematicas" },
                    new Asignatura { Id = Guid.NewGuid().ToString(), CursoId = curso.Id, Nombre = "Educacion Fisica" },
                    new Asignatura { Id = Guid.NewGuid().ToString(), CursoId = curso.Id, Nombre = "Castellano" },
                    new Asignatura { Id = Guid.NewGuid().ToString(), CursoId = curso.Id, Nombre = "Ciencias Naturales" },
                    new Asignatura { Id = Guid.NewGuid().ToString(), CursoId = curso.Id, Nombre = "Programacion" },

                };
                listaCompleta.AddRange(tmpList);
                //curso.Asignaturas = tmpList;
            }
            return listaCompleta;
            

        }

        private static List<Curso> CargarCursos(Escuela escuela)
        {
            return new List<Curso>() {
                new Curso() {
                    Id = Guid.NewGuid().ToString(),
                    EscuelaId = escuela.Id,
                    Nombre = "101",
                    Jornada = TiposJornada.Mañana },
                new Curso() { Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre = "201", Jornada = TiposJornada.Mañana },
                new Curso() { Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre = "301", Jornada = TiposJornada.Mañana },
                new Curso() { Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre = "401", Jornada = TiposJornada.Tarde },
                new Curso() { Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre = "501", Jornada = TiposJornada.Tarde }

            };
        }  
        private List<Alumno> GenerarAlumnosAlAzar(Curso curso,  int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno
                               {
                                   CursoId = curso.Id,
                                   Nombre = $"{n1} {n2} {a1}",
                                   Id = Guid.NewGuid().ToString()
                               };
            return listaAlumnos.OrderBy((al) => al.Id).Take(cantidad).ToList();
        }
    
    }    
}
