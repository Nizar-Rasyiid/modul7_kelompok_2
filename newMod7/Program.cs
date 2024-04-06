using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using newMod7;

namespace modul7_1302220037_Nizar_Rasyiid_AFH
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_1302220037_Nizar_Rasyiid dm = new DataMahasiswa_1302220037_Nizar_Rasyiid();
            TeamMembers_1302220037_Nizar tm = new TeamMembers_1302220037_Nizar();
            GlossaryItem_1302220037_Nizar gm = new GlossaryItem_1302220037_Nizar();
            gm.ReadJson();
            tm.ReadJson();
            dm.ReadJson();
        }
    }
}
