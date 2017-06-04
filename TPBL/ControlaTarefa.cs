using System;
using TPBO;
using TPDL;

namespace TPBL
{
    public class ControlaTarefa
    {

        public ControlaTarefa() { }
        static bool result = false;

        public bool AdicionaTarefa(Tarefa t, out string mensagem)
        {
            string msg = string.Empty;

            try
            {
                GereTarefa.AdicionaTarefa(t, out msg);
                result = true;
            }
            catch (Exception ex)
            {
                msg = ex.Message;

            }
            mensagem = msg;
            return result;
        }
        public bool EliminaTarefa(Tarefa t, out string mensagem)
        {
            string msg;
            try
            {
                if (GereTarefa.RemoveTarefa(t, out msg))
                {
                    t.SituacaoRelativaATarefa = EstadoTarefa.Removida;
                    result = true;
                }
            }
            catch (ImposssivelAdicionarUtilizador ex)
            {
                msg = ex.Message;
                result = false;
            }
            mensagem = msg;
            return result;
        }
        public bool ProcurarTarefa(Tarefa t, out string mensagem)
        {
            string msg;
            try
            {
                if (GereTarefa.ConsultarTarefa(t, out msg)==true)
                {
 
                    result = true;
                }
            }
            catch (ImposssivelAdicionarUtilizador ex)
            {
                msg = ex.Message;
                result = false;
            }
            mensagem = msg;
            return result;
        }
    }
}
