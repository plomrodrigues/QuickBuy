namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validade()
        {
            if (ProdutoId == 0)
                AdicionarCritica("Crítica - Nenhum produto informado");

            if (Quantidade <= 0)
                AdicionarCritica("Crítica - A quantidade deve ser maior que zero");
        }
    }
}
