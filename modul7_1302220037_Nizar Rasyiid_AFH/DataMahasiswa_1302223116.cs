using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_1302220037_Nizar_Rasyiid_AFH
{
    internal class DataMahasiswa_1302223116
    {
        static String json = File.ReadAllText(@"./jurnal7_1_1302223116.json");
        static Mahasiswa mahasiswa = new Mahasiswa();

        public static void readJson()
        {
            mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(json);
            Console.WriteLine(mahasiswa.firstName);
            Console.WriteLine(mahasiswa.lastName);
            Console.WriteLine(mahasiswa.gender);
            Console.WriteLine(mahasiswa.age);
            Console.WriteLine(mahasiswa.address.streetAddress);
            Console.WriteLine(mahasiswa.address.city);
            Console.WriteLine(mahasiswa.address.state);            
            Console.WriteLine(mahasiswa.courses.ElementAt(0).code);
            Console.WriteLine(mahasiswa.courses.ElementAt(0).name);
        }
    }
}
