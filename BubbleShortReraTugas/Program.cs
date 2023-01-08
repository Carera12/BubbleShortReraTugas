using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleShortReraTugas
{
    class Program
    {
        //Deklarasi array int dengan ukuran 83
        private int[] a = new int[83];

        //Deklarasi variable int untuk menyimpan banyaknya data pada array
        private int n;

        //Fungsi / Method untuk menerima masukan
        public void read()
        {
            //Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Rera: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 83)
                    break;
                else
                    Console.WriteLine("\nRera dapat mempunyai maksimal 83 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Masukkan elemen Rera");
            Console.WriteLine("---------------------");

            //Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Element Rera yang telah tersusun");
            Console.WriteLine("---------------------------------");
            for (int SC = 0; SC < n; SC++)
            {
                Console.WriteLine(a[SC]);
            }
            Console.WriteLine("");
        }
        public void BubbletSortArray()
        {
            for (int i = 1; i < n; i++) //For n-1 passes
            {
                //Pada pass i, bandingkan n-i elemen pertama dengan elemen selanjutnya
                for (int SC = 0; SC < n - SC; SC++)
                {
                    if (a[SC] > a[SC + 1]) //Jika elemen tidak dalam urutan yang benaar
                    {
                        //Tukar elemen
                        int temp;
                        temp = a[SC];
                        a[SC] = a[SC + 1];
                        a[SC + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Creating the object of the BubbleSort class
            Program myList = new Program();

            //Pemanggilan fungsi untuk menerima elemen array
            myList.read();
            //Pemanggilan fungsi untuk mengurutkan array
            myList.BubbletSortArray();
            //Pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();
            //Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}
