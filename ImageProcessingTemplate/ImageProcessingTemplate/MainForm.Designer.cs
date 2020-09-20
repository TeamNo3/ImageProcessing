namespace ImageProcessingTemplate
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxwellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toBlackAndWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getSpectrumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.additiveNoiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianNoiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownD = new System.Windows.Forms.NumericUpDown();
            this.labelNoiseLevel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(13, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 609);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 603);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(574, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(555, 609);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(549, 603);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpg";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.swapToolStripMenuItem,
            this.maxwellToolStripMenuItem,
            this.processToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1141, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLeftToolStripMenuItem,
            this.saveRightToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openLeftToolStripMenuItem
            // 
            this.openLeftToolStripMenuItem.Name = "openLeftToolStripMenuItem";
            this.openLeftToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.openLeftToolStripMenuItem.Text = "Open (Left)";
            this.openLeftToolStripMenuItem.Click += new System.EventHandler(this.openLeftToolStripMenuItem_Click);
            // 
            // saveRightToolStripMenuItem
            // 
            this.saveRightToolStripMenuItem.Name = "saveRightToolStripMenuItem";
            this.saveRightToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.saveRightToolStripMenuItem.Text = "Save (Right)";
            this.saveRightToolStripMenuItem.Click += new System.EventHandler(this.saveRightToolStripMenuItem_Click);
            // 
            // swapToolStripMenuItem
            // 
            this.swapToolStripMenuItem.Name = "swapToolStripMenuItem";
            this.swapToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.swapToolStripMenuItem.Text = "Swap";
            this.swapToolStripMenuItem.Click += new System.EventHandler(this.swapToolStripMenuItem_Click);
            // 
            // maxwellToolStripMenuItem
            // 
            this.maxwellToolStripMenuItem.Name = "maxwellToolStripMenuItem";
            this.maxwellToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.maxwellToolStripMenuItem.Text = "Maxwell";
            this.maxwellToolStripMenuItem.Click += new System.EventHandler(this.maxwellToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toBlackAndWhiteToolStripMenuItem,
            this.getSpectrumToolStripMenuItem,
            this.additiveNoiseToolStripMenuItem,
            this.gaussianNoiseToolStripMenuItem,
            this.expandToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // toBlackAndWhiteToolStripMenuItem
            // 
            this.toBlackAndWhiteToolStripMenuItem.Name = "toBlackAndWhiteToolStripMenuItem";
            this.toBlackAndWhiteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.toBlackAndWhiteToolStripMenuItem.Text = "To black&&white";
            this.toBlackAndWhiteToolStripMenuItem.Click += new System.EventHandler(this.toBlackAndWhiteToolStripMenuItem_Click);
            // 
            // getSpectrumToolStripMenuItem
            // 
            this.getSpectrumToolStripMenuItem.Name = "getSpectrumToolStripMenuItem";
            this.getSpectrumToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.getSpectrumToolStripMenuItem.Text = "Get spectrum";
            this.getSpectrumToolStripMenuItem.Click += new System.EventHandler(this.getSpectrumToolStripMenuItem_Click);
            // 
            // additiveNoiseToolStripMenuItem
            // 
            this.additiveNoiseToolStripMenuItem.Name = "additiveNoiseToolStripMenuItem";
            this.additiveNoiseToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.additiveNoiseToolStripMenuItem.Text = "Additive noise";
            this.additiveNoiseToolStripMenuItem.Click += new System.EventHandler(this.additiveNoiseToolStripMenuItem_Click);
            // 
            // gaussianNoiseToolStripMenuItem
            // 
            this.gaussianNoiseToolStripMenuItem.Name = "gaussianNoiseToolStripMenuItem";
            this.gaussianNoiseToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.gaussianNoiseToolStripMenuItem.Text = "Gaussian noise";
            this.gaussianNoiseToolStripMenuItem.Click += new System.EventHandler(this.gaussianNoiseToolStripMenuItem_Click);
            // 
            // expandToolStripMenuItem
            // 
            this.expandToolStripMenuItem.Name = "expandToolStripMenuItem";
            this.expandToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.expandToolStripMenuItem.Text = "Expand";
            this.expandToolStripMenuItem.Click += new System.EventHandler(this.expandToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.filterToolStripMenuItem.Text = "Filter";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // numericUpDownD
            // 
            this.numericUpDownD.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownD.Location = new System.Drawing.Point(88, 25);
            this.numericUpDownD.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownD.Name = "numericUpDownD";
            this.numericUpDownD.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownD.TabIndex = 4;
            this.numericUpDownD.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // labelNoiseLevel
            // 
            this.labelNoiseLevel.AutoSize = true;
            this.labelNoiseLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelNoiseLevel.Location = new System.Drawing.Point(12, 25);
            this.labelNoiseLevel.Name = "labelNoiseLevel";
            this.labelNoiseLevel.Size = new System.Drawing.Size(70, 15);
            this.labelNoiseLevel.TabIndex = 5;
            this.labelNoiseLevel.Text = "Noise level:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(179, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pixels expanded:";
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownN.Location = new System.Drawing.Point(286, 25);
            this.numericUpDownN.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownN.TabIndex = 7;
            this.numericUpDownN.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 665);
            this.Controls.Add(this.numericUpDownN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNoiseLevel);
            this.Controls.Add(this.numericUpDownD);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Image Processor";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem swapToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDownD;
        private System.Windows.Forms.ToolStripMenuItem maxwellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toBlackAndWhiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getSpectrumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem additiveNoiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianNoiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandToolStripMenuItem;
        private System.Windows.Forms.Label labelNoiseLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
    }
}

