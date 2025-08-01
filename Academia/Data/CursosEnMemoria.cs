using Domain.Model;

namespace Data
{
    public class CursosEnMemoria()
    {
        public static List<Curso> Cursos;

        static CursosEnMemoria()
        {
            Cursos = new List<Curso>
            {
                new Curso(1, 101, 201, 2022, 30),
                new Curso(2, 102, 202, 2023, 25),
                new Curso(3, 103, 203, 2024, 35),
                new Curso(4, 104, 204, 2023, 40),
                new Curso(5, 105, 205, 2022, 20),
                new Curso(6, 106, 206, 2024, 50)
            };


        }

    }
}