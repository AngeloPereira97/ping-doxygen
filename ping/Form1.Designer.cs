namespace ping
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer_ping = new System.Windows.Forms.Timer(this.components);
            this.btn_start = new System.Windows.Forms.Button();
            this.ip_textbox = new System.Windows.Forms.TextBox();
            this.textout = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // timer_ping
            // 
            this.timer_ping.Interval = 1000;
            this.timer_ping.Tick += new System.EventHandler(this.timer_ping_Tick);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(73, 55);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // ip_textbox
            // 
            this.ip_textbox.Location = new System.Drawing.Point(239, 55);
            this.ip_textbox.Name = "ip_textbox";
            this.ip_textbox.Size = new System.Drawing.Size(100, 20);
            this.ip_textbox.TabIndex = 1;
            // 
            // textout
            // 
            this.textout.Location = new System.Drawing.Point(396, 55);
            this.textout.Name = "textout";
            this.textout.Size = new System.Drawing.Size(328, 205);
            this.textout.TabIndex = 2;
            this.textout.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textout);
            this.Controls.Add(this.ip_textbox);
            this.Controls.Add(this.btn_start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_ping;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox ip_textbox;
        private System.Windows.Forms.RichTextBox textout;
    }
}

