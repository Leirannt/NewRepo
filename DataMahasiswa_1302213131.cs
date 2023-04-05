using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_10
{
    public class DataMahasiswa_1302213131
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public void ReadJson()
        {
            string Data1 = File.ReadAllText(@"C:\Users\PRAKTIKAN\source\repos\modul7_kelompok_10\modul7_kelompok_10\jurnal7_1_1302213131.json");
            DataMahasiswa_1302213131 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa_1302213131>(Data1);
            Console.WriteLine("Nama Awal  : " + mahasiswa.firstName);
            Console.WriteLine("Nama Akhir : " + mahasiswa.lastName);
            Console.WriteLine("Umur       : " + mahasiswa.age);
            Console.WriteLine("Kelamin    : " + mahasiswa.gender);
        }
    }
}
