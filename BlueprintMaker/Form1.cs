using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueprintMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string fix = textBox1.Text.Replace(" ", "_");
            Manager.ItemName = fix;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.GetItemChecked(0) == true)
            {
                Manager.BlueprintType = "Tool";
            }
            if (checkedListBox1.GetItemChecked(1) == true)
            {
                Manager.BlueprintType = "Apparel";
            }
            if (checkedListBox1.GetItemChecked(2) == true)
            {
                Manager.BlueprintType = "Supply";
            }
            if (checkedListBox1.GetItemChecked(3) == true)
            {
                Manager.BlueprintType = "Gear";
            }
            if (checkedListBox1.GetItemChecked(4) == true)
            {
                Manager.BlueprintType = "Ammo";
            }
            if (checkedListBox1.GetItemChecked(5) == true)
            {
                Manager.BlueprintType = "Barricade";
            }
            if (checkedListBox1.GetItemChecked(6) == true)
            {
                Manager.BlueprintType = "Structure";
            }
            if (checkedListBox1.GetItemChecked(7) == true)
            {
                Manager.BlueprintType = "Repair";
            }
            if (checkedListBox1.GetItemChecked(8) == true)
            {
                Manager.BlueprintType = "Furniture";
            }
            if (checkedListBox1.GetItemChecked(9) == true)
            {
                Manager.BlueprintType = "Utilities";
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Manager.Supplies = (ushort)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Manager.SupplyID[0] = (ushort)numericUpDown3.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            Manager.SupplyAmount[0] = (ushort)numericUpDown4.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            Manager.SupplyID[1] = (ushort)numericUpDown5.Value;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            Manager.SupplyAmount[1] = (ushort)numericUpDown6.Value;
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            Manager.SupplyID[2] = (ushort)numericUpDown7.Value;
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            Manager.SupplyAmount[2] = (ushort)numericUpDown8.Value;
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            Manager.SupplyID[3] = (ushort)numericUpDown9.Value;
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            Manager.SupplyAmount[3] = (ushort)numericUpDown10.Value;
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            Manager.SupplyID[4] = (ushort)numericUpDown11.Value;
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            Manager.SupplyAmount[4] = (ushort)numericUpDown12.Value;
        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            Manager.ToolID = (ushort)numericUpDown13.Value;
        }

        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
            Manager.ProductID = (ushort)numericUpDown14.Value;
        }

        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            Manager.ProductAmount = (ushort)numericUpDown15.Value;
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox2.GetItemChecked(0) == true)
            {
                Manager.BuildID = 27;
            }
            if (checkedListBox2.GetItemChecked(1) == true)
            {
                Manager.BuildID = 10;
            }
            if (checkedListBox2.GetItemChecked(2) == true)
            {
                Manager.BuildID = 32;
            }
            if (checkedListBox2.GetItemChecked(3) == true)
            {
                Manager.BuildID = 9;
            }
            if (checkedListBox2.GetItemChecked(4) == true)
            {
                Manager.BuildID = 126;
            }
            if (checkedListBox2.GetItemChecked(5) == true)
            {
                Manager.BuildID = 47101;
            }
            if (checkedListBox2.GetItemChecked(6) == true)
            {
                Manager.BuildID = 47104;
            }
            if (checkedListBox2.GetItemChecked(7) == true)
            {
                Manager.BuildID = 47103;
            }
            if (checkedListBox2.GetItemChecked(8) == true)
            {
                Manager.BuildID = 47102;
            }
        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox3.GetItemChecked(0) == true)
            {
                Manager.Skill = "Craft";
            }
            if (checkedListBox3.GetItemChecked(1) == true)
            {
                Manager.Skill = "Cook";
            }
            if (checkedListBox3.GetItemChecked(2) == true)
            {
                Manager.Skill = "Repair";
            }
            if (checkedListBox3.GetItemChecked(3) == true)
            {
                Manager.Skill = "None";
            }
        }

        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {
            Manager.Level = (ushort)numericUpDown16.Value;
        }

        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {
            Manager.ItemID = (ushort)numericUpDown17.Value;
        }

        private void numericUpDown18_ValueChanged(object sender, EventArgs e)
        {
            Manager.SupplyID[5] = (ushort)numericUpDown18.Value;
        }

        private void numericUpDown19_ValueChanged(object sender, EventArgs e)
        {
            Manager.SupplyAmount[5] = (ushort)numericUpDown19.Value;
        }

        private void numericUpDown20_ValueChanged(object sender, EventArgs e)
        {
            Manager.SupplyID[6] = (ushort)numericUpDown20.Value;
        }

        private void numericUpDown21_ValueChanged(object sender, EventArgs e)
        {
            Manager.SupplyAmount[6] = (ushort)numericUpDown21.Value;
        }

        private void CopyValues()
        {
            string fix = textBox1.Text.Replace(" ", "_");
            Manager.ItemName = fix;
            if (checkedListBox1.GetItemChecked(0) == true)
            {
                Manager.BlueprintType = "Tool";
            }
            if (checkedListBox1.GetItemChecked(1) == true)
            {
                Manager.BlueprintType = "Apparel";
            }
            if (checkedListBox1.GetItemChecked(2) == true)
            {
                Manager.BlueprintType = "Supply";
            }
            if (checkedListBox1.GetItemChecked(3) == true)
            {
                Manager.BlueprintType = "Gear";
            }
            if (checkedListBox1.GetItemChecked(4) == true)
            {
                Manager.BlueprintType = "Ammo";
            }
            if (checkedListBox1.GetItemChecked(5) == true)
            {
                Manager.BlueprintType = "Barricade";
            }
            if (checkedListBox1.GetItemChecked(6) == true)
            {
                Manager.BlueprintType = "Structure";
            }
            if (checkedListBox1.GetItemChecked(7) == true)
            {
                Manager.BlueprintType = "Repair";
            }
            if (checkedListBox1.GetItemChecked(8) == true)
            {
                Manager.BlueprintType = "Furniture";
            }
            if (checkedListBox1.GetItemChecked(9) == true)
            {
                Manager.BlueprintType = "Utilities";
            }
            Manager.Supplies = (ushort)numericUpDown2.Value;
            Manager.SupplyID[0] = (ushort)numericUpDown3.Value;
            Manager.SupplyAmount[0] = (ushort)numericUpDown4.Value;
            Manager.SupplyID[1] = (ushort)numericUpDown5.Value;
            Manager.SupplyAmount[1] = (ushort)numericUpDown6.Value;
            Manager.SupplyID[2] = (ushort)numericUpDown7.Value;
            Manager.SupplyAmount[2] = (ushort)numericUpDown8.Value;
            Manager.SupplyID[3] = (ushort)numericUpDown9.Value;
            Manager.SupplyAmount[3] = (ushort)numericUpDown10.Value;
            Manager.SupplyID[4] = (ushort)numericUpDown11.Value;
            Manager.SupplyAmount[4] = (ushort)numericUpDown12.Value;
            Manager.SupplyID[5] = (ushort)numericUpDown18.Value;
            Manager.SupplyAmount[5] = (ushort)numericUpDown19.Value;
            Manager.SupplyID[6] = (ushort)numericUpDown20.Value;
            Manager.SupplyAmount[6] = (ushort)numericUpDown21.Value;
            Manager.ToolID = (ushort)numericUpDown13.Value;
            Manager.ProductID = (ushort)numericUpDown14.Value;
            Manager.ProductAmount = (ushort)numericUpDown15.Value;
            if (checkedListBox2.GetItemChecked(0) == true)
            {
                Manager.BuildID = 27;
            }
            if (checkedListBox2.GetItemChecked(1) == true)
            {
                Manager.BuildID = 10;
            }
            if (checkedListBox2.GetItemChecked(2) == true)
            {
                Manager.BuildID = 32;
            }
            if (checkedListBox2.GetItemChecked(3) == true)
            {
                Manager.BuildID = 9;
            }
            if (checkedListBox2.GetItemChecked(4) == true)
            {
                Manager.BuildID = 126;
            }
            if (checkedListBox2.GetItemChecked(5) == true)
            {
                Manager.BuildID = 47101;
            }
            if (checkedListBox2.GetItemChecked(6) == true)
            {
                Manager.BuildID = 47104;
            }
            if (checkedListBox2.GetItemChecked(7) == true)
            {
                Manager.BuildID = 47103;
            }
            if (checkedListBox2.GetItemChecked(8) == true)
            {
                Manager.BuildID = 47102;
            }
            if (checkedListBox3.GetItemChecked(0) == true)
            {
                Manager.Skill = "Craft";
            }
            else if (checkedListBox3.GetItemChecked(1) == true)
            {
                Manager.Skill = "Cook";
            }
            else if (checkedListBox3.GetItemChecked(2) == true)
            {
                Manager.Skill = "Repair";
            }
            else if (checkedListBox3.GetItemChecked(3) == true)
            {
                Manager.Skill = "None";
            }
            else
            {
                Manager.Skill = "None";
            }
            Manager.Level = (ushort)numericUpDown16.Value;
            Manager.ItemID = (ushort)numericUpDown17.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CopyValues();
            Manager.Export();
        }
    }
}
