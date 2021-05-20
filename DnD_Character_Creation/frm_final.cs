using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Character_Creation
{
    public partial class frm_final : System.Windows.Forms.Form
    {
        public frm_main frmmain;
        public frm_final()
        {
            InitializeComponent();
        }

        private void frm_final_Load(object sender, EventArgs e)
        {
            lbl_char_name.Text = ((frm_main)frmmain).txB_char_name.Text;
            lbl_char_race_class.Text = ((frm_main)frmmain).cmB_race.Text + " " + ((frm_main)frmmain).cmB_class.Text;
            lbl_hit_points.Text = ((frm_main)frmmain).txB_hitpoint.Text;
            lbl_background.Text = ((frm_main)frmmain).cmB_background.Text;


            if (((frm_main)frmmain).checkBox2.Checked == true)
            {
                lbl_starting.Text = ((frm_main)frmmain).cmB_class.Text + " Starter Kit";
            }
            else
            {
                lbl_starting.Text = ((frm_main)frmmain).cmB_gold.Text + " gold";
            }

            txB_mod_str.Text = ((frm_main)frmmain).cmB_mod_str.Text;
            txB_mod_dex.Text = ((frm_main)frmmain).cmB_mod_dex.Text;
            txB_mod_con.Text = ((frm_main)frmmain).cmB_mod_con.Text;
            txB_mod_int.Text = ((frm_main)frmmain).cmB_mod_int.Text;
            txB_mod_wis.Text = ((frm_main)frmmain).cmB_mod_wis.Text;
            txB_mod_cha.Text = ((frm_main)frmmain).cmB_mod_cha.Text;

            lbl_sta_tot.Text = ((frm_main)frmmain).cmB_tot_str.Text;
            lbl_dex_tot.Text = ((frm_main)frmmain).cmB_tot_dex.Text;
            lbl_con_tot.Text = ((frm_main)frmmain).cmB_tot_con.Text;
            lbl_int_tot.Text = ((frm_main)frmmain).cmB_tot_int.Text;
            lbl_wis_tot.Text = ((frm_main)frmmain).cmB_tot_wis.Text;
            lbl_cha_tot.Text = ((frm_main)frmmain).cmB_tot_cha.Text;

            textBox36.Text = txB_mod_dex.Text;
            textBox21.Text = txB_mod_dex.Text;
            textBox20.Text = txB_mod_dex.Text;

            textBox35.Text = txB_mod_wis.Text;
            textBox30.Text = txB_mod_wis.Text;
            textBox27.Text = txB_mod_wis.Text;
            textBox25.Text = txB_mod_wis.Text;
            textBox19.Text = txB_mod_wis.Text;

            textBox34.Text = txB_mod_int.Text;
            textBox31.Text = txB_mod_int.Text;
            textBox28.Text = txB_mod_int.Text;
            textBox26.Text = txB_mod_int.Text;
            textBox22.Text = txB_mod_int.Text;

            textBox33.Text = txB_mod_str.Text;

            textBox32.Text = txB_mod_cha.Text;
            textBox29.Text = txB_mod_cha.Text;
            textBox24.Text = txB_mod_cha.Text;
            textBox23.Text = txB_mod_cha.Text;

            if (((frm_main)frmmain).cmB_prof1.Text == "Acrobatics" || ((frm_main)frmmain).cmB_prof2.Text == "Acrobatics" || ((frm_main)frmmain).cmB_prof3.Text == "Acrobatics")
            {
                checkBox1.Checked = true;
                textBox36.Text = Convert.ToString(Convert.ToInt32(textBox36.Text) + 2);
            }
            if (((frm_main)frmmain).cmB_prof1.Text == "Animal Handling" || ((frm_main)frmmain).cmB_prof2.Text == "Animal Handling" || ((frm_main)frmmain).cmB_prof3.Text == "Animal Handling")
            { 
                checkBox2.Checked = true;
                textBox35.Text = Convert.ToString(Convert.ToInt32(textBox35.Text) + 2);
            }
            if (((frm_main)frmmain).cmB_prof1.Text == "Arcana" || ((frm_main)frmmain).cmB_prof2.Text == "Arcana" || ((frm_main)frmmain).cmB_prof3.Text == "Arcana")
            {
                checkBox4.Checked = true;
                textBox34.Text = Convert.ToString(Convert.ToInt32(textBox34.Text) + 2);
            }
            if (((frm_main)frmmain).cmB_prof1.Text == "Athletics" || ((frm_main)frmmain).cmB_prof2.Text == "Athletics" || ((frm_main)frmmain).cmB_prof3.Text == "Athletics")
            {
                checkBox3.Checked = true;
                textBox33.Text = Convert.ToString(Convert.ToInt32(textBox33.Text) + 2);
            }
            if (((frm_main)frmmain).cmB_prof1.Text == "Deception" || ((frm_main)frmmain).cmB_prof2.Text == "Deception" || ((frm_main)frmmain).cmB_prof3.Text == "Deception")
            {
                checkBox8.Checked = true;
                textBox32.Text = Convert.ToString(Convert.ToInt32(textBox32.Text) + 2);
            }
            if (((frm_main)frmmain).cmB_prof1.Text == "History" || ((frm_main)frmmain).cmB_prof2.Text == "History" || ((frm_main)frmmain).cmB_prof3.Text == "History")
            {
                checkBox7.Checked = true;
                textBox31.Text = Convert.ToString(Convert.ToInt32(textBox31.Text) + 2);
            }
            if (((frm_main)frmmain).cmB_prof1.Text == "Insight" || ((frm_main)frmmain).cmB_prof2.Text == "Insight" || ((frm_main)frmmain).cmB_prof3.Text == "Insight")
            {
                checkBox6.Checked = true;
                textBox30.Text = Convert.ToString(Convert.ToInt32(textBox30.Text) + 2);
            }
            if (((frm_main)frmmain).cmB_prof1.Text == "Intimidation" || ((frm_main)frmmain).cmB_prof2.Text == "Intimidation" || ((frm_main)frmmain).cmB_prof3.Text == "Intimidation")
            {
                checkBox5.Checked = true;
                textBox29.Text = Convert.ToString(Convert.ToInt32(textBox29.Text) + 2);
            }
            if (((frm_main)frmmain).cmB_prof1.Text == "Investigation" || ((frm_main)frmmain).cmB_prof2.Text == "Investigation" || ((frm_main)frmmain).cmB_prof3.Text == "Investigation")
            {
                checkBox12.Checked = true;
                textBox28.Text = Convert.ToString(Convert.ToInt32(textBox28.Text) + 2);
            }
            if (((frm_main)frmmain).cmB_prof1.Text == "Medicine" || ((frm_main)frmmain).cmB_prof2.Text == "Medicine" || ((frm_main)frmmain).cmB_prof3.Text == "Medicine")
            {
                checkBox11.Checked = true;
                textBox27.Text = Convert.ToString(Convert.ToInt32(textBox27.Text) + 2);
            }
            if (((frm_main)frmmain).cmB_prof1.Text == "Nature" || ((frm_main)frmmain).cmB_prof2.Text == "Nature" || ((frm_main)frmmain).cmB_prof3.Text == "Nature")
            {
                checkBox10.Checked = true;
                textBox26.Text = Convert.ToString(Convert.ToInt32(textBox26.Text) + 2);
            }
            if (((frm_main)frmmain).cmB_prof1.Text == "Perception" || ((frm_main)frmmain).cmB_prof2.Text == "Perception" || ((frm_main)frmmain).cmB_prof3.Text == "Perception")
            {
                checkBox9.Checked = true;
                textBox25.Text = Convert.ToString(Convert.ToInt32(textBox25.Text) + 2);
            }
            if (((frm_main)frmmain).cmB_prof1.Text == "Performance" || ((frm_main)frmmain).cmB_prof2.Text == "Performance" || ((frm_main)frmmain).cmB_prof3.Text == "Performance")
            {
                checkBox16.Checked = true;
                textBox24.Text = Convert.ToString(Convert.ToInt32(textBox24.Text) + 2);
            }
            if (((frm_main)frmmain).cmB_prof1.Text == "Persuasion" || ((frm_main)frmmain).cmB_prof2.Text == "Persuasion" || ((frm_main)frmmain).cmB_prof3.Text == "Persuasion")
            {
                checkBox15.Checked = true;
                textBox23.Text = Convert.ToString(Convert.ToInt32(textBox23.Text) + 2);
            }
            if (((frm_main)frmmain).cmB_prof1.Text == "Religion" || ((frm_main)frmmain).cmB_prof2.Text == "Religion" || ((frm_main)frmmain).cmB_prof3.Text == "Religion")
            {
                checkBox14.Checked = true;
                textBox22.Text = Convert.ToString(Convert.ToInt32(textBox22.Text) + 2);
            }
            if (((frm_main)frmmain).cmB_prof1.Text == "Sleight of Hand" || ((frm_main)frmmain).cmB_prof2.Text == "Sleight of Hand" || ((frm_main)frmmain).cmB_prof3.Text == "Sleight of Hand")
            {
                checkBox13.Checked = true;
                textBox21.Text = Convert.ToString(Convert.ToInt32(textBox21.Text) + 2);
            }
            if (((frm_main)frmmain).cmB_prof1.Text == "Stealth" || ((frm_main)frmmain).cmB_prof2.Text == "Stealth" || ((frm_main)frmmain).cmB_prof3.Text == "Stealth")
            {
                checkBox18.Checked = true;
                textBox20.Text = Convert.ToString(Convert.ToInt32(textBox20.Text) + 2);
            }
            if (((frm_main)frmmain).cmB_prof1.Text == "Survival" || ((frm_main)frmmain).cmB_prof2.Text == "Survival" || ((frm_main)frmmain).cmB_prof3.Text == "Survival")
            {
                checkBox17.Checked = true;
                textBox19.Text = Convert.ToString(Convert.ToInt32(textBox19.Text) + 2);
            }
        }
    }
}
