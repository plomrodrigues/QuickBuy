using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }

        private List<string> MensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMensagensValidacao()
        {
            _mensagensValidacao.Clear();
        }

        protected void AdicionarCritica(string mensage)
        {
            _mensagensValidacao.Add(mensage);
        }

        public abstract void Validade();

        protected bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        }
    }
}
