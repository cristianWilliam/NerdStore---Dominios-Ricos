using NerdStore.Core.DomainObjects;
using System.Collections.Generic;

namespace NerdStore.Catalogo.Domain
{
    public class Categoria : Entity
    {
        public string Nome { get; private set; }        
        public int Codigo { get; private set; }

        // EF Relation
        public ICollection<Produto> Produtos { get; private set; }
        protected Categoria() { }

        public Categoria(string nome, int codigo)
        {
            Nome = nome;
            Codigo = codigo;
            Validar();
        }

        public override string ToString()
        {
            return $"{Nome} - {Codigo}";
        }

        public void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "O campo Nome da categoria nao pode ser vazio");
            Validacoes.ValidarSeIgual(Codigo, 0, "O campo Codigo da categoria nao pode ser igual a zero");
        }

    }
}
