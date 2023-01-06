namespace Wordly
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.dgLetters = new System.Windows.Forms.DataGridView();
            this.сc0 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cc1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cc2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cc3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cc4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cc5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cc6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cc7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cc8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cc9 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cc10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cc11 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbMatchedLetters = new System.Windows.Forms.GroupBox();
            this.l9 = new System.Windows.Forms.Label();
            this.l8 = new System.Windows.Forms.Label();
            this.l7 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.gbFoundLetters = new System.Windows.Forms.GroupBox();
            this.dgFoundLetters = new System.Windows.Forms.DataGridView();
            this.cLetter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.с1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.с2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.с3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.с4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.с5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.c7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.c8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.c9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbLetters = new System.Windows.Forms.ListBox();
            this.gbVariants = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbVariants = new System.Windows.Forms.ListBox();
            this.cmsSelectLetter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsStatusBar = new System.Windows.Forms.StatusStrip();
            this.sbLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.chkDifferent = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgLetters)).BeginInit();
            this.gbMatchedLetters.SuspendLayout();
            this.gbFoundLetters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFoundLetters)).BeginInit();
            this.gbVariants.SuspendLayout();
            this.tsStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgLetters
            // 
            this.dgLetters.AllowUserToAddRows = false;
            this.dgLetters.AllowUserToDeleteRows = false;
            this.dgLetters.AllowUserToResizeColumns = false;
            this.dgLetters.AllowUserToResizeRows = false;
            this.dgLetters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgLetters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLetters.ColumnHeadersVisible = false;
            this.dgLetters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.сc0,
            this.cc1,
            this.cc2,
            this.cc3,
            this.cc4,
            this.cc5,
            this.cc6,
            this.cc7,
            this.cc8,
            this.cc9,
            this.cc10,
            this.cc11});
            this.dgLetters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgLetters.Location = new System.Drawing.Point(0, 338);
            this.dgLetters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgLetters.MultiSelect = false;
            this.dgLetters.Name = "dgLetters";
            this.dgLetters.RowHeadersVisible = false;
            this.dgLetters.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgLetters.Size = new System.Drawing.Size(939, 107);
            this.dgLetters.TabIndex = 0;
            this.dgLetters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLetters_CellContentClick);
            this.dgLetters.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgLetters_CellMouseClick);
            // 
            // сc0
            // 
            this.сc0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.сc0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.сc0.HeaderText = "c0";
            this.сc0.Name = "сc0";
            this.сc0.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.сc0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.сc0.Text = "c0";
            // 
            // cc1
            // 
            this.cc1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cc1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cc1.HeaderText = "c1";
            this.cc1.Name = "cc1";
            this.cc1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cc2
            // 
            this.cc2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cc2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cc2.HeaderText = "c2";
            this.cc2.Name = "cc2";
            this.cc2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cc3
            // 
            this.cc3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cc3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cc3.HeaderText = "c3";
            this.cc3.Name = "cc3";
            this.cc3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cc4
            // 
            this.cc4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cc4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cc4.HeaderText = "c4";
            this.cc4.Name = "cc4";
            this.cc4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cc5
            // 
            this.cc5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cc5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cc5.HeaderText = "c5";
            this.cc5.Name = "cc5";
            this.cc5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cc6
            // 
            this.cc6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cc6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cc6.HeaderText = "c6";
            this.cc6.Name = "cc6";
            this.cc6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cc7
            // 
            this.cc7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cc7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cc7.HeaderText = "c7";
            this.cc7.Name = "cc7";
            this.cc7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cc8
            // 
            this.cc8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cc8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cc8.HeaderText = "c8";
            this.cc8.Name = "cc8";
            this.cc8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cc9
            // 
            this.cc9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cc9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cc9.HeaderText = "c9";
            this.cc9.Name = "cc9";
            this.cc9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cc10
            // 
            this.cc10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cc10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cc10.HeaderText = "c10";
            this.cc10.Name = "cc10";
            this.cc10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cc11
            // 
            this.cc11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cc11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cc11.HeaderText = "c11";
            this.cc11.Name = "cc11";
            this.cc11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gbMatchedLetters
            // 
            this.gbMatchedLetters.Controls.Add(this.l9);
            this.gbMatchedLetters.Controls.Add(this.l8);
            this.gbMatchedLetters.Controls.Add(this.l7);
            this.gbMatchedLetters.Controls.Add(this.l6);
            this.gbMatchedLetters.Controls.Add(this.l5);
            this.gbMatchedLetters.Controls.Add(this.l4);
            this.gbMatchedLetters.Controls.Add(this.l3);
            this.gbMatchedLetters.Controls.Add(this.l2);
            this.gbMatchedLetters.Controls.Add(this.l1);
            this.gbMatchedLetters.Controls.Add(this.btn9);
            this.gbMatchedLetters.Controls.Add(this.btn8);
            this.gbMatchedLetters.Controls.Add(this.btn7);
            this.gbMatchedLetters.Controls.Add(this.btn6);
            this.gbMatchedLetters.Controls.Add(this.btn5);
            this.gbMatchedLetters.Controls.Add(this.btn4);
            this.gbMatchedLetters.Controls.Add(this.btn3);
            this.gbMatchedLetters.Controls.Add(this.btn2);
            this.gbMatchedLetters.Controls.Add(this.btn1);
            this.gbMatchedLetters.Location = new System.Drawing.Point(18, 18);
            this.gbMatchedLetters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMatchedLetters.Name = "gbMatchedLetters";
            this.gbMatchedLetters.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMatchedLetters.Size = new System.Drawing.Size(550, 97);
            this.gbMatchedLetters.TabIndex = 1;
            this.gbMatchedLetters.TabStop = false;
            this.gbMatchedLetters.Text = " Буквы на своем месте: ";
            // 
            // l9
            // 
            this.l9.AutoSize = true;
            this.l9.Location = new System.Drawing.Point(500, 21);
            this.l9.Name = "l9";
            this.l9.Size = new System.Drawing.Size(18, 20);
            this.l9.TabIndex = 17;
            this.l9.Text = "9";
            // 
            // l8
            // 
            this.l8.AutoSize = true;
            this.l8.Location = new System.Drawing.Point(441, 21);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(18, 20);
            this.l8.TabIndex = 16;
            this.l8.Text = "8";
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.Location = new System.Drawing.Point(382, 21);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(18, 20);
            this.l7.TabIndex = 15;
            this.l7.Text = "7";
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Location = new System.Drawing.Point(323, 21);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(18, 20);
            this.l6.TabIndex = 14;
            this.l6.Text = "6";
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Location = new System.Drawing.Point(264, 21);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(18, 20);
            this.l5.TabIndex = 13;
            this.l5.Text = "5";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(205, 21);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(18, 20);
            this.l4.TabIndex = 12;
            this.l4.Text = "4";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(146, 21);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(18, 20);
            this.l3.TabIndex = 11;
            this.l3.Text = "3";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(87, 21);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(18, 20);
            this.l2.TabIndex = 10;
            this.l2.Text = "2";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(28, 21);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(18, 20);
            this.l1.TabIndex = 9;
            this.l1.Text = "1";
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.Control;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Location = new System.Drawing.Point(489, 45);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 40);
            this.btn9.TabIndex = 8;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.MatchButtonClick);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.Control;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Location = new System.Drawing.Point(430, 45);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 40);
            this.btn8.TabIndex = 7;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.MatchButtonClick);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.Control;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Location = new System.Drawing.Point(371, 45);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 40);
            this.btn7.TabIndex = 6;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.MatchButtonClick);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.Control;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(312, 45);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 40);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.MatchButtonClick);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.Control;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(253, 45);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 40);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.MatchButtonClick);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.Control;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(194, 45);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 40);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Control;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(135, 45);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 40);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Control;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(76, 45);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 40);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Control;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(17, 45);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 40);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // gbFoundLetters
            // 
            this.gbFoundLetters.Controls.Add(this.dgFoundLetters);
            this.gbFoundLetters.Controls.Add(this.btnRemove);
            this.gbFoundLetters.Controls.Add(this.btnAdd);
            this.gbFoundLetters.Controls.Add(this.lbLetters);
            this.gbFoundLetters.Location = new System.Drawing.Point(18, 125);
            this.gbFoundLetters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFoundLetters.Name = "gbFoundLetters";
            this.gbFoundLetters.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFoundLetters.Size = new System.Drawing.Size(550, 196);
            this.gbFoundLetters.TabIndex = 2;
            this.gbFoundLetters.TabStop = false;
            this.gbFoundLetters.Text = " Буквы есть в слове, но не на своем месте: ";
            // 
            // dgFoundLetters
            // 
            this.dgFoundLetters.AllowUserToAddRows = false;
            this.dgFoundLetters.AllowUserToDeleteRows = false;
            this.dgFoundLetters.AllowUserToResizeColumns = false;
            this.dgFoundLetters.AllowUserToResizeRows = false;
            this.dgFoundLetters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFoundLetters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLetter,
            this.с1,
            this.с2,
            this.с3,
            this.с4,
            this.с5,
            this.c6,
            this.c7,
            this.c8,
            this.c9});
            this.dgFoundLetters.Location = new System.Drawing.Point(17, 40);
            this.dgFoundLetters.MultiSelect = false;
            this.dgFoundLetters.Name = "dgFoundLetters";
            this.dgFoundLetters.RowHeadersVisible = false;
            this.dgFoundLetters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgFoundLetters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFoundLetters.Size = new System.Drawing.Size(310, 144);
            this.dgFoundLetters.TabIndex = 4;
            // 
            // cLetter
            // 
            this.cLetter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cLetter.HeaderText = "Буква";
            this.cLetter.Name = "cLetter";
            // 
            // с1
            // 
            this.с1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.с1.HeaderText = "1";
            this.с1.Name = "с1";
            this.с1.Width = 24;
            // 
            // с2
            // 
            this.с2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.с2.HeaderText = "2";
            this.с2.Name = "с2";
            this.с2.Width = 24;
            // 
            // с3
            // 
            this.с3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.с3.HeaderText = "3";
            this.с3.Name = "с3";
            this.с3.Width = 24;
            // 
            // с4
            // 
            this.с4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.с4.HeaderText = "4";
            this.с4.Name = "с4";
            this.с4.Width = 24;
            // 
            // с5
            // 
            this.с5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.с5.HeaderText = "5";
            this.с5.Name = "с5";
            this.с5.Width = 24;
            // 
            // c6
            // 
            this.c6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.c6.HeaderText = "6";
            this.c6.Name = "c6";
            this.c6.Width = 24;
            // 
            // c7
            // 
            this.c7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.c7.HeaderText = "7";
            this.c7.Name = "c7";
            this.c7.Width = 24;
            // 
            // c8
            // 
            this.c8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.c8.HeaderText = "8";
            this.c8.Name = "c8";
            this.c8.Width = 24;
            // 
            // c9
            // 
            this.c9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.c9.HeaderText = "9";
            this.c9.Name = "c9";
            this.c9.Width = 24;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(349, 141);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(45, 30);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = ">>";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(349, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "<<";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbLetters
            // 
            this.lbLetters.FormattingEnabled = true;
            this.lbLetters.ItemHeight = 20;
            this.lbLetters.Location = new System.Drawing.Point(414, 40);
            this.lbLetters.Name = "lbLetters";
            this.lbLetters.Size = new System.Drawing.Size(120, 144);
            this.lbLetters.Sorted = true;
            this.lbLetters.TabIndex = 1;
            // 
            // gbVariants
            // 
            this.gbVariants.Controls.Add(this.chkDifferent);
            this.gbVariants.Controls.Add(this.btnReset);
            this.gbVariants.Controls.Add(this.btnSearch);
            this.gbVariants.Controls.Add(this.lbVariants);
            this.gbVariants.Location = new System.Drawing.Point(587, 18);
            this.gbVariants.Name = "gbVariants";
            this.gbVariants.Size = new System.Drawing.Size(340, 303);
            this.gbVariants.TabIndex = 3;
            this.gbVariants.TabStop = false;
            this.gbVariants.Text = " Варианты (0): ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(201, 253);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 38);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сбросить";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(18, 253);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(165, 38);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Подобрать слова";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbVariants
            // 
            this.lbVariants.FormattingEnabled = true;
            this.lbVariants.ItemHeight = 20;
            this.lbVariants.Location = new System.Drawing.Point(18, 27);
            this.lbVariants.Name = "lbVariants";
            this.lbVariants.Size = new System.Drawing.Size(306, 184);
            this.lbVariants.TabIndex = 0;
            // 
            // cmsSelectLetter
            // 
            this.cmsSelectLetter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmsSelectLetter.Name = "cmsSelectLetter";
            this.cmsSelectLetter.Size = new System.Drawing.Size(61, 4);
            // 
            // tsStatusBar
            // 
            this.tsStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbLabel});
            this.tsStatusBar.Location = new System.Drawing.Point(0, 445);
            this.tsStatusBar.Name = "tsStatusBar";
            this.tsStatusBar.Size = new System.Drawing.Size(939, 22);
            this.tsStatusBar.SizingGrip = false;
            this.tsStatusBar.TabIndex = 4;
            // 
            // sbLabel
            // 
            this.sbLabel.Name = "sbLabel";
            this.sbLabel.Size = new System.Drawing.Size(118, 17);
            this.sbLabel.Text = "toolStripStatusLabel1";
            // 
            // chkDifferent
            // 
            this.chkDifferent.AutoSize = true;
            this.chkDifferent.Location = new System.Drawing.Point(18, 221);
            this.chkDifferent.Name = "chkDifferent";
            this.chkDifferent.Size = new System.Drawing.Size(163, 24);
            this.chkDifferent.TabIndex = 3;
            this.chkDifferent.Text = "Все буквы разные";
            this.chkDifferent.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 467);
            this.Controls.Add(this.dgLetters);
            this.Controls.Add(this.tsStatusBar);
            this.Controls.Add(this.gbVariants);
            this.Controls.Add(this.gbFoundLetters);
            this.Controls.Add(this.gbMatchedLetters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wordly";
            ((System.ComponentModel.ISupportInitialize)(this.dgLetters)).EndInit();
            this.gbMatchedLetters.ResumeLayout(false);
            this.gbMatchedLetters.PerformLayout();
            this.gbFoundLetters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFoundLetters)).EndInit();
            this.gbVariants.ResumeLayout(false);
            this.gbVariants.PerformLayout();
            this.tsStatusBar.ResumeLayout(false);
            this.tsStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgLetters;
        private System.Windows.Forms.GroupBox gbMatchedLetters;
        private System.Windows.Forms.GroupBox gbFoundLetters;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.GroupBox gbVariants;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbVariants;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbLetters;
        private System.Windows.Forms.ContextMenuStrip cmsSelectLetter;
        private System.Windows.Forms.DataGridView dgFoundLetters;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewButtonColumn сc0;
        private System.Windows.Forms.DataGridViewButtonColumn cc1;
        private System.Windows.Forms.DataGridViewButtonColumn cc2;
        private System.Windows.Forms.DataGridViewButtonColumn cc3;
        private System.Windows.Forms.DataGridViewButtonColumn cc4;
        private System.Windows.Forms.DataGridViewButtonColumn cc5;
        private System.Windows.Forms.DataGridViewButtonColumn cc6;
        private System.Windows.Forms.DataGridViewButtonColumn cc7;
        private System.Windows.Forms.DataGridViewButtonColumn cc8;
        private System.Windows.Forms.DataGridViewButtonColumn cc9;
        private System.Windows.Forms.DataGridViewButtonColumn cc10;
        private System.Windows.Forms.DataGridViewButtonColumn cc11;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLetter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn с1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn с2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn с3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn с4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn с5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn c6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn c7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn c8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn c9;
        private System.Windows.Forms.StatusStrip tsStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel;
        private System.Windows.Forms.Label l9;
        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.CheckBox chkDifferent;
    }
}

