using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
namespace preg7
{
    public partial class Form1 : Form
    {
        double res;
        string textogenerado;
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //eliminar el ultimo caracter
            if (textogenerado.Length > 0)
                textogenerado = textogenerado.Remove(textogenerado.Length - 1);
            mostrar();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //limpiar todo
            textogenerado = "";//lo que se genera
            res = 0;//la respuesta final dela aoperacion
            texto.Text = "";//lo q se muestra el resultado
            label2.Text = "";//resultado del infijo a postfijo

            mostrar();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            InfiPost infipost = new InfiPost();
            string textoPostfijo = infipost.infijo_a_Postfijo(textogenerado);
            label2.Text = "expresion Postfijo:"+ textoPostfijo;
            EvaluarPostfijo post = new EvaluarPostfijo();
            res = post.evaluar(textoPostfijo);
            mostrar();
        }
        private void mostrar()
        {
            texto.Text = textogenerado;
            resultado.Text = res.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            res = 0;
            resultado.Text = res.ToString();
            textogenerado = "";
            label2.Text = "expresion Postfijo:";
        }

        private void composicion(object sender, EventArgs e)
        {
            textogenerado += ((Button)sender).Text;
            texto.Text = textogenerado;
        }

        
    }
}
