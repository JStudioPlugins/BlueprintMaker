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
        public static ushort Supply0Amount { get; set; }
        public static ushort Supply1Amount { get; set; }
        public static ushort Supply2Amount { get; set; }
        public static ushort Supply3Amount { get; set; }
        public static ushort Supply4Amount { get; set; }
        public static ushort Supply5Amount { get; set; }
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
            if (SupplyID[0] != 0)
            {
                strings.Add($"Blueprint_0_Supply_0_ID {SupplyID[0]}");
                strings.Add($"Blueprint_0_Supply_0_Amount {Supply0Amount}");
            }
            if (SupplyID[1] != 0)
            {
                strings.Add($"Blueprint_0_Supply_1_ID {SupplyID[1]}");
                strings.Add($"Blueprint_0_Supply_1_Amount {Supply1Amount}");
            }
            if (SupplyID[2] != 0)
            {
                strings.Add($"Blueprint_0_Supply_2_ID {SupplyID[2]}");
                strings.Add($"Blueprint_0_Supply_2_Amount {Supply2Amount}");
            }
            if (SupplyID[3] != 0)
            {
                strings.Add($"Blueprint_0_Supply_3_ID {SupplyID[3]}");
                strings.Add($"Blueprint_0_Supply_3_Amount {Supply3Amount}");
            }
            if (SupplyID[4] != 0)
            {
                strings.Add($"Blueprint_0_Supply_4_ID {SupplyID[4]}");
                strings.Add($"Blueprint_0_Supply_4_Amount {Supply4Amount}");
            }
            if (SupplyID[5] != 0)
            {
                strings.Add($"Blueprint_0_Supply_5_ID {SupplyID[5]}");
                strings.Add($"Blueprint_0_Supply_5_Amount {Supply5Amount}");
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
