using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPicture
{
    public partial class frmPaint : Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        Pen pen = new Pen(Color.Red, 3);
        Pen EraserPen = new Pen(Color.White , 40);
        bool IsDrawing = false;
        Point point;



        public frmPaint()
        {
            InitializeComponent();

            this.Text = "Paint";

            timer.Interval = 3000;
            timer.Tick += timer_Tick;


        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            if (string.IsNullOrWhiteSpace(lbTextPan.Text))
            {
                lbTextPan.Text = "3";
                pen.Width = 3;
            }
        }
        
        private void ApplayPenSize()
        {
            if(string.IsNullOrWhiteSpace(lbTextPan.Text))
               {
                lbTextPan.Text = "3";
                pen.Width = 3;
                  return;
                 }
    
            if (int.TryParse(lbTextPan.Text , out int size))
            {
                if (size > 50)
                {
                    size = 50;
                }
                else if (size < 3)
                {
                    size = 3;
                }

                lbTextPan.Text = size.ToString();
                pen.Width = size;
            }

            //else
            //{
            //    pen.Width = 3; 
            //    lbTextPan.Text = "3";
            //}

        }

        private void frmPaint_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPaint_Load(object sender, EventArgs e)
        {

        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
        }

        private void panelCenter_MouseUp(object sender, MouseEventArgs e)
        {
            IsDrawing = false;
        }

        private void panelCenter_MouseDown(object sender, MouseEventArgs e)
        {
            IsDrawing = true;
            point = e.Location;

        }

        private void panelCenter_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDrawing)
            {
                Graphics g = panelCenter.CreateGraphics();
                g.DrawLine(pen, point, e.Location);
                point = e.Location;

            }
        }

        private void btnWithe_Click(object sender, EventArgs e)
        {
            pen.Color = panelCenter.BackColor;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Yellow;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Green;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Blue;
        }

        private void panelCenter_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {

        }

        private void paneltop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            panelCenter.Refresh();
            panelCenter.BackColor = Color.White;
        }

        private void btnFormColor_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panelCenter.BackColor = colorDialog1.Color;
            }
        }

        private void lbTextPan_TextChanged(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
          
        }

        private void lbTextPan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timer.Stop();
                ApplayPenSize();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lbTextPan.Text, out int size))
            {
                pen.Width = size;

                if (pen.Width < 50)
                {
                    pen.Width += 1;
                    lbTextPan.Text = pen.Width.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(int.TryParse(lbTextPan.Text, out int size))
            {
                pen.Width = size;

                if (pen.Width > 3)
                {
                    pen.Width -= 1;
                    lbTextPan.Text = pen.Width.ToString();
                }
            }
        }

        private void panelCenter_MouseHover(object sender, EventArgs e)
        {
            
            if(string.IsNullOrWhiteSpace(lbTextPan.Text) )
            {
               
                timer.Start();
            }
        }
    }
}
