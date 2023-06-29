using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using ArthesAmig.Domain.Enums;

namespace ArthesAmig.Domain.Entities
{
    [Table("Receita")]
    public class Receita
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Altura { get; set; }

        public NivelDificuldade Dificuldade { get; set; }



        /*  Relationships   */
        public int RevistaId { get; set; }
        public virtual Revista Revista { get; set; }
    }
}
