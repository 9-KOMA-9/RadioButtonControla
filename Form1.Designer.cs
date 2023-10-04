namespace RadioButtonKontrola
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.avion = new System.Windows.Forms.RadioButton();
            this.autobus = new System.Windows.Forms.RadioButton();
            this.auto = new System.Windows.Forms.RadioButton();
            this.butOdabir = new System.Windows.Forms.Button();
            this.ispis = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.auto);
            this.groupBox1.Controls.Add(this.autobus);
            this.groupBox1.Controls.Add(this.avion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(196, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odaberite prijevoz";
            // 
            // avion
            // 
            this.avion.AutoSize = true;
            this.avion.Location = new System.Drawing.Point(6, 28);
            this.avion.Name = "avion";
            this.avion.Size = new System.Drawing.Size(71, 25);
            this.avion.TabIndex = 0;
            this.avion.TabStop = true;
            this.avion.Text = "Avion";
            this.avion.UseVisualStyleBackColor = true;
            // 
            // autobus
            // 
            this.autobus.AutoSize = true;
            this.autobus.Location = new System.Drawing.Point(6, 72);
            this.autobus.Name = "autobus";
            this.autobus.Size = new System.Drawing.Size(92, 25);
            this.autobus.TabIndex = 1;
            this.autobus.TabStop = true;
            this.autobus.Text = "Autobus";
            this.autobus.UseVisualStyleBackColor = true;
            // 
            // auto
            // 
            this.auto.AutoSize = true;
            this.auto.Location = new System.Drawing.Point(6, 117);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(162, 25);
            this.auto.TabIndex = 2;
            this.auto.TabStop = true;
            this.auto.Text = "Vlastiti automobil";
            this.auto.UseVisualStyleBackColor = true;
            // 
            // butOdabir
            // 
            this.butOdabir.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butOdabir.Location = new System.Drawing.Point(196, 216);
            this.butOdabir.Name = "butOdabir";
            this.butOdabir.Size = new System.Drawing.Size(234, 51);
            this.butOdabir.TabIndex = 1;
            this.butOdabir.Text = "Rezerviraj";
            this.butOdabir.UseVisualStyleBackColor = true;
            this.butOdabir.Click += new System.EventHandler(this.butOdabir_Click);
            // 
            // ispis
            // 
            this.ispis.Location = new System.Drawing.Point(194, 292);
            this.ispis.Multiline = true;
            this.ispis.Name = "ispis";
            this.ispis.Size = new System.Drawing.Size(241, 64);
            this.ispis.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ispis);
            this.Controls.Add(this.butOdabir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton auto;
        private System.Windows.Forms.RadioButton autobus;
        private System.Windows.Forms.RadioButton avion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button butOdabir;
        private System.Windows.Forms.TextBox ispis;
    }
}

