using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using Engine;
using System.Xml.Serialization;

namespace F76_LvUpSpecialBuilds
{
    public partial class Main : Form
    {
       
        const string savedPath = "savedCharacters";
        Character player = new Character();
        List<string> savedPlayers = loadList();
       
       
        
        
        private void cbUpdate()
        {

            cb_Characters.Items.Clear();
            cb_Characters.Items.AddRange(savedPlayers.ToArray());
            
        }
        private static List<string> loadList()
        {
            try
            {
                return DeSerializeObject<List<string>>(savedPath);
            }
            catch
            {
                return new List<string>();
            }
            
        }

        public Main()
        {
            InitializeComponent();
            cbUpdate();
        }

       
        private void UpdateUI()
        {
            tb_Name.Text = player.getName();
            label_LevelNumber.Text = player.getLevel().ToString();
            label_SNum.Text = player.getStr().ToString();
            label_PNum.Text = player.getPer().ToString();
            label_ENum.Text = player.getEnd().ToString();
            label_CNum.Text = player.getCha().ToString();
            label_INum.Text = player.getInt().ToString();
            label_ANum.Text = player.getAgi().ToString();
            label_LNum.Text = player.getLuc().ToString();
            

            //Shows the appropriate buttons for what butttons are available, only allowing each stat to be 1 to 15
            if(player.getStr() != 15) { btn_AddS.Visible = true; } else { btn_AddS.Visible = false; }
            if (player.getPer() != 15) { btn_AddP.Visible = true; } else { btn_AddP.Visible = false; }
            if (player.getEnd() != 15) { btn_AddE.Visible = true; } else { btn_AddE.Visible = false; }
            if (player.getCha() != 15) { btn_AddC.Visible = true; } else { btn_AddC.Visible = false; }
            if (player.getInt() != 15) { btn_AddI.Visible = true; } else { btn_AddI.Visible = false; }
            if (player.getAgi() != 15) { btn_AddA.Visible = true; } else { btn_AddA.Visible = false; }
            if (player.getLuc() != 15) { btn_AddL.Visible = true; } else { btn_AddL.Visible = false; }

            //
            if (player.getStr() != 1) { btn_SubS.Visible = true; } else { btn_SubS.Visible = false; }
            if (player.getPer() != 1) { btn_SubP.Visible = true; } else { btn_SubP.Visible = false; }
            if (player.getEnd() != 1) { btn_SubE.Visible = true; } else { btn_SubE.Visible = false; }
            if (player.getCha() != 1) { btn_SubC.Visible = true; } else { btn_SubC.Visible = false; }
            if (player.getInt() != 1) { btn_SubI.Visible = true; } else { btn_SubI.Visible = false; }
            if (player.getAgi() != 1) { btn_SubA.Visible = true; } else { btn_SubA.Visible = false; }
            if (player.getLuc() != 1) { btn_SubL.Visible = true; } else { btn_SubL.Visible = false; }

            //Does not enable increasing stats past level 50
            if (player.getLevel() == 50)
            {
                btn_AddS.Visible = false;
                btn_AddP.Visible = false;
                btn_AddE.Visible = false;
                btn_AddC.Visible = false;
                btn_AddI.Visible = false;
                btn_AddA.Visible = false;
                btn_AddL.Visible = false;
            }



        }
        private void Main_Load(object sender, System.EventArgs e)
        {
            cbUpdate();
        }

        private void button_Quit_Click(object sender, System.EventArgs e)
        {
            try
            {
                SerializeObject<List<string>>(savedPlayers,savedPath);
            }
            catch
            {

            }
              
              Application.Exit();
        }

        private void tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            player.changeName(tb_Name.Text.ToString());
            UpdateUI();
        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {
            player.changeName(tb_Name.Text.ToString());
            UpdateUI();
        }
        private void btn_AddS_Click(object sender, EventArgs e)
        {

            if (player.getStr() < 15)
            {
                player.addLevel();
                player.addStr();
                UpdateUI();

            }
        }

        private void btn_AddP_Click(object sender, EventArgs e)
        {
            if (player.getPer() < 15)
            { 
                player.addLevel();
                player.addPer();
                UpdateUI();
            }
        }

        private void btn_AddE_Click(object sender, EventArgs e)
        {
            if (player.getEnd() < 15)
            {
                player.addLevel();
                player.addEnd();
                UpdateUI();
            }
        }

        private void btn_AddC_Click(object sender, EventArgs e)
        {
            if (player.getCha() < 15)
            {
                player.addLevel();
                player.addCha();
                UpdateUI();
            }
        }

        private void btn_AddI_Click(object sender, EventArgs e)
        {
            if (player.getInt() < 15)
            {
                player.addLevel();
                player.addInt();
                UpdateUI();
            }
        }

        private void btn_AddA_Click(object sender, EventArgs e)
        {
            if (player.getAgi() < 15)
            {
                player.addLevel();
                player.addAgi();
                UpdateUI();
            }
        }

        private void btn_AddL_Click(object sender, EventArgs e)
        {
            if (player.getLuc() < 15)
            {
                player.addLevel();
                player.addLuc();
                UpdateUI();
            }
        }

        private void btn_SubS_Click(object sender, EventArgs e)
        {
            if (player.getStr() > 1)
            {
                player.subLevel();
                player.subStr();
                UpdateUI();
            }
        }

        private void btn_SubP_Click(object sender, EventArgs e)
        {
            if (player.getPer() > 1)
            {
                player.subLevel();
                player.subPer();
                UpdateUI();
            }
        }

        private void btn_SubE_Click(object sender, EventArgs e)
        {
            if (player.getEnd() > 1)
            {
                player.subLevel();
                player.subEnd();
                UpdateUI();
            }
        }

        private void btn_SubC_Click(object sender, EventArgs e)
        {
            if (player.getCha() > 1)
            {
                player.subLevel();
                player.subCha();
                UpdateUI();
            }
        }

        private void btn_SubI_Click(object sender, EventArgs e)
        {
            if (player.getInt() > 1)
            {
                player.subLevel();
                player.subInt();
                UpdateUI();
            }
        }

        private void btn_SubA_Click(object sender, EventArgs e)
        {
            if (player.getAgi() > 1)
            {
                player.subLevel();
                player.subAgi();
                UpdateUI();
            }
        }

        private void btn_SubL_Click(object sender, EventArgs e)
        {
            if (player.getLuc() > 1)
            {
                player.subLevel();
                player.subLuc();
                UpdateUI();
            }
        }

        private void button_CreateNew_Click(object sender, EventArgs e)
        {

            player = new Character();
            UpdateUI();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if ((player.getName() != savedPath)&&(player.getName().Trim(' ') != ""))
            {
               if (!savedPlayers.Contains(player.getName()))
                {
                    savedPlayers.Add(player.getName());
                }
                   
                
                

                cbUpdate();

                try
                { 
                   SerializeObject<Character>(player, player.getName());
                  
                }
                catch
                {

                }
            }
            
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            try
            {
                player = DeSerializeObject<Character>(cb_Characters.SelectedItem.ToString());
                UpdateUI();
            }
            catch
            {

            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            try
            {
                savedPlayers.Remove(cb_Characters.SelectedItem.ToString());
                File.Delete(cb_Characters.SelectedItem.ToString());
                cbUpdate();
                cb_Characters.Text = "";
            }
            catch
            {

            }
            

        }

       
        public static void SerializeObject<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { return; }
                
           
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, serializableObject);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(fileName);
                }
            
           
        }


        
        public static T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }

            T objectOut = default(T);

            
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileName);
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(T);

                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (T)serializer.Deserialize(reader);
                    }
                }
            
            

            return objectOut;
        }



    }
}
