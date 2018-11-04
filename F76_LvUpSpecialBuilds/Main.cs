using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;


namespace F76_LvUpSpecialBuilds
{
    public partial class Main : Form
    {

        Character player = new Character(1, 1, 1, 1, 1, 1, 1, 1,"");
        List<Character> savedPlayers;
        

        public Main()
        {
            InitializeComponent();
        }
        private void UpdateUI()
        {
            tb_Name.Text = player.Name;
            label_LevelNumber.Text = player.Level.ToString();
            label_SNum.Text = player.StrengthLevel.ToString();
            label_PNum.Text = player.PerceptionLevel.ToString();
            label_ENum.Text = player.EnduranceLevel.ToString();
            label_CNum.Text = player.CharismaLevel.ToString();
            label_INum.Text = player.IntelligenceLevel.ToString();
            label_ANum.Text = player.AgilityLevel.ToString();
            label_LNum.Text = player.LuckLevel.ToString();

            
            if (player.Level == 50){
                btn_AddS.Visible = false;
                btn_AddP.Visible = false;
                btn_AddE.Visible = false;
                btn_AddC.Visible = false;
                btn_AddI.Visible = false;
                btn_AddA.Visible = false;
                btn_AddL.Visible = false;
            }
            else
            {
                if(player.StrengthLevel != 15) { btn_AddS.Visible = true; } else { btn_AddS.Visible = false; }
                if (player.PerceptionLevel != 15) { btn_AddP.Visible = true; } else { btn_AddP.Visible = false; }
                if (player.EnduranceLevel != 15) { btn_AddE.Visible = true; } else { btn_AddE.Visible = false; }
                if (player.CharismaLevel != 15) { btn_AddC.Visible = true; } else { btn_AddC.Visible = false; }
                if (player.IntelligenceLevel != 15) { btn_AddI.Visible = true; } else { btn_AddI.Visible = false; }
                if (player.AgilityLevel != 15) { btn_AddA.Visible = true; } else { btn_AddA.Visible = false; }
                if (player.LuckLevel != 15) { btn_AddL.Visible = true; } else { btn_AddL.Visible = false; }

                if (player.StrengthLevel != 1) { btn_SubS.Visible = true; } else { btn_SubS.Visible = false; }
                if (player.PerceptionLevel != 1) { btn_SubP.Visible = true; } else { btn_SubP.Visible = false; }
                if (player.EnduranceLevel != 1) { btn_SubE.Visible = true; } else { btn_SubE.Visible = false; }
                if (player.CharismaLevel != 1) { btn_SubC.Visible = true; } else { btn_SubC.Visible = false; }
                if (player.IntelligenceLevel != 1) { btn_SubI.Visible = true; } else { btn_SubI.Visible = false; }
                if (player.AgilityLevel != 1) { btn_SubA.Visible = true; } else { btn_SubA.Visible = false; }
                if (player.LuckLevel != 1) { btn_SubL.Visible = true; } else { btn_SubL.Visible = false; }
            }
            


        }
        private void Main_Load(object sender, System.EventArgs e)
        {

        }

        private void button_Quit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            player.Name = tb_Name.Text.ToString();
            UpdateUI();
        }


        private void btn_AddS_Click(object sender, EventArgs e)
        {

            if (player.StrengthLevel < 15)
            {
                player.Level += 1;
                player.StrengthLevel += 1;
                UpdateUI();

            }
        }

        private void btn_AddP_Click(object sender, EventArgs e)
        {
            if (player.PerceptionLevel < 15)
            { 
                player.Level += 1;
                player.PerceptionLevel += 1;
                UpdateUI();
            }
        }

        private void btn_AddE_Click(object sender, EventArgs e)
        {
            if (player.EnduranceLevel < 15)
            {
                player.Level += 1;
                player.EnduranceLevel += 1;
                UpdateUI();
            }
        }

        private void btn_AddC_Click(object sender, EventArgs e)
        {
            if (player.CharismaLevel < 15)
            {
                player.Level += 1;
                player.CharismaLevel += 1;
                UpdateUI();
            }
        }

        private void btn_AddI_Click(object sender, EventArgs e)
        {
            if (player.IntelligenceLevel < 15)
            {
                player.Level += 1;
                player.IntelligenceLevel += 1;
                UpdateUI();
            }
        }

        private void btn_AddA_Click(object sender, EventArgs e)
        {
            if (player.AgilityLevel < 15)
            { 
                player.Level += 1;
                player.AgilityLevel += 1;
                UpdateUI();
            }
        }

        private void btn_AddL_Click(object sender, EventArgs e)
        {
            if (player.LuckLevel < 15)
            {
                player.Level += 1;
                player.LuckLevel += 1;
                UpdateUI();
            }
        }

        private void btn_SubS_Click(object sender, EventArgs e)
        {
            if (player.StrengthLevel > 1)
            {
                player.Level -= 1;
                player.StrengthLevel -= 1;
                UpdateUI();
            }
        }

        private void btn_SubP_Click(object sender, EventArgs e)
        {
            if (player.PerceptionLevel > 1)
            {
                player.Level -= 1;
                player.PerceptionLevel -= 1;
                UpdateUI();
            }
        }

        private void btn_SubE_Click(object sender, EventArgs e)
        {
            if (player.EnduranceLevel > 1)
            {
                player.Level -= 1;
                player.EnduranceLevel -= 1;
                UpdateUI();
            }
        }

        private void btn_SubC_Click(object sender, EventArgs e)
        {
            if (player.CharismaLevel > 1)
            {
                player.Level -= 1;
                player.CharismaLevel -= 1;
                UpdateUI();
            }
        }

        private void btn_SubI_Click(object sender, EventArgs e)
        {
            if (player.IntelligenceLevel > 1)
            {
                player.Level -= 1;
                player.IntelligenceLevel -= 1;
                UpdateUI();
            }
        }

        private void btn_SubA_Click(object sender, EventArgs e)
        {
            if (player.AgilityLevel > 1)
            {
                player.Level -= 1;
                player.AgilityLevel -= 1;
                UpdateUI();
            }
        }

        private void btn_SubL_Click(object sender, EventArgs e)
        {
            if (player.LuckLevel > 1)
            {
                player.Level -= 1;
                player.LuckLevel -= 1;
                UpdateUI();
            }
        }

        private void button_CreateNew_Click(object sender, EventArgs e)
        {
            player.defaultCharacter();
            UpdateUI();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            player.Save();
            UpdateUI();
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            player.Load();
            UpdateUI();
        }
    }
}
