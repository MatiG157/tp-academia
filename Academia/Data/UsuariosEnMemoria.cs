using Domain.Model;

namespace Data
{
    public class UsuariosEnMemoria
    {
        public static List<Usuario> Usuarios;

        static UsuariosEnMemoria()
        {
            Usuarios = new List<Usuario>
                {
                    new Usuario(1, "jperez", "clave123", true, "Juan", "Pérez", "juan.perez@email.com", false, 101),
                    new Usuario(2, "mgomez", "maria456", true, "María", "Gómez", "maria.gomez@email.com", true, 102),
                    new Usuario(3, "clopez", "carlos789", false, "Carlos", "López", "carlos.lopez@email.com", false, 103),
                    new Usuario(4, "amartinez", "ana321", true, "Ana", "Martínez", "ana.martinez@email.com", true, 104),
                    new Usuario(5, "lfernandez", "lucia654", true, "Lucía", "Fernández", "lucia.fernandez@email.com", false, 105),
                    new Usuario(6, "dramirez", "diego987", false, "Diego", "Ramírez", "diego.ramirez@email.com", true, 106)
                };

        }

    }
}
