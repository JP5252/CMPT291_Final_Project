namespace CMPT291_Final_Project
{
    partial class Reports
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
            label = new Label();
            CB = new ComboBox();
            generate = new Button();
            results = new Label();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Cambria Math", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label.ImageAlign = ContentAlignment.TopCenter;
            label.Location = new Point(180, -38);
            label.MaximumSize = new Size(350, 80);
            label.MinimumSize = new Size(100, 80);
            label.Name = "label";
            label.Size = new Size(208, 80);
            label.TabIndex = 0;
            label.Text = "Select a report: ";
            label.Click += label1_Click;
            // 
            // CB
            // 
            CB.FormattingEnabled = true;
            CB.Items.AddRange(new object[] { "Customers who have not rented any cars from the city where they live", "Customers who have not rented any cars with a daily price greater than 100 in Edmonton", "Total rental branches in each City", "Costumers who rented in more than one branches in in different cities", "Branches that have cars with low mileage (less than 100k) and low prices(less than 100 daily price)", "" });
            CB.Location = new Point(31, 45);
            CB.Name = "CB";
            CB.Size = new Size(394, 23);
            CB.TabIndex = 1;
            CB.SelectedIndexChanged += CB_SelectedIndexChanged;
            // 
            // generate
            // 
            generate.BackColor = Color.CornflowerBlue;
            generate.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            generate.Location = new Point(456, 45);
            generate.Name = "generate";
            generate.Size = new Size(103, 23);
            generate.TabIndex = 2;
            generate.Text = "GENERATE";
            generate.UseVisualStyleBackColor = false;
            generate.Click += generate_Click;
            // 
            // results
            // 
            results.AutoSize = true;
            results.BackColor = Color.WhiteSmoke;
            results.Location = new Point(22, 101);
            results.MaximumSize = new Size(520, 230);
            results.MinimumSize = new Size(520, 230);
            results.Name = "results";
            results.Size = new Size(520, 230);
            results.TabIndex = 3;
            results.Click += results_Click;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(584, 361);
            Controls.Add(results);
            Controls.Add(generate);
            Controls.Add(CB);
            Controls.Add(label);
            MaximumSize = new Size(600, 400);
            MinimumSize = new Size(600, 400);
            Name = "Reports";
            Text = "Reports";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private ComboBox CB;
        private Button generate;
        private Label results;
    }
}