using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome  { get; set; }
        public string SobreNome { get; set; }

        /// <summary>
        /// Um usuário pode ter nenhum ou muitos pedidos
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validade()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Crítica - E-mail é obrigatório");

            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Crítica - Senha é obrigatório");

            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Crítica - Nome é obrigatório");

            if (string.IsNullOrEmpty(SobreNome))
                AdicionarCritica("Crítica - Sobrenome é obrigatório");
        }
    }
}
