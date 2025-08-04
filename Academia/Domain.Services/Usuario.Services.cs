using Domain.Model;
using Data;
using DTOs;

namespace Domain.Services
{
    public class UsuarioService
    {
        public UsuarioDTO Add(UsuarioDTO dto)
        {

            var id = GetNextId();

            Usuario usuario = new Usuario(id, dto.NombreUsuario, dto.Clave, dto.Habilitado, dto.Nombre, dto.Apellido, dto.Email, dto.CambiaClave, dto.IdPersona);

            UsuariosEnMemoria.Usuarios.Add(usuario);

            dto.IdUsuario = usuario.IdUsuario;

            return dto;
        }

        public bool Delete(int id)
        {
            Usuario? usuarioToDelete = UsuariosEnMemoria.Usuarios.Find(x => x.IdUsuario == id);

            if (usuarioToDelete != null)
            {
                UsuariosEnMemoria.Usuarios.Remove(usuarioToDelete);

                return true;
            }
            else
            {
                return false;
            }
        }

        public UsuarioDTO Get(int id)
        {
            Usuario? usuario = UsuariosEnMemoria.Usuarios.Find(x => x.IdUsuario == id);

            if (usuario == null)
                return null;

            return new UsuarioDTO
            {
                IdUsuario = usuario.IdUsuario,
                NombreUsuario = usuario.NombreUsuario,
                Clave = usuario.Clave,
                Habilitado = usuario.Habilitado,
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                Email = usuario.Email,
                CambiaClave = usuario.CambiaClave,
                IdPersona = usuario.IdPersona
            };
        }

        public IEnumerable<UsuarioDTO> GetAll()
        {
            return UsuariosEnMemoria.Usuarios.Select(usuario => new UsuarioDTO
            {

                IdUsuario = usuario.IdUsuario,
                NombreUsuario = usuario.NombreUsuario,
                Clave = usuario.Clave,
                Habilitado = usuario.Habilitado,
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                Email = usuario.Email,
                CambiaClave = usuario.CambiaClave,
                IdPersona = usuario.IdPersona

            }).ToList();
        }

        public bool Update(UsuarioEntradaDTO dto, int id)
        {
            Usuario? usuarioToUpdate = UsuariosEnMemoria.Usuarios.Find(x => x.IdUsuario == id);

            if (usuarioToUpdate != null)
            {

                usuarioToUpdate.NombreUsuario = dto.NombreUsuario;
                usuarioToUpdate.Clave = dto.Clave;
                usuarioToUpdate.Habilitado = dto.Habilitado;
                usuarioToUpdate.Nombre = dto.Nombre;
                usuarioToUpdate.Apellido = dto.Apellido;
                usuarioToUpdate.Email = dto.Email;
                usuarioToUpdate.CambiaClave = dto.CambiaClave;
                usuarioToUpdate.IdPersona = dto.IdPersona;

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

            if (UsuariosEnMemoria.Usuarios.Count > 0)
            {
                nextId = UsuariosEnMemoria.Usuarios.Max(x => x.IdUsuario) + 1;
            }
            else
            {
                nextId = 1;
            }

            return nextId;




        }
    }
}
