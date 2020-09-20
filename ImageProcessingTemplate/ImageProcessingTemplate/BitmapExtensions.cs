using System;
using System.Drawing;

namespace ImageProcessingTemplate
{
    public static class BitmapExtensions
    {
        private static readonly Random Rnd = new Random();

        /// <summary>
        /// Возвращает треугольник Максвелла
        /// </summary>
        public static Bitmap MaxwellTriangle
        {
            get
            {
                var bm = new Bitmap(256, 256);
                for (var g = 0; g < 256; g++)
                for (var r = 0; r < 256 - g; r++)
                    bm.SetPixel(r, g, Color.FromArgb(r, g, 255 - r - g));
                return bm;
            }
        }

        /// <summary>
        /// Возвращает новый объект Bitmap - преобразованное в черно-белое исходное изображение
        /// </summary>
        public static Bitmap ToBlackAndWhite(this Bitmap bm)
        {
            var newBitmap = new Bitmap(bm.Width, bm.Height);
            for (var y = 0; y < bm.Height; y++)
            for (var x = 0; x < bm.Width; x++)
            {
                var color = bm.GetPixel(x, y);
                var num = (int) (0.36 * color.R + 0.53 * color.G + 0.11 * color.B);
                newBitmap.SetPixel(x, y, Color.FromArgb(num, num, num));
            }

            return newBitmap;
        }

        /// <summary>
        /// Возвращает новый объект Bitmap - спектр исходного изображения
        /// </summary>
        public static Bitmap ToSpectrum(this Bitmap bm)
        {
            var newBitmap = new Bitmap(bm.Width, bm.Height);
            const double u = 0.2;
            const double v = 0.4;
            for (var y = 0; y < bm.Height; y++)
            for (var x = 0; x < bm.Width; x++)
            {
                var br = (int) (127 + 50 * Math.Cos(u * x + v * y));
                newBitmap.SetPixel(x, y, Color.FromArgb(br, br, br));
            }

            return newBitmap;
        }

        /// <summary>
        /// Возвращает новый объект Bitmap - исходное изображение с наложенным на него аддитивным шумом
        /// </summary>
        /// <param name="bm">Исходное изображение</param>
        /// <param name="d">Уровень шума</param>
        public static Bitmap AdditiveNoise(this Bitmap bm, int d)
        {
            var newBitmap = new Bitmap(bm.Width, bm.Height);
            for (var y = 0; y < bm.Height; y++)
            for (var x = 0; x < bm.Width; x++)
            {
                //var d = d * rnd.NextDouble();
                var color = bm.GetPixel(x, y);
                int r = (int) (color.R + d * Rnd.NextDouble()), 
                    g = (int) (color.G + d * Rnd.NextDouble()), 
                    b = (int) (color.B + d * Rnd.NextDouble());
                newBitmap.SetPixel(x, y, Color.FromArgb(
                    r > 255 ? 255 : r < 0 ? 0 : r, g > 255 ? 255 : g < 0 ? 0 : g, b > 255 ? 255 : b < 0 ? 0 : b));
            }

            return newBitmap;
        }

        /// <summary>
        /// Возвращает значение отклонения для гауссовского шума
        /// </summary>
        /// <param name="d">Уровень шума</param>
        private static int GaussianValue(int d)
        {
            var sum = 0.0;
            for (var i = 0; i < 12; i++)
            {
                sum += Rnd.NextDouble();
            }

            return (int) (sum - 6) * d;
        }

        /// <summary>
        /// Возвращает новый объект Bitmap - исходное изображение с наложенным на него гауссовским шумом
        /// </summary>
        /// <param name="bm">Исходное изображение</param>
        /// <param name="d">Уровень шума</param>
        public static Bitmap GaussianNoise(this Bitmap bm, int d)
        {
            var newBitmap = new Bitmap(bm.Width, bm.Height);
            for (var y = 0; y < bm.Height; y++)
            for (var x = 0; x < bm.Width; x++)
            {
                var color = bm.GetPixel(x, y);
                int r = color.R + GaussianValue(d), g = color.G + GaussianValue(d), b = color.B + GaussianValue(d);
                newBitmap.SetPixel(x, y, Color.FromArgb(
                    r > 255 ? 255 : r < 0 ? 0 : r, g > 255 ? 255 : g < 0 ? 0 : g, b > 255 ? 255 : b < 0 ? 0 : b));
            }

            return newBitmap;
        }

        /// <summary>
        /// Возвращает новый объект Bitmap - изображение, дополненное пикселями, зеркально отражающими крайние пиксели исходного
        /// </summary>
        /// <param name="bm">Исходное изображение</param>
        /// <param name="n">Ширина полосы дополнительных пикселей</param>
        public static Bitmap SizePlus(this Bitmap bm, int n)
        {
            var bmNew = new Bitmap(bm.Width + 2 * n, bm.Height + 2 * n);
            for (var y = 0; y < bm.Height; y++)
            for (var x = 0; x < bm.Width; x++)
                bmNew.SetPixel(x + n, y + n, bm.GetPixel(x, y));
            for (var x = 0; x < n; x++)
            for (var y = 0; y < n; y++)
            {
                bmNew.SetPixel(x, y, bm.GetPixel(n - 1 - x, n - 1 - y));
                bmNew.SetPixel(x, bmNew.Height - 1 - y, bm.GetPixel(n - 1 - x, bm.Height - n + y));
                bmNew.SetPixel(bmNew.Width - 1 - x, y, bm.GetPixel(bm.Width - n + x, n - y));
                bmNew.SetPixel(bmNew.Width - 1 - x, bmNew.Height - 1 - y, bm.GetPixel(bm.Width - n + x, bm.Height - n + y));
            }

            for (var x = n; x < bmNew.Width - n; x++)
            for (var y = 0; y < n; y++)
            {
                bmNew.SetPixel(x, y, bm.GetPixel(x - n, n - 1 - y));
                bmNew.SetPixel(x, bmNew.Height - 1 - y, bm.GetPixel(x - n, bm.Height - n + y));
            }

            for (var y = n; y < bmNew.Height - n; y++)
            for (var x = 0; x < n; x++)
            {
                bmNew.SetPixel(x, y, bm.GetPixel(n - 1 - x, y - n));
                bmNew.SetPixel(bmNew.Width - 1 - x, y, bm.GetPixel(bm.Width - n + x, y - n));
            }

            return bmNew;
        }

        /// <summary>
        /// Возвращает новый объект Bitmap - отфильтрованное с помощью метода линейной низкочастотной фильтрации аддитивного шума исходное изображение
        /// </summary>
        /// <param name="bm">Исходное изображение</param>
        public static Bitmap Filter(this Bitmap bm)
        {
            const double w1 = 0.52, w2 = 0.03, w3 = 0.015;
            double[,] w =
            {
                {w3, w3, w3, w3, w3},
                {w3, w2, w2, w2, w3},
                {w3, w2, w1, w2, w3},
                {w3, w2, w2, w2, w3},
                {w3, w3, w3, w3, w3}
            };
            const int n = 2;
            var bmToFilter = bm.SizePlus(n);
            var bmFiltered = new Bitmap(bm.Width, bm.Height);

            for (var y = 0; y < bm.Height; y++)
            for (var x = 0; x < bm.Width; x++)
            {
                int red = 0, green = 0, blue = 0;
                for (var k = 0; k <= 2 * n; k++)
                for (var l = 0; l <= 2 * n; l++)
                {
                    var color = bmToFilter.GetPixel(x + k, y + l);
                    red += (int) (color.R * w[k, l]);
                    green += (int) (color.G * w[k, l]);
                    blue += (int) (color.B * w[k, l]);
                }

                bmFiltered.SetPixel(x, y, Color.FromArgb(red, green, blue));
            }

            return bmFiltered;
        }
    }
}
