using System;
namespace Switch.Domain.Entities
{
    public class Comentario
    {
        public Comentario()
        {
            DataPublicacao = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Texto { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; private set; }

        public void SetUsuario(Usuario usuario)
        {
            if (usuario != null)
            {
                Usuario = usuario;
            }
        }
    }
}
