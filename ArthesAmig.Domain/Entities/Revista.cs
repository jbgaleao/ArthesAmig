using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using ArthesAmig.Domain.Enums;

namespace ArthesAmig.Domain.Entities
{
    [Table("Revista")]
    public class Revista
    {
        public Revista()
        {
            ListaReceitas = new List<Receita>();
        }

        [Key]
        public int Id { get; set; }
        public string Tema { get; set; }
        public int NumEdicao { get; set; }
        public Mes MesEdicao { get; set; }
        public int AnoEdicao { get; set; }

        /*  Relationships   */
        public virtual List<Receita> ListaReceitas { get; }
    }
}
