namespace DazzleDesign_Contact_Manager
{
    partial class ContactManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.newcontactbttn = new System.Windows.Forms.Button();
            this.removecontactbttn = new System.Windows.Forms.Button();
            this.opencontactbttn = new System.Windows.Forms.Button();
            this.groupsbttn = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.ContactsDataGridView = new System.Windows.Forms.DataGridView();
            this.saveAsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessCellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homePhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeCellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedUnderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsStore = new DazzleDesign_Contact_Manager.ContactsStore();
            this.iDLabel1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.minimizebttn = new System.Windows.Forms.Button();
            this.maximizebttn = new System.Windows.Forms.Button();
            this.exitbttn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsStore)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 45);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ContactsDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.iDLabel1);
            this.splitContainer1.Size = new System.Drawing.Size(964, 609);
            this.splitContainer1.SplitterDistance = 123;
            this.splitContainer1.TabIndex = 0;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Controls.Add(this.newcontactbttn, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.removecontactbttn, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.opencontactbttn, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.groupsbttn, 0, 3);
            this.TableLayoutPanel1.Controls.Add(this.Button1, 0, 4);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 10;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(123, 609);
            this.TableLayoutPanel1.TabIndex = 4;
            // 
            // newcontactbttn
            // 
            this.newcontactbttn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.newcontactbttn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newcontactbttn.Location = new System.Drawing.Point(3, 3);
            this.newcontactbttn.Name = "newcontactbttn";
            this.newcontactbttn.Size = new System.Drawing.Size(117, 30);
            this.newcontactbttn.TabIndex = 0;
            this.newcontactbttn.Text = "New Contact";
            this.newcontactbttn.UseVisualStyleBackColor = false;
            this.newcontactbttn.Click += new System.EventHandler(this.newcontactbttn_Click);
            // 
            // removecontactbttn
            // 
            this.removecontactbttn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.removecontactbttn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removecontactbttn.Location = new System.Drawing.Point(3, 39);
            this.removecontactbttn.Name = "removecontactbttn";
            this.removecontactbttn.Size = new System.Drawing.Size(117, 30);
            this.removecontactbttn.TabIndex = 1;
            this.removecontactbttn.Text = "Remove Contact";
            this.removecontactbttn.UseVisualStyleBackColor = false;
            this.removecontactbttn.Click += new System.EventHandler(this.removecontactbttn_Click);
            // 
            // opencontactbttn
            // 
            this.opencontactbttn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.opencontactbttn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opencontactbttn.Location = new System.Drawing.Point(3, 75);
            this.opencontactbttn.Name = "opencontactbttn";
            this.opencontactbttn.Size = new System.Drawing.Size(117, 30);
            this.opencontactbttn.TabIndex = 2;
            this.opencontactbttn.Text = "Open Contact";
            this.opencontactbttn.UseVisualStyleBackColor = false;
            this.opencontactbttn.Click += new System.EventHandler(this.opencontactbttn_Click);
            // 
            // groupsbttn
            // 
            this.groupsbttn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupsbttn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupsbttn.Location = new System.Drawing.Point(3, 111);
            this.groupsbttn.Name = "groupsbttn";
            this.groupsbttn.Size = new System.Drawing.Size(117, 30);
            this.groupsbttn.TabIndex = 3;
            this.groupsbttn.Text = "Manage Groups";
            this.groupsbttn.UseVisualStyleBackColor = false;
            this.groupsbttn.Click += new System.EventHandler(this.groupsbttn_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button1.Location = new System.Drawing.Point(3, 147);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(117, 30);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "Export/Import";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Visible = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ContactsDataGridView
            // 
            this.ContactsDataGridView.AllowUserToAddRows = false;
            this.ContactsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.ContactsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ContactsDataGridView.AutoGenerateColumns = false;
            this.ContactsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ContactsDataGridView.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ContactsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ContactsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saveAsDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.businessPhoneDataGridViewTextBoxColumn,
            this.businessCellDataGridViewTextBoxColumn,
            this.homePhoneDataGridViewTextBoxColumn,
            this.homeCellDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.CreatedUnderColumn});
            this.ContactsDataGridView.DataSource = this.contactsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ContactsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ContactsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ContactsDataGridView.MultiSelect = false;
            this.ContactsDataGridView.Name = "ContactsDataGridView";
            this.ContactsDataGridView.ReadOnly = true;
            this.ContactsDataGridView.RowHeadersVisible = false;
            this.ContactsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ContactsDataGridView.Size = new System.Drawing.Size(837, 609);
            this.ContactsDataGridView.TabIndex = 3;
            this.ContactsDataGridView.TabStop = false;
            // 
            // saveAsDataGridViewTextBoxColumn
            // 
            this.saveAsDataGridViewTextBoxColumn.DataPropertyName = "SaveAs";
            this.saveAsDataGridViewTextBoxColumn.HeaderText = "SaveAs";
            this.saveAsDataGridViewTextBoxColumn.Name = "saveAsDataGridViewTextBoxColumn";
            this.saveAsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // businessPhoneDataGridViewTextBoxColumn
            // 
            this.businessPhoneDataGridViewTextBoxColumn.DataPropertyName = "BusinessPhone";
            this.businessPhoneDataGridViewTextBoxColumn.HeaderText = "BusinessPhone";
            this.businessPhoneDataGridViewTextBoxColumn.Name = "businessPhoneDataGridViewTextBoxColumn";
            this.businessPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // businessCellDataGridViewTextBoxColumn
            // 
            this.businessCellDataGridViewTextBoxColumn.DataPropertyName = "BusinessCell";
            this.businessCellDataGridViewTextBoxColumn.HeaderText = "BusinessCell";
            this.businessCellDataGridViewTextBoxColumn.Name = "businessCellDataGridViewTextBoxColumn";
            this.businessCellDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homePhoneDataGridViewTextBoxColumn
            // 
            this.homePhoneDataGridViewTextBoxColumn.DataPropertyName = "HomePhone";
            this.homePhoneDataGridViewTextBoxColumn.HeaderText = "HomePhone";
            this.homePhoneDataGridViewTextBoxColumn.Name = "homePhoneDataGridViewTextBoxColumn";
            this.homePhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homeCellDataGridViewTextBoxColumn
            // 
            this.homeCellDataGridViewTextBoxColumn.DataPropertyName = "HomeCell";
            this.homeCellDataGridViewTextBoxColumn.HeaderText = "HomeCell";
            this.homeCellDataGridViewTextBoxColumn.Name = "homeCellDataGridViewTextBoxColumn";
            this.homeCellDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CreatedUnderColumn
            // 
            this.CreatedUnderColumn.DataPropertyName = "CreatedUnder";
            this.CreatedUnderColumn.HeaderText = "CreatedUnder";
            this.CreatedUnderColumn.Name = "CreatedUnderColumn";
            this.CreatedUnderColumn.ReadOnly = true;
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataMember = "Contacts";
            this.contactsBindingSource.DataSource = this.contactsStore;
            // 
            // contactsStore
            // 
            this.contactsStore.DataSetName = "ContactsStore";
            this.contactsStore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDLabel1
            // 
            this.iDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "ID", true));
            this.iDLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iDLabel1.Location = new System.Drawing.Point(0, 0);
            this.iDLabel1.Name = "iDLabel1";
            this.iDLabel1.Size = new System.Drawing.Size(837, 609);
            this.iDLabel1.TabIndex = 7;
            this.iDLabel1.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.minimizebttn);
            this.panel3.Controls.Add(this.maximizebttn);
            this.panel3.Controls.Add(this.exitbttn);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(964, 35);
            this.panel3.TabIndex = 7;
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // minimizebttn
            // 
            this.minimizebttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.minimizebttn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizebttn.Location = new System.Drawing.Point(863, 15);
            this.minimizebttn.Name = "minimizebttn";
            this.minimizebttn.Size = new System.Drawing.Size(35, 20);
            this.minimizebttn.TabIndex = 3;
            this.minimizebttn.Text = "---";
            this.minimizebttn.UseVisualStyleBackColor = false;
            this.minimizebttn.Click += new System.EventHandler(this.minimizebttn_Click);
            // 
            // maximizebttn
            // 
            this.maximizebttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.maximizebttn.BackgroundImage = global::DazzleDesign_Contact_Manager.Properties.Resources.maxicon;
            this.maximizebttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.maximizebttn.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizebttn.Location = new System.Drawing.Point(898, 15);
            this.maximizebttn.Name = "maximizebttn";
            this.maximizebttn.Size = new System.Drawing.Size(24, 20);
            this.maximizebttn.TabIndex = 2;
            this.maximizebttn.UseVisualStyleBackColor = false;
            this.maximizebttn.Click += new System.EventHandler(this.maximizebttn_Click);
            this.maximizebttn.SizeChanged += new System.EventHandler(this.maximizebttn_SizeChanged);
            // 
            // exitbttn
            // 
            this.exitbttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exitbttn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitbttn.Location = new System.Drawing.Point(922, 15);
            this.exitbttn.Name = "exitbttn";
            this.exitbttn.Size = new System.Drawing.Size(42, 20);
            this.exitbttn.TabIndex = 1;
            this.exitbttn.Text = "X";
            this.exitbttn.UseVisualStyleBackColor = false;
            this.exitbttn.Click += new System.EventHandler(this.exitbttn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Dazzle Design Contacts (Beta)";
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.contactsStore;
            // 
            // ContactManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(984, 664);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContactManager";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ContactManager_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseLeave += new System.EventHandler(this.MainForm_MouseLeave);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContactsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsStore)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button newcontactbttn;
        internal System.Windows.Forms.Button removecontactbttn;
        internal System.Windows.Forms.Button opencontactbttn;
        internal System.Windows.Forms.Button groupsbttn;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.DataGridView ContactsDataGridView;
        private ContactsStore contactsStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn saveAsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessCellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homePhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeCellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedUnderColumn;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private System.Windows.Forms.Label iDLabel1;
        public System.Windows.Forms.BindingSource contactsBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button minimizebttn;
        private System.Windows.Forms.Button maximizebttn;
        private System.Windows.Forms.Button exitbttn;
        private System.Windows.Forms.Label label7;
    }
}

