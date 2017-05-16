using System;
using System.Collections.Generic;
using System.Text;

namespace TPBO
{
    public class Atividade
    {

        DateTime dtInicio;
        string descricao;
        bool atividadeconcluida;


        public Atividade()
        {

        }
        public Atividade(DateTime dtInicioAtivid, string observacao, bool estaFin)
        {
            dtInicio = dtInicioAtivid;
            descricao = observacao;
            atividadeconcluida = estaFin;
        }
        public DateTime DataInicio
        {
            get { return dtInicio; }
            set { dtInicio = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public bool AtividadeConcluida
        {
            get { return atividadeconcluida; }
            set { atividadeconcluida = value; }
        }
    }
}
