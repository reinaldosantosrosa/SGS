using System;
using System.Collections.Generic;
using System.Text;

namespace SGS.app.Entity
{
    public class Prontuario
    {

        public Prontuario()
        {

        }

        public int ProntuarioId { get; set; }
        public DateTime DataAtendimento { get; set; }
        public int BeneficiarioID { get; set; }
        public Beneficiario Beneficiario { get; set; }

    }


}
