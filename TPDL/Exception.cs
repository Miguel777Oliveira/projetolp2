using System;
using System.Collections.Generic;
using System.Text;

namespace TPDL
{
    public class ImposssivelAdicionarUtilizador:Exception
    {
        public ImposssivelAdicionarUtilizador(): base("Não foi possivel adicionar utilizador") 
        {
        }
        public ImposssivelAdicionarUtilizador(String message): base(message) {
        }
    }

    public class ImposssivelAdicionarTarefa : Exception
    {
        public ImposssivelAdicionarTarefa() : base("Não foi possivel adicionar tarefa")
        {
        }
        public ImposssivelAdicionarTarefa(String message) : base(message)
        {
        }
    }
}
