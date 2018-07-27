using System;
using System.Collections.Generic;
using System.Text;

namespace SGS.app.Entity
{
    public class Beneficiario
    {

        public Beneficiario()
        {

        }
        
        public int BeneficiarioID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public ICollection<Prontuario> Prontuarios { get; set; }
    }


}
