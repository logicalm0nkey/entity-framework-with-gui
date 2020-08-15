using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MasterManagementTool
{
    public partial class AuthorMasterForm : Form
    {
        public AuthorMasterForm()
        {
            InitializeComponent();
        }

        private void AuthorMasterForm_Load(object sender, EventArgs e)
        {
            AuthorOperationTabControl.SelectedTab = RegisterTab;
        }
    }
}
