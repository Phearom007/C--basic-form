namespace TestForm1
{
    partial class Login
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.lblpanel = new System.Windows.Forms.Label();
            this.btnx = new System.Windows.Forms.Button();
            this.lblun = new System.Windows.Forms.Label();
            this.lblpw = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnre = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnlogin.Location = new System.Drawing.Point(492, 454);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(190, 65);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.pic1);
            this.panel1.Controls.Add(this.lblpanel);
            this.panel1.Controls.Add(this.btnx);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 200);
            this.panel1.TabIndex = 1;
            // 
            // pic1
            // 
            this.pic1.Image = global::TestForm1.Properties.Resources.photo_2021_12_28_21_48_31;
            this.pic1.Location = new System.Drawing.Point(12, 15);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(250, 171);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // lblpanel
            // 
            this.lblpanel.AutoSize = true;
            this.lblpanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblpanel.ForeColor = System.Drawing.Color.White;
            this.lblpanel.Location = new System.Drawing.Point(282, 68);
            this.lblpanel.Name = "lblpanel";
            this.lblpanel.Size = new System.Drawing.Size(177, 45);
            this.lblpanel.TabIndex = 2;
            this.lblpanel.Text = "Panel User";
            // 
            // btnx
            // 
            this.btnx.BackColor = System.Drawing.Color.Red;
            this.btnx.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnx.ForeColor = System.Drawing.Color.White;
            this.btnx.Location = new System.Drawing.Point(1058, 30);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(90, 74);
            this.btnx.TabIndex = 0;
            this.btnx.Text = "X";
            this.btnx.UseVisualStyleBackColor = false;
            this.btnx.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblun
            // 
            this.lblun.AutoSize = true;
            this.lblun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblun.Location = new System.Drawing.Point(64, 280);
            this.lblun.Name = "lblun";
            this.lblun.Size = new System.Drawing.Size(245, 45);
            this.lblun.TabIndex = 2;
            this.lblun.Text = "Enter Username";
            // 
            // lblpw
            // 
            this.lblpw.AutoSize = true;
            this.lblpw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblpw.Location = new System.Drawing.Point(64, 368);
            this.lblpw.Name = "lblpw";
            this.lblpw.Size = new System.Drawing.Size(235, 45);
            this.lblpw.TabIndex = 2;
            this.lblpw.Text = "Enter Password";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(353, 281);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(456, 50);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(353, 361);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(456, 50);
            this.textBox2.TabIndex = 3;
            // 
            // btnre
            // 
            this.btnre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnre.Location = new System.Drawing.Point(492, 549);
            this.btnre.Name = "btnre";
            this.btnre.Size = new System.Drawing.Size(190, 60);
            this.btnre.TabIndex = 0;
            this.btnre.Text = "Register";
            this.btnre.UseVisualStyleBackColor = false;
            this.btnre.Click += new System.EventHandler(this.button3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 675);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblpw);
            this.Controls.Add(this.lblun);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnre);
            this.Controls.Add(this.btnlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnlogin;
        private Panel panel1;
        private PictureBox pic1;
        private Label lblpanel;
        private Button btnx;
        private Label lblun;
        private Label lblpw;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnre;
    }
}