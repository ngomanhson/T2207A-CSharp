using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    public class Fraction
    {
        public int tuSo;
        public int mauSo;

        public Fraction(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }

        public Fraction()
        {

        }

        //Nhap phan so
        public void NhapPhanSo()
        {
            do
            {
                Console.WriteLine("Nhap tu so: ");
                string nts = Console.ReadLine();
                tuSo = Convert.ToInt32(nts);
                //Console.WriteLine("Phan so vua nhap: " + t);

                Console.WriteLine("Nhap mau so: ");
                string nms = Console.ReadLine();
                mauSo = Convert.ToInt32(nms);
                //Console.WriteLine("Phan so vua nhap: " + m);
            }
            while (mauSo == 0);
        }

        //In phan so
        public void InPhanSo()
        {
            Console.WriteLine(tuSo +"/"+ mauSo);
        }

        //Uoc chung lon nhat
        private int TimUCLN(int a, int b)
        {
            {
                a = Math.Abs(a);
                b = Math.Abs(b);

                while (a != b)
                {
                    if (a > b)
                        a -= b;
                    else
                        b -= a;
                }
                return a;
            }
        }

        //Rut gon phan so
        public void RutGon()
        {
            int ucln = TimUCLN(tuSo, mauSo);
            tuSo /= ucln;
            mauSo /= ucln;
        }

        //Nghich dao phan so
        public void NghichDao()
        {
            int nghich = tuSo;
            tuSo = mauSo;
            mauSo = nghich;
        }

        //Cong 2 phan so
        public static Fraction Add(Fraction ps1, Fraction ps2)
        {
            Fraction ps = new Fraction();
            ps.tuSo = ps1.tuSo * ps2.mauSo + ps2.tuSo * ps1.mauSo;
            ps.mauSo = ps1.mauSo * ps2.mauSo;
            ps.RutGon();
            return ps;
        }

        // Tru 2 phan so
        public static Fraction Sub(Fraction ps1, Fraction ps2)
        {
            Fraction ps = new Fraction();
            ps.tuSo = ps1.tuSo * ps2.mauSo - ps2.tuSo * ps1.mauSo;
            ps.mauSo = ps1.mauSo * ps2.mauSo;
            ps.RutGon();
            return ps;
        }

        //Nhan 2 phan so
        public static Fraction Mul(Fraction ps1, Fraction ps2)
        {
            Fraction ps = new Fraction();
            ps.tuSo = ps1.tuSo * ps2.tuSo;
            ps.mauSo = ps1.mauSo * ps2.mauSo;
            ps.RutGon();
            return ps;
        }

        //Chia 2 phan so
        public static Fraction Div(Fraction ps1, Fraction ps2)
        {
            Fraction ps = new Fraction();
            ps.tuSo = ps1.tuSo * ps2.mauSo;
            ps.mauSo = ps1.mauSo * ps2.tuSo;
            ps.RutGon();
            return ps;
        }

        public String ToString()
        {
            return tuSo + "/" + mauSo;
        }
    }
    
}