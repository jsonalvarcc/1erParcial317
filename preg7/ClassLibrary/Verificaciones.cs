using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Verificaciones
    {

        // metodo para determinar si el caracter es un operador
        public static bool veriOperador(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        // metodo para determinar la precedencia de los operadores
        public static int VeriPrecedencia(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                default:
                    return 0;
            }
        }

    }
}
