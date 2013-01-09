using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DazzleDesign_Contact_Startup
{
    public partial class Splash : Form
    {
        private string[] args;
        public static DazzleDesign_Contact_Manager.ContactManager ContactManager = new DazzleDesign_Contact_Manager.ContactManager();
        public Splash(string [] AppArgs)
        {
            InitializeComponent();
            args = AppArgs;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            if (args.Length == 0)
            {
                ContactManager.Show();
            }

            else if (args.Length > 0)
            {
                foreach (string Arg in args)
                {
                    DazzleDesign_Contact_Reader.Reader ContactReader = new DazzleDesign_Contact_Reader.Reader(Mode.Mode.EditModeEnum.ExternalEdit,Arg,"");

                 ContactReader.Show();   
                }
                
            }
            this.Hide();
        }
    }
}
