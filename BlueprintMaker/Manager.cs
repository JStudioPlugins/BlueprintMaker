using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueprintMaker
{
    public static class Manager
    {
        public static string ItemName { get; set; }
        public static string BlueprintType { get; set; }
        public static ushort Supplies { get; set; }
        public static ushort[] SupplyID = new ushort[] { 0, 0, 0, 0, 0, 0 };
        public static ushort[] SupplyAmount = new ushort[] { 0, 0, 0, 0, 0, 0 };
        public static ushort ToolID { get; set; }
        public static ushort ProductID { get; set; }
        public static ushort ProductAmount { get; set; }
        public static ushort BuildID { get; set; }
        public static ushort Level { get; set; }
        public static string Skill { get; set; }
        public static ushort ItemID { get; set; }

        public static void Export()
        {
            List<string> strings = new List<string>();
            strings.Add($"GUID {Guid.NewGuid()}");
            strings.Add($"Type Filter");
            strings.Add($"Rarity Rare");
            strings.Add($"Useable Filter");
            strings.Add($"ID {ItemID}");
            strings.Add($"");
            strings.Add($"Size_X 1");
            strings.Add($"Size_Y 1");
            strings.Add($"Size_Z 0.225");
            strings.Add($"");
            strings.Add($"Blueprints 1");
            strings.Add($"Blueprint_0_Type {BlueprintType}");
            strings.Add($"Blueprint_0_Supplies {Supplies}");
            int x = 0;
            foreach (ushort id in SupplyID)
            {
                strings.Add($"Blueprint_0_Supply_{x}_ID {id}");
                strings.Add($"Blueprint_0_Supply_{x}_Amount {SupplyAmount[x]}");
                x++;
            }
            if (ToolID != 0)
            {
                strings.Add($"Blueprint_0_Tool {ToolID}");
            }
            strings.Add($"Blueprint_0_Product {ProductID}");
            strings.Add($"Blueprint_0_Products {ProductAmount}");
            strings.Add($"Blueprint_0_Build {BuildID}");
            if (Skill != "None")
            {
                strings.Add($"Blueprint_0_Skill {Skill}");
                strings.Add($"Blueprint_0_Level {Level}");
            }
            strings.Add($"");
            strings.Add($"Master_Bundle_Override core.masterbundle");
            strings.Add($"Bundle_Override_Path /Items/Filters/Filter");
                

            File.WriteAllLines($"{ItemName}.dat", strings.ToArray());
            List<string> english = new List<string>();
            english.Add($"Name {ItemName}");
            english.Add($"Description Item for a blueprint that gives {ProductID}.");
            File.WriteAllLines($"English.dat", english.ToArray());
        }
    }
}
