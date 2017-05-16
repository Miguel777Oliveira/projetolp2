using System;
using System.Collections.Generic;
using System.Text;

namespace TPBO
{
    public class Alerta
    {
        DateTime dthoraAtivacaoAlerta;// hora "real" do alerta/evento
        DateTime dthoraAntipacao; // lembrete "n" minutos antes
        Projeto proj;
        List<Trabalhador> listaAlerta; // um alerta pode ser emitido para varios utilizadores 


        public Alerta (DateTime dtAlerta, DateTime lembrete, Projeto projeto)
        {
            dthoraAtivacaoAlerta = dtAlerta;
            dthoraAntipacao = lembrete;
            proj = projeto;

        }
        public Alerta(DateTime dtAlerta, DateTime lembrete, Projeto projeto, List<Trabalhador> trabEnvolvidos)
        {
            dthoraAtivacaoAlerta = dtAlerta;
            dthoraAntipacao = lembrete;
            proj = projeto;
            listaAlerta = trabEnvolvidos;

        }

        public DateTime DataAlerta
        {
            get { return dthoraAtivacaoAlerta; }
            set { dthoraAtivacaoAlerta = value; }
        }
        public DateTime AnticapacaoAlerta
        {
            get { return dthoraAntipacao; }
            set { dthoraAntipacao = value; }
        }
        public Projeto ProjetoEnvolvido
        {
            get { return proj; }
            set { proj = value; }
        }

        public List<Trabalhador> ConjuntoTrabalhadoresEmAlerta
        {
            get { return listaAlerta; }
            set { listaAlerta = value; }
        }

    }
}
