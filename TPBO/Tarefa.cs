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
        //atributo
        EstadoTarefa estTarefa;
        
        

        public Tarefa()
        {

        }
        public Tarefa (List<Atividade> listAct, List<Trabalhador> trabalhadores, DateTime dtInicioTar)
        {
            listAtividades = listAct;
            listTrabalhador = trabalhadores;
            horaInicioTarefa = dtInicioTar;
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

        //property
        public EstadoTarefa SituacaoRelativaATarefa
        {
            get { return estTarefa; }
            set { estTarefa = value; }
        }

    }
}
