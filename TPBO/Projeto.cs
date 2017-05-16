using System;
using System.Collections.Generic;

namespace TPBO
{
    public enum EstadoProjeto
    {
        Removido,
        NaoRemovido,
        Suspenso,
        Finalizado,
    }
    public class Projeto
    {

        List<Trabalhador> conjUtilizadores;
        List<Tarefa> conjTarefas;
        Responsavel responsavel;
        EstadoProjeto situacao;

        public Projeto()
        {

        }
        
        public Projeto(List<Trabalhador> conUtilizadores, List<Tarefa> conTarefas, Responsavel pessoaResp)
        {
            conjUtilizadores = conUtilizadores;
            conjTarefas = conTarefas;
            responsavel = pessoaResp;
        }
        
        public List<Trabalhador> ListaTrabalhadores
        {
            get { return conjUtilizadores; }
            set { conjUtilizadores = value; }
        }

        public EstadoProjeto SituacaoRelativaAoProjeto
        {
            get { return situacao; }
            set { situacao = value; }
        }
    }
}
