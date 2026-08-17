using System.ComponentModel.DataAnnotations;

namespace DroneCrud.Models
{
    public class Drone
    {
        [Key]
        public int IdDrone { get; set; }
        public string Modelo { get; set; }
        public decimal Preco { get; set; }
        public int Helice { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
