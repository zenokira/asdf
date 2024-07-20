using System.Drawing;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int mX, mY, ex, ey;
        int radionum;
        bool or;
        int penWidth = 2;
        Pen pen = new Pen(Color.SkyBlue, 2);
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radionum = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mX = e.X;
            mY = e.Y;
            if (radionum == 5)
                or = true;
            
           
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();

            int x = e.X, y = e.Y;
            if (radionum == 1)
            {
                g.DrawLine(pen, mX, mY, mX + 1, mY + 1);
                g.DrawLine(pen, mX - 1, mY - 1, mX, mY);
            }
            else if (radionum == 2)
                g.DrawLine(pen, mX, mY, e.X, e.Y);
            else if (radionum == 3)
            {

                if (mX > x) (mX, x) = (x, mX);
                if (mY > y) (mX, y) = (y, mY);

                g.DrawRectangle(pen, new Rectangle(mX, mY, x - mX, y - mY));
            }
            else if (radionum == 4)
            {
                if (mX > x) (mX, x) = (x, mX);
                if (mY > y) (mX, y) = (y, mY);

                g.DrawEllipse(pen, new Rectangle(mX, mY, x - mX, y - mY));
            }
            else if (radionum == 5)
            {
                or = false;
            }



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radionum = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radionum = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radionum = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radionum = 5;
        }

        private void radioButton5_MouseMove(object sender, MouseEventArgs e)
        {


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();

            if (or == true)
            {

                g.DrawLine(pen, e.X, e.Y, e.X + 1, e.Y + 1);
                g.DrawLine(pen, e.X - 1, e.Y - 1, e.X, e.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ColorDialog 인스턴스 생성
            ColorDialog colorDialog = new ColorDialog();

            // ColorDialog 표시
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // 선택된 색상을 패널의 배경색으로 설정
                panel1.BackColor = colorDialog.Color;
                pen = new Pen(colorDialog.Color, 2);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }
    }
}
