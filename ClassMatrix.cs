    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using ZedGraph;

namespace Draw
{
        class Matrix
        {
            public double[][] M;

            public Matrix(int len)
            {

                M = new double[len][];
                for (int i = 0; i < M.GetLength(0); i++)
                {
                    M[i] = new double[len];
                    for (int j = 0; j < len; j++)
                        M[i][j] = 0;
                }

            }
            public void inputByFile(string fName)
            {
                try
                {
                    using (StreamReader file = new StreamReader(fName))
                    {

                        string temp = "";
                        string line = file.ReadLine();
                        int n_r = Convert.ToInt32(line);
                        line = file.ReadLine();
                        int n_c = Convert.ToInt32(line);
                        M = new double[n_r][];
                        int i = 0;
                        while ((line = file.ReadLine()) != null)
                        {
                            string[] spl = line.Split(new Char[] { ' ' });
                            int j = 0;
                            M[i] = new double[n_c];
                            foreach (string s in spl)
                            {

                                if (!(temp.Equals(s)))
                                { M[i][j] = (double)Convert.ToInt32(s); j++; }
                            }
                            ++i;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(" File can not be read");
                    Console.WriteLine(e.Message);
                }
            }

            public Matrix(int len_r, int len_c)
            {
                M = new double[len_r][];
                for (int i = 0; i < len_r; i++)
                {
                    M[i] = new double[len_c];
                    for (int j = 0; j < len_c; j++)
                        M[i][j] = 0;
                }

            }
            public Matrix(Matrix A)
            {
                M = new double[A.M.Length][];
                for (int i = 0; i < M.Length; i++)
                {
                    M[i] = new double[A.M[0].Length];
                    for (int j = 0; j < A.M[0].Length; j++)
                        M[i][j] = A.M[i][j];
                }
            }

            public void output()
            {
                Console.WriteLine("\nMatrix \n");
                for (int i = 0; i < M.Length; i++)
                {
                    Console.Write(" ");
                    for (int j = 0; j < M[i].Length; j++)
                    {
                        Console.Write("{0} ", M[i][j]);    //!   
                    }
                    Console.WriteLine("\n");
                }
            }
            public void outputByFile()
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream("output.txt", FileMode.Create);
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        for (int i = 0; i < M.Length; i++)
                        {
                            for (int j = 0; j < M[i].Length; j++)
                            {
                                writer.Write(M[i][j]);
                                writer.Write(' ');
                            }
                            writer.Write("\r\n");//возврат каретки
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(" File can not be write");
                    Console.WriteLine(e.Message);
                }
            }
            public void outputByFile(string s)
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(s, FileMode.Create);
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        for (int i = 0; i < M.Length; i++)
                        {
                            for (int j = 0; j < M[i].Length; j++)
                            {
                                writer.Write(M[i][j]);
                                writer.Write(' ');
                            }
                            writer.Write("\r\n");//возврат каретки
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(" File can not be write");
                    Console.WriteLine(e.Message);
                }
            }

            public static Matrix operator *(Matrix obj1, int scalar)// withou friend!!! why static
            {
                Matrix result = new Matrix(obj1.M.Length, obj1.M[0].Length);
                for (int i = 0; i < obj1.M.Length; i++)
                    for (int j = 0; j < obj1.M[i].Length; j++)
                        result.M[i][j] = obj1.M[i][j] * scalar;

                return result;
            }
            public static Matrix operator /(Matrix obj1, int scalar)// withou friend!!! why static
            {
                Matrix result = new Matrix(obj1.M.Length, obj1.M[0].Length);
                try
                {
                    for (int i = 0; i < obj1.M.Length; i++)
                        for (int j = 0; j < obj1.M[i].Length; j++)
                            result.M[i][j] = obj1.M[i][j] / scalar;
                }
                catch (Exception e)
                {
                    Console.WriteLine(" Dividing\n");
                    Console.WriteLine(e.Message);
                }
                return result;
            }
            public static Matrix operator *(Matrix obj1, double scalar)// withou friend!!! why static
            {
                Matrix result = new Matrix(obj1.M.Length, obj1.M[0].Length);
                for (int i = 0; i < obj1.M.Length; i++)
                    for (int j = 0; j < obj1.M[i].Length; j++)
                        result.M[i][j] = obj1.M[i][j] * scalar;

                return result;
            }
            public static Matrix operator /(Matrix obj1, double scalar)// withou friend!!! why static
            {
                Matrix result = new Matrix(obj1.M.Length, obj1.M[0].Length);
                try
                {
                    for (int i = 0; i < obj1.M.Length; i++)
                        for (int j = 0; j < obj1.M[i].Length; j++)
                            result.M[i][j] = obj1.M[i][j] / scalar;
                }
                catch (Exception e)
                {
                    Console.WriteLine(" Dividing\n");
                    Console.WriteLine(e.Message);
                }
                return result;
            }
            public static Matrix operator +(Matrix obj1, Matrix obj2)// binary withou friend!!!
            {
                Matrix result = new Matrix(obj1.M.Length, obj1.M[0].Length);
                for (int i = 0; i < obj1.M.Length; i++)
                    for (int j = 0; j < obj1.M[i].Length; j++)
                        result.M[i][j] = obj1.M[i][j] + obj2.M[i][j];

                return result;
            }
            public static Matrix operator -(Matrix obj1, Matrix obj2)// binary withou friend!!!
            {
                Matrix result = new Matrix(obj1.M.Length, obj1.M[0].Length);
                for (int i = 0; i < obj1.M.Length; i++)
                    for (int j = 0; j < obj1.M[i].Length; j++)
                        result.M[i][j] = obj1.M[i][j] - obj2.M[i][j];

                return result;
            }
            public static Matrix operator *(Matrix obj1, Matrix obj2)
            {
                Matrix result = new Matrix(obj1.M.Length, obj2.M[0].Length);
                try
                {
                    for (int i = 0; i < obj1.M.Length; i++)
                        for (int j = 0; j < obj2.M[0].Length; j++)
                            for (int k = 0; k < obj2.M.Length; k++)
                                result.M[i][j] += obj1.M[i][k] * obj2.M[k][j];
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return result;

            }// operator = can not be override
            public Matrix transp()
            {
                Matrix help = new Matrix(this.M[0].Length, this.M.Length);//!
                for (int i = 0; i < M.Length; i++)
                    for (int j = 0; j < M[0].Length; j++)
                        help.M[j][i] = M[i][j];
                return help;
            }
            public Matrix pow(int p)
            {
                Matrix help = new Matrix(1, 1);
                help.inputByFile("inputE.txt");
                for (int i = 1; i <= p; i++)
                    help = help * this;
                return help;
            }
            public Matrix make_F(Matrix A, double T, int q)
            {

                Matrix F = new Matrix(1, 1);
                F.inputByFile("inputE.txt");
                F = F + A * T;
                for (int i = 2; i <= q; i++)
                {
                    F = F + A.pow(i) * (double)(Math.Pow(T, (1.0) * i)) / fact(i);
                }
                return F;
            }
            public Matrix make_G(Matrix A, Matrix B, double T, int q)
            {
                Matrix G = new Matrix(1, 1);
                Matrix I = new Matrix(1, 1);
                I.inputByFile("inputE.txt");
                G = I * T;
                for (int i = 2; i <= q; i++)
                {
                    G = G + A.pow(i - 1) * (double)(Math.Pow(T, (1.0) * i)) / fact(i);
                }
                return (G * B);
            }
            public static int fact(int n)
            {
                int res = 1;
                if (n == 0 || n == 1) return 1;
                for (int i = 2; i <= n; i++) res *= i;
                return res;
            }


            static public bool checkLimit(Matrix A, double T)
            {
                Matrix E= new Matrix(1,1);
                Matrix O = new Matrix(3, 3);
                E.inputByFile("inputE.txt");
                Matrix Check = new Matrix(1, 1);
                Check = E + A * T;
                double eps = 0.000001;
                double temp;
                
                Check = Check.pow(100000);
                Check.outputByFile();
                for( int i=0; i< Check.M.Length; i++)
                    for (int j = 0; j < Check.M[i].Length; j++)
                    {
                        if (Check.M[i][j] < 0) temp = (-1) * Check.M[i][j];
                        else temp = Check.M[i][j];
                        if (temp < eps) continue;
                        else  return false;        
                    }
                return true;
            }

            public double determinant()
            {
                double det = 0.0;
                if (M.Length != M[0].Length) return 0.0;
                if (M.Length == 1 && M[0].Length ==1) return M[0][0];
                for (int i = 0; i < M.Length; i++)
                {

                    Matrix Minor = this.minor(i, 0);
                    det += Math.Pow(-1.0, i * 1.0) * M[i][0] * Minor.determinant();
                }
                return det;

            }
            public Matrix minor(int i, int j)
            {
                Matrix result = new Matrix(this);
                result = deleteRowAndColumn(result,i, j);
                return result;
            }

            public static Matrix deleteRowAndColumn(Matrix obj1, int r, int c)
            {
                Matrix help = new Matrix(obj1);
               
                int n = obj1.M.Length;
                Matrix result = new Matrix(obj1.M.Length - 1, obj1.M[0].Length - 1);

                int mi = 0, mj = 0;
                try
                {
                    for (int i = 0; i < help.M.Length; i++)
                    {
                        mj = 0;
                        for (int j = 0; j < help.M[0].Length; j++)
                        {
                            if (i != r && j != c)
                            {
                                result.M[mi][mj] = help.M[i][j];
                                mj++;
                            }

                        }
                        if (i != r) mi++;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(" There is a roblem with the array in function <deleteRowandColumn>\n");
                    Console.WriteLine(e.Message);
                }
                return result;

            }
            public Matrix inverseMatrix()
            {
                Matrix inverse = new Matrix(M.Length, M[0].Length);
                Matrix result = new Matrix(1, 1);
                
                double det = this.determinant();

                if (det == 0.0) throw new FormatException(" An inverse matrix doesn't exist. DET=0\n");
                try
                {
                
                    for (int i = 0; i < M.Length; i++)
                        for (int j = 0; j < M[0].Length; j++)
                        {

                            Matrix Minor = this.minor(i, j);
                            double detMin = Minor.determinant();
                            inverse.M[i][j] = Math.Pow(-1.0, 1.0 * i + 1.0 * j) * detMin / det;
                        }
                     result = inverse.transp();
                     
                }


                catch (Exception e)
                {
                    Console.WriteLine(" An inverse matrix doesn't exist. det=0\n");
                    Console.WriteLine(e.Message);
                }
                return result;
            }



        }

    }


