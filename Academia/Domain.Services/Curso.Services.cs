using Domain.Model;
using Data;
using DTOs;

namespace Domain.Services
{
    public class CursoService
    {
        public CursoDTO Add(CursoDTO dto)
        {


            var id = GetNextId();
  

            Curso curso = new Curso (id, dto.IdMateria, dto.IdComision, dto.AnioCalendario, dto.Cupo);

            CursosEnMemoria.Cursos.Add(curso);

            dto.IdCurso = curso.IdCurso;

            return dto;
        }

        public bool Delete(int id)
        {
            Curso? cursoToDelete = CursosEnMemoria.Cursos.Find(x => x.IdCurso == id);

            if (cursoToDelete != null)
            {
                CursosEnMemoria.Cursos.Remove(cursoToDelete);

                return true;
            }
            else
            {
                return false;
            }
        }

        public CursoDTO Get(int id)
        {
            Curso? curso = CursosEnMemoria.Cursos.Find(x => x.IdCurso == id);

            if (curso == null)
                return null;

            return new CursoDTO
            {
                IdCurso = curso.IdCurso,
                IdMateria = curso.IdMateria,
                IdComision = curso.IdComision,
                AnioCalendario = curso.AnioCalendario,
                Cupo = curso.Cupo
            };
        }

        public IEnumerable<CursoDTO> GetAll()
        {
            return CursosEnMemoria.Cursos.Select(curso => new CursoDTO
            {
                IdCurso = curso.IdCurso,
                IdMateria = curso.IdMateria,
                IdComision = curso.IdComision,
                AnioCalendario = curso.AnioCalendario,
                Cupo = curso.Cupo
            }).ToList();
        }

        public bool Update(CursoEntradaDTO dto, int id)
        {
            Curso? cursoToUpdate = CursosEnMemoria.Cursos.Find(x => x.IdCurso == id);

            if (cursoToUpdate != null)
            {
    
                cursoToUpdate.IdMateria =  dto.IdMateria;
                cursoToUpdate.IdComision =  dto.IdComision;
                cursoToUpdate.AnioCalendario =  dto.AnioCalendario;
                cursoToUpdate.Cupo =  dto.Cupo;

                return true;
            }
            else
            {
                return false;
            }
        }
       
        private static int GetNextId()
        {
            int nextId;

            if (CursosEnMemoria.Cursos.Count > 0)
            {
                nextId = CursosEnMemoria.Cursos.Max(x => x.IdCurso) + 1;
            }
            else
            {
                nextId = 1;
            }

            return nextId;
        }
    }
}
