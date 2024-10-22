using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4CG
{
    internal class picture
    {
        public int pixel = 10;
        public static double Scale = 1;
        //public int Rows = 21;
        public double[,] Scaling =
        {
            {Scale,0,0,0 },
            {0,Scale,0,0},
            {0,0,Scale,0},
            {0,0,0,1}
        };
        public double[,] TurnX =
        {
            {1, 0, 0, 0},
            {0, Math.Cos(45*Math.PI/180), -Math.Sin(45*Math.PI/180), 0},
            {0, Math.Sin(45*Math.PI/180), Math.Cos(45*Math.PI/180), 0},
            {0, 0, 0, 1}
        };
        public double[,] TurnY =
        {
            {Math.Cos(45*Math.PI/180), 0, Math.Sin(45*Math.PI/180), 0},
            {0, 1, 0, 0},
            {-Math.Sin(45*Math.PI/180), 0, Math.Cos(45*Math.PI/180), 0},
            {0, 0, 0, 1}
        };
        public double[,] TurnZ =
        {
            {Math.Cos(45*Math.PI/180), -Math.Sin(45*Math.PI/180), 0, 0},
            {Math.Sin(45*Math.PI/180), Math.Cos(45*Math.PI/180), 0, 0},
            {0, 0, 1, 0},
            {0, 0, 0, 1}
        };

        public void updateScaling()
        {
            Scaling[0, 0] = Scale;
            Scaling[1, 1] = Scale;
            Scaling[2, 2] = Scale;
        }
        public double[,] Coordinates =
        {
            { -8, 4, 1, 1 },
            { -8, 2, 1, 1 },
            { -4, 2, 1, 1 },
            { -4, -8, 1 , 1},
            { -2, -8, 1 , 1},
            { -2, -4, 1 , 1},
            { 2, -4, 1 , 1},
            { 2, -8, 1 , 1},
            { 4, -8, 1 , 1},
            { 4, 2, 1 , 1},
            { 8, 2, 1 , 1},
            { 8, 4, 1 , 1},

            { 0, 4, 1 , 1},
            { -6, 10, 1 , 1},
            { 6, 10, 1 , 1},//14

            //глаз
            { 0, 7, 1.1 , 1},
            { 0, 9, 1.1 , 1},
            { 1, 9, 1.1 , 1},
            { 1, 7, 1.1 , 1},

            //круг
            { 0, 8, 1 , 1},
            { -1.5, 8, 1 , 1},
            { 0, 6.5, 1 , 1},


            { -8, 4, -1, 1},
            { -8, 2, -1, 1},
            { -4, 2, -1, 1},
            { -4, -8, -1, 1},

            { -2, -8, -1, 1},
            { -2, -4, -1, 1},
            { 2, -4, -1, 1},
            { 2, -8, -1, 1},
            { 4, -8, -1, 1},
            { 4, 2, -1, 1},
            { 8, 2, -1, 1},
            { 8, 4, -1, 1},
            { -6, 10, -1, 1},
            { 6, 10, -1, 1},
            { 0, 4, -1, 1}
        };
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
        public int[][] BubbleSort(double[,] coords, int[][] mas)
        {
            int[] temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    double zi = coords[mas[i][0], 2];
                    for (int k = 1; k < mas[i].Length; k++)
                    {
                        if (zi > coords[mas[i][k], 2])
                        {
                            zi = coords[mas[i][k], 2];
                        }
                    }
                    double zj = coords[mas[j][0], 2];
                    for (int k = 1; k < mas[j].Length; k++)
                    {
                        if (zj < coords[mas[j][k], 2])
                        {
                            zj = coords[mas[j][k], 2];
                        }
                    }
                    if (zi < zj)
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
        static public int[][] simples =
        {
            new int[]{0,1,2,3,4,5,6,7,8,9,10,11},
            new int[]{12,13,14 },
            new int[]{15,16,17,18},

            new int[]{22,23,24,25,26,27,28,29,30,31,32,33,},
            new int[]{34,35,36 },

            new int[]{0,1,23,22},
            new int[]{1,2,24,23},
            new int[]{2,3,25,24},
            new int[]{3,4,26, 25 },
            new int[]{4,5,27, 26 },
            new int[]{5,6,28, 27 },
            new int[]{6,7,29, 28 },
            new int[]{7,8,30, 29 },
            new int[]{8,9,31, 30 },
            new int[]{9,10,32, 31 },
            new int[]{10,11,33, 32 },
            new int[]{0,11,33, 22 },

            new int[]{12,13,34, 36 },
            new int[]{12,14,35, 36 },
            new int[]{13,14, 35 ,34}
        };
        public readonly int[][] Transitions =
       {
            //лицевая сторона
            new int[]{0,1},//0
            new int[]{1,2},
            new int[]{2,3},
            new int[]{3,4},
            new int[]{4,5},
            new int[]{5,6},//5
            new int[]{6,7},
            new int[]{7,8},
            new int[]{8,9},
            new int[]{9,10},
            new int[]{10,11},
            new int[]{11,0},//11

            new int[]{12,13},
            new int[]{13,14},
            new int[]{14,12},//14

            new int[]{15,16},
            new int[]{16,17},
            new int[]{17,18},
            new int[]{18,15},//18



            new int[]{22, 0 },//19

            new int[]{23, 1},//20

            new int[]{24, 2 },
            new int[]{3, 25},

            new int[]{4, 26},
            new int[]{5, 27},
            new int[]{6, 28},//25
            new int[]{7, 29},
            new int[]{8, 30},
            new int[]{9, 31},
            new int[]{10, 32},
            new int[]{11, 33},//30
            new int[]{13, 34},
            new int[]{14, 35},//32

            //задняя сторона
            new int[]{23, 22},//33
            new int[]{24, 23},
            new int[]{25, 24},//35
            new int[]{25, 26},
            new int[]{26, 27},
            new int[]{27, 28},
            new int[]{28, 29},
            new int[]{29, 30},//40
            new int[]{30, 31},
            new int[]{31, 32},
            new int[]{32, 33},
            new int[]{33, 22},//44

            new int[]{ 35,34 },
            new int[]{34, 36},
            new int[]{ 36,35 },

            new int[]{12, 36}//48

        };
    }
}
