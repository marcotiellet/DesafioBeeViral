using Desafio.Models;

namespace Desafio.Domain
{
    public class PessoaResolver
    {
        public List<Pessoa> Resolve(List<Pessoa> pessoas)
        {
            return pessoas.FindAll(pessoa => pessoa.Idade > 30).ToList();
        }
    }
}
