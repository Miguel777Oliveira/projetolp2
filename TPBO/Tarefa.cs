using System;
using System.Collections.Generic;
using System.Text;

namespace TPBO
{
    public enum EstadoTarefa
    {
        Removida, 
        NaoRemovida,
    }
    public class Tarefa
    {
        List<Atividade> listAtividades;
        List<Trabalhador> listTrabalhador;
        DateTime horaInicioTarefa;
        DateTime horaFimTarefa;
        EstadoTarefa estTarefa;
        
        

        public Tarefa()
        {

        }
        public Tarefa (List<Atividade> listAct, List<Trabalhador> trabalhadores, DateTime dtInicioTar, DateTime dtFimTar)
        {
            listAtividades = listAct;
            listTrabalhador = trabalhadores;
            horaInicioTarefa = dtInicioTar;
            horaFimTarefa = dtFimTar;
        }

        public List<Atividade> ConjuntoAtividade
        {
            get { return listAtividades; }
            set { listAtividades = value; }
        }
        public List<Trabalhador> ConjuntoTrabalhador
        {
            get { return listTrabalhador; }
            set { listTrabalhador = value; }
        }
        public DateTime InicioTarefa
        {
            get { return horaInicioTarefa; }
            set { horaInicioTarefa = value; }
        }

        public DateTime FimTarefa
        {
            get { return horaFimTarefa; }
            set { horaFimTarefa = value; }
        }
        public EstadoTarefa SituacaoRelativaATarefa
        {
            get { return estTarefa; }
            set { estTarefa = value; }
        }

    }
}
