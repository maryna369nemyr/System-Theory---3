using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    static class Processing
    {
        static public int q, k0;
        static public double a1, a2, b, T;
        static public bool checkLimit;
        static public Matrix x_0 = new Matrix(3, 1), xx = new Matrix(3, 1);

        static public Matrix P = new Matrix(1, 1);
        static public Matrix Sigma = new Matrix(1, 1);
        static public Matrix L = new Matrix(1, 1);
        static public Matrix vectorL0 = new Matrix(1, 1);
      




        static public bool checkString(string s1, string s2, string s3, string s4, string s5, string s6, string s7, string s8)
        {
            return (s1.Length != 0 && s2.Length != 0 && s3.Length != 0 && s4.Length != 0 && s5.Length != 0 && s6.Length != 0 && s7.Length != 0 && s8.Length != 0);
        }
        public static bool checkComponents(int q, double a1, double a2, double T)
        {
            return (((q <= 10 && q >= 1) && (a1 <= 10 && a1 >= 1) && (a2 <= 10 && a2 >= 1) && (T <= 1 && T >= 0.001)));
        }
        static public bool checkAccurancy(int q)
        {
            return (q%2!=0);
        }


        static public void function()
        {
            Program.x.Clear();
            Program.y.Clear();
            Program.u.Clear();

            
            Matrix A = new Matrix(1, 1);
            Matrix B = new Matrix(1, 1);
            Matrix C = new Matrix(1, 1);
            Matrix E = new Matrix(1, 1);
            Matrix F = new Matrix(1, 1);
            Matrix G = new Matrix(1, 1);

            Matrix Linv = new Matrix(1, 1);

            List<Matrix> H; // G in the book
            List<Matrix> Htransp;

            
            Matrix Ainv = new Matrix(1, 1);


            

            A.inputByFile("inputA.txt");
            B.inputByFile("inputB.txt");
            C.inputByFile("inputC.txt");
            E.inputByFile("inputE.txt");
            A.M[2][1] = -a1;
            A.M[2][2] = -a2;
            B.M[2][0] = b;

            F = F.make_F(A, T, q);
          
            G = G.make_G(A, B, T, q);

            checkLimit = Matrix.checkLimit(A, Processing.T);

            P = findFDependOnParametr(F, k0);
            Sigma = findSumMatrixH(F, G, k0, out H, out Htransp);
            
            L = P * Sigma;
            Linv = L.inverseMatrix();
            vectorL0 = Linv * xx;
            
            initControlU(Htransp, vectorL0, k0, out Program.u);

            X_function_Y(F, G, Program.u, T, C, k0);
                     

        }     
       


        static public Matrix findFDependOnParametr( Matrix F, int param)
        {
            Matrix P = new Matrix(1, 1);
            P.inputByFile("inputE.txt");
            for (int j = 1; j < param; j++)
            {
                P = F * P;
            }
            return P;

        }

        static public Matrix findSumMatrixH(Matrix F,Matrix G,  int param , out List<Matrix> H, out List<Matrix> Htransp)
        {
            Matrix P = new Matrix(F);           
            
            Matrix Finv = F.inverseMatrix();

            Matrix Sigma = new Matrix(3,3);// 0.0 

             H =  new List<Matrix>();
             Htransp  = new List<Matrix>();

            for (int j = 0; j < param; j++)
            {
                P = Finv * P;
                Matrix  temp = P*G;
                H.Add(new Matrix(temp));
                Htransp.Add(new Matrix(temp.transp()));
                Sigma = Sigma + H[j] * Htransp[j];
            }
            return Sigma;

        }
        static public void initControlU(List<Matrix> Htransp,  Matrix vectorL0, int param, out List<double> result)
        {
            result = new List<double>();
            for (int i = 0; i < param; i++)
            {
                Matrix temp = Htransp[i] * vectorL0;
                result.Add(temp.M[0][0]);
            }

        }

        static public void X_function_Y(Matrix F, Matrix G, List<double> u, double T, Matrix C, int param)
        {

            Program.x.Clear();
            Program.y.Clear();
            Matrix temprorary_y = new Matrix(1, 1);
            Program.x.Add(Processing.x_0);


            for (int i = 0; i < param ; i++)
            {
                Program.x.Add((F * Program.x[i] + G * u[i]));
                temprorary_y = C * Program.x[i];
                Program.y.Add(temprorary_y.M[0][0]);
            }
           
            temprorary_y = C * Program.x[param];
            Program.y.Add(temprorary_y.M[0][0]);


        }

    }
}
