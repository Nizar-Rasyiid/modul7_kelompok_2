using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace newMod7
{
    internal class GlossaryData_1302220037_Nizar
    {
        public class Glossary
        {
            public string Title { get; set; }
            public GlossDiv GlossDiv { get; set; }
        }

        public class GlossDiv
        {
            public string Title { get; set; }
            public GlossList GlossList { get; set; }
        }

        public class GlossList
        {
            public GlossEntry GlossEntry { get; set; }
        }

        public class GlossEntry
        {
            public string ID { get; set; }
            public string SortAs { get; set; }
            public string GlossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev { get; set; }
            public GlossDef GlossDef { get; set; }
            public string GlossSee { get; set; }
        }

        public class GlossDef
        {
            public string Para { get; set; }
            public List<string> GlossSeeAlso { get; set; }
        }

        public void ReadJson()
        {
            try
            {
                string jsonFilePath = "glossary.json";
                string jsonString = File.ReadAllText(jsonFilePath);

                var glossary = JsonSerializer.Deserialize<Glossary>(jsonString);

                Console.WriteLine($"Title: {glossary.Title}");
                Console.WriteLine($"GlossDiv Title: {glossary.GlossDiv.Title}");
                Console.WriteLine($"GlossEntry ID: {glossary.GlossDiv.GlossList.GlossEntry.ID}");
                Console.WriteLine($"GlossTerm: {glossary.GlossDiv.GlossList.GlossEntry.GlossTerm}");
                Console.WriteLine($"Acronym: {glossary.GlossDiv.GlossList.GlossEntry.Acronym}");
                Console.WriteLine($"Abbrev: {glossary.GlossDiv.GlossList.GlossEntry.Abbrev}");
                Console.WriteLine($"GlossSee: {glossary.GlossDiv.GlossList.GlossEntry.GlossSee}");
                Console.WriteLine($"GlossDef Para: {glossary.GlossDiv.GlossList.GlossEntry.GlossDef.Para}");
                Console.WriteLine("GlossSeeAlso:");
                foreach (var item in glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso)
                {
                    Console.WriteLine($"- {item}");
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found: {ex.Message}");
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error while parsing JSON: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
