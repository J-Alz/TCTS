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
            this.label5 = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbCS = new System.Windows.Forms.TextBox();
            this.tbCTSE = new System.Windows.Forms.TextBox();
            this.tbCTS = new System.Windows.Forms.TextBox();
            this.tbCTE = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbTiempo = new System.Windows.Forms.TextBox();
            this.gbPoblacion.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbServidor
            // 
            this.tbServidor.Location = new System.Drawing.Point(32, 20);
            this.tbServidor.Name = "tbServidor";
            this.tbServidor.PlaceholderText = "Servidor";
            this.tbServidor.Size = new System.Drawing.Size(100, 22);
            this.tbServidor.TabIndex = 3;
            this.tbServidor.TextChanged += new System.EventHandler(this.tbServidor_TextChanged);
            // 
            // tbPoblacion
            // 
            this.tbPoblacion.Location = new System.Drawing.Point(89, 45);
            this.tbPoblacion.Name = "tbPoblacion";
            this.tbPoblacion.PlaceholderText = "Población";
            this.tbPoblacion.Size = new System.Drawing.Size(65, 22);
            this.tbPoblacion.TabIndex = 0;
            this.tbPoblacion.TextChanged += new System.EventHandler(this.tbPoblacion_TextChanged);
            // 
            // tbLambda
            // 
            this.tbLambda.Location = new System.Drawing.Point(32, 20);
            this.tbLambda.Name = "tbLambda";
            this.tbLambda.PlaceholderText = "Lambda";
            this.tbLambda.Size = new System.Drawing.Size(100, 22);
            this.tbLambda.TabIndex = 1;
            this.tbLambda.TextChanged += new System.EventHandler(this.tbLambda_TextChanged);
            // 
            // tbMiu
            // 
            this.tbMiu.Location = new System.Drawing.Point(32, 20);
            this.tbMiu.Name = "tbMiu";
            this.tbMiu.PlaceholderText = "Miu";
            this.tbMiu.Size = new System.Drawing.Size(100, 22);
            this.tbMiu.TabIndex = 2;
            this.tbMiu.TextChanged += new System.EventHandler(this.tbMiu_TextChanged);
            // 
            // btResolver
            // 
            this.btResolver.Location = new System.Drawing.Point(301, 196);
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
            this.rbtInfinita.Location = new System.Drawing.Point(12, 20);
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
            this.rbtFinita.Location = new System.Drawing.Point(12, 45);
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
            this.gbPoblacion.Size = new System.Drawing.Size(160, 82);
            this.gbPoblacion.TabIndex = 7;
            this.gbPoblacion.TabStop = false;
            this.gbPoblacion.Text = "Población";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "M";
            this.toolTip1.SetToolTip(this.label5, "■ Población.");
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(32, 20);
            this.tbN.Name = "tbN";
            this.tbN.PlaceholderText = "Clientes";
            this.tbN.Size = new System.Drawing.Size(100, 22);
            this.tbN.TabIndex = 8;
            this.tbN.TextChanged += new System.EventHandler(this.tbN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "λ";
            this.toolTip1.SetToolTip(this.label1, "■ Tasa de llegada.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "μ";
            this.toolTip1.SetToolTip(this.label2, "■ Tasa de servicio.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "n";
            this.toolTip1.SetToolTip(this.label3, "■ Cantidad de clientes.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "k";
            this.toolTip1.SetToolTip(this.label4, "■ Número de servidores.");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = "CS";
            this.toolTip1.SetToolTip(this.label13, "■ Costo unitario por el servidor.\r\n■ Alquiler\r\n■ Salario\r\n■ Funcionamiento");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "CTE";
            this.toolTip1.SetToolTip(this.label12, "■ Costo unitario por tiempo en cola.\r\n■ Tiempo de espera de los clientes.");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "CTS";
            this.toolTip1.SetToolTip(this.label11, "■ Costo unitario por tiempo en el sistema.\r\n■ Tiempo en el sistema de los cliente" +
        "s.\r\n");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "CTSE";
            this.toolTip1.SetToolTip(this.label10, "■ Costo unitario por tiempo de servicio.\r\n■ Tiempo en el servicio de los clientes" +
        ".\r\n");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Horas de trabajo";
            this.toolTip1.SetToolTip(this.label6, "■ Número de servidores.");
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.tbCS);
            this.groupBox4.Controls.Add(this.tbCTSE);
            this.groupBox4.Controls.Add(this.tbCTS);
            this.groupBox4.Controls.Add(this.tbCTE);
            this.groupBox4.Location = new System.Drawing.Point(344, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 162);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Costos Unitarios";
            // 
            // tbCS
            // 
            this.tbCS.Location = new System.Drawing.Point(47, 120);
            this.tbCS.Name = "tbCS";
            this.tbCS.PlaceholderText = "CS";
            this.tbCS.Size = new System.Drawing.Size(100, 22);
            this.tbCS.TabIndex = 3;
            this.tbCS.TextChanged += new System.EventHandler(this.tbCS_TextChanged);
            // 
            // tbCTSE
            // 
            this.tbCTSE.Location = new System.Drawing.Point(47, 90);
            this.tbCTSE.Name = "tbCTSE";
            this.tbCTSE.PlaceholderText = "CTSE";
            this.tbCTSE.Size = new System.Drawing.Size(100, 22);
            this.tbCTSE.TabIndex = 2;
            this.tbCTSE.TextChanged += new System.EventHandler(this.tbCTSE_TextChanged);
            // 
            // tbCTS
            // 
            this.tbCTS.Location = new System.Drawing.Point(47, 60);
            this.tbCTS.Name = "tbCTS";
            this.tbCTS.PlaceholderText = "CTS";
            this.tbCTS.Size = new System.Drawing.Size(100, 22);
            this.tbCTS.TabIndex = 1;
            this.tbCTS.TextChanged += new System.EventHandler(this.tbCTS_TextChanged);
            // 
            // tbCTE
            // 
            this.tbCTE.Location = new System.Drawing.Point(47, 30);
            this.tbCTE.Name = "tbCTE";
            this.tbCTE.PlaceholderText = "CTE";
            this.tbCTE.Size = new System.Drawing.Size(100, 22);
            this.tbCTE.TabIndex = 0;
            this.tbCTE.TextChanged += new System.EventHandler(this.tbCTE_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbServidor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 50);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servidores";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbLambda);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(178, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 50);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tasa de llegada";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbMiu);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(178, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 50);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tasa de servicio";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbN);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(178, 124);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(160, 50);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Clientes";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbTiempo);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(12, 180);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(260, 50);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Día laborable";
            // 
            // tbTiempo
            // 
            this.tbTiempo.Location = new System.Drawing.Point(114, 17);
            this.tbTiempo.Name = "tbTiempo";
            this.tbTiempo.PlaceholderText = "Tiempo de trabajo";
            this.tbTiempo.Size = new System.Drawing.Size(108, 22);
            this.tbTiempo.TabIndex = 3;
            this.tbTiempo.TextChanged += new System.EventHandler(this.tbTiempo_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(516, 287);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbPoblacion);
            this.Controls.Add(this.btResolver);
            this.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Teoría de Colas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPoblacion.ResumeLayout(false);
            this.gbPoblacion.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

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
        private GroupBox groupBox4;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox tbCS;
        private TextBox tbCTSE;
        private TextBox tbCTS;
        private TextBox tbCTE;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private TextBox tbTiempo;
        private Label label6;
    }
}