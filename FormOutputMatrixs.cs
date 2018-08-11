using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class FormOutputMatrixs : Form
    {
        public FormOutputMatrixs()
        {
            InitializeComponent();
            dataFull();
        }

        private void dataGridViewP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void dataFull()
        {
            string[][] rowsP, rowsSigma, rowsL, rowsVectorL0;

            rowsP = new string[Processing.P.M.Length][];
            for (int i = 0; i < Processing.P.M.Length; i++)
            {
                rowsP[i] = new string[Processing.P.M[0].Length];
                for (int j = 0; j < Processing.P.M[0].Length; j++)
                {
                   rowsP[i][j] = Math.Round(Processing.P.M[i][j], 5).ToString();
                }
            }

            rowsSigma = new string[Processing.Sigma.M.Length][];
            for (int i = 0; i < Processing.Sigma.M.Length; i++)
            {
                rowsSigma[i] = new string[Processing.Sigma.M[0].Length];
                for (int j = 0; j < Processing.Sigma.M[0].Length; j++)
                {
                    rowsSigma[i][j] = Math.Round(Processing.Sigma.M[i][j], 5).ToString();
                }
            }

            rowsL = new string[Processing.L.M.Length][];
            for (int i = 0; i < Processing.L.M.Length; i++)
            {
                rowsL[i] = new string[Processing.L.M[0].Length];
                for (int j = 0; j < Processing.L.M[0].Length; j++)
                {
                    rowsL[i][j] = Math.Round(Processing.L.M[i][j], 5).ToString();
                }
            }
           
            rowsVectorL0 = new string[Processing.vectorL0.M.Length][];
            for (int i = 0; i < Processing.vectorL0.M.Length; i++)
            {
                rowsVectorL0[i] = new string[Processing.vectorL0.M[0].Length];
                for (int j = 0; j < Processing.vectorL0.M[0].Length; j++)
                {
                    rowsVectorL0[i][j] = Math.Round(Processing.vectorL0.M[i][j], 5).ToString();
                }
            }

            foreach (string[] rowArray in rowsP)
                dataGridViewP.Rows.Add(rowArray);

            foreach (string[] rowArray in rowsSigma)
                dataGridViewSigma.Rows.Add(rowArray);

            foreach (string[] rowArray in rowsL)
                dataGridViewL.Rows.Add(rowArray);

            foreach (string[] rowArray in rowsVectorL0)
                dataGridViewVectorL.Rows.Add(rowArray);
        }



        //public void matrixIntoString(out string[][] rows, Matrix example)
        //{
        //    rows = new string[example.M.Length][];

        //    for (int i = 0; i < example.M.Length; i++)
        //    {
        //        rows[i] = new string[example.M[0].Length];


        //        for (int j = 0; j < example.M[0].Length; j++)
        //        {
        //            rows[i][j] = Math.Round(example.M[i][j], 5).ToString();
        //        }                  
        //    }
        //}



    }
}
