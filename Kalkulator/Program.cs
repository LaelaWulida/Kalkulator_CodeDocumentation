using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remarks>class Kalk dapat memuat operasi tambah dan pembagian</remarks>
    class Kalk
    {
        /// <summary>
        /// operasi penjumlahan dan pembagian
        /// </summary>
        /// <param name="bil1">angka pertama dalam operasi penjumlahan</param>
        /// <param name="bil2">angka kedua dalam operasi penjumlahan</param>
        /// <returns name="penjumlahan">hasil dari penjumlahan angka pertama dan angka kedua</returns>
        /// <returns name="pembagian">hasil dari pembagian angka pertama dan angka kedua</returns>
        public double bil1, bil2, hasil;
        public void Masukkan()
        {
            Console.Write("Masukkan bilangan pertama = ");
            bil1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan bilangan kedua = ");
            bil2 = Convert.ToDouble(Console.ReadLine());
        }

        public void TampilHasil()
        {
            Console.WriteLine("hasil = " + hasil);
            Console.ReadLine();
        }
        public double Penjumlahan(Double a, double b)
        {
            return a + b;
        }

        public double Pembagian(double a, double b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            Kalk k = new Kalk();
            k.Masukkan();
            k.hasil = k.Penjumlahan(k.bil1, k.bil2);
            k.TampilHasil();
            k.hasil = k.Pembagian(k.bil1, k.bil2);
            k.TampilHasil();
        }
    }
}
