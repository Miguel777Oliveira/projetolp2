using System;
using System.Collections.Generic;
using System.Text;

namespace TPBO
{
    public class Responsavel:Trabalhador
    {
        DateTime dtAtribuicaoResp; // Data de atribuicao de responsabilidade a este utilizador


        public Responsavel(string nomeC, char generoSP, DateTime dataNasc, EstadoCivil civ, string ocupacao, int identificacao, DateTime dtContrato, DateTime dtAtribResp)
            :base(nomeC, generoSP, dataNasc, civ,ocupacao,identificacao,dtContrato)
        {
            dtAtribuicaoResp = dtAtribResp;
        }


        public DateTime DataAtribuicaoResponsabilidade
        {
            get { return dtAtribuicaoResp; }
            set { DataAtribuicaoResponsabilidade = value; }
        }

    }
}
