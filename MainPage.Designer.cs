namespace CMPT291_Final_Project
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
            tabPage3 = new TabPage();
            tabPage2 = new TabPage();
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
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Car).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(621, 253);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Reports";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(621, 253);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Rentals";
            tabPage2.UseVisualStyleBackColor = true;
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
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(621, 253);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cars";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // LicensePlateTextBox
            // 
            LicensePlateTextBox.Location = new Point(406, 190);
            LicensePlateTextBox.Margin = new Padding(2);
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
            MileageTextBox.Margin = new Padding(2);
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
            YearTextBox.Margin = new Padding(2);
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
            RegistrationTextBox.Margin = new Padding(2);
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
            ModelTextBox.Margin = new Padding(2);
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
            MakeTextBox.Margin = new Padding(2);
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
            CarIDTextBox.Margin = new Padding(2);
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
            CTIDTextBox.Margin = new Padding(2);
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
            SearchTextBox.Location = new Point(211, 131);
            SearchTextBox.Margin = new Padding(2);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(196, 23);
            SearchTextBox.TabIndex = 6;
            // 
            // SearchComboBox
            // 
            SearchComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SearchComboBox.FormattingEnabled = true;
            SearchComboBox.Location = new Point(6, 131);
            SearchComboBox.Margin = new Padding(2);
            SearchComboBox.Name = "SearchComboBox";
            SearchComboBox.Size = new Size(196, 23);
            SearchComboBox.TabIndex = 5;
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SearchBtn.Location = new Point(426, 133);
            SearchBtn.Margin = new Padding(2);
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
            ModifyBtn.Location = new Point(515, 190);
            ModifyBtn.Margin = new Padding(2);
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
            DeleteBtn.Location = new Point(515, 223);
            DeleteBtn.Margin = new Padding(2);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Padding = new Padding(4, 0, 4, 3);
            DeleteBtn.Size = new Size(102, 30);
            DeleteBtn.TabIndex = 2;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddBtn.Location = new Point(515, 156);
            AddBtn.Margin = new Padding(2);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(102, 30);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // Car
            // 
            Car.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Car.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Car.Columns.AddRange(new DataGridViewColumn[] { CarID, Make, Model, Year, Mileage, Registration, LicensePlate, CTID });
            Car.Location = new Point(4, 4);
            Car.Margin = new Padding(2);
            Car.Name = "Car";
            Car.RowHeadersWidth = 62;
            Car.RowTemplate.Height = 33;
            Car.Size = new Size(612, 115);
            Car.TabIndex = 0;
            // 
            // CarID
            // 
            CarID.HeaderText = "CarID";
            CarID.MinimumWidth = 8;
            CarID.Name = "CarID";
            CarID.Width = 80;
            // 
            // Make
            // 
            Make.HeaderText = "Make";
            Make.MinimumWidth = 8;
            Make.Name = "Make";
            Make.Width = 120;
            // 
            // Model
            // 
            Model.HeaderText = "Model";
            Model.MinimumWidth = 8;
            Model.Name = "Model";
            Model.Width = 120;
            // 
            // Year
            // 
            Year.HeaderText = "Year";
            Year.MinimumWidth = 8;
            Year.Name = "Year";
            Year.Width = 80;
            // 
            // Mileage
            // 
            Mileage.HeaderText = "Mileage";
            Mileage.MinimumWidth = 8;
            Mileage.Name = "Mileage";
            Mileage.Width = 120;
            // 
            // Registration
            // 
            Registration.HeaderText = "Registration";
            Registration.MinimumWidth = 8;
            Registration.Name = "Registration";
            Registration.Width = 120;
            // 
            // LicensePlate
            // 
            LicensePlate.HeaderText = "LicensePlate";
            LicensePlate.MinimumWidth = 8;
            LicensePlate.Name = "LicensePlate";
            LicensePlate.Width = 110;
            // 
            // CTID
            // 
            CTID.HeaderText = "CTID";
            CTID.MinimumWidth = 8;
            CTID.Name = "CTID";
            CTID.Width = 50;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-1, -1);
            tabControl1.Margin = new Padding(2);
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
            Margin = new Padding(2);
            Name = "MainPage";
            Text = "Car Rentals";
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
    }
}