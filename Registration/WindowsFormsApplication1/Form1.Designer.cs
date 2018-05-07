namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboq = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtanswer = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Question";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Answer";
            // 
            // comboq
            // 
            this.comboq.FormattingEnabled = true;
            this.comboq.Items.AddRange(new object[] {
            "what is your hobby?",
            "whats your favourite color?",
            "whats your favourite character?",
            ""});
            this.comboq.Location = new System.Drawing.Point(144, 131);
            this.comboq.Name = "comboq";
            this.comboq.Size = new System.Drawing.Size(132, 21);
            this.comboq.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(144, 23);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(132, 20);
            this.txtname.TabIndex = 5;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(144, 73);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(132, 20);
            this.txtpassword.TabIndex = 6;
            // 
            // txtanswer
            // 
            this.txtanswer.Location = new System.Drawing.Point(144, 179);
            this.txtanswer.Name = "txtanswer";
            this.txtanswer.Size = new System.Drawing.Size(132, 20);
            this.txtanswer.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(177, 223);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(46, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password\'";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(34, 222);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(33, 13);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Login";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtanswer);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.comboq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboq;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtanswer;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

