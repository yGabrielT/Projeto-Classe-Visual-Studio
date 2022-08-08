using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe12
{
    class Pessoa
    {
        private string nome;
        private int idade;
        private double altura;
        private string sexo;

        public Pessoa()
        {
            this.nome = null;
            this.idade = 0;
            this.altura = 0.0;
            sexo = null;
        }
        public Pessoa(string nome, int idade, double altura, char sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            Sexo = sexo.ToString();
        }
        public string Nome
        { 
          get { return nome; } 
          set { nome = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value.ToUpper() == "M" ? "MASCULINO" : "FEMININO"; }
        }





}


