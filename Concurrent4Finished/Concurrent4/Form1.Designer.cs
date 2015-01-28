namespace Concurrent4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStartFac1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStartFac2 = new System.Windows.Forms.Button();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblFull = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStartFac1);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factory1";
            // 
            // btnStartFac1
            // 
            this.btnStartFac1.Location = new System.Drawing.Point(6, 19);
            this.btnStartFac1.Name = "btnStartFac1";
            this.btnStartFac1.Size = new System.Drawing.Size(188, 75);
            this.btnStartFac1.TabIndex = 2;
            this.btnStartFac1.Text = "Start Factory";
            this.btnStartFac1.UseVisualStyleBackColor = true;
            this.btnStartFac1.Click += new System.EventHandler(this.btnStartFac1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStartFac2);
            this.groupBox2.Location = new System.Drawing.Point(218, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Factory2";
            // 
            // btnStartFac2
            // 
            this.btnStartFac2.Location = new System.Drawing.Point(6, 19);
            this.btnStartFac2.Name = "btnStartFac2";
            this.btnStartFac2.Size = new System.Drawing.Size(188, 75);
            this.btnStartFac2.TabIndex = 0;
            this.btnStartFac2.Text = "Start Factory";
            this.btnStartFac2.UseVisualStyleBackColor = true;
            this.btnStartFac2.Click += new System.EventHandler(this.btnStartFac2_Click);
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(12, 29);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(406, 19);
            this.pBar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Santas Sack";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 164);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 316);
            this.listBox1.TabIndex = 4;
            // 
            // lblFull
            // 
            this.lblFull.AutoSize = true;
            this.lblFull.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFull.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFull.Location = new System.Drawing.Point(268, 244);
            this.lblFull.Name = "lblFull";
            this.lblFull.Size = new System.Drawing.Size(75, 41);
            this.lblFull.TabIndex = 5;
            this.lblFull.Text = "Full";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start Santa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFull);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStartFac1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStartFac2;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblFull;
        private System.Windows.Forms.Button button1;
    }
}

