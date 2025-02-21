namespace WindowsForm_bai2PhepTinh_CoBan
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
            this.txtso1 = new System.Windows.Forms.Label();
            this.txtSOTHU1 = new System.Windows.Forms.TextBox();
            this.txtso2 = new System.Windows.Forms.Label();
            this.txtSOTHU2 = new System.Windows.Forms.TextBox();
            this.txtKq = new System.Windows.Forms.Label();
            this.txtSOTHU3 = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHEP TINH CO BAN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtso1
            // 
            this.txtso1.AutoSize = true;
            this.txtso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtso1.Location = new System.Drawing.Point(36, 110);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(96, 24);
            this.txtso1.TabIndex = 0;
            this.txtso1.Text = "SO THU 1";
            this.txtso1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSOTHU1
            // 
            this.txtSOTHU1.Location = new System.Drawing.Point(138, 113);
            this.txtSOTHU1.Name = "txtSOTHU1";
            this.txtSOTHU1.Size = new System.Drawing.Size(101, 20);
            this.txtSOTHU1.TabIndex = 1;
            this.txtSOTHU1.Text = "txtso1";
            // 
            // txtso2
            // 
            this.txtso2.AutoSize = true;
            this.txtso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtso2.Location = new System.Drawing.Point(36, 134);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(96, 24);
            this.txtso2.TabIndex = 0;
            this.txtso2.Text = "SO THU 2";
            this.txtso2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSOTHU2
            // 
            this.txtSOTHU2.Location = new System.Drawing.Point(139, 137);
            this.txtSOTHU2.Name = "txtSOTHU2";
            this.txtSOTHU2.Size = new System.Drawing.Size(100, 20);
            this.txtSOTHU2.TabIndex = 1;
            this.txtSOTHU2.Text = "txtso2";
            // 
            // txtKq
            // 
            this.txtKq.AutoSize = true;
            this.txtKq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKq.Location = new System.Drawing.Point(36, 158);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(93, 24);
            this.txtKq.TabIndex = 0;
            this.txtKq.Text = "KET QUA";
            this.txtKq.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSOTHU3
            // 
            this.txtSOTHU3.Location = new System.Drawing.Point(139, 161);
            this.txtSOTHU3.Name = "txtSOTHU3";
            this.txtSOTHU3.Size = new System.Drawing.Size(100, 20);
            this.txtSOTHU3.TabIndex = 1;
            this.txtSOTHU3.Text = "txtKQ";
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(82, 187);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(75, 63);
            this.btnCong.TabIndex = 2;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(164, 187);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(75, 63);
            this.btnTru.TabIndex = 2;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(245, 187);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(75, 63);
            this.btnNhan.TabIndex = 2;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(326, 187);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(75, 63);
            this.btnChia.TabIndex = 2;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtSOTHU3);
            this.Controls.Add(this.txtSOTHU2);
            this.Controls.Add(this.txtSOTHU1);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtso1;
        private System.Windows.Forms.TextBox txtSOTHU1;
        private System.Windows.Forms.Label txtso2;
        private System.Windows.Forms.TextBox txtSOTHU2;
        private System.Windows.Forms.Label txtKq;
        private System.Windows.Forms.TextBox txtSOTHU3;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
    }
}

