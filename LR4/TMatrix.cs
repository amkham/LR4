using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{

  public  class TMatrix
    {
        private int col, row;
        private int[,] mass;

        public TMatrix(int col, int row)
        {
            this.col = col;
            this.row = row;
            this.Mass = new int[col, row];


        }

        public void Sum(TMatrix matrix)
        {
            for (int i = 0; i < Col; i++)
            {
                for (int j = 0; j < Row; j++)
                {
                    Mass[i, j] = Mass[i, j] + matrix.Mass[i,j];
                }
            }

            
        }

        public void InputMatrix()
        {
            for (int i = 0; i < Col; i++)
            {
                for (int j = 0; j < Row; j++)
                {
                    Mass[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }


        public void Show()
        {
            for (int i = 0; i < Col; i++)
            {
                for (int j = 0; j < Row; j++)
                {
                    Console.Write(Mass[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        public int Col { get => col; set => col = value; }
        public int Row { get => row; set => row = value; }
        public int[,] Mass { get => mass; set => mass = value; }
    }
}
