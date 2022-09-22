using System.ComponentModel.DataAnnotations;

namespace MontadoraCarroApi.model
{
    public class Montadora
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }

        public Montadora(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public Montadora()
        {

        }



    }
}
