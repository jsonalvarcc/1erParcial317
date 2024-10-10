namespace preg7
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.texto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(167, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 27);
            this.label1.TabIndex = 44;
            this.label1.Text = "CALCULADORA INFIJO POSTFIJO";
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.RoyalBlue;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(131, 115);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(97, 37);
            this.button19.TabIndex = 43;
            this.button19.Text = "AC";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(233, 115);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(132, 37);
            this.button18.TabIndex = 42;
            this.button18.Text = "=";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Red;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(27, 115);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(97, 37);
            this.button17.TabIndex = 41;
            this.button17.Text = "CE";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(285, 305);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(79, 43);
            this.button16.TabIndex = 40;
            this.button16.Text = "/";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.composicion);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(285, 256);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(79, 43);
            this.button15.TabIndex = 39;
            this.button15.Text = "*";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.composicion);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(285, 207);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(79, 43);
            this.button14.TabIndex = 38;
            this.button14.Text = "-";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.composicion);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(285, 158);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(79, 43);
            this.button13.TabIndex = 37;
            this.button13.Text = "+";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.composicion);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Lime;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(198, 305);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(79, 43);
            this.button12.TabIndex = 36;
            this.button12.Text = ")";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.composicion);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Lime;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(112, 305);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(79, 43);
            this.button11.TabIndex = 35;
            this.button11.Text = "(";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.composicion);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(27, 305);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(79, 43);
            this.button10.TabIndex = 34;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.composicion);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(198, 256);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(79, 43);
            this.button9.TabIndex = 33;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.composicion);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(112, 256);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(79, 43);
            this.button8.TabIndex = 32;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.composicion);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(27, 256);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(79, 43);
            this.button7.TabIndex = 31;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.composicion);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(198, 207);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 43);
            this.button6.TabIndex = 30;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.composicion);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(112, 207);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 43);
            this.button5.TabIndex = 29;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.composicion);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(27, 207);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 43);
            this.button4.TabIndex = 28;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.composicion);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(198, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 43);
            this.button3.TabIndex = 27;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.composicion);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(112, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 43);
            this.button2.TabIndex = 26;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.composicion);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 43);
            this.button1.TabIndex = 25;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.composicion);
            // 
            // resultado
            // 
            this.resultado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resultado.BackColor = System.Drawing.Color.White;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(27, 82);
            this.resultado.Margin = new System.Windows.Forms.Padding(0);
            this.resultado.Name = "resultado";
            this.resultado.ReadOnly = true;
            this.resultado.Size = new System.Drawing.Size(338, 30);
            this.resultado.TabIndex = 24;
            this.resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // texto
            // 
            this.texto.BackColor = System.Drawing.Color.White;
            this.texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto.Location = new System.Drawing.Point(27, 52);
            this.texto.Margin = new System.Windows.Forms.Padding(0);
            this.texto.Name = "texto";
            this.texto.ReadOnly = true;
            this.texto.Size = new System.Drawing.Size(338, 30);
            this.texto.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(378, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "expresion postfijo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(707, 368);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.texto);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.TextBox texto;
        private System.Windows.Forms.Label label2;
    }
}

