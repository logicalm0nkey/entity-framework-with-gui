using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MasterManagementTool
{
    public partial class GenreMasterForm : Form
    {
        public GenreMasterForm()
        {
            InitializeComponent();
        }

        private void GenreMasterForm_Load(object sender, EventArgs e)
        {
            GenreOperationTabControl.SelectedTab = RegisterTab;
        }
    }
}
