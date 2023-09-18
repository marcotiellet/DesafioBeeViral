using Desafio.Domain;

namespace Desafio.Testes.Domain
{
    public class FatorialResolverTestes
    {
        [Fact]
        public void Resolve_ComNumeroPositivo()
        {
            var resolver = new FatorialResolver();
            int numero = 5;

            string result = resolver.Resolve(numero);

            Assert.Equal($"O fatorial de {numero} é 120.", result);
        }

        [Fact]
        public void Resolve_ComZero()
        {
            var resolver = new FatorialResolver();
            int numero = 0;

            string result = resolver.Resolve(numero);

            Assert.Equal($"O fatorial de {numero} é 1.", result);
        }

        [Fact]
        public void Resolve_ComNumeroNegativo()
        {
            var resolver = new FatorialResolver();
            int numero = -1;

            string result = resolver.Resolve(numero);

            Assert.Equal("O número deve ser não negativo.", result);
        }
    }
}
