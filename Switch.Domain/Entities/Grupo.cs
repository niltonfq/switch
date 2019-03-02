using System;
using System.Collections.Generic;

namespace Switch.Domain.Entities
{
    public class Grupo
    {
        public Grupo()
        {
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string UrlFoto { get; set; }
        public virtual ICollection<Postagem> Postagems { get; set; }
        public virtual ICollection<UsuarioGrupo> UsuarioGrupos { get; set; }
    }
}
