using System;
using System.Collections.Generic;
using System.Text;
using TPBO;

namespace TPDL
{
    public class GereTarefa
    {

       static List<Tarefa> gereTarefa;
       static bool result = false; //Retoma resultado de cada metodo bool
       static string msg;

        public GereTarefa () { }


        public static bool AdicionaTarefa (Tarefa t,out string mensagem)
        {
            
            try
            {
               
                gereTarefa.Add(t);
                result = true;
            }
            catch(ImposssivelAdicionarTarefa ex)
            {
                msg = ex.Message;
                result = false;
            }
            catch(NullReferenceException ex)
            {
                mensagem=ex.Message;
                result = false;
            }
            mensagem = msg;
            return result;
        }


        public static bool RemoveTarefa(Tarefa t, out string mensagem)
        {

            try
            {
                if (gereTarefa.Contains(t))
                {
                    t.SituacaoRelativaATarefa = EstadoTarefa.Removida;
                    result = true;
                }
            }
            catch(ImposssivelAdicionarUtilizador ex)
            {
                msg = ex.Message;
                result = false;
            }
            mensagem = msg;
            return result;
        }
        public static bool ConsultarTarefa(Tarefa t, out string mensagem)
        {
            string msgI = string.Empty;
            try
            {
                if (gereTarefa.Contains(t))
                { 
                    result = true;
                    
                }
            }
            catch (ImposssivelAdicionarUtilizador ex)
            {
                msgI = ex.Message;
                result = false;
            }
            mensagem = msgI;
            return result;

           
        }
        

        public static bool AssociaUtilizadorATarefa(List<Trabalhador> trabalhadores, Tarefa tar, out string msg)
        {
            string output = String.Empty;
            try
            {

                bool result = false;
                if (gereTarefa.Contains(tar))
                {
                    tar.ConjuntoTrabalhador = trabalhadores;
                    result = true;
                }

            }
            catch(Exception ex)
            {
                
                output=ex.Message;
            }
            msg=output;
            return result;
        }


    }
}
