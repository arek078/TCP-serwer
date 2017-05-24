namespace TCPKlient
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
            this.Adres = new System.Windows.Forms.TextBox();
            this.info_o_polaczeniu = new System.Windows.Forms.ListBox();
            this.przycisk_polacz = new System.Windows.Forms.Button();
            this.my_port = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).BeginInit();
            this.SuspendLayout();
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(29, 13);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(367, 20);
            this.Adres.TabIndex = 0;
            this.Adres.Text = "Adres";
            // 
            // info_o_polaczeniu
            // 
            this.info_o_polaczeniu.FormattingEnabled = true;
            this.info_o_polaczeniu.Location = new System.Drawing.Point(29, 50);
            this.info_o_polaczeniu.Name = "info_o_polaczeniu";
            this.info_o_polaczeniu.Size = new System.Drawing.Size(515, 251);
            this.info_o_polaczeniu.TabIndex = 1;
            // 
            // przycisk_polacz
            // 
            this.przycisk_polacz.Location = new System.Drawing.Point(239, 314);
            this.przycisk_polacz.Name = "przycisk_polacz";
            this.przycisk_polacz.Size = new System.Drawing.Size(146, 40);
            this.przycisk_polacz.TabIndex = 2;
            this.przycisk_polacz.Text = "Polacz z";
            this.przycisk_polacz.UseVisualStyleBackColor = true;
            this.przycisk_polacz.Click += new System.EventHandler(this.przycisk_polacz_Click);
            // 
            // my_port
            // 
            this.my_port.Location = new System.Drawing.Point(424, 13);
            this.my_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.my_port.Name = "my_port";
            this.my_port.Size = new System.Drawing.Size(120, 20);
            this.my_port.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 387);
            this.Controls.Add(this.my_port);
            this.Controls.Add(this.przycisk_polacz);
            this.Controls.Add(this.info_o_polaczeniu);
            this.Controls.Add(this.Adres);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.ListBox info_o_polaczeniu;
        private System.Windows.Forms.Button przycisk_polacz;
        private System.Windows.Forms.NumericUpDown my_port;
    }
}

