using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace newMod7
{
    internal class DataMahasiswa_1302220037_Nizar_Rasyiid
    {
        public class Mahasiswa
        {
            [JsonPropertyName("firstName")]
            public string firstName { get; set; }

            [JsonPropertyName("lastName")]
            public string lastName { get; set; }
            [JsonPropertyName("age")]
            public int age { get; set; }

            [JsonPropertyName("address")]
            public Address address { get; set; }

            [JsonPropertyName("courses")]
            public List<Courses> Courses { get; set; }

        }

        public class Courses
        {
            [JsonPropertyName("code")]
            public string code { get; set; }

            [JsonPropertyName("name")]
            public string name { get; set; }
        }


        public class Address
        {
            [JsonPropertyName("streetAddress")]
            public string streetAddress { get; set; }

            [JsonPropertyName("city")]
            public string city { get; set; }

            [JsonPropertyName("state")]
            public string state { get; set; }
        }

        public void ReadJson()
        {
            try
            {
                string fileName = "jurnal7_1_1302220037.json";
                string jsonText = File.ReadAllText(fileName);
                var mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(jsonText);
                string fName = mahasiswa.firstName;
                string lName = mahasiswa.lastName;
                int age = mahasiswa.age;
                string streetAdr = mahasiswa.address.streetAddress;
                string cit = mahasiswa.address.city;
                string stat = mahasiswa.address.state;
                Console.WriteLine($"Nama Depan {fName}, Nama Belakang {lName} dengan umur {age} di jalan {streetAdr} di kota {cit} di Provinsi {stat}  ");
                Console.WriteLine(mahasiswa.Courses.ElementAt(0).code);
                Console.WriteLine(mahasiswa.Courses.ElementAt(0).name);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }
        }

    }
}
