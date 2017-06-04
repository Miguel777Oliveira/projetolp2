using System;
using System.Collections.Generic;
using System.Text;

namespace TPBO
{
    public class Trabalhador : Utilizador
    {
        int identificacaoTrabalhador;
        DateTime dtInicioContrato;



        public Trabalhador(string nomeC, char generoSP, DateTime dataNasc, EstadoCivil civ, string ocupacao, int identificacao, DateTime dtContrato)
            : base(nomeC, generoSP, dataNasc, civ, ocupacao)
        {
            identificacaoTrabalhador = identificacao;
            dtInicioContrato = dtContrato;
        }

        public int IdentificacaoTrabalhador
        {
            get { return identificacaoTrabalhador; }
            set { identificacaoTrabalhador = value; }
        }

        public DateTime DataInicioContrato
        {
            get { return dtInicioContrato; }
            set { dtInicioContrato = value; }
        }
        
        //Faltam properties
    }
}
