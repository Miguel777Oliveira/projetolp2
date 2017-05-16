using System;
using System.Collections.Generic;
using System.Text;

namespace TPBO
{
    public enum EstadoCivil
    {
        solteiro,
        caseiro,
        viuvo,
        divorciado,

    }

    public enum Etnia
    {
        branca,
        negra,
        outra,
    }


    class Utilizador
    {
        string nomeCompleto;
        char genero;
        DateTime dtNascimento;
        EstadoCivil estCiv;
        string cargo;
        public Utilizador(string nomeC, char generoSP, DateTime dataNasc, EstadoCivil civ, string ocupacao)

        {

            nomeCompleto = nomeC;
            genero = generoSP;
            dtNascimento = dataNasc;
            estCiv = civ;
            cargo = ocupacao;

        }

        public string NomeUtilizador
        {
            get { return nomeCompleto; }
            set { nomeCompleto = value; }
        }
        public DateTime DataNascimentoUtilizador
        {
            get { return dtNascimento; }
            set { dtNascimento = value; }
        }
        public char Genero
        {
            get { return genero; }
            set { genero = value; }
        }

    }
}
