namespace ImageFilters
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnZGraph = new System.Windows.Forms.Button();
            this.Filter_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Time_L = new System.Windows.Forms.Label();
            this.Time_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Alpha_RB = new System.Windows.Forms.RadioButton();
            this.Adaptive_RB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Count_RB = new System.Windows.Forms.RadioButton();
            this.Quick_RB = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Rondom_RB2 = new System.Windows.Forms.RadioButton();
            this.Count_RB2 = new System.Windows.Forms.RadioButton();
            this.T_lb = new System.Windows.Forms.Label();
            this.T_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxW_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 440);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(12, 458);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(126, 62);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open Image";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnZGraph
            // 
            this.btnZGraph.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZGraph.Location = new System.Drawing.Point(322, 460);
            this.btnZGraph.Name = "btnZGraph";
            this.btnZGraph.Size = new System.Drawing.Size(126, 62);
            this.btnZGraph.TabIndex = 3;
            this.btnZGraph.Text = "Z Graph Example";
            this.btnZGraph.UseVisualStyleBackColor = true;
            this.btnZGraph.Click += new System.EventHandler(this.btnZGraph_Click);
            // 
            // Filter_btn
            // 
            this.Filter_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter_btn.Location = new System.Drawing.Point(157, 460);
            this.Filter_btn.Name = "Filter_btn";
            this.Filter_btn.Size = new System.Drawing.Size(116, 62);
            this.Filter_btn.TabIndex = 4;
            this.Filter_btn.Text = "Filter";
            this.Filter_btn.UseVisualStyleBackColor = true;
            this.Filter_btn.Click += new System.EventHandler(this.Filter_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(803, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(436, 440);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Time_L
            // 
            this.Time_L.AutoSize = true;
            this.Time_L.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_L.Location = new System.Drawing.Point(472, 480);
            this.Time_L.Name = "Time_L";
            this.Time_L.Size = new System.Drawing.Size(139, 19);
            this.Time_L.TabIndex = 6;
            this.Time_L.Text = "Time spanning :";
            // 
            // Time_lbl
            // 
            this.Time_lbl.AutoSize = true;
            this.Time_lbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_lbl.Location = new System.Drawing.Point(617, 480);
            this.Time_lbl.Name = "Time_lbl";
            this.Time_lbl.Size = new System.Drawing.Size(59, 19);
            this.Time_lbl.TabIndex = 7;
            this.Time_lbl.Text = "label2";
            this.Time_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Alpha_RB);
            this.groupBox1.Controls.Add(this.Adaptive_RB);
            this.groupBox1.Location = new System.Drawing.Point(459, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Methods";
            // 
            // Alpha_RB
            // 
            this.Alpha_RB.AutoSize = true;
            this.Alpha_RB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alpha_RB.Location = new System.Drawing.Point(6, 63);
            this.Alpha_RB.Name = "Alpha_RB";
            this.Alpha_RB.Size = new System.Drawing.Size(117, 23);
            this.Alpha_RB.TabIndex = 1;
            this.Alpha_RB.TabStop = true;
            this.Alpha_RB.Text = "Alpha Trim";
            this.Alpha_RB.UseVisualStyleBackColor = true;
            this.Alpha_RB.CheckedChanged += new System.EventHandler(this.Alpha_RB_CheckedChanged);
            // 
            // Adaptive_RB
            // 
            this.Adaptive_RB.AutoSize = true;
            this.Adaptive_RB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adaptive_RB.Location = new System.Drawing.Point(6, 19);
            this.Adaptive_RB.Name = "Adaptive_RB";
            this.Adaptive_RB.Size = new System.Drawing.Size(100, 23);
            this.Adaptive_RB.TabIndex = 0;
            this.Adaptive_RB.TabStop = true;
            this.Adaptive_RB.Text = "Adaptive";
            this.Adaptive_RB.UseVisualStyleBackColor = true;
            this.Adaptive_RB.CheckedChanged += new System.EventHandler(this.Adaptive_RB_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Count_RB);
            this.groupBox2.Controls.Add(this.Quick_RB);
            this.groupBox2.Location = new System.Drawing.Point(459, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adaptive ";
            this.groupBox2.Visible = false;
            // 
            // Count_RB
            // 
            this.Count_RB.AutoSize = true;
            this.Count_RB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count_RB.Location = new System.Drawing.Point(6, 65);
            this.Count_RB.Name = "Count_RB";
            this.Count_RB.Size = new System.Drawing.Size(114, 23);
            this.Count_RB.TabIndex = 2;
            this.Count_RB.TabStop = true;
            this.Count_RB.Text = "Count Sort";
            this.Count_RB.UseVisualStyleBackColor = true;
            // 
            // Quick_RB
            // 
            this.Quick_RB.AutoSize = true;
            this.Quick_RB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quick_RB.Location = new System.Drawing.Point(6, 30);
            this.Quick_RB.Name = "Quick_RB";
            this.Quick_RB.Size = new System.Drawing.Size(111, 23);
            this.Quick_RB.TabIndex = 1;
            this.Quick_RB.TabStop = true;
            this.Quick_RB.Text = "Quick Sort";
            this.Quick_RB.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Rondom_RB2);
            this.groupBox3.Controls.Add(this.Count_RB2);
            this.groupBox3.Location = new System.Drawing.Point(621, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(129, 100);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alpha Trim";
            this.groupBox3.Visible = false;
            // 
            // Rondom_RB2
            // 
            this.Rondom_RB2.AutoSize = true;
            this.Rondom_RB2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rondom_RB2.Location = new System.Drawing.Point(11, 52);
            this.Rondom_RB2.Name = "Rondom_RB2";
            this.Rondom_RB2.Size = new System.Drawing.Size(94, 23);
            this.Rondom_RB2.TabIndex = 2;
            this.Rondom_RB2.TabStop = true;
            this.Rondom_RB2.Text = "Rondom";
            this.Rondom_RB2.UseVisualStyleBackColor = true;
            // 
            // Count_RB2
            // 
            this.Count_RB2.AutoSize = true;
            this.Count_RB2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count_RB2.Location = new System.Drawing.Point(9, 23);
            this.Count_RB2.Name = "Count_RB2";
            this.Count_RB2.Size = new System.Drawing.Size(114, 23);
            this.Count_RB2.TabIndex = 1;
            this.Count_RB2.TabStop = true;
            this.Count_RB2.Text = "Count Sort";
            this.Count_RB2.UseVisualStyleBackColor = true;
            this.Count_RB2.CheckedChanged += new System.EventHandler(this.Count_RB2_CheckedChanged);
            // 
            // T_lb
            // 
            this.T_lb.AutoSize = true;
            this.T_lb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_lb.Location = new System.Drawing.Point(626, 79);
            this.T_lb.Name = "T_lb";
            this.T_lb.Size = new System.Drawing.Size(20, 19);
            this.T_lb.TabIndex = 12;
            this.T_lb.Text = "T";
            this.T_lb.Visible = false;
            this.T_lb.Click += new System.EventHandler(this.T_lb_Click);
            // 
            // T_tb
            // 
            this.T_tb.Location = new System.Drawing.Point(660, 78);
            this.T_tb.Name = "T_tb";
            this.T_tb.Size = new System.Drawing.Size(100, 20);
            this.T_tb.TabIndex = 13;
            this.T_tb.Visible = false;
            this.T_tb.TextChanged += new System.EventHandler(this.T_tb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Max windows size";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // MaxW_TB
            // 
            this.MaxW_TB.Location = new System.Drawing.Point(621, 280);
            this.MaxW_TB.Name = "MaxW_TB";
            this.MaxW_TB.Size = new System.Drawing.Size(100, 20);
            this.MaxW_TB.TabIndex = 16;
            this.MaxW_TB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(472, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Window Size";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(601, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 527);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaxW_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.T_tb);
            this.Controls.Add(this.T_lb);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Time_lbl);
            this.Controls.Add(this.Time_L);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Filter_btn);
            this.Controls.Add(this.btnZGraph);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Image Filters...";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnZGraph;
        private System.Windows.Forms.Button Filter_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Time_L;
        private System.Windows.Forms.Label Time_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Alpha_RB;
        private System.Windows.Forms.RadioButton Adaptive_RB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Count_RB;
        private System.Windows.Forms.RadioButton Quick_RB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton Rondom_RB2;
        private System.Windows.Forms.RadioButton Count_RB2;
        private System.Windows.Forms.Label T_lb;
        private System.Windows.Forms.TextBox T_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaxW_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

