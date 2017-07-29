using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutExample_EasyIt.edu.vn
{
    class Program
    {
        static void Main(string[] args)
        {
            //double so = 2;
            //Console.WriteLine("");
            //Console.WriteLine("  Gia tri so ban dau: " + so);

            //NhanDoi(so);
            //Console.WriteLine("  Ket qua goi ham NhanDoi: " + so);

            //NhanDoiVoiRef(ref so);
            //Console.WriteLine("  Ket qua goi ham NhanDoiVoiRef: " + so);

            //---------------------------------------------------------------------

            int a = 9, b = 2, ketquaChia;

            Console.WriteLine("");
            Console.WriteLine("  Ket qua chia het: " + ChiaHet(a, b, out ketquaChia));
            Console.WriteLine("  Ket qua phep chia a = {0} cho b = {1} la: {2}", a, b, ketquaChia);
            Console.ReadKey();
        }

        static bool ChiaHet(int soBiChia, int soChia, out int thuong)
        {
            thuong = soBiChia / soChia;
            return soBiChia == thuong * soChia;
        }

        static void NhanDoi(double x)
        {
            x *= 2;
        }

        static void NhanDoiVoiRef(ref double x)
        {
            x *= 2;
        }
    }
}

