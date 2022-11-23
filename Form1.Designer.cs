namespace TCTS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPoblacion = new System.Windows.Forms.TextBox();
            this.tbLambda = new System.Windows.Forms.TextBox();
            this.tbMiu = new System.Windows.Forms.TextBox();
            this.tbServidor = new System.Windows.Forms.TextBox();
            this.btResolver = new System.Windows.Forms.Button();
            this.rbtInfinita = new System.Windows.Forms.RadioButton();
            this.rbtFinita = new System.Windows.Forms.RadioButton();
            this.gbPoblacion = new System.Windows.Forms.GroupBox();
            this.tbN = new System.Windows.Forms.TextBox();
            this.gbPoblacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(285, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(107, 169);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(290, 173);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // tbPoblacion
            // 
            this.tbPoblacion.Location = new System.Drawing.Point(21, 69);
            this.tbPoblacion.Name = "tbPoblacion";
            this.tbPoblacion.Size = new System.Drawing.Size(62, 23);
            this.tbPoblacion.TabIndex = 0;
            this.tbPoblacion.Text = "Poblacion";
            // 
            // tbLambda
            // 
            this.tbLambda.Location = new System.Drawing.Point(157, 27);
            this.tbLambda.Name = "tbLambda";
            this.tbLambda.Size = new System.Drawing.Size(100, 23);
            this.tbLambda.TabIndex = 1;
            this.tbLambda.Text = "Lambda";
            // 
            // tbMiu
            // 
            this.tbMiu.Location = new System.Drawing.Point(157, 56);
            this.tbMiu.Name = "tbMiu";
            this.tbMiu.Size = new System.Drawing.Size(100, 23);
            this.tbMiu.TabIndex = 2;
            this.tbMiu.Text = "miu";
            // 
            // tbServidor
            // 
            this.tbServidor.Location = new System.Drawing.Point(157, 87);
            this.tbServidor.Name = "tbServidor";
            this.tbServidor.Size = new System.Drawing.Size(100, 23);
            this.tbServidor.TabIndex = 3;
            this.tbServidor.Text = "servidores";
            // 
            // btResolver
            // 
            this.btResolver.Location = new System.Drawing.Point(75, 176);
            this.btResolver.Name = "btResolver";
            this.btResolver.Size = new System.Drawing.Size(75, 23);
            this.btResolver.TabIndex = 4;
            this.btResolver.Text = "Resolver";
            this.btResolver.UseVisualStyleBackColor = true;
            this.btResolver.Click += new System.EventHandler(this.btResolver_Click);
            // 
            // rbtInfinita
            // 
            this.rbtInfinita.AutoSize = true;
            this.rbtInfinita.Location = new System.Drawing.Point(6, 19);
            this.rbtInfinita.Name = "rbtInfinita";
            this.rbtInfinita.Size = new System.Drawing.Size(62, 19);
            this.rbtInfinita.TabIndex = 5;
            this.rbtInfinita.TabStop = true;
            this.rbtInfinita.Text = "Infinita";
            this.rbtInfinita.UseVisualStyleBackColor = true;
            // 
            // rbtFinita
            // 
            this.rbtFinita.AutoSize = true;
            this.rbtFinita.Location = new System.Drawing.Point(6, 44);
            this.rbtFinita.Name = "rbtFinita";
            this.rbtFinita.Size = new System.Drawing.Size(54, 19);
            this.rbtFinita.TabIndex = 6;
            this.rbtFinita.TabStop = true;
            this.rbtFinita.Text = "Finita";
            this.rbtFinita.UseVisualStyleBackColor = true;
            // 
            // gbPoblacion
            // 
            this.gbPoblacion.Controls.Add(this.rbtFinita);
            this.gbPoblacion.Controls.Add(this.tbPoblacion);
            this.gbPoblacion.Controls.Add(this.rbtInfinita);
            this.gbPoblacion.Location = new System.Drawing.Point(12, 12);
            this.gbPoblacion.Name = "gbPoblacion";
            this.gbPoblacion.Size = new System.Drawing.Size(89, 98);
            this.gbPoblacion.TabIndex = 7;
            this.gbPoblacion.TabStop = false;
            this.gbPoblacion.Text = "Población";
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(157, 116);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(100, 23);
            this.tbN.TabIndex = 8;
            this.tbN.Text = "n";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(291, 269);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.gbPoblacion);
            this.Controls.Add(this.btResolver);
            this.Controls.Add(this.tbServidor);
            this.Controls.Add(this.tbMiu);
            this.Controls.Add(this.tbLambda);
            this.Name = "Form1";
            this.Text = "Teoría de Colas";
            this.gbPoblacion.ResumeLayout(false);
            this.gbPoblacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private TextBox tbPoblacion;
        private TextBox tbLambda;
        private TextBox tbMiu;
        private TextBox tbServidor;
        private Button btResolver;
        private RadioButton rbtInfinita;
        private RadioButton rbtFinita;
        private GroupBox gbPoblacion;
        private TextBox tbN;
    }
}