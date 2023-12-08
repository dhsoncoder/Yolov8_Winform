using System.Data;
using System.Text.RegularExpressions;
using Compunet.YoloV8;
using SixLabors.ImageSharp;
namespace Yolov8_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> listImage;
        string _fileName;
        private void Form1_Load(object sender, EventArgs e)
        {
            listImage = new List<string>();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
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
            using var predictor = new YoloV8("G://HaiSon/yolov8m (1).onnx");

            var result = predictor.Detect("G://HaiSon/Job4_Yolov8/cc1.jpg");
            

            Console.WriteLine(result);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            _fileName = listImage[dataGridView1.CurrentRow.Index];
            var image = new Bitmap(_fileName);
            pictureBox1.Image = image;

        }
    }
}