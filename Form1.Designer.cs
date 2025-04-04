namespace PTBac2
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
            this.txtNumA = new System.Windows.Forms.TextBox();
            this.txtNumB = new System.Windows.Forms.TextBox();
            this.txtNumC = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "C:";
            // 
            // txtNumA
            // 
            this.txtNumA.Location = new System.Drawing.Point(191, 29);
            this.txtNumA.Name = "txtNumA";
            this.txtNumA.Size = new System.Drawing.Size(309, 22);
            this.txtNumA.TabIndex = 3;
            // 
            // txtNumB
            // 
            this.txtNumB.Location = new System.Drawing.Point(191, 68);
            this.txtNumB.Name = "txtNumB";
            this.txtNumB.Size = new System.Drawing.Size(309, 22);
            this.txtNumB.TabIndex = 4;
            // 
            // txtNumC
            // 
            this.txtNumC.Location = new System.Drawing.Point(191, 114);
            this.txtNumC.Name = "txtNumC";
            this.txtNumC.Size = new System.Drawing.Size(309, 22);
            this.txtNumC.TabIndex = 5;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(35, 271);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 6;
            this.btnTinh.Text = "Giải ";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(243, 271);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kết Quả";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(191, 159);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(309, 84);
            this.txtResult.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtNumC);
            this.Controls.Add(this.txtNumB);
            this.Controls.Add(this.txtNumA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumA;
        private System.Windows.Forms.TextBox txtNumB;
        private System.Windows.Forms.TextBox txtNumC;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResult;
    }
}

