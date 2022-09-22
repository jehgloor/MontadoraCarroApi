using System.ComponentModel.DataAnnotations;

namespace MontadoraCarroApi.model
{
    public class Carro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O modelo do Carro é obrigatório")]
        public string Modelo { get; set; }

       [Required(ErrorMessage = "O Ano do Carro é obrigatório")]

        public int AnoCarro { get; set; }

        public string Motor { get; set; }

        public string Cor { get; set; }

        public bool VidroEletrico { get; set; }

        public int QtdPortas { get; set; }

        public Carro() { }

        public Carro(int id, string modelo, int anoCarro, string motor, string cor, bool vidroEletrico, int qtdPortas)
        {
            this.Id = id;
            this.Modelo = modelo;
            this.AnoCarro = anoCarro;
            this.Motor = motor;
            this.Cor = cor;
            this.VidroEletrico = vidroEletrico; ;
            this.QtdPortas = qtdPortas;
        }

    }
}
