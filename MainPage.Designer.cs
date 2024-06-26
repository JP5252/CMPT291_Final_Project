﻿namespace CMPT291_Final_Project
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            tabPage3 = new TabPage();
            ReportsLabel = new Label();
            ResultsDataGrid = new DataGridView();
            reportsbutton = new Button();
            reportcombobox = new ComboBox();
            ReportScreenHeader = new Label();
            tabPage2 = new TabPage();
            EndBranchComboBox = new ComboBox();
            StartBranchComboBox = new ComboBox();
            CheckAvailBtn = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            RentalCarID = new DataGridViewTextBoxColumn();
            RentalCarMake = new DataGridViewTextBoxColumn();
            RentalCarModel = new DataGridViewTextBoxColumn();
            RentalCarYear = new DataGridViewTextBoxColumn();
            RentalCarPrice = new DataGridViewTextBoxColumn();
            CreateRentalButton = new Button();
            label15 = new Label();
            label16 = new Label();
            customerIDBox = new TextBox();
            label14 = new Label();
            label11 = new Label();
            label10 = new Label();
            tabPage1 = new TabPage();
            LicensePlateTextBox = new TextBox();
            label8 = new Label();
            MileageTextBox = new TextBox();
            label5 = new Label();
            YearTextBox = new TextBox();
            label6 = new Label();
            RegistrationTextBox = new TextBox();
            label7 = new Label();
            ModelTextBox = new TextBox();
            label4 = new Label();
            MakeTextBox = new TextBox();
            label3 = new Label();
            CarIDTextBox = new TextBox();
            label2 = new Label();
            CTIDTextBox = new TextBox();
            label1 = new Label();
            SearchTextBox = new TextBox();
            SearchComboBox = new ComboBox();
            SearchBtn = new Button();
            ModifyBtn = new Button();
            DeleteBtn = new Button();
            AddBtn = new Button();
            Car = new DataGridView();
            CarID = new DataGridViewTextBoxColumn();
            Make = new DataGridViewTextBoxColumn();
            Model = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Mileage = new DataGridViewTextBoxColumn();
            Registration = new DataGridViewTextBoxColumn();
            LicensePlate = new DataGridViewTextBoxColumn();
            CTID = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ResultsDataGrid).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Car).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(ReportsLabel);
            tabPage3.Controls.Add(ResultsDataGrid);
            tabPage3.Controls.Add(reportsbutton);
            tabPage3.Controls.Add(reportcombobox);
            tabPage3.Controls.Add(ReportScreenHeader);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(2, 2, 2, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(621, 253);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Reports";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // ReportsLabel
            // 
            ReportsLabel.AutoSize = true;
            ReportsLabel.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ReportsLabel.Location = new Point(148, 73);
            ReportsLabel.Name = "ReportsLabel";
            ReportsLabel.Size = new Size(196, 18);
            ReportsLabel.TabIndex = 6;
            ReportsLabel.Text = "Result of Report Chosen : ";
            ReportsLabel.Visible = false;
            // 
            // ResultsDataGrid
            // 
            ResultsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResultsDataGrid.Location = new Point(21, 100);
            ResultsDataGrid.Name = "ResultsDataGrid";
            ResultsDataGrid.RowHeadersWidth = 62;
            ResultsDataGrid.RowTemplate.Height = 25;
            ResultsDataGrid.Size = new Size(565, 150);
            ResultsDataGrid.TabIndex = 5;
            ResultsDataGrid.Visible = false;
            // 
            // reportsbutton
            // 
            reportsbutton.BackColor = Color.Aquamarine;
            reportsbutton.Location = new Point(501, 39);
            reportsbutton.Name = "reportsbutton";
            reportsbutton.Size = new Size(85, 23);
            reportsbutton.TabIndex = 4;
            reportsbutton.Text = "GENERATE";
            reportsbutton.UseVisualStyleBackColor = false;
            reportsbutton.Click += reportsbutton_Click;
            // 
            // reportcombobox
            // 
            reportcombobox.FormattingEnabled = true;
            reportcombobox.Items.AddRange(new object[] { "Names of customers who have not rented any cars with a daily price greater than 100 in the city of Edmonton.", "Finds the total rentals from branches in each City", "Customers rented in more than one branches in in different cities", "Branches that have atleast 3 different customers renting from them", "Highest Daily Price of Car Make and Model from each branches" });
            reportcombobox.Location = new Point(21, 39);
            reportcombobox.MaximumSize = new Size(400, 0);
            reportcombobox.MinimumSize = new Size(440, 0);
            reportcombobox.Name = "reportcombobox";
            reportcombobox.Size = new Size(440, 23);
            reportcombobox.TabIndex = 3;
            // 
            // ReportScreenHeader
            // 
            ReportScreenHeader.AutoSize = true;
            ReportScreenHeader.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            ReportScreenHeader.Location = new Point(148, 0);
            ReportScreenHeader.Name = "ReportScreenHeader";
            ReportScreenHeader.Size = new Size(201, 36);
            ReportScreenHeader.TabIndex = 2;
            ReportScreenHeader.Text = "Select a report:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Transparent;
            tabPage2.Controls.Add(EndBranchComboBox);
            tabPage2.Controls.Add(StartBranchComboBox);
            tabPage2.Controls.Add(CheckAvailBtn);
            tabPage2.Controls.Add(dateTimePicker2);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(CreateRentalButton);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(customerIDBox);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 2, 2, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 2, 2, 2);
            tabPage2.Size = new Size(621, 253);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Rentals";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // EndBranchComboBox
            // 
            EndBranchComboBox.FormattingEnabled = true;
            EndBranchComboBox.Location = new Point(101, 211);
            EndBranchComboBox.Margin = new Padding(2, 2, 2, 2);
            EndBranchComboBox.Name = "EndBranchComboBox";
            EndBranchComboBox.Size = new Size(129, 23);
            EndBranchComboBox.TabIndex = 32;
            // 
            // StartBranchComboBox
            // 
            StartBranchComboBox.FormattingEnabled = true;
            StartBranchComboBox.Location = new Point(101, 179);
            StartBranchComboBox.Margin = new Padding(2, 2, 2, 2);
            StartBranchComboBox.Name = "StartBranchComboBox";
            StartBranchComboBox.Size = new Size(129, 23);
            StartBranchComboBox.TabIndex = 31;
            // 
            // CheckAvailBtn
            // 
            CheckAvailBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CheckAvailBtn.Location = new Point(463, 141);
            CheckAvailBtn.Margin = new Padding(2, 2, 2, 2);
            CheckAvailBtn.Name = "CheckAvailBtn";
            CheckAvailBtn.Size = new Size(139, 37);
            CheckAvailBtn.TabIndex = 30;
            CheckAvailBtn.Text = "Check Availability";
            CheckAvailBtn.UseVisualStyleBackColor = true;
            CheckAvailBtn.Click += CheckAvailBtn_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(77, 148);
            dateTimePicker2.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(152, 23);
            dateTimePicker2.TabIndex = 29;
            dateTimePicker2.Value = new DateTime(2023, 6, 12, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(298, 147);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(152, 23);
            dateTimePicker1.TabIndex = 28;
            dateTimePicker1.Value = new DateTime(2023, 6, 12, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { RentalCarID, RentalCarMake, RentalCarModel, RentalCarYear, RentalCarPrice });
            dataGridView1.Location = new Point(5, 4);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(612, 133);
            dataGridView1.TabIndex = 27;
            // 
            // RentalCarID
            // 
            RentalCarID.HeaderText = "CarID";
            RentalCarID.MinimumWidth = 8;
            RentalCarID.Name = "RentalCarID";
            RentalCarID.ReadOnly = true;
            RentalCarID.Width = 80;
            // 
            // RentalCarMake
            // 
            RentalCarMake.HeaderText = "Make";
            RentalCarMake.MinimumWidth = 8;
            RentalCarMake.Name = "RentalCarMake";
            RentalCarMake.ReadOnly = true;
            RentalCarMake.Width = 150;
            // 
            // RentalCarModel
            // 
            RentalCarModel.HeaderText = "Model";
            RentalCarModel.MinimumWidth = 8;
            RentalCarModel.Name = "RentalCarModel";
            RentalCarModel.ReadOnly = true;
            RentalCarModel.Width = 150;
            // 
            // RentalCarYear
            // 
            RentalCarYear.HeaderText = "Year";
            RentalCarYear.MinimumWidth = 8;
            RentalCarYear.Name = "RentalCarYear";
            RentalCarYear.ReadOnly = true;
            RentalCarYear.Width = 150;
            // 
            // RentalCarPrice
            // 
            RentalCarPrice.HeaderText = "Price";
            RentalCarPrice.MinimumWidth = 8;
            RentalCarPrice.Name = "RentalCarPrice";
            RentalCarPrice.ReadOnly = true;
            RentalCarPrice.Width = 150;
            // 
            // CreateRentalButton
            // 
            CreateRentalButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CreateRentalButton.Location = new Point(421, 188);
            CreateRentalButton.Margin = new Padding(2, 2, 2, 2);
            CreateRentalButton.Name = "CreateRentalButton";
            CreateRentalButton.Size = new Size(191, 56);
            CreateRentalButton.TabIndex = 26;
            CreateRentalButton.Text = "Create Rental";
            CreateRentalButton.UseVisualStyleBackColor = true;
            CreateRentalButton.Click += CreateRentalButton_Click;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Location = new Point(3, 213);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(88, 15);
            label15.TabIndex = 24;
            label15.Text = "Dropoff Branch";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label16.AutoSize = true;
            label16.Location = new Point(15, 181);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(71, 15);
            label16.TabIndex = 22;
            label16.Text = "Start Branch";
            // 
            // customerIDBox
            // 
            customerIDBox.Location = new Point(312, 194);
            customerIDBox.Margin = new Padding(2, 2, 2, 2);
            customerIDBox.Name = "customerIDBox";
            customerIDBox.Size = new Size(106, 23);
            customerIDBox.TabIndex = 17;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Location = new Point(232, 196);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(70, 15);
            label14.TabIndex = 16;
            label14.Text = "CustomerID";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(9, 151);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 14;
            label11.Text = "Start Date";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(235, 150);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 12;
            label10.Text = "End Date";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(LicensePlateTextBox);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(MileageTextBox);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(YearTextBox);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(RegistrationTextBox);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(ModelTextBox);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(MakeTextBox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(CarIDTextBox);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(CTIDTextBox);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(SearchTextBox);
            tabPage1.Controls.Add(SearchComboBox);
            tabPage1.Controls.Add(SearchBtn);
            tabPage1.Controls.Add(ModifyBtn);
            tabPage1.Controls.Add(DeleteBtn);
            tabPage1.Controls.Add(AddBtn);
            tabPage1.Controls.Add(Car);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2, 2, 2, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 2, 2, 2);
            tabPage1.Size = new Size(621, 253);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cars";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // LicensePlateTextBox
            // 
            LicensePlateTextBox.Location = new Point(406, 190);
            LicensePlateTextBox.Margin = new Padding(2, 2, 2, 2);
            LicensePlateTextBox.Name = "LicensePlateTextBox";
            LicensePlateTextBox.Size = new Size(106, 23);
            LicensePlateTextBox.TabIndex = 20;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(340, 193);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(69, 13);
            label8.TabIndex = 21;
            label8.Text = "LicensePlate";
            // 
            // MileageTextBox
            // 
            MileageTextBox.Location = new Point(234, 201);
            MileageTextBox.Margin = new Padding(2, 2, 2, 2);
            MileageTextBox.Name = "MileageTextBox";
            MileageTextBox.Size = new Size(106, 23);
            MileageTextBox.TabIndex = 16;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(178, 200);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 19;
            label5.Text = "Mileage";
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(234, 175);
            YearTextBox.Margin = new Padding(2, 2, 2, 2);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(106, 23);
            YearTextBox.TabIndex = 14;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(188, 175);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 17;
            label6.Text = "Year";
            // 
            // RegistrationTextBox
            // 
            RegistrationTextBox.Location = new Point(234, 226);
            RegistrationTextBox.Margin = new Padding(2, 2, 2, 2);
            RegistrationTextBox.Name = "RegistrationTextBox";
            RegistrationTextBox.Size = new Size(106, 23);
            RegistrationTextBox.TabIndex = 18;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(160, 226);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 15;
            label7.Text = "Registration";
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(51, 229);
            ModelTextBox.Margin = new Padding(2, 2, 2, 2);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(106, 23);
            ModelTextBox.TabIndex = 12;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(6, 228);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 13;
            label4.Text = "Model";
            // 
            // MakeTextBox
            // 
            MakeTextBox.Location = new Point(51, 201);
            MakeTextBox.Margin = new Padding(2, 2, 2, 2);
            MakeTextBox.Name = "MakeTextBox";
            MakeTextBox.Size = new Size(106, 23);
            MakeTextBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(6, 200);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 11;
            label3.Text = "Make";
            // 
            // CarIDTextBox
            // 
            CarIDTextBox.Location = new Point(51, 175);
            CarIDTextBox.Margin = new Padding(2, 2, 2, 2);
            CarIDTextBox.Name = "CarIDTextBox";
            CarIDTextBox.Size = new Size(106, 23);
            CarIDTextBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(6, 175);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 9;
            label2.Text = "CarID";
            // 
            // CTIDTextBox
            // 
            CTIDTextBox.Location = new Point(406, 212);
            CTIDTextBox.Margin = new Padding(2, 2, 2, 2);
            CTIDTextBox.Name = "CTIDTextBox";
            CTIDTextBox.Size = new Size(106, 23);
            CTIDTextBox.TabIndex = 22;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(352, 213);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 7;
            label1.Text = "CTID";
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top;
            SearchTextBox.Location = new Point(215, 136);
            SearchTextBox.Margin = new Padding(2, 2, 2, 2);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(196, 23);
            SearchTextBox.TabIndex = 6;
            // 
            // SearchComboBox
            // 
            SearchComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SearchComboBox.DataSource = resources.GetObject("SearchComboBox.DataSource");
            SearchComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SearchComboBox.FormattingEnabled = true;
            SearchComboBox.Location = new Point(6, 131);
            SearchComboBox.Margin = new Padding(2, 2, 2, 2);
            SearchComboBox.Name = "SearchComboBox";
            SearchComboBox.Size = new Size(196, 23);
            SearchComboBox.TabIndex = 5;
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SearchBtn.Location = new Point(426, 131);
            SearchBtn.Margin = new Padding(2, 2, 2, 2);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(191, 20);
            SearchBtn.TabIndex = 4;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // ModifyBtn
            // 
            ModifyBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ModifyBtn.Location = new Point(515, 189);
            ModifyBtn.Margin = new Padding(2, 2, 2, 2);
            ModifyBtn.Name = "ModifyBtn";
            ModifyBtn.Size = new Size(102, 30);
            ModifyBtn.TabIndex = 3;
            ModifyBtn.Text = "Modify";
            ModifyBtn.UseVisualStyleBackColor = true;
            ModifyBtn.Click += ModifyBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DeleteBtn.Location = new Point(515, 227);
            DeleteBtn.Margin = new Padding(2, 2, 2, 2);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Padding = new Padding(4, 0, 4, 3);
            DeleteBtn.Size = new Size(102, 30);
            DeleteBtn.TabIndex = 2;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddBtn.Location = new Point(515, 156);
            AddBtn.Margin = new Padding(2, 2, 2, 2);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(102, 30);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // Car
            // 
            Car.AllowUserToAddRows = false;
            Car.AllowUserToResizeRows = false;
            Car.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Car.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Car.Columns.AddRange(new DataGridViewColumn[] { CarID, Make, Model, Year, Mileage, Registration, LicensePlate, CTID });
            Car.Location = new Point(4, 4);
            Car.Margin = new Padding(2, 2, 2, 2);
            Car.Name = "Car";
            Car.ReadOnly = true;
            Car.RowHeadersVisible = false;
            Car.RowHeadersWidth = 62;
            Car.RowTemplate.Height = 33;
            Car.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Car.Size = new Size(612, 115);
            Car.TabIndex = 0;
            // 
            // CarID
            // 
            CarID.HeaderText = "CarID";
            CarID.MinimumWidth = 8;
            CarID.Name = "CarID";
            CarID.ReadOnly = true;
            CarID.Width = 70;
            // 
            // Make
            // 
            Make.HeaderText = "Make";
            Make.MinimumWidth = 8;
            Make.Name = "Make";
            Make.ReadOnly = true;
            Make.Width = 150;
            // 
            // Model
            // 
            Model.HeaderText = "Model";
            Model.MinimumWidth = 8;
            Model.Name = "Model";
            Model.ReadOnly = true;
            Model.Width = 180;
            // 
            // Year
            // 
            Year.HeaderText = "Year";
            Year.MinimumWidth = 8;
            Year.Name = "Year";
            Year.ReadOnly = true;
            Year.Width = 60;
            // 
            // Mileage
            // 
            Mileage.HeaderText = "Mileage";
            Mileage.MinimumWidth = 8;
            Mileage.Name = "Mileage";
            Mileage.ReadOnly = true;
            Mileage.Width = 90;
            // 
            // Registration
            // 
            Registration.HeaderText = "Registration";
            Registration.MinimumWidth = 8;
            Registration.Name = "Registration";
            Registration.ReadOnly = true;
            Registration.Width = 120;
            // 
            // LicensePlate
            // 
            LicensePlate.HeaderText = "LicensePlate";
            LicensePlate.MinimumWidth = 8;
            LicensePlate.Name = "LicensePlate";
            LicensePlate.ReadOnly = true;
            LicensePlate.Width = 110;
            // 
            // CTID
            // 
            CTID.HeaderText = "CTID";
            CTID.MinimumWidth = 8;
            CTID.Name = "CTID";
            CTID.ReadOnly = true;
            CTID.Width = 70;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-1, -1);
            tabControl1.Margin = new Padding(2, 2, 2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(629, 281);
            tabControl1.SizeMode = TabSizeMode.FillToRight;
            tabControl1.TabIndex = 0;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(626, 279);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MainPage";
            Text = "Car Rentals";
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ResultsDataGrid).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Car).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage3;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TextBox SearchTextBox;
        private ComboBox SearchComboBox;
        private Button SearchBtn;
        private Button ModifyBtn;
        private Button DeleteBtn;
        private Button AddBtn;
        private DataGridView Car;
        private TabControl tabControl1;
        private Label label1;
        private TextBox ModelTextBox;
        private Label label4;
        private TextBox MakeTextBox;
        private Label label3;
        private TextBox CarIDTextBox;
        private Label label2;
        private TextBox CTIDTextBox;
        private TextBox MileageTextBox;
        private Label label5;
        private TextBox YearTextBox;
        private Label label6;
        private TextBox RegistrationTextBox;
        private Label label7;
        private TextBox LicensePlateTextBox;
        private Label label8;
        private DataGridViewTextBoxColumn CarID;
        private DataGridViewTextBoxColumn Make;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Mileage;
        private DataGridViewTextBoxColumn Registration;
        private DataGridViewTextBoxColumn LicensePlate;
        private DataGridViewTextBoxColumn CTID;
        private Label label15;
        private Label label16;
        private TextBox customerIDBox;
        private Label label14;
        private Label label11;
        private Label label10;
        private Button CreateRentalButton;
        private DataGridView dataGridView1;
        private ComboBox reportcombobox;
        private Label ReportScreenHeader;
        private Button reportsbutton;
        private DataGridView ResultsDataGrid;
        private Label ReportsLabel;
        private DataGridViewTextBoxColumn RentalCarID;
        private DataGridViewTextBoxColumn RentalCarMake;
        private DataGridViewTextBoxColumn RentalCarModel;
        private DataGridViewTextBoxColumn RentalCarYear;
        private DataGridViewTextBoxColumn RentalCarPrice;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button CheckAvailBtn;
        private ComboBox EndBranchComboBox;
        private ComboBox StartBranchComboBox;
    }
}