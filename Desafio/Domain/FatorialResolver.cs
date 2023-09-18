using System.Numerics;

namespace Desafio.Domain
{
    public class FatorialResolver
    {
        public string Resolve(int numero) 
        {            
            var numeroOriginal = numero;
            BigInteger total = 1;

            if (numero < 0)
            {               
                return "O número deve ser não negativo.";
            }
            else
            {
                if (numero == 0)
                {
                    return $"O fatorial de {numero} é 1.";
                }
                else
                {
                    while (numero > 0)
                    {
                        total = total * numero;
                        numero--;
                    }

                    return $"O fatorial de {numeroOriginal} é {total}.";

                }
            }
        }
    }
}
