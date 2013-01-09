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
    public partial class GroupManager : Form
    {    
        private Mode.Mode CurrentMode = new Mode.Mode();
        private bool SelectionOnlyMode = false;
        public GroupManager(bool SelectionOnlyModeArg)
        {
            InitializeComponent();

            switch (SelectionOnlyModeArg)
            {
                case true:
                    Panel1.Enabled = false;
                    break;

                case false:
                    Panel1.Enabled = true;
                    break;
            }
            SelectionOnlyMode= SelectionOnlyModeArg;

            CurrentMode.EditMode = Mode.Mode.EditModeEnum.Normal;

            ReadData();
        }
        private string BeforeRename = "";
        private bool isMouseDown = false;
        private Point StartPoint;


        private void ReadData()
        {
            string XMLDataFilePath = string.Concat(PathGenerator.PathGen.GetPath(PathGenerator.PathGen.PathType.DocContactsDir), @"\Contacts.xml");
            if (DataRW.DataRW.ReadFile() == true)
            { 
               contactsStore.Clear();
            contactsStore.ReadXml(XMLDataFilePath);
            }
         
        }
     

        private void WriteData()
        {
            groupsBindingSource.EndEdit();
         
            DataRW.DataRW.WriteData(contactsStore.GetXml(), Application.ProductVersion);
        }

        private void newgroupbttn_Click(object sender, EventArgs e)
        {
            groupsBindingSource.AddNew();
            CurrentMode.EditMode = Mode.Mode.EditModeEnum.AddNew;
            
            GroupNameTextBox.Focus();
        }

        private void savebttn_Click(object sender, EventArgs e)
        {
            string DirPath = string.Concat(PathGenerator.PathGen.GetPath(PathGenerator.PathGen.PathType.DocContactsDir), @"\", GroupNameTextBox.Text.Trim());
                                 

            
            switch (CurrentMode.EditMode)
            {
                case Mode.Mode.EditModeEnum.Rename:
                    string OldDirPath = string.Concat(PathGenerator.PathGen.GetPath(PathGenerator.PathGen.PathType.DocContactsDir), @"\", BeforeRename);

                    bool RenameCheck = PathGenerator.PathGen.RenameDir(OldDirPath, DirPath, GroupNameTextBox.Text.Trim());
                                if ( RenameCheck== true)
                                {
                                    try
                                    {
                                        try
                                        {
                                                                      groupsBindingSource.EndEdit();
                                                                      WriteData();

                                                                      CurrentMode.EditMode = Mode.Mode.EditModeEnum.Normal;
                                        }
                                        catch (ConstraintException)
                                        {

                                            MessageBox.Show("Failed to create contact.Try saving this contact with a different name.", "DazzleDesign Contacts", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        }
                                    }
                                    catch (DBConcurrencyException)
                                    {

                                        MessageBox.Show("Failed to update database.", "DazzleDesign Contacts", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    }
                                   
                                }
                                else if (RenameCheck == false)
                                {
                                    groupsBindingSource.CancelEdit();
                                }
                    break;
               
                case Mode.Mode.EditModeEnum.AddNew:
 if(PathGenerator.PathGen.CreateDir(DirPath,GroupNameTextBox.Text.Trim())==true)

        {
     
            try
            {
                try
                {
                    groupsBindingSource.EndEdit();
                    WriteData();

                    CurrentMode.EditMode = Mode.Mode.EditModeEnum.Normal;
                }
                catch (ConstraintException)
                {

                    MessageBox.Show("Failed to create contact.Try saving this contact with a different name.", "DazzleDesign Contacts", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("Failed to update database.", "DazzleDesign Contacts", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
           

           
        
        }
                    break;
                
            }
       
        }

        private void removegroupbttn_Click(object sender, EventArgs e)
        {
            string DirPath = string.Concat(PathGenerator.PathGen.GetPath(PathGenerator.PathGen.PathType.DocContactsDir), @"\", GroupNameTextBox.Text.Trim());
            switch (System.IO.Directory.Exists(DirPath))
            {
                case true:
     System.IO.Directory.Delete(DirPath,true);

            groupsBindingSource.RemoveCurrent();
            WriteData();
                    break;

                case false:
                    if (MessageBox.Show("Contact Group not found in the file system. Entry will be removed from the database.", "DazzleDesign Contacts", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                    {
                        groupsBindingSource.RemoveCurrent();

                      WriteData();
                    }

                    break;
            }
       
          
        }

        private void editgroupbttn_Click(object sender, EventArgs e)
        {
            BeforeRename = GroupNameTextBox.Text.Trim();
CurrentMode.EditMode = Mode.Mode.EditModeEnum.Rename;
            GroupNameTextBox.Focus();
            

           
            
        }

        private void cancelbttn_Click(object sender, EventArgs e)
        {
            switch (CurrentMode.EditMode)
            {
                
                   
                case Mode.Mode.EditModeEnum.Rename:
                    GroupNameTextBox.Text = BeforeRename;
                    CurrentMode.EditMode = Mode.Mode.EditModeEnum.Normal;
                   
                    break;
                
                case Mode.Mode.EditModeEnum.AddNew:
                    groupsBindingSource.CancelEdit();
                    CurrentMode.EditMode = Mode.Mode.EditModeEnum.Normal;
                    break;
                
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (GroupNameListBox.SelectedItems.Count > 0)
            {
                switch (CurrentMode.EditMode)
                {
                    case Mode.Mode.EditModeEnum.Rename:
                        
                            newgroupbttn.Enabled = false;
                            removegroupbttn.Enabled = false;
                            savebttn.Enabled = true;
                            renamegroupbttn.Enabled = false;
                            cancelbttn.Enabled = true;
                            GroupNameTextBox.Visible = true;

                            GroupNameListBox.Enabled = false;

                        break;
                    case Mode.Mode.EditModeEnum.Normal:
                        newgroupbttn.Enabled = true;
                        removegroupbttn.Enabled = true;
                        savebttn.Enabled = false;
                        renamegroupbttn.Enabled =true;
                        cancelbttn.Enabled = false;

                        GroupNameTextBox.Visible = false;

                        GroupNameListBox.Enabled = true;
                        break;
                    case Mode.Mode.EditModeEnum.AddNew:
                        newgroupbttn.Enabled = false;
                        removegroupbttn.Enabled = false;
                        savebttn.Enabled = true;
                        renamegroupbttn.Enabled = false;
                        cancelbttn.Enabled = true;

                        GroupNameTextBox.Visible = true;

                        GroupNameListBox.Enabled = false;
                        break;

                }
            }
            else if (GroupNameListBox.SelectedItems.Count == 0)
            {
                switch (CurrentMode.EditMode)
                {
                 
                    case Mode.Mode.EditModeEnum.Normal:
                        newgroupbttn.Enabled = true;
                        removegroupbttn.Enabled = false;
                        savebttn.Enabled = false;
                        renamegroupbttn.Enabled = false;
                        cancelbttn.Enabled = false;

                        GroupNameTextBox.Visible = false;
                        break;
                    case Mode.Mode.EditModeEnum.AddNew:
                        newgroupbttn.Enabled = false;
                        removegroupbttn.Enabled = false;
                        savebttn.Enabled = true;
                        renamegroupbttn.Enabled = false;
                        cancelbttn.Enabled = true;

                        GroupNameTextBox.Visible = true;
                        break;

                    default:
                        newgroupbttn.Enabled = true;
                        removegroupbttn.Enabled = false;
                        savebttn.Enabled = false;
                        renamegroupbttn.Enabled = false;
                        cancelbttn.Enabled = false;

                        GroupNameTextBox.Visible =false;
                        break;

                }
            }
        }

        private void closebttn_Click(object sender, EventArgs e)
        {


                      

                        switch (SelectionOnlyMode)
                        {
                            case true:
                                string DirPath = string.Concat(PathGenerator.PathGen.GetPath(PathGenerator.PathGen.PathType.DocContactsDir), @"\", GroupNameTextBox.Text.Trim());

                                bool Result = System.IO.Directory.Exists(DirPath);

                                if (Result == true)
                                {
                                    DazzleDesign_Contact_Reader.Reader.SlectedGroupName = GroupNameTextBox.Text.Trim();
                                    this.DialogResult = DialogResult.OK;
                                    this.Dispose();
                                }

                                else if (Result == false)
                                {
                                    if (MessageBox.Show("This group does not exist in the file system. Entry will be removed from the database.", "DazzleDesign Contacts", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                                    {
                                        groupsBindingSource.RemoveCurrent();
                                        groupsBindingSource.EndEdit();

                                        WriteData();
                                    }
                                }
                                break;

                            case false:
                               this.DialogResult = DialogResult.OK;
                                    this.Dispose();

                                break;
                        }
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

      
      
    }
}
