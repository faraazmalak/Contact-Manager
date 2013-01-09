namespace DazzleDesign_Contact_Manager
{
    partial class Export
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
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.contactcombobox = new System.Windows.Forms.ComboBox();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsStore = new DazzleDesign_Contact_Manager.ContactsStore();
            this.Label10 = new System.Windows.Forms.Label();
            this.locationtxtbox = new System.Windows.Forms.TextBox();
            this.step2label = new System.Windows.Forms.Label();
            this.step3label = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupcombobox1 = new System.Windows.Forms.ComboBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.selectorbttn = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.step1label = new System.Windows.Forms.Label();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TableLayoutPanel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsStore)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(332, 292);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            this.TableLayoutPanel1.TabIndex = 7;
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(3, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(67, 23);
            this.OK_Button.TabIndex = 1;
            this.OK_Button.Text = "OK";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(76, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Exit";
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.contactcombobox);
            this.Panel2.Controls.Add(this.Label10);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Enabled = false;
            this.Panel2.Location = new System.Drawing.Point(0, 40);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(413, 55);
            this.Panel2.TabIndex = 1;
            // 
            // contactcombobox
            // 
            this.contactcombobox.DataSource = this.contactsBindingSource;
            this.contactcombobox.DisplayMember = "SaveAs";
            this.contactcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contactcombobox.FormattingEnabled = true;
            this.contactcombobox.Location = new System.Drawing.Point(126, 17);
            this.contactcombobox.Name = "contactcombobox";
            this.contactcombobox.Size = new System.Drawing.Size(211, 21);
            this.contactcombobox.TabIndex = 1;
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataMember = "FK_Groups_Contacts";
            this.contactsBindingSource.DataSource = this.groupsBindingSource;
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
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(39, 20);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(80, 13);
            this.Label10.TabIndex = 0;
            this.Label10.Text = "Select Contact:";
            // 
            // locationtxtbox
            // 
            this.locationtxtbox.BackColor = System.Drawing.Color.White;
            this.locationtxtbox.Location = new System.Drawing.Point(126, 14);
            this.locationtxtbox.Name = "locationtxtbox";
            this.locationtxtbox.Size = new System.Drawing.Size(181, 20);
            this.locationtxtbox.TabIndex = 1;
            // 
            // step2label
            // 
            this.step2label.AutoSize = true;
            this.step2label.Enabled = false;
            this.step2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step2label.Location = new System.Drawing.Point(3, 60);
            this.step2label.Name = "step2label";
            this.step2label.Size = new System.Drawing.Size(41, 13);
            this.step2label.TabIndex = 1;
            this.step2label.Text = "Step 2:";
            // 
            // step3label
            // 
            this.step3label.AutoSize = true;
            this.step3label.Enabled = false;
            this.step3label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step3label.Location = new System.Drawing.Point(3, 112);
            this.step3label.Name = "step3label";
            this.step3label.Size = new System.Drawing.Size(41, 13);
            this.step3label.TabIndex = 2;
            this.step3label.Text = "Step 3:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(36, 17);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(84, 13);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Select Location:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(7, 11);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(112, 13);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "Select Contact Group:";
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.Filter = "DzzleDesign Contact File(*.icontact)|*.icontact";
            this.OpenFileDialog1.Title = "DazzleDesign Contacts";
            // 
            // groupcombobox1
            // 
            this.groupcombobox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.groupsBindingSource, "Groups", true));
            this.groupcombobox1.DataSource = this.groupsBindingSource;
            this.groupcombobox1.DisplayMember = "Groups";
            this.groupcombobox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupcombobox1.FormattingEnabled = true;
            this.groupcombobox1.Location = new System.Drawing.Point(126, 8);
            this.groupcombobox1.Name = "groupcombobox1";
            this.groupcombobox1.Size = new System.Drawing.Size(211, 21);
            this.groupcombobox1.TabIndex = 1;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Label8);
            this.Panel1.Controls.Add(this.groupcombobox1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Enabled = false;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(413, 40);
            this.Panel1.TabIndex = 0;
            // 
            // selectorbttn
            // 
            this.selectorbttn.Location = new System.Drawing.Point(313, 12);
            this.selectorbttn.Name = "selectorbttn";
            this.selectorbttn.Size = new System.Drawing.Size(30, 23);
            this.selectorbttn.TabIndex = 2;
            this.selectorbttn.Text = "...";
            this.selectorbttn.UseVisualStyleBackColor = true;
            this.selectorbttn.Click += new System.EventHandler(this.selectorbttn_Click);
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.button1);
            this.Panel3.Controls.Add(this.selectorbttn);
            this.Panel3.Controls.Add(this.locationtxtbox);
            this.Panel3.Controls.Add(this.Label7);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Enabled = false;
            this.Panel3.Location = new System.Drawing.Point(0, 95);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(413, 88);
            this.Panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // step1label
            // 
            this.step1label.AutoSize = true;
            this.step1label.Enabled = false;
            this.step1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step1label.Location = new System.Drawing.Point(3, 11);
            this.step1label.Name = "step1label";
            this.step1label.Size = new System.Drawing.Size(41, 13);
            this.step1label.TabIndex = 0;
            this.step1label.Text = "Step 1:";
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Location = new System.Drawing.Point(12, 65);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(94, 17);
            this.RadioButton3.TabIndex = 2;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Text = "Import Contact";
            this.RadioButton3.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.RadioButton3);
            this.GroupBox1.Controls.Add(this.RadioButton2);
            this.GroupBox1.Controls.Add(this.RadioButton1);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(490, 102);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "I want to:";
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(12, 42);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(95, 17);
            this.RadioButton2.TabIndex = 1;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "Export Contact";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(12, 19);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(127, 17);
            this.RadioButton1.TabIndex = 0;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Export Contact Group";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // SplitContainer2
            // 
            this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplitContainer2.IsSplitterFixed = true;
            this.SplitContainer2.Location = new System.Drawing.Point(0, 102);
            this.SplitContainer2.Name = "SplitContainer2";
            // 
            // SplitContainer2.Panel1
            // 
            this.SplitContainer2.Panel1.Controls.Add(this.step2label);
            this.SplitContainer2.Panel1.Controls.Add(this.step3label);
            this.SplitContainer2.Panel1.Controls.Add(this.step1label);
            // 
            // SplitContainer2.Panel2
            // 
            this.SplitContainer2.Panel2.Controls.Add(this.Panel3);
            this.SplitContainer2.Panel2.Controls.Add(this.Panel2);
            this.SplitContainer2.Panel2.Controls.Add(this.Panel1);
            this.SplitContainer2.Size = new System.Drawing.Size(490, 183);
            this.SplitContainer2.SplitterDistance = 73;
            this.SplitContainer2.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(490, 327);
            this.ControlBox = false;
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.SplitContainer2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Export";
            this.Text = "Export";
            this.Load += new System.EventHandler(this.Export_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsStore)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel1.PerformLayout();
            this.SplitContainer2.Panel2.ResumeLayout(false);
            this.SplitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.ComboBox contactcombobox;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox locationtxtbox;
        internal System.Windows.Forms.Label step2label;
        internal System.Windows.Forms.Label step3label;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog1;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.ComboBox groupcombobox1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button selectorbttn;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Label step1label;
        internal System.Windows.Forms.RadioButton RadioButton3;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton RadioButton2;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.SplitContainer SplitContainer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private ContactsStore contactsStore;
        private System.Windows.Forms.Button button1;
    }
}