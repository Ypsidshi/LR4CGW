using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4CG
{
    public partial class Form1 : Form
    {
        picture pic = new picture();
        double[,] Position = new double[37, 3];
        double[,] Move = {
            {1,0,0,0},
            {0,1,0,0},
            {0,0,1,0},
            {0,0,0,1}
        };
        public Form1()
        {
            InitializeComponent();
        }
        public bool SurfaceCalculation(
                       double x1,
                       double y1,
                       double z1,
                       double x2,
                       double y2,
                       double z2,
                       double x3,
                       double y3,
                       double z3,
                       ref double a,
                       ref double b,
                       ref double c,
                        ref double d
                        )
        {



            //double k2 = x1 - x2;

            //if (k2 == 0)
            //    return false;

            a = (y2 - y1) * (z3 - z1) - (z2 - z1) * (y3 - y1);
            b = (z2 - z1) * (x3 - x1) - (x2 - x1) * (z3 - z1);
            c = (x2 - x1) * (y3 - y1) - (y2 - y1) * (x3 - x1);
            d = x1 * (z2 - z1) * (y3 - y1) - x1 * (y2 - y1) * (z3 - z1) +
                z1 * (y2 - y1) * (x3 - x1) - z1 * (x2 - x1) * (y3 - y1) +
                y1 * (x2 - x1) * (z3 - z1) - y1 * (z2 - z1) * (x3 - x1);



            return true;
        }
        private void ToForm(double[,] mov)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            double[,] Zbuffer = new double[pictureBox1.Width, pictureBox1.Height];
            for (int x = 0; x < pictureBox1.Width; x++)
                for (int y = 0; y < pictureBox1.Height; y++)
                    Zbuffer[x, y] = int.MinValue;
            Bitmap rezult = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (int i = 0; i < picture.simples.Length; i++)
            {
                double a, b, c, d;
                a = b = c = d = 0;

                Bitmap tmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                if (tmp != null)
                    for (int x = 0; x < tmp.Width; x++)
                        for (int y = 0; y < tmp.Height; y++)
                        {
                            Color tm = tmp.GetPixel(x, y);
                            var f = tm.ToArgb();
                            if (f != 0)
                            {

                                Pen pn = new Pen(Color.Black, 3);
                                Graphics gr = pictureBox1.CreateGraphics();
                                gr.DrawRectangle(Pens.White, x, y, 1, 1);

                            }
                        }
                ShowFigure(tmp, mov, picture.simples[i]);
                SurfaceCalculation(mov[picture.simples[i][0], 0], mov[picture.simples[i][0], 1], mov[picture.simples[i][0], 2],
                    mov[picture.simples[i][1], 0], mov[picture.simples[i][1], 1], mov[picture.simples[i][1], 2],
                    mov[picture.simples[i][2], 0], mov[picture.simples[i][2], 1], mov[picture.simples[i][2], 2],
                   ref a, ref b, ref c, ref d);



                Graphics g = Graphics.FromImage(rezult);
                for (int x = 0; x < tmp.Width; x++)
                    for (int y = 0; y < tmp.Height; y++)
                    {
                        if (tmp.GetPixel(x, y).ToArgb() != 0)
                        {
                            double z = (-a * x - b * y - d) / c;
                            double f = Zbuffer[x, y];
                            if (!double.IsInfinity(z) && !double.IsNaN(z) && z > Zbuffer[x, y])
                            {
                                Pen pn = new Pen(tmp.GetPixel(x, y), 1);
                                Zbuffer[x, y] = z;
                                g.DrawRectangle(pn, x, y, 1, 1);

                            }
                        }
                    }



            }
            pictureBox1.Image = rezult;
        }

        double Min(double[,] mov, int[] ints)
        {
            double min = mov[ints[0], 2];
            for (int i = 1; i < ints.Length; i++)
            {
                if (mov[ints[i], 2] < min)
                {
                    min = mov[ints[i], 2];
                }
            }
            return min;
        }
        double Max(double[,] mov, int[] ints)
        {
            double max = mov[ints[0], 2];
            for (int i = 1; i < ints.Length; i++)
            {
                if (mov[ints[i], 2] > max)
                {
                    max = mov[ints[i], 2];
                }
            }
            return max;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //ShowPicture();
        }
        private double[,] convetToScrin()
        {
            Position = (double[,])pic.Coordinates.Clone();
            Position = MatrixMultiplication(Position, pic.Scaling);

            for (int i = 0; i < pic.Coordinates.GetLength(0); i++)
            {
                Position[i, 0] = pic.pixel * Position[i, 0] / 1 + pictureBox1.Width / 2;
                Position[i, 1] = -(pic.pixel * Position[i, 1]) / 1 + pictureBox1.Height / 2;
            }
            Position = MatrixMultiplication(Position, Move);
            return Position;
        }

        private void ShowFigure(Bitmap pictureBox, double[,] mov, int[] lines)
        {
            Pen pn = new Pen(Color.Black, 3);
            Graphics g = Graphics.FromImage(pictureBox);
            PointF[] pointFs = new PointF[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                pointFs[i] = new PointF((((float)mov[lines[i], 0])) / 1, (((float)mov[lines[i], 1]) / 1));
            }

            g.FillPolygon(Brushes.Aqua, pointFs);
            g.DrawPolygon(pn, pointFs);
        }
        private void HideFigure(PictureBox pictureBox, double[,] mov, int[] lines)
        {
            Pen pn = new Pen(Color.White, 3);
            Graphics g = pictureBox1.CreateGraphics();
            PointF[] pointFs = new PointF[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                pointFs[i] = new PointF((((float)mov[lines[i], 0])) / 1, (((float)mov[lines[i], 1]) / 1));
                //g.DrawLine(pn, new PointF((((float)mov[pic.Transitions[lines[i]][0], 0])) / 1,
                //    (((float)mov[pic.Transitions[lines[i]][0], 1]) / 1)),
                //    new PointF((((float)mov[pic.Transitions[lines[i]][1], 0])) / 1,
                //    (((float)mov[pic.Transitions[lines[i]][1], 1]) / 1)));
            }

            g.FillPolygon(Brushes.White, pointFs);
            g.DrawPolygon(pn, pointFs);
        }
        private void ShowPicture(double[,] mov)
        {
            Pen pn = new Pen(Color.Black, 3);
            Graphics g = pictureBox1.CreateGraphics();
            for (int i = 0; i < pic.Transitions.Count() - 1; i++)
            {
                g.DrawLine(pn, new PointF((((float)mov[pic.Transitions[i][0], 0])) / 1,
                    (((float)mov[pic.Transitions[i][0], 1]) / 1)),
                    new PointF((((float)mov[pic.Transitions[i][1], 0])) / 1,
                    (((float)mov[pic.Transitions[i][1], 1]) / 1)));
            }

            float rad = Math.Abs((((float)mov[19, 1]) / 1) - (((float)mov[21, 1]) / 1));
            if (rad < 1) rad = Math.Abs((((float)mov[20, 1]) / 1) - (((float)mov[19, 1]) / 1));
            g.DrawEllipse(pn, (((float)mov[19, 0])) / 1 - rad, ((float)mov[19, 1]) / 1 - rad,
                rad * 2, rad * 2);
        }
        private void HidePicture(double[,] mov)
        {
            Pen pn = new Pen(Color.White, 3);
            Graphics g = pictureBox1.CreateGraphics();
            for (int i = 0; i < pic.Transitions.Count() - 1; i++)
            {
                g.DrawLine(pn, new PointF((((float)mov[pic.Transitions[i][0], 0])) / 1,
                    (((float)mov[pic.Transitions[i][0], 1]) / 1)),
                    new PointF((((float)mov[pic.Transitions[i][1], 0])) / 1,
                    (((float)mov[pic.Transitions[i][1], 1]) / 1)));
            }

            float rad = Math.Abs((((float)mov[19, 1]) / 1) - (((float)mov[21, 1]) / 1));
            if (rad < 1) rad = Math.Abs((((float)mov[20, 1]) / 1) - (((float)mov[19, 1]) / 1));
            g.DrawEllipse(pn, (((float)mov[19, 0])) / 1 - rad, ((float)mov[19, 1]) / 1 - rad,
                rad * 2, rad * 2);
        }
        static double[,] MatrixMultiplication(double[,] matrixA, double[,] matrixB)
        {
            if (matrixA.GetLength(1) != matrixB.GetLength(0))
            {
                throw new Exception("Óìíîæåíèå íå âîçìîæíî! Êîëè÷åñòâî ñòîëáöîâ ïåðâîé ìàòðèöû íå ðàâíî êîëè÷åñòâó ñòðîê âòîðîé ìàòðèöû.");
            }

            var matrixC = new double[matrixA.GetLength(0), matrixB.GetLength(1)];

            for (var i = 0; i < matrixA.GetLength(0); i++)
            {
                for (var j = 0; j < matrixB.GetLength(1); j++)
                {
                    matrixC[i, j] = 0;

                    for (var k = 0; k < matrixA.GetLength(1); k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            return matrixC;
        }
        private void TurnXButton_Click(object sender, EventArgs e)
        {
            //ToHide(convetToScrin());
            pic.Coordinates = MatrixMultiplication(pic.Coordinates, pic.TurnX);
            ToForm(convetToScrin());
        }

        private void TurnYButton_Click(object sender, EventArgs e)
        {
            //ToHide(convetToScrin());
            pic.Coordinates = MatrixMultiplication(pic.Coordinates, pic.TurnY);
            ToForm(convetToScrin());
        }

        private void TurnZButton_Click(object sender, EventArgs e)
        {
            //ToHide(convetToScrin());
            pic.Coordinates = MatrixMultiplication(pic.Coordinates, pic.TurnZ);
            ToForm(convetToScrin());
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            //ToHide(convetToScrin());
            int x = (int)numericUpDownMoveX.Value;
            int y = (int)numericUpDownMoveY.Value;
            Move[3, 0] += x; Move[3, 1] += y;
            ToForm(convetToScrin());
        }

        private void buttonScaling_Click(object sender, EventArgs e)
        {
            //ToHide(convetToScrin());
            picture.Scale = (int)numericUpDownScale.Value;
            pic.updateScaling();
            ToForm(convetToScrin());
        }
    }
}
