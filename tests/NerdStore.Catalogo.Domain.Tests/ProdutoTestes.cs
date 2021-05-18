using NerdStore.Core.DomainObjects;
using NerdStore.Catalogo.Domain;
using System;
using Xunit;

namespace NerdStore.Catalogo.Domain.Tests
{
    public class ProdutoTestes
    {
        [Fact]
        public void Produto_Validar_ValidacoesDevemRetornarExceptions()
        {
            var ex = Assert.Throws<DomainException>(() =>
                new Produto(string.Empty, "Descricao", false, 100, Guid.NewGuid(), DateTime.Now, "imagem", new Dimensoes(2, 2, 2))
                );

            Assert.Equal("O campo nome do produto não pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Produto("Nome", string.Empty, false, 100, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensoes(2, 2, 2))
            );

            Assert.Equal("O campo Descricao do produto não pode estar vazio", ex.Message); 
        }
    }
}
