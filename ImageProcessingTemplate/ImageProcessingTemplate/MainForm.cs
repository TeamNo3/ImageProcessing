using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessingTemplate
{
    public partial class MainForm : Form
    {
        private Bitmap _bitmap = new Bitmap(@"C:\Users\Павел\Pictures\Saved Pictures\default.jpg");

        public MainForm()
        {
            InitializeComponent();
            pictureBox1.Image = _bitmap;
        }

        private void openLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            _bitmap = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = _bitmap;
        }

        private void saveRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            pictureBox2.Image.Save(saveFileDialog1.FileName);
        }

        /// <summary>
        /// Меняет обработанное изображение с исходным, чтобы можно было обработать повторно
        /// </summary>
        private void swapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = pictureBox2.Image;
            _bitmap = (Bitmap) temp;
            pictureBox2.Image = pictureBox1.Image;
            pictureBox1.Image = temp;
        }

        private void maxwellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = BitmapExtensions.MaxwellTriangle;
        }

        private void toBlackAndWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _bitmap.ToBlackAndWhite();
        }

        private void getSpectrumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _bitmap.ToSpectrum();
        }

        private void additiveNoiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _bitmap.AdditiveNoise((int) numericUpDownD.Value);
        }

        private void gaussianNoiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _bitmap.GaussianNoise((int) numericUpDownD.Value);
        }

        private void expandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _bitmap.SizePlus((int) numericUpDownN.Value);
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = _bitmap.Filter();
        }
    }
}
