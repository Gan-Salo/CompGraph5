using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;
        private Bitmap bufferImage;
        Dictionary<int, int> histogram = new Dictionary<int, int>(); //Словарь для хранения значений яркости пискелей для гистограммы
        private int thresholdValue = 128; //Значение на ползунке бинаризации
        private int imageWidth;
        private int imageHeight;
            
        public Form1()
        {
            InitializeComponent();
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 255;
            trackBar1.Value = 128;

            brighttrackBar.Minimum = -255;
            brighttrackBar.Maximum = 255;
            brighttrackBar.Value = 0;

            ContrasttrackBar.Minimum = 0;
            ContrasttrackBar.Maximum = 255;
            ContrasttrackBar.Value = 0;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {          
            //histogram.Clear();
            // Перерисовка pictureBox2
            pictureBox2.Paint -= pictureBox2_Paint; 
            

            pictureBox2.Invalidate();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(openFileDialog.FileName);
                bufferImage = originalImage;
                imageWidth = originalImage.Width;
                imageHeight = originalImage.Height;
                label1.Text = originalImage.Width.ToString();
                label2.Text = originalImage.Height.ToString();
                histogram.Clear(); 
                DisplayImage();
            }
        }

        //Функция отображения изображения
        private void DisplayImage()
        {
            if (originalImage != null)
            {
                pictureBox1.Image = originalImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                
                DrawHistogram();
            }
        }

        //Функция сброса изображения
        private void ResetImage()
        {
            if (originalImage != null)
            {
                originalImage = bufferImage;
                DisplayImage();
            }
        }

        //Кнопка сброса изменений изображения
        private void button2_Click(object sender, EventArgs e)
        {

            histogram.Clear();
            // Перерисовка гистограммы
            pictureBox2.Paint -= pictureBox2_Paint; 

            pictureBox2.Invalidate();
            ResetImage();
        }

        //Поле для гистограммы
        private void pictureBox2_Paint(object sender, PaintEventArgs ev)
        {    
            //Сортирока по яркости пикселей
            var sortedKeys = histogram.Keys.OrderBy(k => k).ToList();
            int labelY = pictureBox2.Height + 30; 
            
            //Максимальное число пикселей определенной яркости
            int maxHistogramValue = histogram.Values.Max();
            int maxLabelValue = maxHistogramValue;
            
            //Отрисовка значений гистограммы
            Pen pen = new Pen(Color.DarkRed);
                int barWidth = 2;
                int offsetX = 5; // Расстояние от краев по оси X
                foreach (var entry in histogram)
                {
                    int i = entry.Key;
                    float normalizedValue = entry.Value / (float)maxHistogramValue;
                    int barHeight = (int)(normalizedValue * pictureBox2.Height / 1.2);

                    float normalizedX = (float)i / (float)sortedKeys.Max();
                    int x = (int)(normalizedX * (pictureBox2.Width - 2 * offsetX)) + offsetX;
                    int y = pictureBox2.Height - barHeight;

                // Проверка на переполнение x и y
                if (x < offsetX)
                {
                    x = offsetX;
                }
                else if (x > pictureBox2.Width - offsetX)
                {
                    x = pictureBox2.Width - offsetX;
                }
                // Проверка на переполнение
                if (y < 0)
                    {
                        y = 0;
                    }
                    else if (y > pictureBox2.Height)
                    {
                        y = pictureBox2.Height;
                    }

                ev.Graphics.DrawLine(pen, x, pictureBox2.Height, x, y);
                }
          
            // Отрисовка вертикальных подписей
            for (int i = 0; i <= pictureBox2.Height; i += pictureBox2.Height / 10)
                {
                    ev.Graphics.DrawString(((maxLabelValue * (pictureBox2.Height - i)) / pictureBox2.Height).ToString(), Font, Brushes.Black, 0, i);
                }

            int horizontalLinesCount = 10; 
            for (int i = 1; i < horizontalLinesCount; i++)
            {
                int y = i * pictureBox2.Height / horizontalLinesCount;
                ev.Graphics.DrawLine(Pens.LightGray, 0, y, pictureBox2.Width, y);
            }

            
        }

        //Функция рисования гистограммы яркости
        private void DrawHistogram()
        {
            
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

            //Console.WriteLine("Brightness\tPixel Count");
            //foreach (var entry in histogram)
            //{
            //    Console.WriteLine($"{entry.Key}\t\t{entry.Value}");
            //}
            //label3.Text = histogram.Values.Max().ToString();
            
            pictureBox2.Paint += pictureBox2_Paint;          
            pictureBox2.Invalidate(); 
        }

        //Функция расчёта яркости пискеля по формуле
        public int getBrightPixel(int width, int height)
        {
            Color color = originalImage.GetPixel(width, height);

            return (int)(0.299 * color.R + 0.5876 * color.G + 0.114 * color.B);
        }

        //Функция получения изображения в негативе
        private void NegateImage()
        {
            if (originalImage != null)
            {
                Bitmap negativeImage = new Bitmap(originalImage);

                for (int y = 0; y < negativeImage.Height; y++)
                {
                    for (int x = 0; x < negativeImage.Width; x++)
                    {
                        Color pixelColor = negativeImage.GetPixel(x, y);
                        Color newColor = Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);
                        negativeImage.SetPixel(x, y, newColor);
                    }
                }

                originalImage = negativeImage;
            }
        }

        //Функция перехода к оттенкам серого
        private void ConvertToGrayscale()
        {
            if (originalImage != null)
            {
                Bitmap grayscaleImage = new Bitmap(originalImage);

                for (int y = 0; y < grayscaleImage.Height; y++)
                {
                    for (int x = 0; x < grayscaleImage.Width; x++)
                    {                      
                        int grayValue = getBrightPixel(x, y);
                        Color newColor = Color.FromArgb(grayValue, grayValue, grayValue);
                        grayscaleImage.SetPixel(x, y, newColor);
                    }
                }

                originalImage = grayscaleImage;
            }
        }

        //Ползунок регулировки бинаризации 
        private void BinarizeImage(int level)
        {
            if (originalImage != null)
            {
                Bitmap binaryImage = new Bitmap(originalImage);

                for (int y = 0; y < binaryImage.Height; y++)
                {
                    for (int x = 0; x < binaryImage.Width; x++)
                    {
                        Color pixelColor = binaryImage.GetPixel(x, y);
                        if ((pixelColor.R + pixelColor.G + pixelColor.B) / 3 < level)
                        {
                            binaryImage.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        }
                        else
                        {
                            binaryImage.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        }
                                      
                        label3.Text = level.ToString();
                        // Бинаризация по текущему порогу
                        //Color newColor = (grayValue < level) ? Color.Black : Color.White;
                       // binaryImage.SetPixel(x, y, newColor);
                    }
                }

                // Отображаем бинаризированное изображение
                originalImage = binaryImage;
            }
        }

        //Ползунок регулировки яркости
        private void AdjustBrightness(int brightness)
        {
            if (originalImage != null)
            {
                Bitmap adjustedImage = new Bitmap(originalImage);

                for (int y = 0; y < adjustedImage.Height; y++)
                {
                    for (int x = 0; x < adjustedImage.Width; x++)
                    {
                        Color pixelColor = adjustedImage.GetPixel(x, y);

                        int newRed = Clamp(pixelColor.R + brightness, 0, 255);
                        int newGreen = Clamp(pixelColor.G + brightness, 0, 255);
                        int newBlue = Clamp(pixelColor.B + brightness, 0, 255);

                        Color newColor = Color.FromArgb(newRed, newGreen, newBlue);
                        adjustedImage.SetPixel(x, y, newColor);
                        label6.Text = brightness.ToString();
                    }
                }

                originalImage = adjustedImage;
            }
        }

        //Проверка значения цвета на принадлежность промежутку от 0 до 255
        private int Clamp(int value, int min, int max)
        {
            return Math.Max(min, Math.Min(value, max));
        }

        //Вычисление контрастности
        private void AdjustContrast(float value)
        {
            if (originalImage != null)
            {              
                Bitmap contrastImage = new Bitmap(originalImage);
                float contrast = 0;
                float sumY = 0, avg = 0;
                int newR = 0, newG = 0, newB = 0;
                contrast = value;

                for (int y = 0; y < originalImage.Height; y++)
                {
                    for (int x = 0; x < originalImage.Width; x++)
                    {                     
                        sumY += getBrightPixel(x, y);
                    }
                }
                avg = sumY / (originalImage.Height * originalImage.Width);

                for (int y = 0; y < originalImage.Height; y++)
                {
                    for (int x = 0; x < originalImage.Width; x++)
                    {
                        Color pixelColor = originalImage.GetPixel(x, y);
                        newR = (int)(contrast * (pixelColor.R - avg) + avg);
                        newG = (int)(contrast * (pixelColor.G - avg) + avg);
                        newB = (int)(contrast * (pixelColor.B - avg) + avg);

                        newR = Clamp((int)newR, 0, 255);
                        newG = Clamp((int)newG, 0, 255);
                        newB = Clamp((int)newB, 0, 255);

                        Color newPixelColor = Color.FromArgb(newR, newG, newB);
                        //sumY += coloryValue;

                        contrastImage.SetPixel(x, y, newPixelColor);
                    }
                }
                originalImage = contrastImage;
                
            }
        }
 
        //Ползунок контрастности - ДЕАКТИВИРОВАНО!
        private void ContrasttrackBar_Scroll(object sender, EventArgs e)
        {
            //float contrastValue = ContrasttrackBar.Value; // Подстраиваем значение к нужному диапазону
            ////CalculateAverageRgb();
            //ResetImage();
            //histogram.Clear();
            //AdjustContrast(contrastValue);
            //DisplayImage(); // Обновляем отображение после преобразования
        }

        //Ползунок яркости
        private void brighttrackBar_Scroll(object sender, EventArgs e)
        {
            int brightnessValue = brighttrackBar.Value;
        
            ResetImage();
            histogram.Clear();
            AdjustBrightness(brightnessValue);
            DisplayImage(); // Обновляем отображение после преобразования
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ResetImage();
            histogram.Clear();
            thresholdValue = trackBar1.Value;
            BinarizeImage(trackBar1.Value);
            DisplayImage(); 

        }

        //Кнопка - негатив
        private void button3_Click(object sender, EventArgs e)
        {
            histogram.Clear();
            NegateImage();
            DisplayImage(); // Обновляем отображение после преобразования
        }

        //Кнопка для примения контрастности 
        private void contrastbutton_Click(object sender, EventArgs e)
        {
            
            ResetImage();
            histogram.Clear();
            if (float.TryParse(contrasttextBox.Text, out float contrastValue))
            {
                AdjustContrast(contrastValue);
            }
            else
            {         
                MessageBox.Show("Некорректное значение контрастности. Введите число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DisplayImage(); // Обновляем отображение после преобразования
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            histogram.Clear();
            ConvertToGrayscale();
            DisplayImage(); // Обновляем отображение после преобразования
        }


        private void button5_Click(object sender, EventArgs e)
        {
            trackBar1.Enabled = true;
            histogram.Clear();
            BinarizeImage(thresholdValue);
            DisplayImage(); // Обновляем отображение после преобразования
        }


    }
}
