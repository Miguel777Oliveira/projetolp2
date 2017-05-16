using System;
using System.Collections.Generic;
using System.Text;
using TPBO;
namespace TPDL
{
    public class GereTarefa
    {

        List<Tarefa> gereTarefa;
        bool result = true; //Retoma resultado de cada metodo bool
        string msg;

        public GereTarefa () { }


        public bool AdicionaTarefa (Tarefa t,out string mensagem)
        {
            try
            {
                gereTarefa.Add(t);
            }
            catch(Exception ex)
            {
                msg = ex.Message;
                result = false;
            }
            mensagem = msg;
            return result;
        }
            

        
    }
}
