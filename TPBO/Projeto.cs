using System;
using System.Collections.Generic;

namespace TPBO
{
    class Projeto
    {

        List<Trabalhador> conjUtilizadores;
        List<Tarefa> conjTarefas;
        Responsavel responsavel;


        public Projeto()
        {

        }
        public Projeto(List<Trabalhador> conUtilizadores, List<Tarefa> conTarefas, Responsavel pessoaResp)
        {
            conjUtilizadores = conUtilizadores;
            conjTarefas = conTarefas;
            responsavel = pessoaResp;
        }
    }
}
