using System;
using System.Collections.Generic;
using System.Text;

namespace TPBO
{
    class Trabalhador:Utilizador
    {
        int identificacaoTrabalhador;
        DateTime dtInicioContrato;



        public Trabalhador(string nomeC, char generoSP, DateTime dataNasc, EstadoCivil civ, string ocupacao, int identificacao, DateTime dtContrato)
            : base(nomeC, generoSP, dataNasc, civ, ocupacao)
        {
            identificacaoTrabalhador = identificacao;
            dtInicioContrato = dtContrato;
        }


        //Faltam properties
    }
}
