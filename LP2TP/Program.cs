using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPBO;
using TPDL;

namespace LP2TP
{
    class Program
    {
        static void Main(string[] args)
        {
            string errorMSG =" ";
            //Teste ao metodo associa tarefa a utilizador
            DateTime dtTime = new DateTime(2017, 05, 05);
            DateTime dtTimeII = new DateTime(2017, 08, 15);
            Atividade act = new Atividade(dtTime, " ", true);
            List<Atividade> conjAtividade = new List<Atividade>();
            conjAtividade.Add(act);
         

            List<Trabalhador> trabalhadores = null;
            Tarefa t = new Tarefa(conjAtividade, trabalhadores, dtTime, dtTimeII);

            //GereTarefa tar = new GereTarefa();
            try
            {
                if(GereTarefa.AdicionaTarefa(t, out errorMSG)==false)
                {
                    throw new NullReferenceException("Não foi possivel adicionar tarefa");
                }
            }

            catch (ImposssivelAdicionarTarefa ex)
            {
                Console.WriteLine("Impossivel adicionar tarefa");
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine("Impossivel adicionar tarefa");
            }

        }
    }
}
