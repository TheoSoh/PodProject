﻿namespace PodProject
{
    partial class LibraryPage
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
            components = new System.ComponentModel.Container();
            listBoxEpisodes = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnDelete = new Button();
            btnChange = new Button();
            cmbChangeCategory = new ComboBox();
            label5 = new Label();
            txtChangeName = new TextBox();
            btnSaveChanges = new Button();
            label7 = new Label();
            cmbCategories = new ComboBox();
            listViewPods = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label8 = new Label();
            txtBoxDescription = new RichTextBox();
            btnChangeName = new Button();
            btnShowAllCategories = new Button();
            SuspendLayout();
            // 
            // listBoxEpisodes
            // 
            listBoxEpisodes.FormattingEnabled = true;
            listBoxEpisodes.ItemHeight = 32;
            listBoxEpisodes.Location = new Point(1062, 171);
            listBoxEpisodes.Margin = new Padding(4, 2, 4, 2);
            listBoxEpisodes.Name = "listBoxEpisodes";
            listBoxEpisodes.Size = new Size(515, 388);
            listBoxEpisodes.TabIndex = 0;
            listBoxEpisodes.SelectedIndexChanged += listBoxEpisodes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 36);
            label1.TabIndex = 2;
            label1.Text = "Poddar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1062, 111);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 36);
            label2.TabIndex = 3;
            label2.Text = "Avsnitt:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 599);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(248, 36);
            label3.TabIndex = 4;
            label3.Text = "Hantera poddar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(457, 650);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(178, 26);
            label4.TabIndex = 5;
            label4.Text = "Ändra kategori:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(39, 670);
            btnDelete.Margin = new Padding(4, 2, 4, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 47);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Ta bort";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(221, 670);
            btnChange.Margin = new Padding(4, 2, 4, 2);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(150, 47);
            btnChange.TabIndex = 7;
            btnChange.Text = "Ändra";
            btnChange.UseVisualStyleBackColor = true;
            // 
            // cmbChangeCategory
            // 
            cmbChangeCategory.FormattingEnabled = true;
            cmbChangeCategory.Location = new Point(457, 696);
            cmbChangeCategory.Margin = new Padding(4, 2, 4, 2);
            cmbChangeCategory.Name = "cmbChangeCategory";
            cmbChangeCategory.Size = new Size(242, 40);
            cmbChangeCategory.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(795, 650);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(149, 26);
            label5.TabIndex = 11;
            label5.Text = "Ändra namn:";
            // 
            // txtChangeName
            // 
            txtChangeName.Location = new Point(795, 696);
            txtChangeName.Margin = new Padding(4, 2, 4, 2);
            txtChangeName.Name = "txtChangeName";
            txtChangeName.Size = new Size(238, 39);
            txtChangeName.TabIndex = 12;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(457, 776);
            btnSaveChanges.Margin = new Padding(4, 2, 4, 2);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(251, 47);
            btnSaveChanges.TabIndex = 15;
            btnSaveChanges.Text = "Ändra kategori";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 119);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(246, 32);
            label7.TabIndex = 16;
            label7.Text = "Sortera efter kategori:";
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(293, 107);
            cmbCategories.Margin = new Padding(4, 2, 4, 2);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(242, 40);
            cmbCategories.TabIndex = 17;
            cmbCategories.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // listViewPods
            // 
            listViewPods.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewPods.FullRowSelect = true;
            listViewPods.Location = new Point(39, 171);
            listViewPods.Margin = new Padding(4, 2, 4, 2);
            listViewPods.Name = "listViewPods";
            listViewPods.Size = new Size(954, 388);
            listViewPods.TabIndex = 18;
            listViewPods.UseCompatibleStateImageBehavior = false;
            listViewPods.View = View.Details;
            listViewPods.SelectedIndexChanged += listViewPods_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Namn";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Titel";
            columnHeader2.Width = 350;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Kategori";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Antal avsnitt";
            columnHeader4.Width = 150;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(1062, 617);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(246, 26);
            label8.TabIndex = 20;
            label8.Text = "Beskrivning av avsnitt:";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Location = new Point(1062, 670);
            txtBoxDescription.Margin = new Padding(6);
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.ReadOnly = true;
            txtBoxDescription.Size = new Size(408, 258);
            txtBoxDescription.TabIndex = 21;
            txtBoxDescription.Text = "";
            // 
            // btnChangeName
            // 
            btnChangeName.Location = new Point(795, 777);
            btnChangeName.Name = "btnChangeName";
            btnChangeName.Size = new Size(200, 50);
            btnChangeName.TabIndex = 22;
            btnChangeName.Text = "Ändra namn";
            btnChangeName.UseVisualStyleBackColor = true;
            btnChangeName.Click += btnChangeName_Click;
            // 
            // btnShowAllCategories
            // 
            btnShowAllCategories.Location = new Point(586, 103);
            btnShowAllCategories.Name = "btnShowAllCategories";
            btnShowAllCategories.Size = new Size(300, 46);
            btnShowAllCategories.TabIndex = 23;
            btnShowAllCategories.Text = "Visa alla kategorier";
            btnShowAllCategories.UseVisualStyleBackColor = true;
            btnShowAllCategories.Click += btnShowAllCategories_Click;
            // 
            // LibraryPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1672, 962);
            Controls.Add(btnShowAllCategories);
            Controls.Add(btnChangeName);
            Controls.Add(txtBoxDescription);
            Controls.Add(label8);
            Controls.Add(listViewPods);
            Controls.Add(cmbCategories);
            Controls.Add(label7);
            Controls.Add(btnSaveChanges);
            Controls.Add(txtChangeName);
            Controls.Add(label5);
            Controls.Add(cmbChangeCategory);
            Controls.Add(btnChange);
            Controls.Add(btnDelete);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxEpisodes);
            Margin = new Padding(4, 2, 4, 2);
            Name = "LibraryPage";
            Text = "LibraryPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxEpisodes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private Button btnDelete;
        private Button btnChange;
        private VScrollBar vScrollBar1;
        private ComboBox cmbChangeCategory;
        private Label label5;
        private TextBox txtChangeName;
        private Button btnSaveChanges;
        private Label label7;
        private ComboBox cmbCategories;
        private ListView listViewPods;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label8;
        private RichTextBox txtBoxDescription;
        private Button btnChangeName;
        private Button btnShowAllCategories;
    }
}