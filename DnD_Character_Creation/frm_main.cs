using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DnD_Character_Creation
{
    public partial class frm_main : Form
    {
        public static string details_val = "";
        public static string details_val2 = "";
        public int abilty_val = 0;
        public frm_main()
        {
            InitializeComponent();
            {
                lbl_userid.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                Startup();
            }
        }

        public void Startup()
        {
            txB_char_name.Text = lbl_userid.Text + "'s Character";
            Fill_cmB_race();
            Fill_cmB_race_filter();
            Fill_cmB_class();
            Fill_cmB_ability();
            Fill_cmB_background_values();
            Fill_cmB_prof();
            Fill_cmB_gold_values();
        }

        public void Fill_cmB_race()
        {
            cmB_race.Items.Clear();
            Fill_cmB_race_PHB();
            Fill_cmB_race_EEPC();
        }
        public void Fill_cmB_race_PHB()
        {
            try
            {
                string[] ToLine = File.ReadAllLines(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Files", "Races_PHB.txt"));

                foreach (var Row in ToLine[0].Split(";".ToCharArray()))
                {
                    cmB_race.Items.Add(Row);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check @\\Files\\Races_PHB.txt file in the Debug folder");
            }
        }
        public void Fill_cmB_race_EEPC()
        {
            try
            {
                string[] ToLine = File.ReadAllLines(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Files", "Races_EEPC.txt"));

                foreach (var Row in ToLine[0].Split(";".ToCharArray()))
                {
                    cmB_race.Items.Add(Row);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check @\\Files\\Races_EEPC.txt file in the Debug folder");
            }
        }

        public void Fill_cmB_class()
        {
            try
            {
                string[] ToLine = File.ReadAllLines(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Files", "Classes.txt"));

                foreach (var Row in ToLine[0].Split(";".ToCharArray()))
                {
                    cmB_class.Items.Add(Row);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check @\\Files\\Classes.txt file in the Debug folder");
            }
        }

        public void Fill_cmB_prof()
        {
            try
            {
                string[] ToLine = File.ReadAllLines(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Files", "Proficiencies.txt"));

                foreach (var Row in ToLine[0].Split(";".ToCharArray()))
                {
                    cmB_prof1.Items.Add(Row);
                    cmB_prof2.Items.Add(Row);
                    cmB_prof3.Items.Add(Row);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check @\\Files\\Proficiencies.txt file in the Debug folder");
            }
        }

        public void Fill_cmB_race_filter()
        {
            cmB_race_filter.Items.AddRange(new string[] { "All", "Player's Handbook", "Player's Companion" });
        }

        public void cmB_race_TextChanged(object sender, EventArgs e)
        {
            details_val = cmB_race.Text;
            Character_Details.Race_Description();
            txB_race_flav.ReadOnly = false;
            txB_race_flav.Text = details_val;
            txB_race_flav.ReadOnly = true;
        }

        private void cmB_race_filter_TextChanged(object sender, EventArgs e)
        {
            cmB_race.Items.Clear();
            cmB_race.Text = "-- Choose --";
            if (cmB_race_filter.Text == "All")
            {
                Fill_cmB_race();
            }
            else if (cmB_race_filter.Text == "Player's Handbook")
            {
                Fill_cmB_race_PHB();
            }
            else if (cmB_race_filter.Text == "Player's Companion")
            {
                Fill_cmB_race_EEPC();
            }
        }

        private void cmB_class_TextChanged(object sender, EventArgs e)
        {
            details_val = cmB_class.Text;
            Character_Details.Class_Description();
            txB_class_flav.ReadOnly = false;
            txB_hitdice.ReadOnly = false;
            txB_class_flav.Text = details_val;
            txB_hitdice.Text = details_val2;

            txB_hitpoint.ReadOnly = false;
            if (txB_hitdice.Text == "")
            {
                txB_hitpoint.Text = "0";
            }
            else
            {
                txB_hitpoint.Text = Convert.ToString(Convert.ToInt32(details_val2.Substring(1, (details_val2.Length - 1)))-1);
            }

            txB_class_flav.ReadOnly = true;
            txB_hitdice.ReadOnly = true;
            txB_hitpoint.ReadOnly = true;
        }

        public void Fill_cmB_ability()
        {
            cmB_ability.Items.AddRange(new string[] { "Point Buy", "Manual/Rolled" });
        }

        private void cmB_ability_TextChanged(object sender, EventArgs e)
        {
            if (cmB_ability.Text == "Point Buy")
            {
                foreach (var control in this.Controls)
                {
                    if (control is ComboBox)
                    {
                        if (((ComboBox)control).Name.Contains("cmB_ability_"))
                        {
                            ((ComboBox)control).Text = "";
                        }
                    }
                }
                Fill_cmB_details_values();
                lbl_current_points.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                btn_ability_roll.Visible = false;

            }
            else
            {
                foreach (var control in this.Controls)
                {
                    if (control is ComboBox)
                    {
                        if (((ComboBox)control).Name.Contains("cmB_ability_"))
                        {
                            ((ComboBox)control).Text = "";
                            ((ComboBox)control).Items.Clear();
                        }
                    }
                }
                lbl_current_points.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                btn_ability_roll.Visible = true;
            }
        }

        public void Fill_cmB_details_values()
        {
            cmB_ability_str.Items.AddRange(new string[] { "15", "14", "13", "12", "11", "10", "9", "8" });
            cmB_ability_dex.Items.AddRange(new string[] { "15", "14", "13", "12", "11", "10", "9", "8" });
            cmB_ability_con.Items.AddRange(new string[] { "15", "14", "13", "12", "11", "10", "9", "8" });
            cmB_ability_int.Items.AddRange(new string[] { "15", "14", "13", "12", "11", "10", "9", "8" });
            cmB_ability_wis.Items.AddRange(new string[] { "15", "14", "13", "12", "11", "10", "9", "8" });
            cmB_ability_cha.Items.AddRange(new string[] { "15", "14", "13", "12", "11", "10", "9", "8" });
        }

        public void Fill_cmB_background_values()
        {
            cmB_background.Text = "-- Choose --";
            cmB_background.Items.AddRange(new string[] { "Charlatan", "Entertainer", "Outlander", "Sage", "Sailor", "Soldier", "Noble",});
        }

        public void Fill_cmB_gold_values()
        {
            cmB_gold.Items.AddRange(Enumerable.Range(1, 20).Select(i => (object)i).ToArray());
        }

        private void cmB_ability_str_TextChanged(object sender, EventArgs e)
        {
            if (cmB_ability.Text == "Point Buy")
            {
                details_val = cmB_ability_str.Text;
                Character_Details.Ability_BaseValues();
                cmB_rac_str.Text = details_val;
                details_val = cmB_ability_str.Text;
                Character_Details.Ability_Modifiers();
                cmB_mod_str.Text = details_val;
                if (details_val != "")
                    cmB_tot_str.Text = Convert.ToString(Convert.ToInt32(cmB_ability_str.Text) + Convert.ToInt32(cmB_mod_str.Text));
                else
                    cmB_tot_str.Text = "";
            }
            else
            {
                cmB_rac_str.Text = "";
                details_val = cmB_ability_str.Text;
                Character_Details.Ability_Modifiers();
                cmB_mod_str.Text = details_val;
                if (details_val != "")
                    cmB_tot_str.Text = Convert.ToString(Convert.ToInt32(cmB_ability_str.Text) + Convert.ToInt32(cmB_mod_str.Text));
                else
                    cmB_tot_str.Text = "";
            }
        }

        private void cmB_ability_dex_TextChanged(object sender, EventArgs e)
        {
            if (cmB_ability.Text == "Point Buy")
            {
                details_val = cmB_ability_dex.Text;
                Character_Details.Ability_BaseValues();
                cmB_rac_dex.Text = details_val;
                details_val = cmB_ability_dex.Text;
                Character_Details.Ability_Modifiers();
                cmB_mod_dex.Text = details_val;
                if (details_val != "")
                    cmB_tot_dex.Text = Convert.ToString(Convert.ToInt32(cmB_ability_dex.Text) + Convert.ToInt32(cmB_mod_dex.Text));
                else
                    cmB_tot_dex.Text = "";
            }
            else
            {
                cmB_rac_dex.Text = "";
                details_val = cmB_ability_dex.Text;
                Character_Details.Ability_Modifiers();
                cmB_mod_dex.Text = details_val;
                if (details_val != "")
                    cmB_tot_dex.Text = Convert.ToString(Convert.ToInt32(cmB_ability_dex.Text) + Convert.ToInt32(cmB_mod_dex.Text));
                else
                    cmB_tot_dex.Text = "";
            }
        }

        private void cmB_ability_con_TextChanged(object sender, EventArgs e)
        {
            if (cmB_ability.Text == "Point Buy")
            {
                details_val = cmB_ability_con.Text;
                Character_Details.Ability_BaseValues();
                cmB_rac_con.Text = details_val;
                details_val = cmB_ability_con.Text;
                Character_Details.Ability_Modifiers();
                cmB_mod_con.Text = details_val;
                if (details_val != "")
                    cmB_tot_con.Text = Convert.ToString(Convert.ToInt32(cmB_ability_con.Text) + Convert.ToInt32(cmB_mod_con.Text));
                else
                    cmB_tot_con.Text = "";
            }
            else
            {
                cmB_rac_con.Text = "";
                details_val = cmB_ability_con.Text;
                Character_Details.Ability_Modifiers();
                cmB_mod_con.Text = details_val;
                if (details_val != "")
                    cmB_tot_con.Text = Convert.ToString(Convert.ToInt32(cmB_ability_con.Text) + Convert.ToInt32(cmB_mod_con.Text));
                else
                    cmB_tot_con.Text = "";
            }
        }

        private void cmB_ability_int_TextChanged(object sender, EventArgs e)
        {
            if (cmB_ability.Text == "Point Buy")
            {
                details_val = cmB_ability_int.Text;
                Character_Details.Ability_BaseValues();
                cmB_rac_int.Text = details_val;
                details_val = cmB_ability_int.Text;
                Character_Details.Ability_Modifiers();
                cmB_mod_int.Text = details_val;
                if (details_val != "")
                    cmB_tot_int.Text = Convert.ToString(Convert.ToInt32(cmB_ability_int.Text) + Convert.ToInt32(cmB_mod_int.Text));
            }
            else
            {
                cmB_rac_int.Text = "";
                details_val = cmB_ability_int.Text;
                Character_Details.Ability_Modifiers();
                cmB_mod_int.Text = details_val;
                if (details_val != "")
                    cmB_tot_int.Text = Convert.ToString(Convert.ToInt32(cmB_ability_int.Text) + Convert.ToInt32(cmB_mod_int.Text));
                else
                    cmB_tot_int.Text = "";
            }
        }

        private void cmB_ability_wis_TextChanged(object sender, EventArgs e)
        {
            if (cmB_ability.Text == "Point Buy")
            {
                details_val = cmB_ability_wis.Text;
                Character_Details.Ability_BaseValues();
                cmB_rac_wis.Text = details_val;
                details_val = cmB_ability_wis.Text;
                Character_Details.Ability_Modifiers();
                cmB_mod_wis.Text = details_val;
                if (details_val != "")
                    cmB_tot_wis.Text = Convert.ToString(Convert.ToInt32(cmB_ability_wis.Text) + Convert.ToInt32(cmB_mod_wis.Text));
                else
                    cmB_tot_wis.Text = "";
            }
            else
            {
                cmB_rac_wis.Text = "";
                details_val = cmB_ability_wis.Text;
                Character_Details.Ability_Modifiers();
                cmB_mod_wis.Text = details_val;
                if (details_val != "")
                    cmB_tot_wis.Text = Convert.ToString(Convert.ToInt32(cmB_ability_wis.Text) + Convert.ToInt32(cmB_mod_wis.Text));
                else
                    cmB_tot_wis.Text = "";
            }
        }

        private void cmB_ability_cha_TextChanged(object sender, EventArgs e)
        {
            if (cmB_ability.Text == "Point Buy")
            {
                details_val = cmB_ability_cha.Text;
                Character_Details.Ability_BaseValues();
                cmB_rac_cha.Text = details_val;
                details_val = cmB_ability_cha.Text;
                Character_Details.Ability_Modifiers();
                cmB_mod_cha.Text = details_val;
                if (details_val != "")
                    cmB_tot_cha.Text = Convert.ToString(Convert.ToInt32(cmB_ability_cha.Text) + Convert.ToInt32(cmB_mod_cha.Text));
                else
                    cmB_tot_cha.Text = "";
            }
            else
            {
                cmB_rac_cha.Text = "";
                details_val = cmB_ability_cha.Text;
                Character_Details.Ability_Modifiers();
                cmB_mod_cha.Text = details_val;
                if (details_val != "")
                    cmB_tot_cha.Text = Convert.ToString(Convert.ToInt32(cmB_ability_cha.Text) + Convert.ToInt32(cmB_mod_cha.Text));
                else
                    cmB_tot_cha.Text = "";
            }
        }

        private void cmB_rac_str_TextChanged(object sender, EventArgs e)
        {
            if (cmB_ability.Text == "Point Buy")
            {
                int currpoint = 27;
                currpoint = currpoint - Convert.ToInt32(cmB_rac_str.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_dex.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_con.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_int.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_wis.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_cha.Text);
                lbl_current_points.Text = Convert.ToString(currpoint);
            }
        }

               

        private void cmB_rac_dex_TextChanged(object sender, EventArgs e)
        {
            if (cmB_ability.Text == "Point Buy")
            {
                int currpoint = 27;
                currpoint = currpoint - Convert.ToInt32(cmB_rac_str.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_dex.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_con.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_int.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_wis.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_cha.Text);
                lbl_current_points.Text = Convert.ToString(currpoint);
            }
        }

        private void cmB_rac_con_TextChanged(object sender, EventArgs e)
        {
            if (cmB_ability.Text == "Point Buy")
            {
                int currpoint = 27;
                currpoint = currpoint - Convert.ToInt32(cmB_rac_str.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_dex.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_con.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_int.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_wis.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_cha.Text);
                lbl_current_points.Text = Convert.ToString(currpoint);
            }
        }

        private void cmB_rac_int_TextChanged(object sender, EventArgs e)
        {
            if (cmB_ability.Text == "Point Buy")
            {
                int currpoint = 27;
                currpoint = currpoint - Convert.ToInt32(cmB_rac_str.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_dex.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_con.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_int.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_wis.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_cha.Text);
                lbl_current_points.Text = Convert.ToString(currpoint);
            }
        }

        private void cmB_rac_wis_TextChanged(object sender, EventArgs e)
        {
            if (cmB_ability.Text == "Point Buy")
            {
                int currpoint = 27;
                currpoint = currpoint - Convert.ToInt32(cmB_rac_str.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_dex.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_con.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_int.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_wis.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_cha.Text);
                lbl_current_points.Text = Convert.ToString(currpoint);
            }
        }

        private void cmB_rac_cha_TextChanged(object sender, EventArgs e)
        {
            if (cmB_ability.Text == "Point Buy")
            {
                int currpoint = 27;
                currpoint = currpoint - Convert.ToInt32(cmB_rac_str.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_dex.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_con.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_int.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_wis.Text);
                currpoint = currpoint - Convert.ToInt32(cmB_rac_cha.Text);
                lbl_current_points.Text = Convert.ToString(currpoint);
            }
        }

        private void lbl_current_points_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbl_current_points.Text) < 0)
            {
                lbl_current_points.ForeColor = System.Drawing.Color.Red;
                lbl_current_points.Font = new Font(lbl_current_points.Font, FontStyle.Bold);
                label2.ForeColor = System.Drawing.Color.Red;
                label3.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lbl_current_points.ForeColor = System.Drawing.Color.Black;
                lbl_current_points.Font = new Font(lbl_current_points.Font, FontStyle.Regular);
                label2.ForeColor = System.Drawing.Color.Black;
                label3.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void btn_ability_roll_Click(object sender, EventArgs e)
        {
            int[] Ability = new int[4];
            int[] Stats = new int[6];
            Random randNum = new Random();

            for (int j = 0; j < 6; j++)
            {
                for (int i = 0; i < Ability.Length; i++)
                {
                    Ability[i] = randNum.Next(1, 7);
                }
                int ability = Ability.Sum() - Ability.Min();
                abilty_val = ability;

                Stats[j] = abilty_val;
            }

            cmB_ability_str.Text = Convert.ToString(Stats[0]);
            cmB_ability_dex.Text = Convert.ToString(Stats[1]);
            cmB_ability_con.Text = Convert.ToString(Stats[2]);
            cmB_ability_int.Text = Convert.ToString(Stats[3]);
            cmB_ability_wis.Text = Convert.ToString(Stats[4]);
            cmB_ability_cha.Text = Convert.ToString(Stats[5]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random randNum = new Random();
                txB_hitpoint.Text = Convert.ToString(randNum.Next(1, Convert.ToInt32(details_val2.Substring(1, (details_val2.Length - 1))) + 1));
            }
            catch
            {
                MessageBox.Show("Pick a Class before you roll for Hit Points.");
            }
        }

        private void cmB_background_TextChanged(object sender, EventArgs e)
        {
            details_val = cmB_background.Text;
            Character_Details.Background_Details();
            txB_background.Text = details_val;
        }

        private void cmB_prof1_SelectedIndexChanged(object sender, EventArgs e)
        {
            details_val = cmB_prof1.Text;
            Character_Details.Proficiencies_Details();
            txB_prof.Text = details_val;
        }

        private void cmB_prof2_SelectedIndexChanged(object sender, EventArgs e)
        {
            details_val = cmB_prof2.Text;
            Character_Details.Proficiencies_Details();
            txB_prof.Text = details_val;
        }

        private void cmB_prof3_SelectedIndexChanged(object sender, EventArgs e)
        {
            details_val = cmB_prof3.Text;
            Character_Details.Proficiencies_Details();
            txB_prof.Text = details_val;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label11.Visible = true;
                cmB_gold.Visible = true;
                btn_gold_roll.Visible = true;
            }
            else
            {
                label11.Visible = false;
                cmB_gold.Visible = false;
                btn_gold_roll.Visible = false;
            }
        }

        private void btn_gold_roll_Click(object sender, EventArgs e)
        {
            int[] Gold = new int[5];
            Random randNum = new Random();

            for (int i = 0; i < Gold.Length; i++)
            {
                Gold[i] = randNum.Next(1, 5);
            }
            int ability = Gold.Sum();
            cmB_gold.Text = Convert.ToString(ability);
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Biztos vagy benne, hogy ki akarsz lépni az alkalmazásból?", "EXIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btn_summ_Click(object sender, EventArgs e)
        {
            bool issue = false;
            if (cmB_race.Text == "-- Choose --" || cmB_race.Text == "")
            {
                issue = true;
                MessageBox.Show("Please choose a race to continue!");
                return;
            }
            if (cmB_class.Text == "-- Choose --" || cmB_class.Text == "")
            {
                issue = true;
                MessageBox.Show("Please choose a class to continue!");
                return;
            }
            if (cmB_ability.Text == "-- Chose a Generation Method --" || cmB_ability.Text == "")
            {
                issue = true;
                MessageBox.Show("Please choose a Generation Method to continue!");
                return;
            }
            if (cmB_tot_str.Text == "" || cmB_tot_dex.Text == "" || cmB_tot_con.Text == "" || cmB_tot_int.Text == "" || cmB_tot_wis.Text == "" || cmB_tot_cha.Text == "")
            {
                issue = true;
                MessageBox.Show("Please choose/roll the ability values to continue!");
                return;
            }
            if (txB_char_name.Text == "")
            {
                issue = true;
                MessageBox.Show("Please choose a character name to continue!");
                return;
            }
            if (cmB_prof1.Text == "-- Choose --" || cmB_prof1.Text == "" || cmB_prof2.Text == "-- Choose --" || cmB_prof2.Text == "" || cmB_prof3.Text == "-- Choose --" || cmB_prof3.Text == "")
            {
                issue = true;
                MessageBox.Show("Please choose proficiencies to continue!");
                return;
            }
            if (cmB_background.Text == "-- Choose --" || cmB_background.Text == "")
            {
                issue = true;
                MessageBox.Show("Please choose a background to continue!");
                return;
            }
            if(checkBox1.Checked == false && checkBox2.Checked == false)
            {
                issue = true;
                MessageBox.Show("Please choose starting equipment to continue!");
                return;
            }
            else if(checkBox1.Checked == true && (cmB_gold.Text == "" || cmB_gold.Text == "-- Choose --"))
            {
                issue = true;
                MessageBox.Show("Please choose/roll starting gold to continue!");
                return;
            }

            if(cmB_ability.Text == "Point Buy" && Convert.ToInt32(lbl_current_points.Text) < 0)
            {
                issue = true;
                MessageBox.Show("You exceeded the 27 points. Please adjust your ability values to continue!");
                return;
            }

            if (issue == false)
            {
                frm_final frm = new frm_final();
                frm.frmmain = this;
                frm.Show();
            }
        }
    }
}
