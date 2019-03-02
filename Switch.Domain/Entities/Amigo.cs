using System;
namespace Switch.Domain.Entities
{
    public class Amigo
    {
        public Amigo()
        {
        }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int UsuarioAmigoId { get; set; }
        public virtual Usuario UsuarioAmigo { get; set; }
    }
}
