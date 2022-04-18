namespace ContactsAppUI
{
	partial class MainForm
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Search = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.NamePerson = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.VkId = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.VkTextBox = new System.Windows.Forms.TextBox();
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BirthdayTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.MenuStrip1.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            this.BirthdayTableLayoutPanel.SuspendLayout();
            this.TableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pictureBox1.Image = global::ContactsAppUI.Properties.Resources._1485477027_attention_78563;
            pictureBox1.Location = new System.Drawing.Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(94, 95);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Search.Location = new System.Drawing.Point(37, 3);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(216, 20);
            this.Search.TabIndex = 1;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // Find
            // 
            this.Find.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Find.AutoSize = true;
            this.Find.Location = new System.Drawing.Point(4, 6);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(27, 13);
            this.Find.TabIndex = 2;
            this.Find.Text = "Find";
            this.Find.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Surname
            // 
            this.Surname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(5, 9);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(52, 13);
            this.Surname.TabIndex = 6;
            this.Surname.Text = "Surname:";
            this.Surname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NamePerson
            // 
            this.NamePerson.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NamePerson.AutoSize = true;
            this.NamePerson.Location = new System.Drawing.Point(19, 41);
            this.NamePerson.Name = "NamePerson";
            this.NamePerson.Size = new System.Drawing.Size(38, 13);
            this.NamePerson.TabIndex = 7;
            this.NamePerson.Text = "Name:";
            this.NamePerson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Birthday
            // 
            this.Birthday.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Birthday.AutoSize = true;
            this.Birthday.Location = new System.Drawing.Point(9, 73);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(48, 13);
            this.Birthday.TabIndex = 8;
            this.Birthday.Text = "Birthday:";
            this.Birthday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Phone
            // 
            this.Phone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(16, 105);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(41, 13);
            this.Phone.TabIndex = 9;
            this.Phone.Text = "Phone:";
            this.Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Email
            // 
            this.Email.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(19, 137);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(38, 13);
            this.Email.TabIndex = 10;
            this.Email.Text = "E-mail:";
            this.Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VkId
            // 
            this.VkId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VkId.AutoSize = true;
            this.VkId.Location = new System.Drawing.Point(12, 170);
            this.VkId.Name = "VkId";
            this.VkId.Size = new System.Drawing.Size(45, 13);
            this.VkId.TabIndex = 11;
            this.VkId.Text = "vk.com:";
            this.VkId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SurnameTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SurnameTextBox.Location = new System.Drawing.Point(63, 6);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.ReadOnly = true;
            this.SurnameTextBox.ShortcutsEnabled = false;
            this.SurnameTextBox.Size = new System.Drawing.Size(260, 20);
            this.SurnameTextBox.TabIndex = 6;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Location = new System.Drawing.Point(63, 38);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(260, 20);
            this.NameTextBox.TabIndex = 7;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextBox.Location = new System.Drawing.Point(63, 134);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.ReadOnly = true;
            this.EmailTextBox.Size = new System.Drawing.Size(260, 20);
            this.EmailTextBox.TabIndex = 10;
            // 
            // VkTextBox
            // 
            this.VkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VkTextBox.Location = new System.Drawing.Point(63, 167);
            this.VkTextBox.Name = "VkTextBox";
            this.VkTextBox.ReadOnly = true;
            this.VkTextBox.Size = new System.Drawing.Size(260, 20);
            this.VkTextBox.TabIndex = 11;
            // 
            // BirthdayDateTimePicker
            // 
            this.BirthdayDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BirthdayDateTimePicker.CustomFormat = "";
            this.BirthdayDateTimePicker.Enabled = false;
            this.BirthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(63, 70);
            this.BirthdayDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(85, 20);
            this.BirthdayDateTimePicker.TabIndex = 8;
            this.BirthdayDateTimePicker.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.IntegralHeight = false;
            this.ContactsListBox.Location = new System.Drawing.Point(6, 71);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.ScrollAlwaysVisible = true;
            this.ContactsListBox.Size = new System.Drawing.Size(247, 303);
            this.ContactsListBox.TabIndex = 2;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(63, 102);
            this.PhoneMaskedTextBox.Mask = "7 (999) 000-0000";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.ReadOnly = true;
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(260, 20);
            this.PhoneMaskedTextBox.TabIndex = 9;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(597, 24);
            this.MenuStrip1.TabIndex = 21;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.ExitToolStripMenuItem.Text = "Exit ";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditContactToolStripMenuItem,
            this.RemoveToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.AddToolStripMenuItem.Text = "Add";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.Add_Click);
            // 
            // EditContactToolStripMenuItem
            // 
            this.EditContactToolStripMenuItem.Name = "EditContactToolStripMenuItem";
            this.EditContactToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.EditContactToolStripMenuItem.Text = "Edit Contact";
            this.EditContactToolStripMenuItem.Click += new System.EventHandler(this.Edit_Click);
            // 
            // RemoveToolStripMenuItem
            // 
            this.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem";
            this.RemoveToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.RemoveToolStripMenuItem.Text = "Remove";
            this.RemoveToolStripMenuItem.Click += new System.EventHandler(this.Remove_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.About_Click);
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.AutoSize = true;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Controls.Add(this.Surname, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.NamePerson, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.Birthday, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.Phone, 0, 3);
            this.TableLayoutPanel1.Controls.Add(this.PhoneMaskedTextBox, 1, 3);
            this.TableLayoutPanel1.Controls.Add(this.Email, 0, 4);
            this.TableLayoutPanel1.Controls.Add(this.EmailTextBox, 1, 4);
            this.TableLayoutPanel1.Controls.Add(this.VkId, 0, 5);
            this.TableLayoutPanel1.Controls.Add(this.BirthdayDateTimePicker, 1, 2);
            this.TableLayoutPanel1.Controls.Add(this.NameTextBox, 1, 1);
            this.TableLayoutPanel1.Controls.Add(this.VkTextBox, 1, 5);
            this.TableLayoutPanel1.Controls.Add(this.SurnameTextBox, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(259, 39);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 6;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(326, 194);
            this.TableLayoutPanel1.TabIndex = 25;
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.ColumnCount = 2;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.43874F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.56126F));
            this.TableLayoutPanel2.Controls.Add(this.Search, 1, 0);
            this.TableLayoutPanel2.Controls.Add(this.Find, 0, 0);
            this.TableLayoutPanel2.Location = new System.Drawing.Point(0, 39);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 1;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.TableLayoutPanel2.Size = new System.Drawing.Size(258, 26);
            this.TableLayoutPanel2.TabIndex = 26;
            // 
            // BirthdayTableLayoutPanel
            // 
            this.BirthdayTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayTableLayoutPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.BirthdayTableLayoutPanel.ColumnCount = 2;
            this.BirthdayTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.BirthdayTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BirthdayTableLayoutPanel.Controls.Add(this.BirthdayLabel, 1, 0);
            this.BirthdayTableLayoutPanel.Controls.Add(pictureBox1, 0, 0);
            this.BirthdayTableLayoutPanel.Location = new System.Drawing.Point(259, 325);
            this.BirthdayTableLayoutPanel.Name = "BirthdayTableLayoutPanel";
            this.BirthdayTableLayoutPanel.RowCount = 1;
            this.BirthdayTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BirthdayTableLayoutPanel.Size = new System.Drawing.Size(326, 101);
            this.BirthdayTableLayoutPanel.TabIndex = 27;
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Location = new System.Drawing.Point(103, 0);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(220, 101);
            this.BirthdayLabel.TabIndex = 1;
            this.BirthdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TableLayoutPanel4
            // 
            this.TableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TableLayoutPanel4.ColumnCount = 3;
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel4.Controls.Add(this.RemoveButton, 2, 0);
            this.TableLayoutPanel4.Controls.Add(this.AddButton, 0, 0);
            this.TableLayoutPanel4.Controls.Add(this.EditButton, 1, 0);
            this.TableLayoutPanel4.Location = new System.Drawing.Point(7, 392);
            this.TableLayoutPanel4.Name = "TableLayoutPanel4";
            this.TableLayoutPanel4.RowCount = 1;
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel4.Size = new System.Drawing.Size(97, 34);
            this.TableLayoutPanel4.TabIndex = 31;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.BackgroundImage = global::ContactsAppUI.Properties.Resources.Delete;
            this.RemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RemoveButton.Location = new System.Drawing.Point(67, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(27, 28);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.Remove_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackgroundImage = global::ContactsAppUI.Properties.Resources.Add;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(26, 28);
            this.AddButton.TabIndex = 3;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.Add_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.BackgroundImage = global::ContactsAppUI.Properties.Resources.Edit;
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.ForeColor = System.Drawing.SystemColors.Control;
            this.EditButton.Location = new System.Drawing.Point(35, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(26, 25);
            this.EditButton.TabIndex = 4;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.Edit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 438);
            this.Controls.Add(this.TableLayoutPanel4);
            this.Controls.Add(this.BirthdayTableLayoutPanel);
            this.Controls.Add(this.TableLayoutPanel2);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.ContactsListBox);
            this.Controls.Add(this.MenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuStrip1;
            this.MinimumSize = new System.Drawing.Size(613, 477);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "ContactApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactsApp_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.TableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanel2.PerformLayout();
            this.BirthdayTableLayoutPanel.ResumeLayout(false);
            this.BirthdayTableLayoutPanel.PerformLayout();
            this.TableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox Search;
		private System.Windows.Forms.Label Find;
		private System.Windows.Forms.Label Surname;
		private System.Windows.Forms.Label NamePerson;
		private System.Windows.Forms.Label Birthday;
		private System.Windows.Forms.Label Phone;
		private System.Windows.Forms.Label Email;
		private System.Windows.Forms.Label VkId;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.TextBox EmailTextBox;
		private System.Windows.Forms.TextBox VkTextBox;
		private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
		private System.Windows.Forms.ListBox ContactsListBox;
		private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
		private System.Windows.Forms.MenuStrip MenuStrip1;
		private System.Windows.Forms.TextBox SurnameTextBox;
		private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EditContactToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RemoveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel TableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel BirthdayTableLayoutPanel;
		private System.Windows.Forms.Label BirthdayLabel;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button RemoveButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.TableLayoutPanel TableLayoutPanel4;
	}
}

