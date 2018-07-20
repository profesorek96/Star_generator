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
            this.tB_Scale = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nUpD_line_size = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_Color_fill = new System.Windows.Forms.Button();
            this.CB_fill = new System.Windows.Forms.CheckBox();
            this.Bt_Color_line = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tB_Scale)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpD_line_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tB_Scale
            // 
            this.tB_Scale.Location = new System.Drawing.Point(4, 240);
            this.tB_Scale.Margin = new System.Windows.Forms.Padding(2);
            this.tB_Scale.Maximum = 1000;
            this.tB_Scale.Name = "tB_Scale";
            this.tB_Scale.Size = new System.Drawing.Size(141, 45);
            this.tB_Scale.TabIndex = 1;
            this.tB_Scale.Value = 500;
            this.tB_Scale.Scroll += new System.EventHandler(this.tB_Scale_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.nUpD_line_size);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Bt_Color_fill);
            this.groupBox1.Controls.Add(this.CB_fill);
            this.groupBox1.Controls.Add(this.Bt_Color_line);
            this.groupBox1.Controls.Add(this.tB_Scale);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(487, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(150, 481);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties";
            // 
            // nUpD_line_size
            // 
            this.nUpD_line_size.DecimalPlaces = 2;
            this.nUpD_line_size.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nUpD_line_size.Location = new System.Drawing.Point(75, 186);
            this.nUpD_line_size.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUpD_line_size.Name = "nUpD_line_size";
            this.nUpD_line_size.Size = new System.Drawing.Size(56, 20);
            this.nUpD_line_size.TabIndex = 10;
            this.nUpD_line_size.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpD_line_size.ValueChanged += new System.EventHandler(this.nUpD_line_size_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Line size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Deformation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Count sides";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(15, 83);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(116, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Color line";
            // 
            // Bt_Color_fill
            // 
            this.Bt_Color_fill.Location = new System.Drawing.Point(15, 333);
            this.Bt_Color_fill.Margin = new System.Windows.Forms.Padding(2);
            this.Bt_Color_fill.Name = "Bt_Color_fill";
            this.Bt_Color_fill.Size = new System.Drawing.Size(116, 32);
            this.Bt_Color_fill.TabIndex = 4;
            this.Bt_Color_fill.UseVisualStyleBackColor = true;
            this.Bt_Color_fill.Click += new System.EventHandler(this.Bt_Color_fill_Click);
            // 
            // CB_fill
            // 
            this.CB_fill.AutoSize = true;
            this.CB_fill.Location = new System.Drawing.Point(15, 289);
            this.CB_fill.Margin = new System.Windows.Forms.Padding(2);
            this.CB_fill.Name = "CB_fill";
            this.CB_fill.Size = new System.Drawing.Size(46, 17);
            this.CB_fill.TabIndex = 3;
            this.CB_fill.Text = "Fillin";
            this.CB_fill.UseVisualStyleBackColor = true;
            this.CB_fill.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Bt_Color_line
            // 
            this.Bt_Color_line.Location = new System.Drawing.Point(15, 138);
            this.Bt_Color_line.Margin = new System.Windows.Forms.Padding(2);
            this.Bt_Color_line.Name = "Bt_Color_line";
            this.Bt_Color_line.Size = new System.Drawing.Size(116, 32);
            this.Bt_Color_line.TabIndex = 2;
            this.Bt_Color_line.UseVisualStyleBackColor = true;
            this.Bt_Color_line.Click += new System.EventHandler(this.Bt_Color_line_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 481);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Star generator";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tB_Scale)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpD_line_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar tB_Scale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_Color_fill;
        private System.Windows.Forms.CheckBox CB_fill;
        private System.Windows.Forms.Button Bt_Color_line;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUpD_line_size;
        private System.Windows.Forms.Label label4;
    }
}

