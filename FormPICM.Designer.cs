namespace TCTS
{
    partial class FormPICM
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
            this.tbWn = new System.Windows.Forms.TextBox();
            this.tbWq = new System.Windows.Forms.TextBox();
            this.tbW = new System.Windows.Forms.TextBox();
            this.tbLn = new System.Windows.Forms.TextBox();
            this.tbLq = new System.Windows.Forms.TextBox();
            this.tbL = new System.Windows.Forms.TextBox();
            this.tbPn = new System.Windows.Forms.TextBox();
            this.tbP0 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPNe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPk = new System.Windows.Forms.TextBox();
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
            this.label9.Location = new System.Drawing.Point(12, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "P₀";
            this.toolTip1.SetToolTip(this.label9, "■ Probabilidad de hallar el sistema completamente vacío.\r\n■ Probabilidad de que t" +
        "odos los servidores estén desocupados u ociosos a la vez.");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Wn";
            this.toolTip1.SetToolTip(this.label8, "■ Tiempo esperado en cola para colas no vacías.");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Wq";
            this.toolTip1.SetToolTip(this.label7, "■ Tiempo esperado en cola.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "W";
            this.toolTip1.SetToolTip(this.label6, "■ Tiempo esperado en el sistema.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Ln";
            this.toolTip1.SetToolTip(this.label5, "■ Número esperado de clientes en la cola no vacía.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Lq";
            this.toolTip1.SetToolTip(this.label4, "■ Número esperado de clientes en la cola.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "L";
            this.toolTip1.SetToolTip(this.label3, "■ Número esperado de clientes en el sistema.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Pn";
            this.toolTip1.SetToolTip(this.label2, "■ Probabilidad de hallar exactamente n clientes dentro del sistema.");
            // 
            // tbWn
            // 
            this.tbWn.Location = new System.Drawing.Point(42, 90);
            this.tbWn.Name = "tbWn";
            this.tbWn.PlaceholderText = "Wn";
            this.tbWn.ReadOnly = true;
            this.tbWn.Size = new System.Drawing.Size(100, 23);
            this.tbWn.TabIndex = 26;
            // 
            // tbWq
            // 
            this.tbWq.Location = new System.Drawing.Point(42, 60);
            this.tbWq.Name = "tbWq";
            this.tbWq.PlaceholderText = "Wq";
            this.tbWq.ReadOnly = true;
            this.tbWq.Size = new System.Drawing.Size(100, 23);
            this.tbWq.TabIndex = 25;
            // 
            // tbW
            // 
            this.tbW.Location = new System.Drawing.Point(42, 30);
            this.tbW.Name = "tbW";
            this.tbW.PlaceholderText = "W";
            this.tbW.ReadOnly = true;
            this.tbW.Size = new System.Drawing.Size(100, 23);
            this.tbW.TabIndex = 24;
            // 
            // tbLn
            // 
            this.tbLn.Location = new System.Drawing.Point(42, 90);
            this.tbLn.Name = "tbLn";
            this.tbLn.PlaceholderText = "Ln";
            this.tbLn.ReadOnly = true;
            this.tbLn.Size = new System.Drawing.Size(100, 23);
            this.tbLn.TabIndex = 23;
            // 
            // tbLq
            // 
            this.tbLq.Location = new System.Drawing.Point(42, 60);
            this.tbLq.Name = "tbLq";
            this.tbLq.PlaceholderText = "Lq";
            this.tbLq.ReadOnly = true;
            this.tbLq.Size = new System.Drawing.Size(100, 23);
            this.tbLq.TabIndex = 22;
            // 
            // tbL
            // 
            this.tbL.Location = new System.Drawing.Point(42, 30);
            this.tbL.Name = "tbL";
            this.tbL.PlaceholderText = "L";
            this.tbL.ReadOnly = true;
            this.tbL.Size = new System.Drawing.Size(100, 23);
            this.tbL.TabIndex = 21;
            // 
            // tbPn
            // 
            this.tbPn.Location = new System.Drawing.Point(47, 120);
            this.tbPn.Multiline = true;
            this.tbPn.Name = "tbPn";
            this.tbPn.PlaceholderText = "Pn";
            this.tbPn.ReadOnly = true;
            this.tbPn.Size = new System.Drawing.Size(100, 129);
            this.tbPn.TabIndex = 20;
            // 
            // tbP0
            // 
            this.tbP0.Location = new System.Drawing.Point(47, 30);
            this.tbP0.Name = "tbP0";
            this.tbP0.PlaceholderText = "P₀";
            this.tbP0.ReadOnly = true;
            this.tbP0.Size = new System.Drawing.Size(100, 23);
            this.tbP0.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPNe);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbPk);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbP0);
            this.groupBox1.Controls.Add(this.tbPn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 266);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Probabilidad";
            // 
            // tbPNe
            // 
            this.tbPNe.Location = new System.Drawing.Point(47, 90);
            this.tbPNe.Name = "tbPNe";
            this.tbPNe.PlaceholderText = "PNE";
            this.tbPNe.ReadOnly = true;
            this.tbPNe.Size = new System.Drawing.Size(100, 23);
            this.tbPNe.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 15);
            this.label10.TabIndex = 38;
            this.label10.Text = "PNE";
            this.toolTip1.SetToolTip(this.label10, "■ Probabilidad de que un usuario que llega no tenga que esperar.");
            // 
            // tbPk
            // 
            this.tbPk.Location = new System.Drawing.Point(47, 60);
            this.tbPk.Name = "tbPk";
            this.tbPk.PlaceholderText = "Pk";
            this.tbPk.ReadOnly = true;
            this.tbPk.Size = new System.Drawing.Size(100, 23);
            this.tbPk.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Pk";
            this.toolTip1.SetToolTip(this.label1, "■ Probabilidad de que un usuario que llega tenga que esperar.\r\n■ Probabilidad de " +
        "que haya k o más usuarios en el sistema.");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbL);
            this.groupBox2.Controls.Add(this.tbLq);
            this.groupBox2.Controls.Add(this.tbLn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(178, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 130);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "# Esperado de clientes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbWn);
            this.groupBox3.Controls.Add(this.tbW);
            this.groupBox3.Controls.Add(this.tbWq);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(178, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 130);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tiempo esperado";
            // 
            // FormPICM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 291);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPICM";
            this.Text = " Población Infinita Canal Múltiple";
            this.Load += new System.EventHandler(this.FormPICM_Load);
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
        private TextBox tbWn;
        private TextBox tbWq;
        private TextBox tbW;
        private TextBox tbLn;
        private TextBox tbLq;
        private TextBox tbL;
        private TextBox tbPn;
        private TextBox tbP0;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox tbPNe;
        private Label label10;
        private TextBox tbPk;
        private Label label1;
        private ToolTip toolTip1;
    }
}