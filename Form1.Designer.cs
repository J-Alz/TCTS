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
            this.components = new System.ComponentModel.Container();
            this.tbServidor = new System.Windows.Forms.TextBox();
            this.tbPoblacion = new System.Windows.Forms.TextBox();
            this.tbLambda = new System.Windows.Forms.TextBox();
            this.tbMiu = new System.Windows.Forms.TextBox();
            this.btResolver = new System.Windows.Forms.Button();
            this.rbtInfinita = new System.Windows.Forms.RadioButton();
            this.rbtFinita = new System.Windows.Forms.RadioButton();
            this.gbPoblacion = new System.Windows.Forms.GroupBox();
            this.tbN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbPoblacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbServidor
            // 
            this.tbServidor.Location = new System.Drawing.Point(64, 93);
            this.tbServidor.Name = "tbServidor";
            this.tbServidor.PlaceholderText = "Servidor";
            this.tbServidor.Size = new System.Drawing.Size(100, 22);
            this.tbServidor.TabIndex = 3;
            this.tbServidor.TextChanged += new System.EventHandler(this.tbServidor_TextChanged);
            // 
            // tbPoblacion
            // 
            this.tbPoblacion.Location = new System.Drawing.Point(90, 43);
            this.tbPoblacion.Name = "tbPoblacion";
            this.tbPoblacion.PlaceholderText = "Población";
            this.tbPoblacion.Size = new System.Drawing.Size(62, 22);
            this.tbPoblacion.TabIndex = 0;
            this.tbPoblacion.TextChanged += new System.EventHandler(this.tbPoblacion_TextChanged);
            // 
            // tbLambda
            // 
            this.tbLambda.Location = new System.Drawing.Point(202, 12);
            this.tbLambda.Name = "tbLambda";
            this.tbLambda.PlaceholderText = "Lambda";
            this.tbLambda.Size = new System.Drawing.Size(100, 22);
            this.tbLambda.TabIndex = 1;
            this.tbLambda.TextChanged += new System.EventHandler(this.tbLambda_TextChanged);
            // 
            // tbMiu
            // 
            this.tbMiu.Location = new System.Drawing.Point(202, 42);
            this.tbMiu.Name = "tbMiu";
            this.tbMiu.PlaceholderText = "Miu";
            this.tbMiu.Size = new System.Drawing.Size(100, 22);
            this.tbMiu.TabIndex = 2;
            this.tbMiu.TextChanged += new System.EventHandler(this.tbMiu_TextChanged);
            // 
            // btResolver
            // 
            this.btResolver.Location = new System.Drawing.Point(121, 121);
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
            this.gbPoblacion.Controls.Add(this.label5);
            this.gbPoblacion.Controls.Add(this.rbtFinita);
            this.gbPoblacion.Controls.Add(this.tbPoblacion);
            this.gbPoblacion.Controls.Add(this.rbtInfinita);
            this.gbPoblacion.Location = new System.Drawing.Point(12, 12);
            this.gbPoblacion.Name = "gbPoblacion";
            this.gbPoblacion.Size = new System.Drawing.Size(160, 75);
            this.gbPoblacion.TabIndex = 7;
            this.gbPoblacion.TabStop = false;
            this.gbPoblacion.Text = "Población";
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(202, 72);
            this.tbN.Name = "tbN";
            this.tbN.PlaceholderText = "Clientes";
            this.tbN.Size = new System.Drawing.Size(100, 22);
            this.tbN.TabIndex = 8;
            this.tbN.TextChanged += new System.EventHandler(this.tbN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "λ";
            this.toolTip1.SetToolTip(this.label1, "■ Tasa de llegada.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "μ";
            this.toolTip1.SetToolTip(this.label2, "■ Tasa de servicio.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "n";
            this.toolTip1.SetToolTip(this.label3, "■ Cantidad de clientes.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "k";
            this.toolTip1.SetToolTip(this.label4, "■ Número de servidores.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "M";
            this.toolTip1.SetToolTip(this.label5, "■ Población.");
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(318, 159);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ToolTip toolTip1;
    }
}