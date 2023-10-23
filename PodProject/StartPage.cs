﻿using BLL.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodProject
{
    public partial class StartPage : Form
    {
        private Form activeForm = null;
        CategoryController controller;
        public StartPage()
        {
            InitializeComponent();
            CategoryController controller = new CategoryController();
            controller.AddNewCategory();

        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pagePanel.Controls.Add(childForm);
            this.pagePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAddPod_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddPodPage(), sender);
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LibraryPage(), sender);
        }
    }
}
