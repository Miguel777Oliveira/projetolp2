using System;
using System.Collections.Generic;
using System.Text;

namespace TPBO
{

    public enum TipoHorario
    {
        Laboral,
        PosLaboral,
    }
    public class Horario
    {


        TipoHorario generoHorarioAplicado; 
        DateTime dthoraInicioHorario; // Data e hora de inicio de um horario
        DateTime dthoraFimHorario; // Data e hora final de determinado horario

        public Horario()
        {

        }


        public Horario(TipoHorario genero, DateTime dtInicio, DateTime dtFim)
        {
            generoHorarioAplicado = genero;
            dthoraInicioHorario = dtInicio;
            dthoraFimHorario = dtFim;
        }


        //property

    }
}
