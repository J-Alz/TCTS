namespace TCTS
{
    partial class FormCostos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCT = new System.Windows.Forms.TextBox();
            this.tbCTS = new System.Windows.Forms.TextBox();
            this.tbCTTSE = new System.Windows.Forms.TextBox();
            this.tbCTTS = new System.Windows.Forms.TextBox();
            this.tbCTTE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CTTE";
            this.toolTip1.SetToolTip(this.label1, "■ Costo diario por el tiempo de espera en cola.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CTTS";
            this.toolTip1.SetToolTip(this.label2, "■ Costo diario por el tiempo en el sistema.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "CTTSE";
            this.toolTip1.SetToolTip(this.label3, "■ Costo diario por el tiempo de servicio.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "CTS";
            this.toolTip1.SetToolTip(this.label4, "■ Costo diario del servidor.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "CT";
            this.toolTip1.SetToolTip(this.label5, "■ Costo total diario del sistema.");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCT);
            this.groupBox1.Controls.Add(this.tbCTS);
            this.groupBox1.Controls.Add(this.tbCTTSE);
            this.groupBox1.Controls.Add(this.tbCTTS);
            this.groupBox1.Controls.Add(this.tbCTTE);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 200);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Costos Totales";
            // 
            // tbCT
            // 
            this.tbCT.Location = new System.Drawing.Point(60, 160);
            this.tbCT.Name = "tbCT";
            this.tbCT.PlaceholderText = "CT";
            this.tbCT.ReadOnly = true;
            this.tbCT.Size = new System.Drawing.Size(100, 22);
            this.tbCT.TabIndex = 10;
            // 
            // tbCTS
            // 
            this.tbCTS.Location = new System.Drawing.Point(60, 120);
            this.tbCTS.Name = "tbCTS";
            this.tbCTS.PlaceholderText = "CTS";
            this.tbCTS.ReadOnly = true;
            this.tbCTS.Size = new System.Drawing.Size(100, 22);
            this.tbCTS.TabIndex = 9;
            // 
            // tbCTTSE
            // 
            this.tbCTTSE.Location = new System.Drawing.Point(60, 90);
            this.tbCTTSE.Name = "tbCTTSE";
            this.tbCTTSE.PlaceholderText = "CTTSE";
            this.tbCTTSE.ReadOnly = true;
            this.tbCTTSE.Size = new System.Drawing.Size(100, 22);
            this.tbCTTSE.TabIndex = 8;
            // 
            // tbCTTS
            // 
            this.tbCTTS.Location = new System.Drawing.Point(60, 60);
            this.tbCTTS.Name = "tbCTTS";
            this.tbCTTS.PlaceholderText = "CTTS";
            this.tbCTTS.ReadOnly = true;
            this.tbCTTS.Size = new System.Drawing.Size(100, 22);
            this.tbCTTS.TabIndex = 8;
            // 
            // tbCTTE
            // 
            this.tbCTTE.Location = new System.Drawing.Point(60, 30);
            this.tbCTTE.Name = "tbCTTE";
            this.tbCTTE.PlaceholderText = "CTTE";
            this.tbCTTE.ReadOnly = true;
            this.tbCTTE.Size = new System.Drawing.Size(100, 22);
            this.tbCTTE.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "----------------------------------------";
            // 
            // FormCostos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 231);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormCostos";
            this.Text = "Costos";
            this.Load += new System.EventHandler(this.FormCostos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private ToolTip toolTip1;
        private TextBox tbCT;
        private TextBox tbCTS;
        private TextBox tbCTTSE;
        private TextBox tbCTTS;
        private TextBox tbCTTE;
        private Label label6;
    }
}