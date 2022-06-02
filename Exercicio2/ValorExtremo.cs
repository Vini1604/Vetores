using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2
{
    class ValorExtremo
    {
        public int ValorDoNumero { get; set; }
        public int IndiceDoNumero { get; set; }
        public override string ToString()
        {
            return $"Valor = {ValorDoNumero}, Indice = {IndiceDoNumero}";
        }
    }
}
