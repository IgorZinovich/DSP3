namespace Lab3
{
    partial class Window
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
            this.func = new System.Windows.Forms.PictureBox();
            this.dwt = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fwt = new System.Windows.Forms.PictureBox();
            this.odwt = new System.Windows.Forms.PictureBox();
            this.ofwt = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.func)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fwt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odwt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofwt)).BeginInit();
            this.SuspendLayout();
            // 
            // func
            // 
            this.func.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.func.Location = new System.Drawing.Point(25, 36);
            this.func.Name = "func";
            this.func.Size = new System.Drawing.Size(200, 150);
            this.func.TabIndex = 0;
            this.func.TabStop = false;
            // 
            // dwt
            // 
            this.dwt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dwt.Location = new System.Drawing.Point(287, 36);
            this.dwt.Name = "dwt";
            this.dwt.Size = new System.Drawing.Size(200, 150);
            this.dwt.TabIndex = 0;
            this.dwt.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fwt
            // 
            this.fwt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fwt.Location = new System.Drawing.Point(528, 36);
            this.fwt.Name = "fwt";
            this.fwt.Size = new System.Drawing.Size(200, 150);
            this.fwt.TabIndex = 0;
            this.fwt.TabStop = false;
            // 
            // odwt
            // 
            this.odwt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.odwt.Location = new System.Drawing.Point(287, 230);
            this.odwt.Name = "odwt";
            this.odwt.Size = new System.Drawing.Size(200, 150);
            this.odwt.TabIndex = 0;
            this.odwt.TabStop = false;
            // 
            // ofwt
            // 
            this.ofwt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ofwt.Location = new System.Drawing.Point(528, 230);
            this.ofwt.Name = "ofwt";
            this.ofwt.Size = new System.Drawing.Size(200, 150);
            this.ofwt.TabIndex = 0;
            this.ofwt.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "DWT";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(528, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "FWT";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(287, 207);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "DWT";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(528, 204);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "oFWT";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 402);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ofwt);
            this.Controls.Add(this.odwt);
            this.Controls.Add(this.fwt);
            this.Controls.Add(this.dwt);
            this.Controls.Add(this.func);
            this.Name = "Window";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.func)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fwt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odwt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofwt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox func;
        private System.Windows.Forms.PictureBox dwt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox fwt;
        private System.Windows.Forms.PictureBox odwt;
        private System.Windows.Forms.PictureBox ofwt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

