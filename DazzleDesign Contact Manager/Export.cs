using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DazzleDesign_Contact_Manager
{
    public partial class Export : Form
    {
        public Export()
        {
            InitializeComponent();
        }

        public void ReadData()
        {

            string XMLDataFilePath = string.Concat(PathGenerator.PathGen.GetPath(PathGenerator.PathGen.PathType.DocContactsDir), @"\Contacts.xml");
            if (DataRW.DataRW.ReadFile() == true)
            {
                contactsStore.Clear();
                contactsStore.ReadXml(XMLDataFilePath);
            }


        }

        public void WriteData()
        {
            contactsBindingSource.EndEdit();

            DataRW.DataRW.WriteData(contactsStore.GetXml(), Application.ProductVersion);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            {
                Panel1.Enabled = true;
                Panel2.Enabled = false;
                Panel3.Enabled = true;

                step1label.Enabled = true;
                step2label.Enabled = false;
                step3label.Enabled = true;

                step1label.Text = "Step 1:";
                step3label.Text = "Step 3:";
            }

            else if (RadioButton2.Checked == true)
            {
                Panel1.Enabled = true;
                Panel2.Enabled = true;
                Panel3.Enabled = true;

                step1label.Enabled = true;
                step2label.Enabled = true;
                step3label.Enabled = true;

                step1label.Text = "Step 1:";
                step2label.Text = "Step 2:";
                step3label.Text = "Step 3:";
            
            }

            else if (RadioButton3.Checked == true)
            {
                Panel1.Enabled = false;
                Panel2.Enabled = false;
                Panel3.Enabled = true;

                step1label.Enabled = false;
                step2label.Enabled = false;
                step3label.Enabled = true;

                step3label.Text = "Step 1:";

            
            }
        }

        private void Export_Load(object sender, EventArgs e)
        {
            ReadData();
        }

        private void selectorbttn_Click(object sender, EventArgs e)
        {
            if ((RadioButton1.Checked == true || RadioButton2.Checked == true) && FolderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                locationtxtbox.Text = FolderBrowserDialog1.SelectedPath;
            }
            else if (RadioButton3.Checked == true && OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                locationtxtbox.Text = OpenFileDialog1.FileName;
            }
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            { 
            
            
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show((string)Convert.ChangeType(groupcombobox1.SelectedValue.ToString(), typeof(string)));
        }
    }
}
