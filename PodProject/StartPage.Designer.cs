﻿namespace PodProject
{
    partial class StartPage
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
            panel1 = new Panel();
            menuPanel = new Panel();
            header = new Label();
            btnLibrary = new Button();
            btnAddPod = new Button();
            btnManageCategories = new Button();
            pagePanel = new Panel();
            panel1.SuspendLayout();
            menuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(header);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1171, 100);
            panel1.TabIndex = 0;
            // 
            // menuPanel
            // 
            menuPanel.BackColor = SystemColors.AppWorkspace;
            menuPanel.Controls.Add(btnManageCategories);
            menuPanel.Controls.Add(btnAddPod);
            menuPanel.Controls.Add(btnLibrary);
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 100);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(140, 541);
            menuPanel.TabIndex = 1;
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Top;
            header.AutoSize = true;
            header.Font = new Font("Sans Serif Collection", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            header.Location = new Point(505, 19);
            header.Name = "header";
            header.Size = new Size(174, 67);
            header.TabIndex = 0;
            header.Text = "PodLib";
            // 
            // btnLibrary
            // 
            btnLibrary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLibrary.Location = new Point(10, 6);
            btnLibrary.Name = "btnLibrary";
            btnLibrary.Size = new Size(120, 60);
            btnLibrary.TabIndex = 0;
            btnLibrary.Text = "Mina poddar";
            btnLibrary.UseVisualStyleBackColor = true;
            // 
            // btnAddPod
            // 
            btnAddPod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddPod.Location = new Point(10, 72);
            btnAddPod.Name = "btnAddPod";
            btnAddPod.Size = new Size(120, 60);
            btnAddPod.TabIndex = 1;
            btnAddPod.Text = "Lägg till pod";
            btnAddPod.UseVisualStyleBackColor = true;
            // 
            // btnManageCategories
            // 
            btnManageCategories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnManageCategories.Location = new Point(10, 138);
            btnManageCategories.Name = "btnManageCategories";
            btnManageCategories.Size = new Size(120, 60);
            btnManageCategories.TabIndex = 2;
            btnManageCategories.Text = "Hantera kategorier";
            btnManageCategories.UseVisualStyleBackColor = true;
            // 
            // pagePanel
            // 
            pagePanel.Location = new Point(139, 100);
            pagePanel.Name = "pagePanel";
            pagePanel.Size = new Size(1032, 541);
            pagePanel.TabIndex = 2;
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 641);
            Controls.Add(pagePanel);
            Controls.Add(menuPanel);
            Controls.Add(panel1);
            Name = "StartPage";
            Text = "StartPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel menuPanel;
        private Label header;
        private Button btnLibrary;
        private Button btnAddPod;
        private Button btnManageCategories;
        private Panel pagePanel;
    }
}