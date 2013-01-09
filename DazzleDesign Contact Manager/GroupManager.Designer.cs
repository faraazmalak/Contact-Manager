namespace DazzleDesign_Contact_Manager
{
    partial class GroupManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.cancelbttn = new System.Windows.Forms.Button();
            this.renamegroupbttn = new System.Windows.Forms.Button();
            this.savebttn = new System.Windows.Forms.Button();
            this.removegroupbttn = new System.Windows.Forms.Button();
            this.newgroupbttn = new System.Windows.Forms.Button();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GroupNameListBox = new System.Windows.Forms.ListBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsStore = new DazzleDesign_Contact_Manager.ContactsStore();
            this.GroupNameTextBox = new System.Windows.Forms.TextBox();
            this.closebttn = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsStore)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.AutoScroll = true;
            this.Panel1.Controls.Add(this.cancelbttn);
            this.Panel1.Controls.Add(this.renamegroupbttn);
            this.Panel1.Controls.Add(this.savebttn);
            this.Panel1.Controls.Add(this.removegroupbttn);
            this.Panel1.Controls.Add(this.newgroupbttn);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(91, 192);
            this.Panel1.TabIndex = 3;
            // 
            // cancelbttn
            // 
            this.cancelbttn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelbttn.Dock = System.Windows.Forms.DockStyle.Top;
            this.cancelbttn.Location = new System.Drawing.Point(0, 96);
            this.cancelbttn.Name = "cancelbttn";
            this.cancelbttn.Size = new System.Drawing.Size(91, 24);
            this.cancelbttn.TabIndex = 4;
            this.cancelbttn.Text = "Cancel";
            this.cancelbttn.UseVisualStyleBackColor = false;
            this.cancelbttn.Click += new System.EventHandler(this.cancelbttn_Click);
            // 
            // renamegroupbttn
            // 
            this.renamegroupbttn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.renamegroupbttn.Dock = System.Windows.Forms.DockStyle.Top;
            this.renamegroupbttn.Location = new System.Drawing.Point(0, 72);
            this.renamegroupbttn.Name = "renamegroupbttn";
            this.renamegroupbttn.Size = new System.Drawing.Size(91, 24);
            this.renamegroupbttn.TabIndex = 3;
            this.renamegroupbttn.Text = "Rename Group";
            this.renamegroupbttn.UseVisualStyleBackColor = false;
            this.renamegroupbttn.Click += new System.EventHandler(this.editgroupbttn_Click);
            // 
            // savebttn
            // 
            this.savebttn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.savebttn.Dock = System.Windows.Forms.DockStyle.Top;
            this.savebttn.Enabled = false;
            this.savebttn.Location = new System.Drawing.Point(0, 48);
            this.savebttn.Name = "savebttn";
            this.savebttn.Size = new System.Drawing.Size(91, 24);
            this.savebttn.TabIndex = 2;
            this.savebttn.Text = "Save";
            this.savebttn.UseVisualStyleBackColor = false;
            this.savebttn.Click += new System.EventHandler(this.savebttn_Click);
            // 
            // removegroupbttn
            // 
            this.removegroupbttn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.removegroupbttn.Dock = System.Windows.Forms.DockStyle.Top;
            this.removegroupbttn.Location = new System.Drawing.Point(0, 24);
            this.removegroupbttn.Name = "removegroupbttn";
            this.removegroupbttn.Size = new System.Drawing.Size(91, 24);
            this.removegroupbttn.TabIndex = 1;
            this.removegroupbttn.Text = "Remove Group";
            this.removegroupbttn.UseVisualStyleBackColor = false;
            this.removegroupbttn.Click += new System.EventHandler(this.removegroupbttn_Click);
            // 
            // newgroupbttn
            // 
            this.newgroupbttn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newgroupbttn.Dock = System.Windows.Forms.DockStyle.Top;
            this.newgroupbttn.Location = new System.Drawing.Point(0, 0);
            this.newgroupbttn.Name = "newgroupbttn";
            this.newgroupbttn.Size = new System.Drawing.Size(91, 24);
            this.newgroupbttn.TabIndex = 0;
            this.newgroupbttn.Text = "New Group";
            this.newgroupbttn.UseVisualStyleBackColor = false;
            this.newgroupbttn.Click += new System.EventHandler(this.newgroupbttn_Click);
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 35);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.AutoScroll = true;
            this.SplitContainer1.Panel1.Controls.Add(this.GroupNameListBox);
            this.SplitContainer1.Panel1.Controls.Add(this.GroupNameTextBox);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.AutoScroll = true;
            this.SplitContainer1.Panel2.Controls.Add(this.Panel1);
            this.SplitContainer1.Panel2.Controls.Add(this.closebttn);
            this.SplitContainer1.Size = new System.Drawing.Size(302, 216);
            this.SplitContainer1.SplitterDistance = 210;
            this.SplitContainer1.SplitterWidth = 1;
            this.SplitContainer1.TabIndex = 2;
            // 
            // GroupNameListBox
            // 
            this.GroupNameListBox.DataSource = this.groupsBindingSource;
            this.GroupNameListBox.DisplayMember = "Groups";
            this.GroupNameListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupNameListBox.FormattingEnabled = true;
            this.GroupNameListBox.Location = new System.Drawing.Point(0, 20);
            this.GroupNameListBox.Name = "GroupNameListBox";
            this.GroupNameListBox.Size = new System.Drawing.Size(210, 186);
            this.GroupNameListBox.TabIndex = 1;
            this.GroupNameListBox.TabStop = false;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.contactsStore;
            // 
            // contactsStore
            // 
            this.contactsStore.DataSetName = "ContactsStore";
            this.contactsStore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GroupNameTextBox
            // 
            this.GroupNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupsBindingSource, "Groups", true));
            this.GroupNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupNameTextBox.Location = new System.Drawing.Point(0, 0);
            this.GroupNameTextBox.Name = "GroupNameTextBox";
            this.GroupNameTextBox.Size = new System.Drawing.Size(210, 20);
            this.GroupNameTextBox.TabIndex = 0;
            this.GroupNameTextBox.TabStop = false;
            // 
            // closebttn
            // 
            this.closebttn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.closebttn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.closebttn.Location = new System.Drawing.Point(0, 192);
            this.closebttn.Name = "closebttn";
            this.closebttn.Size = new System.Drawing.Size(91, 24);
            this.closebttn.TabIndex = 4;
            this.closebttn.Text = "Close";
            this.closebttn.UseVisualStyleBackColor = false;
            this.closebttn.Click += new System.EventHandler(this.closebttn_Click);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 35);
            this.panel3.TabIndex = 7;
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Dazzle Design Group Manager (Beta)";
            // 
            // GroupManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(302, 251);
            this.ControlBox = false;
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GroupManager";
            this.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsStore)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button renamegroupbttn;
        internal System.Windows.Forms.Button savebttn;
        internal System.Windows.Forms.Button removegroupbttn;
        internal System.Windows.Forms.Button newgroupbttn;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.ListBox GroupNameListBox;
        internal System.Windows.Forms.TextBox GroupNameTextBox;
        internal System.Windows.Forms.Button closebttn;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Button cancelbttn;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private ContactsStore contactsStore;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
    }
}