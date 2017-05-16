using System;
using System.Collections.Generic;
using TPBO;
namespace TPDL
{
    public class GereProjeto
    {

        List<Projeto> gereProjeto;
        bool result = false;
        string msg;

        public GereProjeto() { }
      
        

        public bool AdicionaProjeto (Projeto p, out string mensagem)
        {
            try
            {
                gereProjeto.Add(p);
                result = true;
            }
            catch(Exception ex)
            {
                msg = ex.Message;
                result = false;
            }
            mensagem = msg;
            return result;
        }

        
        public bool Removeprojeto (Projeto proj, out string mensagem)
        {

            try
            {
                if (gereProjeto.Contains(proj))
                {
                    proj.SituacaoRelativaAoProjeto = EstadoProjeto.Removido; // marcado como removido
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
        

        public bool ConsultaProjeto(Projeto p, out string mensagem)
        {
            try
            {
                gereProjeto.Contains(p);
                
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                result = false;
            }
            mensagem = msg;
            return result;
        }

        public Projeto ConsultaERotomaProjeto(Projeto p, out string mensagem)
        {
            Projeto projetoDevolvido = null;

            try
            {
                if (gereProjeto.Contains(p))
                    projetoDevolvido = p;

            }
            catch (Exception ex)
            {
                msg = ex.Message;
                result = false;
            }
            mensagem = msg;
            return projetoDevolvido;
        }

     




    }


}
