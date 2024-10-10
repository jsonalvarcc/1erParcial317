using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class InfiPost
    {
        
        // mtodo para convertir infijo a postfijo
        public  string infijo_a_Postfijo(string infijo)
        {
            Stack<char> pila = new Stack<char>();
            string postfijo = "";
            int i = 0;

            while (i < infijo.Length)
            {
                char c = infijo[i];


                if (c == ' ')
                {
                    i++;
                    continue;
                }

                // Leer num completo
                if (char.IsDigit(c))
                {
                    while (i < infijo.Length && (char.IsDigit(infijo[i]) || infijo[i] == '.'))
                    {
                        postfijo += infijo[i];
                        i++;
                    }
                    postfijo += ' '; // Separar num
                    continue; // Saltar al siguiente ciclo
                }

                // Manejar ()
                if (c == '(')
                {
                    pila.Push(c);
                }
                else if (c == ')')
                {
                    while (pila.Count > 0 && pila.Peek() != '(')
                    {
                        postfijo += pila.Pop() + " ";
                    }
                    pila.Pop(); // quitar '('
                }
                else if (Verificaciones.veriOperador(c))
                {
                    while (pila.Count > 0 && Verificaciones.VeriPrecedencia(pila.Peek()) >=Verificaciones.VeriPrecedencia(c))
                    {
                        postfijo += pila.Pop() + " ";
                    }
                    pila.Push(c);
                }

                i++;
            }

            // Desapilar todos los operadores restantes
            while (pila.Count > 0)
            {
                postfijo += pila.Pop() + " ";
            }

            return postfijo.Trim(); // Remover espacio final
        }

    }
}
