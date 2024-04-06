using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace newMod7
{
    internal class TeamMembers_1302220037_Nizar
    {
        public class MemberContainer
        {
            [JsonPropertyName("members")]
            public List<Member> Members { get; set; }
        }

        public class Member
        {
            [JsonPropertyName("firstName")]
            public string FirstName { get; set; }

            [JsonPropertyName("lastName")]
            public string LastName { get; set; }

            [JsonPropertyName("gender")]
            public string Gender { get; set; }

            [JsonPropertyName("age")]
            public int Age { get; set; }

            [JsonPropertyName("nim")]
            public string Nim { get; set; }
        }

        public void ReadJson()
        {
            try
            {
                string fileName = "jurnal7_2_1302220037.json";
                string jsonText = File.ReadAllText(fileName);

                var container = JsonSerializer.Deserialize<MemberContainer>(jsonText);

                foreach (var member in container.Members)
                {
                    Console.WriteLine($"Nama: {member.FirstName} {member.LastName}");
                    Console.WriteLine($"Jenis Kelamin: {member.Gender}");
                    Console.WriteLine($"Umur: {member.Age}");
                    Console.WriteLine($"NIM: {member.Nim}");
                    Console.WriteLine();
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File tidak ditemukan: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }
        }
    }
}
