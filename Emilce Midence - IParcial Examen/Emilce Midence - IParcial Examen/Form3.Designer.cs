
namespace Emilce_Midence___IParcial_Examen
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DesdenumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.MultiplotextBox1 = new System.Windows.Forms.TextBox();
            this.HastanumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Listarbutton1 = new System.Windows.Forms.Button();
            this.ListalistBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.DesdenumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HastanumericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multiplos de X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Listar multiplos de";
            // 
            // DesdenumericUpDown1
            // 
            this.DesdenumericUpDown1.Location = new System.Drawing.Point(101, 203);
            this.DesdenumericUpDown1.Name = "DesdenumericUpDown1";
            this.DesdenumericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.DesdenumericUpDown1.TabIndex = 2;
            // 
            // MultiplotextBox1
            // 
            this.MultiplotextBox1.Location = new System.Drawing.Point(209, 151);
            this.MultiplotextBox1.Name = "MultiplotextBox1";
            this.MultiplotextBox1.Size = new System.Drawing.Size(137, 20);
            this.MultiplotextBox1.TabIndex = 3;
            // 
            // HastanumericUpDown2
            // 
            this.HastanumericUpDown2.Location = new System.Drawing.Point(325, 203);
            this.HastanumericUpDown2.Name = "HastanumericUpDown2";
            this.HastanumericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.HastanumericUpDown2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasta";
            // 
            // Listarbutton1
            // 
            this.Listarbutton1.Location = new System.Drawing.Point(249, 266);
            this.Listarbutton1.Name = "Listarbutton1";
            this.Listarbutton1.Size = new System.Drawing.Size(75, 23);
            this.Listarbutton1.TabIndex = 6;
            this.Listarbutton1.Text = "Listar";
            this.Listarbutton1.UseVisualStyleBackColor = true;
            this.Listarbutton1.Click += new System.EventHandler(this.Listarbutton1_Click);
            // 
            // ListalistBox1
            // 
            this.ListalistBox1.FormattingEnabled = true;
            this.ListalistBox1.Location = new System.Drawing.Point(158, 309);
            this.ListalistBox1.Name = "ListalistBox1";
            this.ListalistBox1.Size = new System.Drawing.Size(257, 121);
            this.ListalistBox1.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListalistBox1);
            this.Controls.Add(this.Listarbutton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HastanumericUpDown2);
            this.Controls.Add(this.MultiplotextBox1);
            this.Controls.Add(this.DesdenumericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.DesdenumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HastanumericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown DesdenumericUpDown1;
        private System.Windows.Forms.TextBox MultiplotextBox1;
        private System.Windows.Forms.NumericUpDown HastanumericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Listarbutton1;
        private System.Windows.Forms.ListBox ListalistBox1;
    }
}