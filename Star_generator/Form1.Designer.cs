namespace Star_generator
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bt_Color_line = new System.Windows.Forms.Button();
            this.CB_fill = new System.Windows.Forms.CheckBox();
            this.Bt_Color_fill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(643, 592);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 199);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(188, 56);
            this.trackBar1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Bt_Color_fill);
            this.groupBox1.Controls.Add(this.CB_fill);
            this.groupBox1.Controls.Add(this.Bt_Color_line);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(649, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 592);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties";
            // 
            // Bt_Color_line
            // 
            this.Bt_Color_line.Location = new System.Drawing.Point(19, 102);
            this.Bt_Color_line.Name = "Bt_Color_line";
            this.Bt_Color_line.Size = new System.Drawing.Size(155, 40);
            this.Bt_Color_line.TabIndex = 2;
            this.Bt_Color_line.UseVisualStyleBackColor = true;
            this.Bt_Color_line.Click += new System.EventHandler(this.Bt_Color_line_Click);
            // 
            // CB_fill
            // 
            this.CB_fill.AutoSize = true;
            this.CB_fill.Location = new System.Drawing.Point(19, 261);
            this.CB_fill.Name = "CB_fill";
            this.CB_fill.Size = new System.Drawing.Size(47, 21);
            this.CB_fill.TabIndex = 3;
            this.CB_fill.Text = "Fill";
            this.CB_fill.UseVisualStyleBackColor = true;
            this.CB_fill.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Bt_Color_fill
            // 
            this.Bt_Color_fill.Location = new System.Drawing.Point(19, 298);
            this.Bt_Color_fill.Name = "Bt_Color_fill";
            this.Bt_Color_fill.Size = new System.Drawing.Size(155, 40);
            this.Bt_Color_fill.TabIndex = 4;
            this.Bt_Color_fill.UseVisualStyleBackColor = true;
            this.Bt_Color_fill.Click += new System.EventHandler(this.Bt_Color_fill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Color line";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 592);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Star generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_Color_fill;
        private System.Windows.Forms.CheckBox CB_fill;
        private System.Windows.Forms.Button Bt_Color_line;
    }
}

