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
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBox7 = new TextBox();
            label15 = new Label();
            textBox8 = new TextBox();
            label16 = new Label();
            textBox5 = new TextBox();
            label13 = new Label();
            textBox6 = new TextBox();
            label14 = new Label();
            textBox3 = new TextBox();
            label11 = new Label();
            textBox2 = new TextBox();
            label10 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
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
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(891, 430);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Reports";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // ReportsLabel
            // 
            ReportsLabel.AutoSize = true;
            ReportsLabel.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ReportsLabel.Location = new Point(211, 122);
            ReportsLabel.Margin = new Padding(4, 0, 4, 0);
            ReportsLabel.Name = "ReportsLabel";
            ReportsLabel.Size = new Size(306, 27);
            ReportsLabel.TabIndex = 6;
            ReportsLabel.Text = "Result of Report Chosen : ";
            ReportsLabel.Visible = false;
            // 
            // ResultsDataGrid
            // 
            ResultsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResultsDataGrid.Location = new Point(30, 167);
            ResultsDataGrid.Margin = new Padding(4, 5, 4, 5);
            ResultsDataGrid.Name = "ResultsDataGrid";
            ResultsDataGrid.RowHeadersWidth = 62;
            ResultsDataGrid.RowTemplate.Height = 25;
            ResultsDataGrid.Size = new Size(629, 250);
            ResultsDataGrid.TabIndex = 5;
            ResultsDataGrid.Visible = false;
            // 
            // reportsbutton
            // 
            reportsbutton.BackColor = Color.Aquamarine;
            reportsbutton.Location = new Point(716, 65);
            reportsbutton.Margin = new Padding(4, 5, 4, 5);
            reportsbutton.Name = "reportsbutton";
            reportsbutton.Size = new Size(121, 38);
            reportsbutton.TabIndex = 4;
            reportsbutton.Text = "GENERATE";
            reportsbutton.UseVisualStyleBackColor = false;
            reportsbutton.Click += reportsbutton_Click;
            // 
            // reportcombobox
            // 
            reportcombobox.FormattingEnabled = true;
            reportcombobox.Items.AddRange(new object[] { "Names customers who have not rented any cars with a daily price greater than 100 in the city of Edmonton. ", "Finds the total rental branches in the City", "Customers rented in more than one branches in in different cities", "Branches that have cars with low mileage (less than 100000) and low prices (less than 100 a day)", "Highest Daily Price of Car Make and Model from each branches." });
            reportcombobox.Location = new Point(30, 65);
            reportcombobox.Margin = new Padding(4, 5, 4, 5);
            reportcombobox.MaximumSize = new Size(570, 0);
            reportcombobox.MinimumSize = new Size(627, 0);
            reportcombobox.Name = "reportcombobox";
            reportcombobox.Size = new Size(627, 33);
            reportcombobox.TabIndex = 3;
            // 
            // ReportScreenHeader
            // 
            ReportScreenHeader.AutoSize = true;
            ReportScreenHeader.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            ReportScreenHeader.Location = new Point(211, 0);
            ReportScreenHeader.Margin = new Padding(4, 0, 4, 0);
            ReportScreenHeader.Name = "ReportScreenHeader";
            ReportScreenHeader.Size = new Size(303, 54);
            ReportScreenHeader.TabIndex = 2;
            ReportScreenHeader.Text = "Select a report:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Transparent;
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(textBox8);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label9);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 3, 3, 3);
            tabPage2.Size = new Size(891, 430);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Rentals";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dataGridView1.Location = new Point(7, 7);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(874, 192);
            dataGridView1.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "RentalID";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "DateTo";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "DateFrom";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Price";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "CustomerID";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "CarID";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "BranchIDIn";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 110;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "BranchIDOut";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 120;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(601, 293);
            button1.Name = "button1";
            button1.Size = new Size(273, 115);
            button1.TabIndex = 26;
            button1.Text = "Create Rental";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(416, 370);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(150, 31);
            textBox7.TabIndex = 25;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Location = new Point(303, 373);
            label15.Name = "label15";
            label15.Size = new Size(113, 25);
            label15.TabIndex = 24;
            label15.Text = "BranchIDOut";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(127, 370);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(150, 31);
            textBox8.TabIndex = 23;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label16.AutoSize = true;
            label16.Location = new Point(29, 373);
            label16.Name = "label16";
            label16.Size = new Size(98, 25);
            label16.TabIndex = 22;
            label16.Text = "BranchIDIn";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(416, 293);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 19;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Location = new Point(359, 298);
            label13.Name = "label13";
            label13.Size = new Size(56, 25);
            label13.TabIndex = 18;
            label13.Text = "CarID";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(127, 293);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 31);
            textBox6.TabIndex = 17;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Location = new Point(21, 298);
            label14.Name = "label14";
            label14.Size = new Size(107, 25);
            label14.TabIndex = 16;
            label14.Text = "CustomerID";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(691, 215);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 15;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(601, 220);
            label11.Name = "label11";
            label11.Size = new Size(91, 25);
            label11.TabIndex = 14;
            label11.Text = "DateFrom";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(414, 215);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 13;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(347, 220);
            label10.Name = "label10";
            label10.Size = new Size(67, 25);
            label10.TabIndex = 12;
            label10.Text = "DateTo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 215);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 11;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(47, 220);
            label9.Name = "label9";
            label9.Size = new Size(78, 25);
            label9.TabIndex = 10;
            label9.Text = "RentalID";
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
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 3, 3, 3);
            tabPage1.Size = new Size(891, 430);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cars";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // LicensePlateTextBox
            // 
            LicensePlateTextBox.Location = new Point(580, 317);
            LicensePlateTextBox.Name = "LicensePlateTextBox";
            LicensePlateTextBox.Size = new Size(150, 31);
            LicensePlateTextBox.TabIndex = 20;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(486, 322);
            label8.Name = "label8";
            label8.Size = new Size(95, 21);
            label8.TabIndex = 21;
            label8.Text = "LicensePlate";
            // 
            // MileageTextBox
            // 
            MileageTextBox.Location = new Point(334, 335);
            MileageTextBox.Name = "MileageTextBox";
            MileageTextBox.Size = new Size(150, 31);
            MileageTextBox.TabIndex = 16;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(254, 333);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 19;
            label5.Text = "Mileage";
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(334, 292);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(150, 31);
            YearTextBox.TabIndex = 14;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(269, 292);
            label6.Name = "label6";
            label6.Size = new Size(44, 25);
            label6.TabIndex = 17;
            label6.Text = "Year";
            // 
            // RegistrationTextBox
            // 
            RegistrationTextBox.Location = new Point(334, 377);
            RegistrationTextBox.Name = "RegistrationTextBox";
            RegistrationTextBox.Size = new Size(150, 31);
            RegistrationTextBox.TabIndex = 18;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(229, 377);
            label7.Name = "label7";
            label7.Size = new Size(106, 25);
            label7.TabIndex = 15;
            label7.Text = "Registration";
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(73, 382);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(150, 31);
            ModelTextBox.TabIndex = 12;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(9, 380);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 13;
            label4.Text = "Model";
            // 
            // MakeTextBox
            // 
            MakeTextBox.Location = new Point(73, 335);
            MakeTextBox.Name = "MakeTextBox";
            MakeTextBox.Size = new Size(150, 31);
            MakeTextBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(9, 333);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 11;
            label3.Text = "Make";
            // 
            // CarIDTextBox
            // 
            CarIDTextBox.Location = new Point(73, 292);
            CarIDTextBox.Name = "CarIDTextBox";
            CarIDTextBox.Size = new Size(150, 31);
            CarIDTextBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(9, 292);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 9;
            label2.Text = "CarID";
            // 
            // CTIDTextBox
            // 
            CTIDTextBox.Location = new Point(580, 353);
            CTIDTextBox.Name = "CTIDTextBox";
            CTIDTextBox.Size = new Size(150, 31);
            CTIDTextBox.TabIndex = 22;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(503, 355);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 7;
            label1.Text = "CTID";
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top;
            SearchTextBox.Location = new Point(307, 227);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(278, 31);
            SearchTextBox.TabIndex = 6;
            // 
            // SearchComboBox
            // 
            SearchComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SearchComboBox.DataSource = resources.GetObject("SearchComboBox.DataSource");
            SearchComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SearchComboBox.FormattingEnabled = true;
            SearchComboBox.Location = new Point(9, 218);
            SearchComboBox.Name = "SearchComboBox";
            SearchComboBox.Size = new Size(278, 33);
            SearchComboBox.TabIndex = 5;
            SearchComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SearchComboBox.DataSource = new List<String> {
                "Show All", "Car ID", "Make", "Model",
                "Year", "Mileage", "Registration",
                "License Plate", "CTID"
            };
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SearchBtn.Location = new Point(609, 218);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(273, 33);
            SearchBtn.TabIndex = 4;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // ModifyBtn
            // 
            ModifyBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ModifyBtn.Location = new Point(736, 315);
            ModifyBtn.Name = "ModifyBtn";
            ModifyBtn.Size = new Size(146, 50);
            ModifyBtn.TabIndex = 3;
            ModifyBtn.Text = "Modify";
            ModifyBtn.UseVisualStyleBackColor = true;
            ModifyBtn.Click += ModifyBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DeleteBtn.Location = new Point(736, 378);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Padding = new Padding(6, 0, 6, 5);
            DeleteBtn.Size = new Size(146, 50);
            DeleteBtn.TabIndex = 2;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddBtn.Location = new Point(736, 260);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(146, 50);
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
            Car.Location = new Point(6, 7);
            Car.Name = "Car";
            Car.ReadOnly = true;
            Car.RowHeadersVisible = false;
            Car.RowHeadersWidth = 62;
            Car.RowTemplate.Height = 33;
            Car.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Car.Size = new Size(874, 192);
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
            tabControl1.Location = new Point(-1, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(899, 468);
            tabControl1.SizeMode = TabSizeMode.FillToRight;
            tabControl1.TabIndex = 0;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(894, 465);
            Controls.Add(tabControl1);
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
        private TextBox textBox1;
        private Label label9;
        private TextBox textBox7;
        private Label label15;
        private TextBox textBox8;
        private Label label16;
        private TextBox textBox5;
        private Label label13;
        private TextBox textBox6;
        private Label label14;
        private TextBox textBox3;
        private Label label11;
        private TextBox textBox2;
        private Label label10;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private ComboBox reportcombobox;
        private Label ReportScreenHeader;
        private Button reportsbutton;
        private DataGridView ResultsDataGrid;
        private Label ReportsLabel;
    }
}