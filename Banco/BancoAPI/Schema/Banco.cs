using Bogus;
using System.Collections;
using System.Collections.Generic;

namespace BancoAPI.Schema
{
    public class Banco
    {
        public List<Conta>? Contas { get; set; }

        public Banco()
        {
            this.Contas = new List<Conta> { new Conta(1, 3357.94), new Conta(2, 12), new Conta(3, 456.98), new Conta(4, 6548.09), new Conta(5, 1515.15) };
        }
    }
}
