using System.Data;
using System.Text.RegularExpressions;
using Compunet.YoloV8;
using Compunet.YoloV8.Plotting;
using Yolov5Net;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;


namespace Yolov8_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Tải xuống mô hình Yolov8
           
            

        }
        List<string> listImage;
        string _fileName;
        private void Form1_Load(object sender, EventArgs e)
        {
            listImage = new List<string>();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            listImage.Clear();
            using (var fdb = new FolderBrowserDialog())
            {
                DialogResult result = fdb.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fdb.SelectedPath))
                {
                    var files = Directory.GetFiles(fdb.SelectedPath);
                    var table = new DataTable();
                    table.Columns.Add("File Name: ");
                    foreach (var file in files)
                    {
                        if (Regex.IsMatch(file, @".jpg|.png|.bmp|.jpeg|.JPG|.PNG|.JPEG|.BMP$"))
                        {

                            listImage.Add(file);
                            table.Rows.Add(Path.GetFileNameWithoutExtension(file));
                        }
                    }
                    dataGridView1.DataSource = table;


                }
            }
        }

        private void btn_detect_Click(object sender, EventArgs e)
        {
            // Đọc hình ảnh
            var predictor = new YoloV8(@"G:\HaiSon\Yolov8_Winform\assets\Model\yolov8n.onnx");
            var image = _fileName;
            var result = predictor.Detect(image);
            using var origin = SixLabors.ImageSharp.Image.Load<Rgb24>(image);
            using var ploted = result.PlotImage(origin);
            ploted.Save(@"G:\HaiSon\Yolov8_Winform\assets\images\image_done.jpg");
            var path_done = @"G:\HaiSon\Yolov8_Winform\assets\images\image_done.jpg";
            var image1 = new Bitmap(path_done);
            pictureBox1.Image = image1;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            _fileName = listImage[dataGridView1.CurrentRow.Index];
            var image = new Bitmap(_fileName);
            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}
