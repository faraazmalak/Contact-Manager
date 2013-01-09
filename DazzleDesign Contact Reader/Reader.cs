using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace DazzleDesign_Contact_Reader
{
    public partial class Reader : Form
    {
        private Mode.Mode CurrentMode=new Mode.Mode();
        private string FileToOpen = "";
        private Contact Contact=new Contact();
        public static string SlectedGroupName = "";
        private string OriginalGroup = "";
        private string OriginalName = "";
        private string ContactID = "";
        private Mode.Mode EmailMode = new Mode.Mode();
        private bool isMouseDown = false;
        private Point StartPoint;

        public Reader(Mode.Mode.EditModeEnum Mode,string FilePath,string ContactIDArg)
        {
            InitializeComponent();

            CurrentMode.EditMode = Mode;
            FileToOpen = FilePath;
            ContactID=ContactIDArg;
        }

        private bool DeSerializeContact()
        {
            bool Result = false;
            if (string.IsNullOrEmpty(FileToOpen) == false)
            {
                BinaryFormatter Formatter = new BinaryFormatter();
                FileStream Stream = new FileStream(FileToOpen, FileMode.Open);

                Contact = (Contact)Formatter.Deserialize(Stream);

                Stream.Close();
                Result = true;
            }

            else if (string.IsNullOrEmpty(FileToOpen) == true)
            {
                
                Result = false;
            }
            return Result;
        }
        private void CreateSummary()
        {
            string FullName = "";
            FullName = string.Concat(FirstNameTextBox.Text.Trim(), " ", MiddleNameTextBox.Text.Trim(), " ", LastNameTextBox.Text.Trim());
            if (string.IsNullOrEmpty(FullName.Trim()) == false)
            {
                FullNameTextBoxTxtBox.Text = FullName;

            }

            WorkCellTextBox2.Text = WorkCellTxtBox.Text;

            HomeCellTextBox2.Text = HomeCellTxtBox.Text;

            WorkCompanyTextBox2.Text = WorkCompanyTxtBox.Text;
        }
        private bool SerializeContact()
        {
            bool Result = false;
            string FilePath = string.Concat(PathGenerator.PathGen.GetPath(PathGenerator.PathGen.PathType.DocContactsDir), @"\", CreatedUnderTxtBox.Text.Trim(), @"\", SaveContactAsTxtBox.Text.Trim(), ".icard");

            if ((CurrentMode.EditMode == Mode.Mode.EditModeEnum.AddNew || CurrentMode.EditMode == Mode.Mode.EditModeEnum.Import) && (PathGenerator.PathGen.CheckChars(SaveContactAsTxtBox.Text.Trim())==true))
            {

                
                    try
                    {
                        try
                        {
                            ContactsBindingSource.EndEdit();
                            
                            BinaryFormatter Formatter = new BinaryFormatter();
                    FileStream Stream = new FileStream(FilePath, FileMode.Create);

                    Formatter.Serialize(Stream, Contact); 
                    
                    Stream.Close();

   WriteXMLData();

                        }
                        catch (ConstraintException)
                        {

                            MessageBox.Show("Failed to create contact.Try saving this contact with a different name.", "DazzleDesign Contacts", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            Result = false;
                        }
                    }
                    catch (DBConcurrencyException)
                    {

                        MessageBox.Show("Failed to update database.", "DazzleDesign Contacts", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Result = false;
                    }

                 

                 

                   
                
                Result = true;
            }

            else if ((CurrentMode.EditMode == Mode.Mode.EditModeEnum.InternalEdit) && (PathGenerator.PathGen.CheckChars(SaveContactAsTxtBox.Text.Trim())==true))
            {
               
                    try
                    {
                        try
                        {
                            ContactsBindingSource.EndEdit();

                            int NameCompare = string.Compare(SaveContactAsTxtBox.Text.Trim(), OriginalName, false);
                            int GroupCompare = string.Compare(CreatedUnderTxtBox.Text.Trim(), OriginalGroup, true);


                            if (GroupCompare != 0)
                            {
                                PathGenerator.PathGen.MoveFile(FilePath, FileToOpen, SaveContactAsTxtBox.Text.Trim());
                                OriginalGroup = CreatedUnderTxtBox.Text.Trim();
                            }
                            else if (GroupCompare == 0 && NameCompare != 0)
                            {

                                Microsoft.VisualBasic.FileSystem.Rename(FileToOpen, FilePath);
                                OriginalName = SaveContactAsTxtBox.Text.Trim();



                            }








                            BinaryFormatter Formatter = new BinaryFormatter();
                            FileStream Stream = new FileStream(FilePath, FileMode.Create);

                            Formatter.Serialize(Stream, Contact);

                            Stream.Close();


                            WriteXMLData();
                        }
                        catch (ConstraintException)
                        {

                            MessageBox.Show("Failed to create contact.Try saving this contact with a different name.", "DazzleDesign Contacts", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            Result = false;
                        }
                    }
                    catch (DBConcurrencyException)
                    {

                        MessageBox.Show("Failed to update database.", "DazzleDesign Contacts", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Result = false;
                    }

                
                
                          

              

                Result = true;
              

            }

            else if ((CurrentMode.EditMode == Mode.Mode.EditModeEnum.ExternalEdit) && (PathGenerator.PathGen.CheckChars(SaveContactAsTxtBox.Text.Trim()) == true))

            {

                int NameCompare = string.Compare(SaveContactAsTxtBox.Text.Trim(), OriginalName, false);
                int GroupCompare = string.Compare(CreatedUnderTxtBox.Text.Trim(), OriginalGroup, true);


                if (GroupCompare != 0)
                {
                    PathGenerator.PathGen.MoveFile(FilePath, FileToOpen, SaveContactAsTxtBox.Text.Trim());
                    OriginalGroup = CreatedUnderTxtBox.Text.Trim();
                }
                else if (GroupCompare == 0 && NameCompare != 0)
                {

                    Microsoft.VisualBasic.FileSystem.Rename(FileToOpen, FilePath);
                    OriginalName = SaveContactAsTxtBox.Text.Trim();



                }








                BinaryFormatter Formatter = new BinaryFormatter();
                FileStream Stream = new FileStream(FilePath, FileMode.Create);

                Formatter.Serialize(Stream, Contact);

                Stream.Close();

                Result = true;
            
            }

            return Result;
        }

        private bool ReadXMLData()
        {
            bool Result = false;
            string XMLDataFilePath = string.Concat(PathGenerator.PathGen.GetPath(PathGenerator.PathGen.PathType.DocContactsDir), @"\Contacts.xml");
            if (DataRW.DataRW.ReadFile() == true)
            {
                ContactsStore.Clear();
                ContactsStore.ReadXml(XMLDataFilePath);
                Result = true;
            }
           return Result;
        }
        private bool WriteXMLData()
        {
            bool Result = false;
            ContactsBindingSource.EndEdit();
            
            DataRW.DataRW.WriteData(ContactsStore.GetXml(), Application.ProductVersion);
            return Result;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }


        private bool CreateContact()
        {
            
            bool Result = false;

            Contact.Details.Clear();
            Contact.Emails.Clear();



            Contact.AppVersion = Application.ProductVersion;

            Contact.Location = this.Location;

            IDLabel1.Text = string.Concat(CreatedUnderTxtBox.Text.Trim(), @"\", SaveContactAsTxtBox.Text.Trim());



            Contact.Picture = ContactPicture.Image;

            CreateSummary();
          

            foreach (Control Control in TabPage1.Controls)
            {
                if (Control.Name.Contains("TextBox") == true && string.IsNullOrEmpty(Control.Text.Trim()) == false)
                {
                    Contact.Details.Add(Control.Name, Control.Text);
                }


            }   

foreach (Control Control in TabPage2.Controls)
	{
		 if (Control.Name.Contains("TextBox")==true && string.IsNullOrEmpty(Control.Text.Trim())==false)
         {
         Contact.Details.Add(Control.Name,Control.Text);
         }

       
	}
            foreach (string Email in EmailListBox.Items)
             {
                 Contact.Emails.Add(Email);
             }

foreach (Control Control in TabPage3.Controls)
{
    if (Control.Name.Contains("TextBox") == true && string.IsNullOrEmpty(Control.Text.Trim()) == false)
    {
        Contact.Details.Add(Control.Name, Control.Text);
    }

  
}

foreach (Control Control in TabPage4.Controls)
{
    if (Control.Name.Contains("TextBox") == true && string.IsNullOrEmpty(Control.Text.Trim()) == false)
    {
        Contact.Details.Add(Control.Name, Control.Text);
    }


}
if (SerializeContact() == true)
{
    Result= true;

}
else {Result= false; }



           

            return Result;
        }

        private bool LoadContact()
        {
            bool Result = false;
         

            if (DeSerializeContact() == true)
            {
                System.IO.FileInfo FileInfo = new FileInfo(FileToOpen);

                this.Location = Contact.Location;

                SaveContactAsTxtBox.Text = FileInfo.Name.Substring(0, FileInfo.Name.IndexOf("."));
                
                OriginalName = FileInfo.Name.Substring(0, FileInfo.Name.IndexOf("."));

                switch (CurrentMode.EditMode)
                {
                   
                    case Mode.Mode.EditModeEnum.ExternalEdit:

                        CreatedUnderTxtBox.Text = FileInfo.DirectoryName;
                        OriginalGroup = FileInfo.DirectoryName;

                        break;
                    
                    case Mode.Mode.EditModeEnum.InternalEdit:
                              CreatedUnderTxtBox.Text = FileInfo.Directory.Name;
                              OriginalGroup = FileInfo.Directory.Name;

                        break;

                }

                if (Contact.Picture != null)
                { 
                           ContactPicture.Image = Contact.Picture;
     
                }


            
                foreach (Control Control in TabPage1.Controls)
                {
                    if (Control.Name.Contains("TextBox") == true && Contact.Details.ContainsKey(Control.Name) == true)
                    {
                        Control.Text = (string)  Convert.ChangeType( Contact.Details[Control.Name],typeof(string));



                    }
                }

                foreach (Control Control in TabPage2.Controls)
                {
                    if (Control.Name.Contains("TextBox") == true && Contact.Details.ContainsKey(Control.Name) == true)
                    {
                        Control.Text = (string)Convert.ChangeType(Contact.Details[Control.Name], typeof(string));



                    }
                
                }

                foreach (string Email in Contact.Emails)
                {
                    EmailListBox.Items.Add(Email);
                }

                foreach (Control Control in TabPage3.Controls)
                {
                    if (Control.Name.Contains("TextBox") == true && Contact.Details.ContainsKey(Control.Name) == true)
                    {
                        Control.Text = (string)Convert.ChangeType(Contact.Details[Control.Name], typeof(string));



                    }
                }

                foreach (Control Control in TabPage4.Controls)
                {
                    if (Control.Name.Contains("TextBox") == true && Contact.Details.ContainsKey(Control.Name) == true)
                    {
                        Control.Text = (string)Convert.ChangeType(Contact.Details[Control.Name], typeof(string));



                    }
                }
                Result = true;
            }
            return Result;
        }

        private void Reader_Load(object sender, EventArgs e)
        {
            foreach (TabPage Tab in TabControl1.TabPages)
            {
                Tab.Show();
            }

            IDLabel.Visible = false;
            IDLabel1.Visible = false;

            GenderTextBox.Text = "Unspecified";

           

            switch (CurrentMode.EditMode)
            {
                case Mode.Mode.EditModeEnum.AddNew:
                    ReadXMLData();
                    ContactsBindingSource.AddNew();
              
                    break;
                case Mode.Mode.EditModeEnum.ExternalEdit:
                    ContactsBindingSource.SuspendBinding();
                    break;
                case Mode.Mode.EditModeEnum.Import:
                    ReadXMLData();
                    ContactsBindingSource.AddNew();
                   
                    break;
                case Mode.Mode.EditModeEnum.InternalEdit:
                    ReadXMLData();
                    ContactsBindingSource.Filter = string.Concat("ID='", ContactID, "'");
                    foreach (Control Control in TabPage1.Controls)
                    {
                        if (Control.Name.Contains("TxtBox") == true)
                        {
                            Control.DataBindings["Text"].ControlUpdateMode = ControlUpdateMode.Never;
                            Control.ResetText();
                        }

                    }

                    foreach (Control Control in TabPage2.Controls)
                    {
                        if (Control.Name.Contains("TxtBox") == true)
                        {
                            Control.DataBindings["Text"].ControlUpdateMode = ControlUpdateMode.Never;
                            Control.ResetText();

                        }

                    }

                    foreach (Control Control in TabPage3.Controls)
                    {
                        if (Control.Name.Contains("TxtBox") == true)
                        {
                            Control.DataBindings["Text"].ControlUpdateMode = ControlUpdateMode.Never;
                            Control.ResetText();

                        }

                    }

                    foreach (Control Control in TabPage4.Controls)
                    {
                        if (Control.Name.Contains("TxtBox") == true)
                        {
                            Control.DataBindings["Text"].ControlUpdateMode = ControlUpdateMode.Never;
                            Control.ResetText();

                        }

                    }
                 

                   
                    break;
               
            }



            LoadContact();
           
            
           
        }

        private void savecontactbttn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SaveContactAsTxtBox.Text.Trim()) == false && string.IsNullOrEmpty(CreatedUnderTxtBox.Text.Trim()) == false && EmailMode.EditMode==Mode.Mode.EditModeEnum.Normal)
            { 
            
                      CreateContact();
  
            }
            else if (string.IsNullOrEmpty(SaveContactAsTxtBox.Text.Trim()) == true)
            {
                MessageBox.Show("Please enter a valid name in 'Save Contact As' filed", "DazzleDesign Contacts", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else if (string.IsNullOrEmpty(CreatedUnderTxtBox.Text.Trim()) == true)
            {

                MessageBox.Show("Please enter a valid name in 'Create Under' filed", "DazzleDesign Contacts", MessageBoxButtons.OK, MessageBoxIcon.Stop);
 
            }

            else if (EmailMode.EditMode != Mode.Mode.EditModeEnum.Normal)
            {
                MessageBox.Show("You must first finish creating/editing email before you can save the contact.", "DazzleDesign Contacts", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            
            }
        }

        private void showgroupsbttn_Click(object sender, EventArgs e)
        {
            if (CurrentMode.EditMode == Mode.Mode.EditModeEnum.ExternalEdit)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    CreatedUnderTxtBox.Text = folderBrowserDialog1.SelectedPath;
                }

            }
            else
            {
                DazzleDesign_Contact_Manager.GroupManager GroupManager = new DazzleDesign_Contact_Manager.GroupManager(true);
                if (GroupManager.ShowDialog() == DialogResult.OK)
                {
                    CreatedUnderTxtBox.Text = SlectedGroupName;
                }
            }
        }

        private void TabPage1_Enter(object sender, EventArgs e)
        {
            CreateSummary();

           

        }

       
        
        
        #region Emails
         private void addemail_Click(object sender, EventArgs e)
        {
            switch (addemail.Text)
            {
                case "New":

                    EmailListBox.Height = 56;

                    addemail.Text = "Add";
                    EmailMode.EditMode = Mode.Mode.EditModeEnum.AddNew;

                    EmailTxtBx.Focus();
                    break;

                case "Add":

                   int Result=EmailListBox.FindStringExact(EmailTxtBx.Text.Trim());
 if (Result == -1 && EmailTxtBx.Text.Contains("@") == true && EmailTxtBx.Text.Contains(".") == true)
                    {
                        EmailListBox.Items.Add(EmailTxtBx.Text.Trim());


                        EmailMode.EditMode = Mode.Mode.EditModeEnum.Normal;

                        EmailTxtBx.ResetText();
                    
                    }

                    else if(Result==-1 &&( EmailTxtBx.Text.Contains("@")==false || EmailTxtBx.Text.Contains(".")==false))
                    {
                    if (MessageBox.Show("The e-mail address appears to be invalid. Do you want to add it anyway?","DazzleDesign Contact",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                    {
                       EmailListBox.Items.Add(EmailTxtBx.Text.Trim());
                       
                        EmailMode.EditMode = Mode.Mode.EditModeEnum.Normal;

                    
                    }
                    
                       
                    }

                    else if (Result != -1)
                    {
                        MessageBox.Show("This email already exists.", "Email Exists", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    }
                    break;

                default:
                    MessageBox.Show("Invalid Operation", "DazzleDesign Contacts", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                            break;
            }
        }
        #endregion

         private void removeemail_Click(object sender, EventArgs e)
         {
             if (MessageBox.Show("Are you sure you want to delete this e-mail?", "DazzleDesign Contacts", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
             {
                 if ((string)Convert.ChangeType(EmailListBox.SelectedItem, typeof(string)) == DefEmailTextBoxTxtBox.Text)
                 {
                     DefEmailTextBoxTxtBox.ResetText();
                     EmailListBox.Items.Remove(EmailListBox.SelectedItem);

                 }
                 else {
                     EmailListBox.Items.Remove(EmailListBox.SelectedItem);
    
                 }
             }
         }

         private void cancelemail_Click(object sender, EventArgs e)
         {
             switch (cancelemail.Text)
             {
                 case "Cancel":
                     EmailTxtBx.ResetText();
                     EmailMode.EditMode = Mode.Mode.EditModeEnum.Normal;


                     break;

                 case "Set Default":
                     DefEmailTextBoxTxtBox.Text = (string)Convert.ChangeType(EmailListBox.SelectedItem, typeof(string));
                     break;
             }
         }

         private void editemailbttn_Click(object sender, EventArgs e)
         {
             EmailTxtBx.Text = (string)Convert.ChangeType(EmailListBox.SelectedItem, typeof(string));

             EmailTxtBx.Focus();
             EmailMode.EditMode = Mode.Mode.EditModeEnum.Rename;
         }

         private void saveemail_Click(object sender, EventArgs e)
         {
             int Result = EmailListBox.FindStringExact(EmailTxtBx.Text.Trim());
             if (Result == -1 && EmailTxtBx.Text.Contains("@") == true && EmailTxtBx.Text.Contains(".") == true)
             {
                 int index = EmailListBox.SelectedIndex;
                 EmailListBox.Items.RemoveAt(index);

                 EmailListBox.Items.Insert(index, EmailTxtBx.Text.Trim());


                 EmailMode.EditMode = Mode.Mode.EditModeEnum.Normal;

                 EmailTxtBx.ResetText();

             }

             else if (Result == -1 && (EmailTxtBx.Text.Contains("@") == false || EmailTxtBx.Text.Contains(".") == false))
             {
                 if (MessageBox.Show("The e-mail address appears to be invalid. Do you want to add it anyway?", "DazzleDesign Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                 {
                     int index = EmailListBox.SelectedIndex;
                     EmailListBox.Items.RemoveAt(index);

                     EmailListBox.Items.Insert(index, EmailTxtBx.Text.Trim());

                     EmailMode.EditMode = Mode.Mode.EditModeEnum.Normal;


                 }


             }

             else if (Result != -1)
             {
                 MessageBox.Show("This email already exists.", "Email Exists", MessageBoxButtons.OK, MessageBoxIcon.Stop);

             }
            
         }

         private void cancelemailedit_Click(object sender, EventArgs e)
         {
             EmailTxtBx.ResetText();
             EmailMode.EditMode = Mode.Mode.EditModeEnum.Normal;

         }

         private void Timer1_Tick(object sender, EventArgs e)
         {
             switch (EmailMode.EditMode)
             {
                 case Mode.Mode.EditModeEnum.AddNew:
                     addemail.Enabled = true;
                     addemail.Text = "Add";
                     removeemail.Enabled = false;

                     cancelemail.Text = "Cancel";
                     cancelemail.Enabled = true;

                     editemailbttn.Enabled = false;
                     saveemail.Enabled = false;
                     cancelemailedit.Enabled = false;

                     EmailListBox.Height = 56;
                     EmailListBox.Enabled = false;
                     break;
                 
                
                 case Mode.Mode.EditModeEnum.Normal:
                     addemail.Enabled = true;
                     addemail.Text = "New";

                     if (EmailListBox.SelectedItems.Count > 0)
                     { removeemail.Enabled = true;
                     editemailbttn.Enabled = true;

                     if ((string)Convert.ChangeType(EmailListBox.SelectedItem, typeof(string)) != DefEmailTextBoxTxtBox.Text.Trim())
                     {
                         cancelemail.Enabled = true;

                     }
                     else
                     {
                         cancelemail.Enabled = false;
                     }

                     }
                     else{removeemail.Enabled=false;
                     editemailbttn.Enabled = false;
                     cancelemail.Enabled = false;
                     }

                     cancelemail.Text = "Set Default";

                     
                     saveemail.Enabled = false;
                     cancelemailedit.Enabled = false;

                     EmailListBox.Height = 82;
                     EmailListBox.Enabled = true;
                     break;
                 case Mode.Mode.EditModeEnum.Rename:
                     addemail.Enabled = false;
                     removeemail.Enabled = false;
                     cancelemail.Enabled = false;
                     cancelemail.Text = "Set Default";

                     editemailbttn.Enabled = false;
                     saveemail.Enabled = true;
                     cancelemailedit.Enabled = true;

                     EmailListBox.Height = 56;
                     EmailListBox.Enabled = false;

                     break;
                
             }
         }

         private void saveclosebttn_Click(object sender, EventArgs e)
         {
             if (string.IsNullOrEmpty(SaveContactAsTxtBox.Text.Trim()) == false && string.IsNullOrEmpty(CreatedUnderTxtBox.Text.Trim()) == false && EmailMode.EditMode == Mode.Mode.EditModeEnum.Normal)
             {

                 CreateContact();
                 this.DialogResult = DialogResult.OK;
                 this.Dispose();
             }
             else if (string.IsNullOrEmpty(SaveContactAsTxtBox.Text.Trim()) == true)
             {
                 MessageBox.Show("Please enter a valid name in 'Save Contact As' filed", "DazzleDesign Contacts", MessageBoxButtons.OK, MessageBoxIcon.Stop);
             }

             else if (string.IsNullOrEmpty(CreatedUnderTxtBox.Text.Trim()) == true)
             {

                 MessageBox.Show("Please enter a valid name in 'Create Under' filed", "DazzleDesign Contacts", MessageBoxButtons.OK, MessageBoxIcon.Stop);

             }

             else if (EmailMode.EditMode != Mode.Mode.EditModeEnum.Normal)
             {
                 MessageBox.Show("You must first finish creating/editing email before you can save the contact.", "DazzleDesign Contacts", MessageBoxButtons.OK, MessageBoxIcon.Stop);


             }
          

         }
         #region Contact Picture
         private void resetpic_Click(object sender, EventArgs e)
         {
             ContactPicture.Image = Properties.Resources.UserIcon;
         }



         private void ContactPicture_MouseHover(object sender, EventArgs e)
         {
             if (ContactPicture.Dock != DockStyle.Fill)
             { ContactPicture.Dock = DockStyle.Fill; }
         }

         private void ContactPicture_MouseLeave(object sender, EventArgs e)
         {
             if (ContactPicture.Dock == DockStyle.Fill)
             {
                 ContactPicture.Dock = DockStyle.None;
             }

         }

         private void ContactPicture_MouseClick(object sender, MouseEventArgs e)
         {
             if (this.ToolStripContainer1.BottomToolStripPanel.Visible == false)
             {
                 this.ToolStripContainer1.BottomToolStripPanel.Visible = true;
                 ImageCtxMenu.ShowDropDown();

             }
         }   

 private void ImageCtxMenu_DropDownClosed(object sender, EventArgs e)
 {
     if (this.ToolStripContainer1.BottomToolStripPanel.Visible == true)
     { this.ToolStripContainer1.BottomToolStripPanel.Visible = false; }
 } 
        private void changepic_Click(object sender, EventArgs e)
 {

     if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
     {
         Bitmap Source = new Bitmap(OpenFileDialog1.FileName);
         Bitmap Destination = new Bitmap(100, 100);

         Graphics ImageGraphics = Graphics.FromImage(Destination);
         ImageGraphics.DrawImage(Source, 0, 0, Destination.Width, Destination.Height);
         ImageGraphics.Save();

         ContactPicture.Image = Destination;
     }

 }
         #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            IDLabel1.Text = string.Concat(CreatedUnderTxtBox.Text.Trim(), @"\", SaveContactAsTxtBox.Text.Trim());

            ContactsBindingSource.EndEdit();
        }






        #region Form Move

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.StartPoint.X,
                                     p2.Y - this.StartPoint.Y);
                this.Location = p3;
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
        #endregion


        #region Control Box
       private void exitbttn_Click(object sender, EventArgs e)
        {
            Cancel_Button.PerformClick();
        }
    private void minimizebttn_Click(object sender, EventArgs e)
       {
           this.WindowState = FormWindowState.Minimized;
       }
        #endregion

     
       
           

        
      

      

    }
}
