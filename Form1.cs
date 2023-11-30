using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;
        Dictionary<int, int> histogram = new Dictionary<int, int>();
        private int imageWidth;
        private int imageHeight;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(openFileDialog.FileName);
                imageWidth = originalImage.Width;
                imageHeight = originalImage.Height;
                label1.Text = originalImage.Width.ToString();
                label2.Text = originalImage.Height.ToString();
                DisplayImage();
            }
        }
        private void DisplayImage()
        {
            if (originalImage != null)
            {
                pictureBox1.Image = originalImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                DrawHistogram();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            histogram.Clear();
            pictureBox2.Image = null;
            // Перерисовка pictureBox2
            pictureBox2.Invalidate();
        }

        private void DrawHistogram()
        {
            // Build histogram
            //Dictionary<int, int> histogram = new Dictionary<int, int>(); // Assuming 8-bit grayscale image

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);
                    int brightness = (int)(0.299 * pixelColor.R + 0.5876 * pixelColor.G + 0.114 * pixelColor.B);

                    if (histogram.TryGetValue(brightness, out int count))
                        histogram[brightness] = count + 1;
                    else
                        histogram[brightness] = 1;
                }
            }
            // Sort keys in ascending order
            var sortedKeys = histogram.Keys.OrderBy(k => k).ToList();

            Console.WriteLine("Brightness\tPixel Count");
            foreach (var entry in histogram)
            {
                Console.WriteLine($"{entry.Key}\t\t{entry.Value}");
            }

            // Get the maximum histogram value
            int maxHistogramValue = histogram.Values.Max();
            label3.Text = histogram.Values.Max().ToString();
            // Подписи к осям
            int maxBrightnessLabelInterval = 50; // Интервал для подписей к осям
            int labelY = pictureBox2.Height + 30; // Исходное значение Y для подписей

            int maxLabelValue = maxHistogramValue;
            // Draw histogram
            pictureBox2.Paint += (s, ev) =>
            {
                Pen pen = new Pen(Color.Black);
                int barWidth = 2;
                int offsetX = 5; // Расстояние от краев по оси X
                foreach (var entry in histogram)
                {
                    int i = entry.Key;
                    float normalizedValue = entry.Value / (float)maxHistogramValue;
                    int barHeight = (int)(normalizedValue * pictureBox2.Height);
                    
                    float normalizedX = (float)i / (float)sortedKeys.Max();
                    int x = (int)(normalizedX * (pictureBox2.Width - 2 * offsetX)) + offsetX;
                    int y = pictureBox2.Height - barHeight;

                    ev.Graphics.DrawLine(pen, x, pictureBox2.Height, x, y);
                    //// Подписи к осям
                    //if (i % 50 == 0)
                    //{
                    //    ev.Graphics.DrawString(entry.ToString(), Font, Brushes.Black, 0, y - 10);
                    //}

                    //// Распределение подписей к осям
                    //if (i % 50 == 0)
                    //{
                    //    int textX = x + barWidth / 2 - 10; // Добавьте сдвиг для лучшей читаемости
                    //    int textY = pictureBox2.Height + 5;
                    //    ev.Graphics.DrawString(i.ToString(), Font, Brushes.Black, textX, textY);
                    //}

                    //if (i % 20 == 0)
                    //{
                    //    int textX = 0;
                    //    int textY = y - 10;
                    //    ev.Graphics.DrawString(entry.Value.ToString(), Font, Brushes.Black, textX, textY);
                    //}
                }

                // Подписи к осям
                
                // Отрисовка вертикальных подписей
                for (int i = 0; i <= pictureBox2.Height; i += pictureBox2.Height / 10)
                {
                    ev.Graphics.DrawString(((maxLabelValue * (pictureBox2.Height - i)) / pictureBox2.Height).ToString(), Font, Brushes.Black, 0, i);
                }

                // Подписи осей              
                //ev.Graphics.DrawString("Яркость", Font, Brushes.Black, pictureBox2.Width / 2, labelY);
                //ev.Graphics.DrawString("Число пикселей", Font, Brushes.Black, -20, pictureBox2.Height / 2, new StringFormat { FormatFlags = StringFormatFlags.DirectionVertical });
            };

            pictureBox2.Invalidate(); // Trigger the Paint event
        }
    }
}
