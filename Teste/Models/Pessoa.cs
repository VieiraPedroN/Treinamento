﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Models
{
    class Pessoa
    {
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public string Nome { get; set; }
        public int Idade {get; set;}

        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} idade é {Idade}");
        }

    }
}
