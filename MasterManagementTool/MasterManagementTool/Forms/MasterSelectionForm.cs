﻿using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterManagementTool.Data;
using Microsoft.Data.SqlClient;

namespace MasterManagementTool.Forms
{
    public partial class MasterSelectionForm : Form
    {
        public MasterSelectionForm()
        {
            InitializeComponent();
        }

        private void AuthorMasterButton_Click(object sender, EventArgs e)
        {
            using (var form = new AuthorMasterForm())
            {
                form.ShowDialog();
            }
        }

        private void GenreMasterButton_Click(object sender, EventArgs e)
        {
            using (var form = new GenreMasterForm())
            {
                form.ShowDialog();
            }
        }
    }
}
