using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Models;

namespace Funcionario
{
    class UsuarioFuncionario : Pessoa
    {
        int id = 0;

        public UsuarioFuncionario(string nome, int idade) : base(nome, idade)
        {
            
        }

        public void Longevidade()
        {
            if (Idade >= 18)
            {
                Console.WriteLine("Velho");
                id = 1;
            }
            else
            {
                Console.WriteLine("Novo");
            }
        }
    }
}
