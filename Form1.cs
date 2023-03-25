using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Drawing
{
    public partial class Form1 : Form
    {
        Point p;
        Pen pen = new Pen(Color.Black, 3); // 팬 초기 설정
        Bitmap bt = new Bitmap(800, 426);

        public Form1()
        {
            InitializeComponent();
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round; // 팬 시작 끝 둥굴게
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round; // 팬 시작 끝 둥굴게
        }

        private void 지우기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null; // 픽쳐박스 지우기
            bt = new Bitmap(800, 426); ;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            p.X = e.X; // 마우스 현재 x좌표
            p.Y = e.Y; // 마우스 현재 y좌표
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = pictureBox1.CreateGraphics(); // 객체선언
                Graphics g2 = Graphics.FromImage(bt);
                
                g.DrawLine(pen, p.X, p.Y, e.X, e.Y); // 선 그리기
                g2.DrawLine(pen, p.X, p.Y, e.X, e.Y); // 선 그리기
                p.X = e.X; // x 좌표 갱신
                p.Y = e.Y; // y 좌표 갱신
                g.Dispose(); // 객체해제
                g2.Dispose(); // 객체해제
                pictureBox1.Image = bt;
            }
        }

        private void 불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();

            File.InitialDirectory = System.Windows.Forms.Application.StartupPath;  // 불러오기 눌렀을때 처음 위치
            File.Filter = "JPEG (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|PNG (*.png)|*.png|All (*.*)|*.*";  // 읽을 파일 확장자 및 설명
            File.FileName = "";

            if (File.ShowDialog() == System.Windows.Forms.DialogResult.OK)      // 확인시에는
            {
                Bitmap bitmap = new Bitmap(File.FileName);                      // 비트맵에 사진 넣기
                pictureBox1.Image = bitmap;                                     // 픽쳐박스에 비트맵 전송
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;         // 사진 크기를 픽쳐박스 맞추기
            }
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog File = new SaveFileDialog();
            File.Title = "다른 이름으로 저장";
            File.DefaultExt = "jpg";
            File.Filter = "JPEG (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|PNG (*.png)|*.png|All (*.*)|*.*";
            File.FilterIndex = 0;

            if (File.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(File.FileName);
                MessageBox.Show("저장완료!", "성공");
            }
        }

        private void 검정색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
        }

        private void 파랑색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Blue;
        }

        private void 빨간색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
        }

        private void 굵기1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.Width = 1;
        }

        private void 굵기2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.Width = 2;
        }

        private void 굵기3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.Width = 3;
        }

        private void 지우개ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
        }
    }
}
