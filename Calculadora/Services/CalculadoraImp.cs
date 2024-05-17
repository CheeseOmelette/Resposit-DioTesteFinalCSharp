using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        private List<double> Listahistorico = new List<double>();
        public double Somar(double num1, double num2) 
        {
            double res = num1 + num2;
            Listahistorico.Add(res);
            return res;
        }

        public double Subtrair(double num1, double num2) 
        {
           double res = num1 - num2;
            Listahistorico.Add(res);
            return res;
        }

        public double Multiplicar (double num1, double num2) 
        {
            double res = num1 * num2;
            Listahistorico.Add(res);
            return res;
        }

        public double Dividir (double num1, double num2) 
        {   
            if (num2 == 0) {
                throw new DivideByZeroException("Operação Inválida");
            } 
            
            else {
            
            double res = num1 / num2;
            Listahistorico.Add(res);
            return res;
            
            }
        }

        public List<double> Historico() {
            

            return Listahistorico;
        }
    
    }
       
}