using System;
using System.Collections.Generic;
using System.Text;

namespace TPBO
{
    class Cliente
    {
        int numCliente;
        string moradaCliente;
        int numeroTelefone;
        int numeroFiscal;

        public Cliente()
        {
            
        }
        public Cliente( int numeroCliente, string endCliente, int numTel, int numFisc)
        {
            numCliente = numeroCliente;
            moradaCliente = endCliente;
            numeroTelefone = numTel;
            numeroFiscal = numFisc;
        }


        public string MoradaCliente
        {
            get { return moradaCliente; }
            set { moradaCliente = value; }
        }
        public int NumeroCliente
        {
            get { return numCliente; }
            set { numCliente = value; }
        }
        public int NumeroTelefone
        {
            get { return numeroTelefone; }
            set { numeroTelefone = value; }
        }

        public int NumeroFiscal
        {
            get { return numeroFiscal; }
            set { numeroFiscal = value; }
        }
        
    }

    
}
