namespace cshap.bai6._1
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
            this.btnxkq = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdiemhk1 = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.txtdtb = new System.Windows.Forms.TextBox();
            this.txtdiemhk2 = new System.Windows.Forms.TextBox();
            this.txtxlhl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnxkq
            // 
            this.btnxkq.Location = new System.Drawing.Point(311, 392);
            this.btnxkq.Name = "btnxkq";
            this.btnxkq.Size = new System.Drawing.Size(104, 23);
            this.btnxkq.TabIndex = 1;
            this.btnxkq.Text = "Xem Kết Quả";
            this.btnxkq.UseVisualStyleBackColor = true;
            this.btnxkq.Click += new System.EventHandler(this.btnxkq_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "kết quả học tập";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Điểm hk1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "xếp loại học lực";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "kết quả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Điểm trung bình";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Điểm hk2";
            // 
            // txtdiemhk1
            // 
            this.txtdiemhk1.Location = new System.Drawing.Point(196, 87);
            this.txtdiemhk1.Name = "txtdiemhk1";
            this.txtdiemhk1.Size = new System.Drawing.Size(326, 20);
            this.txtdiemhk1.TabIndex = 9;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(196, 250);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(326, 20);
            this.txtkq.TabIndex = 10;
            // 
            // txtdtb
            // 
            this.txtdtb.Location = new System.Drawing.Point(196, 189);
            this.txtdtb.Name = "txtdtb";
            this.txtdtb.Size = new System.Drawing.Size(326, 20);
            this.txtdtb.TabIndex = 11;
            // 
            // txtdiemhk2
            // 
            this.txtdiemhk2.Location = new System.Drawing.Point(196, 142);
            this.txtdiemhk2.Name = "txtdiemhk2";
            this.txtdiemhk2.Size = new System.Drawing.Size(326, 20);
            this.txtdiemhk2.TabIndex = 12;
            // 
            // txtxlhl
            // 
            this.txtxlhl.Location = new System.Drawing.Point(196, 304);
            this.txtxlhl.Name = "txtxlhl";
            this.txtxlhl.Size = new System.Drawing.Size(326, 20);
            this.txtxlhl.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtxlhl);
            this.Controls.Add(this.txtdiemhk2);
            this.Controls.Add(this.txtdtb);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtdiemhk1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnxkq);
            this.Name = "Form1";
            this.Text = "C";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnxkq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdiemhk1;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.TextBox txtdtb;
        private System.Windows.Forms.TextBox txtdiemhk2;
        private System.Windows.Forms.TextBox txtxlhl;
    }
}

