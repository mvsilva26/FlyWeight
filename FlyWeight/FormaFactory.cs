using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class FormaFactory //FlyWeightFactory
    {
        private static Dictionary<string, IForma> formas = new Dictionary<string, IForma>(); // Uso do objeto Dictionary como uma coleção
                                                                                             // de objetos forma   
        
        public static IForma GetForma(string chave) // Metodo getforma estático que recebe a chave 
        {                                           // e verifica com base se o objeto está ou não no CACHE
                                                    // 
            IForma forma;
            if (formas.ContainsKey(chave)) //verifica se está no dicionario
                                           // . Se estiver ele retorna o objeto existente
            {
                return formas[chave];
            }
            else
            {
                if(chave == "circulo") // Se o objeto definido pela chave círculo não existir ele será criado e será "devolvido"
                {
                    forma = new Circulo(); // criação
                    formas.Add("circulo", forma); // Adiciona ao CACHE
                }
                else
                {
                    throw new Exception("Este tipo de objeto não pode ser criado");
                }
            }
            return forma; // retorna 
        }





    }
}
