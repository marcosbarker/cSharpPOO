using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasAluno
{
    class Aluno
    {
        public double NotaA;
        public double NotaB;
        public double NotaC;
        public string NomeAluno;

        public double NotaFinal()
        {
            return NotaA + NotaB + NotaC;
        }

        public string Situacao()
        {
            if (NotaFinal() >= 60)
            {
                return "\nAPROVADO";
            }
            else
            {
                double falta = 60 - NotaFinal();
                return "\nREPROVADO\nFALTAM " + falta + " PONTOS";
            }
        }

        public override string ToString()
        {
            return "NOTA FINAL = " + NotaFinal().ToString("F2") + " " + Situacao();
        }
    }
}
