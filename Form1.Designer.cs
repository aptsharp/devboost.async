namespace SincronoAssincrono
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
            this.Sincrono = new System.Windows.Forms.Button();
            this.Assincrono = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Sincrono
            // 
            this.Sincrono.Location = new System.Drawing.Point(47, 31);
            this.Sincrono.Name = "Sincrono";
            this.Sincrono.Size = new System.Drawing.Size(75, 48);
            this.Sincrono.TabIndex = 0;
            this.Sincrono.Text = "Sincrono";
            this.Sincrono.UseVisualStyleBackColor = true;
            this.Sincrono.Click += new System.EventHandler(this.button1_Click);
            // 
            // Assincrono
            // 
            this.Assincrono.Location = new System.Drawing.Point(47, 102);
            this.Assincrono.Name = "Assincrono";
            this.Assincrono.Size = new System.Drawing.Size(75, 50);
            this.Assincrono.TabIndex = 0;
            this.Assincrono.Text = "Assincrono";
            this.Assincrono.UseVisualStyleBackColor = true;
            this.Assincrono.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metodos Sincronos são executados passo a passo";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Metodos Assincronos são executados todos de uma vez.";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(136, 166);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(486, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 201);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Assincrono);
            this.Controls.Add(this.Sincrono);
            this.Name = "Form1";
            this.Text = "Sincrono & Assincrono";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sincrono;
        private System.Windows.Forms.Button Assincrono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Timer timer1;
    }
}

