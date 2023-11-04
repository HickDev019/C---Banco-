using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Cliente
    {
        public string nome;
        public double saldo;

        public void creditar(double valor)
        {
            this.saldo += valor;
        }  
        public void debitar(double valor)
        {
            this.saldo -= valor;
        }
    }
}
