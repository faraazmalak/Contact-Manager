using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataRW;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace DazzleDesign_Contact_Manager
{
    public partial class ContactManager : Form
    {
        public ContactManager()
        {
            InitializeComponent();

            switch (Properties.Settings.Default.formstate)
            {
                case FormWindowState.Maximized:
                    this.WindowState = FormWindowState.Maximized;
                    maximizebttn.BackgroundImage = Properties.Resources.normicon;
                    break;

                case FormWindowState.Normal:
                    if (Properties.Settings.Default.formloc.IsEmpty == true)
                    {
                        this.StartPosition = FormStartPosition.CenterScreen;

                        this.Size = Properties.Settings.Default.formsize;

                        maximizebttn.BackgroundImage = Properties.Resources.maxicon;
                    }
                    else
                    {
                        this.StartPosition = FormStartPosition.Manual;
                        this.Size = Properties.Settings.Default.formsize;
                        this.Location = Properties.Settings.Default.formloc;
                    }
                    break;

            }
        }

        private bool isMouseDown = false;
        private Point StartPoint;
        private bool OnLeft = false;
        private bool OnRight = false;
        private bool OnTop = false;
        private bool OnBottom = false;
        private int LeftDist = 0;
        private int TopDist = 0;




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
            
          DataRW. DataRW.WriteData(contactsStore.GetXml(),Application.ProductVersion);
            
        }


        private string CreateContactPath()
            
        {

         
       return(string.Concat( PathGenerator.PathGen.GetPath(PathGenerator.PathGen.PathType.DocContactsDir),@"\", iDLabel1.Text,".icard"));

        }

        private void newcontactbttn_Click(object sender, EventArgs e)
        {
            switch (groupsBindingSource.Count)
            {
                default:
                    DazzleDesign_Contact_Reader.Reader Reader = new DazzleDesign_Contact_Reader.Reader(Mode.Mode.EditModeEnum.AddNew, "", "");

                    if (Reader.ShowDialog() == DialogResult.OK)
                    {
                        ReadData();
                    }
                    break;
                case 0:

                    if (MessageBox.Show("You must first create a group before adding contacts. Would you like to create one now?", "No Group Created", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    { 
                     GroupManager GroupManager = new GroupManager(false);

                    if (GroupManager.ShowDialog() == DialogResult.OK)
                    { ReadData(); }

                   

                    }
                    break;
            }
        }

        private void removecontactbttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this contact? This operation cannot be reversed","DazzleDesign Contacts",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                
                switch (System.IO.File.Exists(CreateContactPath()))
                {
                    case true:
                        System.IO.File.Delete(CreateContactPath());

                        contactsBindingSource.RemoveCurrent();

                        WriteData();
                        break;

                    case false:
                        if (MessageBox.Show("Contact not found in the filesystem. Entry will be removed from the database", "DazzleDesign Contacts", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            contactsBindingSource.RemoveCurrent();
                            WriteData();
                        }
                        break;
                }


            
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (ContactsDataGridView.SelectedCells.Count > 0 || ContactsDataGridView.SelectedRows.Count > 0)
            {
                opencontactbttn.Enabled = true;
                removecontactbttn.Enabled = true;
            }

            else if (ContactsDataGridView.SelectedRows.Count == 0 && ContactsDataGridView.SelectedCells.Count == 0)
            {
                opencontactbttn.Enabled = false;
                removecontactbttn.Enabled = false;
            }
        }

        private void groupsbttn_Click(object sender, EventArgs e)
        {
            GroupManager GroupManager = new GroupManager(false);

            if (GroupManager.ShowDialog() == DialogResult.OK)
            {
                ReadData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contactsBindingSource.SuspendBinding();

        
        
        }

      

        private void opencontactbttn_Click(object sender, EventArgs e)
        {
            switch (System.IO.File.Exists(CreateContactPath()))
            {
                case true:
      DazzleDesign_Contact_Reader.Reader ContactReader = new DazzleDesign_Contact_Reader.Reader(Mode.Mode.EditModeEnum.InternalEdit,CreateContactPath(),iDLabel1.Text);
            if (ContactReader.ShowDialog() == DialogResult.OK) { ReadData(); }
                    break;

                case false:

                                                        if (MessageBox.Show("This contact does not exist in the file system. Entry will be removed from the database.", "DazzleDesign Contacts", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                                                        {
                                                       contactsBindingSource.RemoveCurrent();
                                                            WriteData();
                                                        }
                    break;
            }
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            contactsBindingSource.ResumeBinding();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Export ExportDialog = new Export();

            if (ExportDialog.ShowDialog() == DialogResult.OK)
            {
                ReadData();
            }
        }

        private void ContactManager_Load(object sender, EventArgs e)
        {
            ReadData();
        }


        #region Control Box
               private void exitbttn_Click(object sender, EventArgs e)
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:

                    Properties.Settings.Default.formstate = FormWindowState.Maximized;
                    break;

                case FormWindowState.Normal:
                    Properties.Settings.Default.formstate = FormWindowState.Normal;
                    Properties.Settings.Default.formloc = this.Location;
                    Properties.Settings.Default.formsize = this.Size;


                    break;

            }
            Properties.Settings.Default.Save();


          

            Application.Exit();

        }
               private void maximizebttn_Click(object sender, EventArgs e)
               {
                   switch (this.WindowState)
                   {
                       case FormWindowState.Maximized:
                           this.WindowState = FormWindowState.Normal;
                           this.Refresh();
                           break;

                       case FormWindowState.Normal:
                           this.WindowState = FormWindowState.Maximized;
                           this.Refresh();
                           break;
                   }
               }
               private void maximizebttn_SizeChanged(object sender, EventArgs e)
               {
                   switch (this.WindowState)
                   {
                       case FormWindowState.Maximized:
                           maximizebttn.BackgroundImage = Properties.Resources.normicon;
                           break;

                       case FormWindowState.Normal:
                           maximizebttn.BackgroundImage = Properties.Resources.maxicon;
                           break;
                   }
               }

               private void minimizebttn_Click(object sender, EventArgs e)
               {
                   this.WindowState = FormWindowState.Minimized;

               }

        #endregion

               #region ResizeForm
               private void MainForm_MouseUp(object sender, MouseEventArgs e)
               {
                   isMouseDown = false;
                   OnLeft = false;
                   OnRight = false;
                   OnTop = false;
                   OnBottom = false;
               }

               private void MainForm_MouseMove(object sender, MouseEventArgs e)
               {


                   //if ((e.X>=0 && e.X<10) && (e.Y>=0 &&e.Y<10))
                   //{
                   //    //Top Left Corner
                   //    this.Cursor = System.Windows.Forms.Cursors.SizeNWSE;

                   //    if (isMouseDown == true)
                   //    {



                   //        if ((PointToScreen(e.Location).X < PointToScreen(MoveXY).X) && (this.Left > 0) && (this.Top > 0))
                   //        {
                   //            this.Left -= PointToScreen(MoveXY).X - PointToScreen(e.Location).X;
                   //            this.Width += PointToScreen(MoveXY).X - PointToScreen(e.Location).X; ;

                   //            this.Top -= PointToScreen(MoveXY).Y - PointToScreen(e.Location).Y;
                   //            this.Height += PointToScreen(MoveXY).Y - PointToScreen(e.Location).Y;
                   //        }
                   //        else if ((PointToScreen(e.Location).X > PointToScreen(MoveXY).X) && (this.Left > 0) && (this.Top > 0))
                   //        {
                   //            this.Left += PointToScreen(e.Location).X - PointToScreen(MoveXY).X;
                   //            this.Width -= PointToScreen(e.Location).X - PointToScreen(MoveXY).X;

                   //            this.Top += PointToScreen(e.Location).Y - PointToScreen(MoveXY).Y;
                   //            this.Height -= PointToScreen(e.Location).Y - PointToScreen(MoveXY).Y;
                   //        }



                   //    }

                   //}

                   //else if((e.X>=0 && e.X<10) && (e.Y>=this.Height-10 && e.Y<=this.Height))
                   //{
                   //    //Bottom Left Corner
                   //    this.Cursor = System.Windows.Forms.Cursors.SizeNESW;

                   //    if (isMouseDown == true)
                   //    {
                   //        if ((PointToScreen(e.Location).X < PointToScreen(MoveXY).X) && (this.Left > 0) && (this.Top > 0))
                   //        {
                   //            this.Left -= PointToScreen(MoveXY).X - PointToScreen(e.Location).X;
                   //            this.Width += PointToScreen(MoveXY).X - PointToScreen(e.Location).X; ;

                   //            this.Height += PointToScreen(MoveXY).Y - PointToScreen(e.Location).Y;
                   //        }
                   //        else if ((PointToScreen(e.Location).Y > PointToScreen(MoveXY).Y) && (this.Left > 0) && (this.Top > 0))
                   //        {
                   //           // this.Left += PointToScreen(e.Location).X - PointToScreen(MoveXY).X;
                   //           // this.Width -= PointToScreen(e.Location).X - PointToScreen(MoveXY).X;

                   //            this.Height += PointToScreen(MoveXY).Y - PointToScreen(e.Location).Y;
                   //        }
                   //    }

                   //}

                   //else if ((e.Y >= 0 && e.Y < 10) && (e.X >= this.Width - 10 && e.X <= this.Width))
                   //{
                   //    // Top Right Corner
                   //    this.Cursor = System.Windows.Forms.Cursors.SizeNESW;
                   //    if(isMouseDown==true)
                   //    {
                   //        if ((PointToScreen(e.Location).X < PointToScreen(MoveXY).X) && (this.Left > 0) && (this.Top > 0))
                   //        {
                   //            this.Width += PointToScreen(MoveXY).X - PointToScreen(e.Location).X; ;

                   //            this.Top -= PointToScreen(MoveXY).Y - PointToScreen(e.Location).Y;
                   //            this.Height += PointToScreen(MoveXY).Y - PointToScreen(e.Location).Y;
                   //        }
                   //        else if ((PointToScreen(e.Location).X > PointToScreen(MoveXY).X) && (this.Left > 0) && (this.Top > 0))
                   //        {
                   //            this.Width -= PointToScreen(e.Location).X - PointToScreen(MoveXY).X;

                   //            this.Top += PointToScreen(e.Location).Y - PointToScreen(MoveXY).Y;
                   //            this.Height -= PointToScreen(e.Location).Y - PointToScreen(MoveXY).Y;
                   //        }
                   //    }

                   //}

                   //else if ((e.X >= this.Width-10 && e.X <= this.Width) && (e.Y >= this.Height - 10 && e.Y <= this.Height))
                   //{
                   //    //Bottom Right Corner
                   //    this.Cursor = System.Windows.Forms.Cursors.SizeNWSE;


                   //}
                   if (this.WindowState == FormWindowState.Normal)
                   {
                       switch (isMouseDown)
                       {
                           case false:
                               {

                                   if ((e.X >= 0 && e.X <= 10) && (e.Y < this.Height - 10))
                                   {
                                       //Left Side
                                       this.Cursor = System.Windows.Forms.Cursors.SizeWE;


                                   }
                                   else if ((e.X >= this.Width - 10 && e.X <= this.Width) && (e.Y > 10 && e.Y <= this.Height - 10))
                                   {
                                       //Right Side
                                       this.Cursor = System.Windows.Forms.Cursors.SizeWE;


                                   }
                                   else if ((e.X >= 10 && e.X <= this.Width - 10) && (e.Y >= 0 && e.Y <= 10))
                                   {
                                       //Top Side
                                       this.Cursor = System.Windows.Forms.Cursors.SizeNS;

                                   }
                                   else if ((e.X >= 10 && e.X <= this.Width - 10) && (e.Y >= this.Height - 10 && e.Y <= this.Height))
                                   {
                                       //Bottom Side
                                       this.Cursor = System.Windows.Forms.Cursors.SizeNS;

                                   }
                                   else
                                   {


                                       this.Cursor = System.Windows.Forms.Cursors.Arrow;

                                   }
                               }
                               break;


                           case true:
                               {

                                   Point pt = PointToScreen(e.Location);

                                   if (OnLeft == true)
                                   {
                                       this.Left = pt.X;

                                       if ((LeftDist > this.Left) && (this.Width < Screen.PrimaryScreen.WorkingArea.Width))
                                       {

                                           this.Width += LeftDist - this.Left;
                                           this.Refresh();
                                       }
                                       else if ((LeftDist < this.Left) && (this.Width < Screen.PrimaryScreen.WorkingArea.Width))
                                       {
                                           this.Width -= this.Left - LeftDist;
                                           this.Refresh();

                                       }


                                   }
                                   else if (OnRight == true)
                                   {
                                       this.Width = PointToClient(pt).X;
                                       this.Refresh();

                                   }
                                   else if (OnTop == true)
                                   {
                                       this.Top = pt.Y;
                                       if ((TopDist > this.Top) && (this.Height < Screen.PrimaryScreen.WorkingArea.Height))
                                       {

                                           this.Height += TopDist - this.Top;
                                           this.Refresh();
                                       }
                                       else if ((TopDist < this.Top) && (this.Height < Screen.PrimaryScreen.WorkingArea.Height))
                                       {
                                           this.Height -= this.Top - TopDist;
                                           this.Refresh();

                                       }
                                   }
                                   else if (OnBottom == true)
                                   {
                                       this.Height = PointToClient(pt).Y;
                                       this.Refresh();
                                   }
                               }

                               break;
                       }
                   }
               }







               private void MainForm_MouseDown(object sender, MouseEventArgs e)
               {
                   isMouseDown = true;

                   if ((e.X >= 0 && e.X <= 10) && (e.Y < this.Height - 10))
                   {
                       //Left Side


                       OnLeft = true;
                   }
                   else if ((e.X >= this.Width - 10 && e.X <= this.Width) && (e.Y > 10 && e.Y <= this.Height - 10))
                   {
                       //Right Side

                       OnRight = true;

                   }
                   else if ((e.X >= 10 && e.X <= this.Width - 10) && (e.Y >= 0 && e.Y <= 10))
                   {
                       //Top Side

                       OnTop = true;
                   }
                   else if ((e.X >= 10 && e.X <= this.Width - 10) && (e.Y >= this.Height - 10 && e.Y <= this.Height))
                   {
                       //Bottom Side

                       OnBottom = true;
                   }
               }

               private void MainForm_Resize(object sender, EventArgs e)
               {
                   LeftDist = this.Left;
                   TopDist = this.Top;
               }

               private void MainForm_MouseLeave(object sender, EventArgs e)
               {
                   this.Cursor = System.Windows.Forms.Cursors.Arrow;

               }

               private void MainForm_SizeChanged(object sender, EventArgs e)
               {
                   switch (this.WindowState)
                   {
                       case FormWindowState.Maximized:
                           maximizebttn.BackgroundImage = Properties.Resources.normicon;
                           break;

                       case FormWindowState.Normal:
                           maximizebttn.BackgroundImage = Properties.Resources.maxicon;
                           break;
                   }
               }

               #endregion


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
