namespace TCTS
{
    partial class FormPFCM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWsubN = new System.Windows.Forms.TextBox();
            this.tbWsubQ = new System.Windows.Forms.TextBox();
            this.tbW = new System.Windows.Forms.TextBox();
            this.tbLsubN = new System.Windows.Forms.TextBox();
            this.tbLsubQ = new System.Windows.Forms.TextBox();
            this.tbL = new System.Windows.Forms.TextBox();
            this.tbPsubN = new System.Windows.Forms.TextBox();
            this.tbPsubZero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "P₀";
            this.toolTip1.SetToolTip(this.label9, "■ Probabilidad de hallar el sistema completamente vacío, de que todos los servido" +
        "res estén desocupados u ociosos a la vez.");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Wn";
            this.toolTip1.SetToolTip(this.label8, "■ Tiempo esperado en cola para colas no vacías.");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Wq";
            this.toolTip1.SetToolTip(this.label7, "■ Tiempo esperado en cola.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "W";
            this.toolTip1.SetToolTip(this.label6, "■ Tiempo esperado en el sistema.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Ln";
            this.toolTip1.SetToolTip(this.label5, "■ Número esperado de clientes en la cola no vacía.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Lq";
            this.toolTip1.SetToolTip(this.label4, "■ Número esperado de clientes en la cola.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "L";
            this.toolTip1.SetToolTip(this.label3, "■ Núermo esperado de clientes en el sistema.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Pn";
            this.toolTip1.SetToolTip(this.label2, "■ Probabilidad de hallar exactamente n clientes dentro del sistema.");
            // 
            // tbWsubN
            // 
            this.tbWsubN.Location = new System.Drawing.Point(79, 109);
            this.tbWsubN.Name = "tbWsubN";
            this.tbWsubN.PlaceholderText = "Wn";
            this.tbWsubN.ReadOnly = true;
            this.tbWsubN.Size = new System.Drawing.Size(100, 23);
            this.tbWsubN.TabIndex = 26;
            // 
            // tbWsubQ
            // 
            this.tbWsubQ.Location = new System.Drawing.Point(79, 69);
            this.tbWsubQ.Name = "tbWsubQ";
            this.tbWsubQ.PlaceholderText = "Wq";
            this.tbWsubQ.ReadOnly = true;
            this.tbWsubQ.Size = new System.Drawing.Size(100, 23);
            this.tbWsubQ.TabIndex = 25;
            // 
            // tbW
            // 
            this.tbW.Location = new System.Drawing.Point(79, 29);
            this.tbW.Name = "tbW";
            this.tbW.PlaceholderText = "W";
            this.tbW.ReadOnly = true;
            this.tbW.Size = new System.Drawing.Size(100, 23);
            this.tbW.TabIndex = 24;
            // 
            // tbLsubN
            // 
            this.tbLsubN.Location = new System.Drawing.Point(79, 109);
            this.tbLsubN.Name = "tbLsubN";
            this.tbLsubN.PlaceholderText = "Ln";
            this.tbLsubN.ReadOnly = true;
            this.tbLsubN.Size = new System.Drawing.Size(100, 23);
            this.tbLsubN.TabIndex = 23;
            // 
            // tbLsubQ
            // 
            this.tbLsubQ.Location = new System.Drawing.Point(79, 69);
            this.tbLsubQ.Name = "tbLsubQ";
            this.tbLsubQ.PlaceholderText = "Lq";
            this.tbLsubQ.ReadOnly = true;
            this.tbLsubQ.Size = new System.Drawing.Size(100, 23);
            this.tbLsubQ.TabIndex = 22;
            // 
            // tbL
            // 
            this.tbL.Location = new System.Drawing.Point(79, 32);
            this.tbL.Name = "tbL";
            this.tbL.PlaceholderText = "L";
            this.tbL.ReadOnly = true;
            this.tbL.Size = new System.Drawing.Size(100, 23);
            this.tbL.TabIndex = 21;
            // 
            // tbPsubN
            // 
            this.tbPsubN.Location = new System.Drawing.Point(72, 176);
            this.tbPsubN.Multiline = true;
            this.tbPsubN.Name = "tbPsubN";
            this.tbPsubN.PlaceholderText = "Pn";
            this.tbPsubN.ReadOnly = true;
            this.tbPsubN.Size = new System.Drawing.Size(100, 66);
            this.tbPsubN.TabIndex = 20;
            // 
            // tbPsubZero
            // 
            this.tbPsubZero.Location = new System.Drawing.Point(72, 29);
            this.tbPsubZero.Name = "tbPsubZero";
            this.tbPsubZero.PlaceholderText = "P₀";
            this.tbPsubZero.ReadOnly = true;
            this.tbPsubZero.Size = new System.Drawing.Size(100, 23);
            this.tbPsubZero.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPsubN);
            this.groupBox1.Controls.Add(this.tbPsubZero);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 248);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Probabilidad";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "PE";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 15);
            this.label10.TabIndex = 38;
            this.label10.Text = "PE";
            this.toolTip1.SetToolTip(this.label10, "■ Probabilidad de hallar el sistema completamente ocupado, de que un usuario que " +
        "llega tenga que esperar.\r\n■ Probabilidad de que haya k o más usuarios en el sist" +
        "ema.");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "PNE";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "PNE";
            this.toolTip1.SetToolTip(this.label1, "■ Probabilidad de no esperar.");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbL);
            this.groupBox2.Controls.Add(this.tbLsubQ);
            this.groupBox2.Controls.Add(this.tbLsubN);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(213, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 165);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "# esperado de clientes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbWsubN);
            this.groupBox3.Controls.Add(this.tbW);
            this.groupBox3.Controls.Add(this.tbWsubQ);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(414, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 165);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tiempo esperado";
            // 
            // FormPFCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 349);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPFCM";
            this.Text = "Población Finita Canal Múltiple";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbWsubN;
        private TextBox tbWsubQ;
        private TextBox tbW;
        private TextBox tbLsubN;
        private TextBox tbLsubQ;
        private TextBox tbL;
        private TextBox tbPsubN;
        private TextBox tbPsubZero;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox2;
        private Label label10;
        private TextBox textBox1;
        private Label label1;
        private ToolTip toolTip1;
    }
}