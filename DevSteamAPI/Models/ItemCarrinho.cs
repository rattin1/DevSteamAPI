using System.ComponentModel.DataAnnotations;

namespace DevSteamAPI.Models

{
    public class ItemCarrinho
    {
        public Guid ItemCarrinhoId { get; set; }
        public Guid CarrinhoId { get; set; }
        public Guid JogoId { get; set; }
        [Required(ErrorMessage = "O Campo é Obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "A quantidade deve ser maior que zero")]
        public int Quantidade { get; set; }
        [Required(ErrorMessage = "O Campo é Obrigatório")]
        [Range(0.01, 9999.99, ErrorMessage = "O valor deve ser maior que zero e menor que R$ 9.999,99")]
        public decimal Valor { get; set; }
        public decimal Total { get; set; }
    }
}
