using Desafio.Domain;
using Desafio.Models;

namespace Desafio.Testes.Domain
{
    public class PessoaResolverTestes
    {
        [Fact]
        public void Resolve_FiltrarPessoasMais30Anos()
        {
            var resolver = new PessoaResolver();
            var pessoas = new List<Pessoa>
            {
                new Pessoa { Nome = "Amanda", Idade = 25, Email = "amanda@beeviral.com" },
                new Pessoa { Nome = "Ricardo", Idade = 35, Email = "ricardo@beeviral.com" },
                new Pessoa { Nome = "André", Idade = 40, Email = "andre@beeviral.com" },
                new Pessoa { Nome = "Marco", Idade = 28, Email = "marco@beeviral.com" }
            };

            List<Pessoa> resultado = resolver.Resolve(pessoas);

            Assert.Equal(2, resultado.Count);
            Assert.Contains(resultado, pessoa => pessoa.Nome == "André");
            Assert.Contains(resultado, pessoa => pessoa.Nome == "Ricardo");
        }

        [Fact]
        public void Resolve_SemPessoasComMais30Anos()
        {
            var resolver = new PessoaResolver();
            var pessoas = new List<Pessoa>
            {
                new Pessoa { Nome = "Amanda", Idade = 25, Email = "amanda@beeviral.com" },
                new Pessoa { Nome = "Marco", Idade = 28, Email = "marco@beeviral.com" }
            };

            List<Pessoa> resultado = resolver.Resolve(pessoas);

            Assert.Empty(resultado);
        }

        [Fact]
        public void Resolve_ListaVazia()
        {
            var resolver = new PessoaResolver();
            var pessoas = new List<Pessoa>();

            List<Pessoa> resultado = resolver.Resolve(pessoas);

            Assert.Empty(resultado);
        }

    }
}
