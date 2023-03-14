using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making_With_Different_Method
{
    class InputData
    {
        //method yang berfungsi untuk memasukkan data

        // Numeric nilM, nilB
        public double nilM, nilB;

        public double InputNilaiM()
        {
            // Display 'Masukkan Nilai Matematika = '
            Console.Write("Masukan nilai Matematika = ");

            // Accept nilM
            nilM = Convert.ToDouble(Console.ReadLine());
            return nilM;
        }

        public double InputNilaiB()
        {
            // Display 'Masukkan Nilai Bahasa Inggris = '
            Console.Write("Masukkan nilai Bahasa Inggris = ");

            // Accept nilB
            nilB = Convert.ToDouble(Console.ReadLine());
            return nilB;
        }
    }
    class ProsesData
    {
        // method yang berfungsi untuk memproses data

        // Numeric rerata
        public double rerata;

        public double Hitung(double nilM, double nilB)
        {
            // Compute rerata = (nilM + nilB) / 2 
            // menghitung rerata dengan rumus nilm + nilb/2
            rerata = (nilM + nilB) / 2;
            return rerata;
        }


    }
    class OutputData
    {
        // method yang berfungsi untuk menampilkan output data

        // Character Status
        public string status;

        public void Hasil(double rerata, double nilM)
        {
            // if (rerata >= 60 AND nilM >= 70) jika rerata lebih dari 60 dan nilai mata kuliah lebih dari 70 maka dinyatakan lulus
            if (rerata >= 60 & nilM >= 70)

            { // Begin 

                // Status = 'lulus' menampilkan status lulus
                Console.WriteLine("Lulus");
            } // End
            else
            { // Begin

                // Status = 'Gagal' menampilkan status gagal
                Console.WriteLine("Gagal");
            } // End
        }
        public void Status(string status)
        // Menampilkan status peserta
        {
            Console.WriteLine("Status peserta adalah {0}", status);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // initiate Class
            InputData id = new InputData();
            ProsesData pd = new ProsesData();
            OutputData od = new OutputData();

            // panggil method untuk input data
            id.InputNilaiM();
            id.InputNilaiB();

            // panggil method untuk proses data
            pd.Hitung(id.nilM, id.nilB);

            // panggil method untuk output  data
            od.Status(od.status);
            od.Hasil(pd.rerata, id.nilM);

            Console.ReadKey();
        }
    }

}