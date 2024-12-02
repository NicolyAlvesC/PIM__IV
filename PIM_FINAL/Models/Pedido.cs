using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PIM_FINAL.Models
{
    [Table("Pedido")]
    public class Pedido
    {
        [Column("Id")]
        [Display(Name = "ID")]
        public int Id { get; set; }


        [Column("CNPJ")]
        [Display(Name = "CNPJ")]
        public string CNPJ { get; set; }



        [Column("Nome do Produto")]
        [Display(Name = "Nome do Produto")]
        public string NomeProduto { get; set; }
    }
}
