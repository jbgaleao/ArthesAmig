using System.ComponentModel.DataAnnotations;

namespace ArthesAmig.Domain.Enums
{
    public enum NivelDificuldade : int
    {
        [Display(Name = "Muito Fácil")]
        MuitoFacil = 0,

        [Display(Name = "Fácil")]
        Facil = 1,

        [Display(Name = "Médio")]
        Medio = 2,

        [Display(Name = "Difícil")]
        Dificil = 3,

        [Display(Name = "Muito Difícil")]
        MuitoDificil = 4

    }
}
