namespace tcpserver
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
            this.przycisk_start = new System.Windows.Forms.Button();
            this.przycisk_stop = new System.Windows.Forms.Button();
            this.my_port = new System.Windows.Forms.NumericUpDown();
            this.Adres = new System.Windows.Forms.TextBox();
            this.info_o_polaczeniu = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).BeginInit();
            this.SuspendLayout();
            // 
            // przycisk_start
            // 
            this.przycisk_start.Location = new System.Drawing.Point(202, 429);
            this.przycisk_start.Name = "przycisk_start";
            this.przycisk_start.Size = new System.Drawing.Size(104, 53);
            this.przycisk_start.TabIndex = 0;
            this.przycisk_start.Text = "start";
            this.przycisk_start.UseVisualStyleBackColor = true;
            // 
            // przycisk_stop
            // 
            this.przycisk_stop.Location = new System.Drawing.Point(500, 429);
            this.przycisk_stop.Name = "przycisk_stop";
            this.przycisk_stop.Size = new System.Drawing.Size(121, 53);
            this.przycisk_stop.TabIndex = 1;
            this.przycisk_stop.Text = "stop";
            this.przycisk_stop.UseVisualStyleBackColor = true;
            this.przycisk_stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // my_port
            // 
            this.my_port.Location = new System.Drawing.Point(433, 13);
            this.my_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.my_port.Name = "my_port";
            this.my_port.Size = new System.Drawing.Size(360, 20);
            this.my_port.TabIndex = 2;
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(12, 12);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(356, 20);
            this.Adres.TabIndex = 3;
            this.Adres.Text = "Adres";
            // 
            // info_o_polaczeniu
            // 
            this.info_o_polaczeniu.FormattingEnabled = true;
            this.info_o_polaczeniu.Location = new System.Drawing.Point(12, 38);
            this.info_o_polaczeniu.Name = "info_o_polaczeniu";
            this.info_o_polaczeniu.Size = new System.Drawing.Size(781, 368);
            this.info_o_polaczeniu.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 509);
            this.Controls.Add(this.info_o_polaczeniu);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.my_port);
            this.Controls.Add(this.przycisk_stop);
            this.Controls.Add(this.przycisk_start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button przycisk_start;
        private System.Windows.Forms.Button przycisk_stop;
        private System.Windows.Forms.NumericUpDown my_port;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.ListBox info_o_polaczeniu;
    }
}

