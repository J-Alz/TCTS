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
            this.tbServidor = new System.Windows.Forms.TextBox();
            this.tbPoblacion = new System.Windows.Forms.TextBox();
            this.tbLambda = new System.Windows.Forms.TextBox();
            this.tbMiu = new System.Windows.Forms.TextBox();
            this.btResolver = new System.Windows.Forms.Button();
            this.rbtInfinita = new System.Windows.Forms.RadioButton();
            this.rbtFinita = new System.Windows.Forms.RadioButton();
            this.gbPoblacion = new System.Windows.Forms.GroupBox();
            this.tbN = new System.Windows.Forms.TextBox();
            this.gbPoblacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPoblacion
            // 
            this.tbPoblacion.Location = new System.Drawing.Point(66, 44);
            this.tbPoblacion.Name = "tbPoblacion";
            this.tbPoblacion.PlaceholderText = "Población";
            this.tbPoblacion.Size = new System.Drawing.Size(62, 22);
            this.tbPoblacion.TabIndex = 0;
            this.tbPoblacion.TextChanged += new System.EventHandler(this.tbPoblacion_TextChanged);
            // 
            // tbLambda
            // 
            this.tbLambda.Location = new System.Drawing.Point(204, 24);
            this.tbLambda.Name = "tbLambda";
            this.tbLambda.PlaceholderText = "Lambda";
            this.tbLambda.Size = new System.Drawing.Size(100, 22);
            this.tbLambda.TabIndex = 1;
            this.tbLambda.TextChanged += new System.EventHandler(this.tbLambda_TextChanged);
            // 
            // tbMiu
            // 
            this.tbMiu.Location = new System.Drawing.Point(204, 53);
            this.tbMiu.Name = "tbMiu";
            this.tbMiu.PlaceholderText = "Miu";
            this.tbMiu.Size = new System.Drawing.Size(100, 22);
            this.tbMiu.TabIndex = 2;
            this.tbMiu.TextChanged += new System.EventHandler(this.tbMiu_TextChanged);
            // 
            // tbServidor
            // 
            this.tbServidor.Location = new System.Drawing.Point(18, 95);
            this.tbServidor.Name = "tbServidor";
            this.tbServidor.PlaceholderText = "Servidor";
            this.tbServidor.Size = new System.Drawing.Size(100, 22);
            this.tbServidor.TabIndex = 3;
            this.tbServidor.TextChanged += new System.EventHandler(this.tbServidor_TextChanged);
            // 
            // btResolver
            // 
            this.btResolver.Location = new System.Drawing.Point(113, 151);
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
            this.rbtInfinita.Size = new System.Drawing.Size(63, 19);
            this.rbtInfinita.TabIndex = 5;
            this.rbtInfinita.TabStop = true;
            this.rbtInfinita.Text = "Infinita";
            this.rbtInfinita.UseVisualStyleBackColor = true;
            this.rbtInfinita.CheckedChanged += new System.EventHandler(this.rbtInfinita_CheckedChanged);
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
            this.rbtFinita.CheckedChanged += new System.EventHandler(this.rbtFinita_CheckedChanged);
            // 
            // gbPoblacion
            // 
            this.gbPoblacion.Controls.Add(this.rbtFinita);
            this.gbPoblacion.Controls.Add(this.tbPoblacion);
            this.gbPoblacion.Controls.Add(this.rbtInfinita);
            this.gbPoblacion.Location = new System.Drawing.Point(12, 12);
            this.gbPoblacion.Name = "gbPoblacion";
            this.gbPoblacion.Size = new System.Drawing.Size(139, 77);
            this.gbPoblacion.TabIndex = 7;
            this.gbPoblacion.TabStop = false;
            this.gbPoblacion.Text = "Población";
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(204, 81);
            this.tbN.Name = "tbN";
            this.tbN.PlaceholderText = "Clientes";
            this.tbN.Size = new System.Drawing.Size(100, 22);
            this.tbN.TabIndex = 8;
            this.tbN.TextChanged += new System.EventHandler(this.tbN_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(344, 293);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.gbPoblacion);
            this.Controls.Add(this.btResolver);
            this.Controls.Add(this.tbServidor);
            this.Controls.Add(this.tbMiu);
            this.Controls.Add(this.tbLambda);
            this.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Teoría de Colas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPoblacion.ResumeLayout(false);
            this.gbPoblacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tbServidor;
        private TextBox tbPoblacion;
        private TextBox tbLambda;
        private TextBox tbMiu;
        private TextBox tbN;
        private Button btResolver;
        private RadioButton rbtInfinita;
        private RadioButton rbtFinita;
        private GroupBox gbPoblacion;
        
    }
}