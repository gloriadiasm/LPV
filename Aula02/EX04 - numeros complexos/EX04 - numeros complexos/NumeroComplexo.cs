using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04___numeros_complexos
{
    class NumeroComplexo
    {
        public Double pReal;
        public Double pImag;

        public NumeroComplexo()
        {

        }

        public NumeroComplexo(Double pReal, Double pImag)
        {
            this.pReal = pReal;
            this.pImag = pImag;
        }

        public NumeroComplexo Soma(NumeroComplexo outro)
        {

            return new NumeroComplexo(this.pReal + outro.pReal, this.pImag + outro.pImag); ;
        }

        public NumeroComplexo Subt(NumeroComplexo outro)
        {

            return new NumeroComplexo(this.pReal - outro.pReal, this.pImag - outro.pImag); ;
        }
        public override string ToString()
        {
            return this.pReal + " + " + this.pImag + "i";
        }
    }
}
