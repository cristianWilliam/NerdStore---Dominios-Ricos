using NerdStore.Core.DomainObjects;

namespace NerdStore.Catalogo.Domain
{
    public class Dimensoes
    {
        public decimal Altura { get; private set; }
        public decimal Largura { get; private set; }
        public decimal Profundidade { get; private set; }

        public Dimensoes(decimal altura, decimal largura, decimal profundidade)
        {
            Validacoes.ValidarSeMenorQue(altura, 1, "O Campo altura deve ser obrigatorio");
            Validacoes.ValidarSeMenorQue (largura, 1, "O Campo largura deve ser obrigatorio");
            Validacoes.ValidarSeMenorQue(profundidade, 1, "O Campo profundidade deve ser obrigatorio");

            Altura = altura;
            Largura = largura;
            Profundidade = profundidade;
        }

        public string DescricaoFormatada()
        {
            return $"LxAxP: {Largura} x {Altura} x {Profundidade}";
        }

        public override string ToString()
        {
            return this.DescricaoFormatada();
        }

    }
}
