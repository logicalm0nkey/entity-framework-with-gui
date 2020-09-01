using MasterManagementTool.Data;
using MasterManagementTool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MasterManagementTool.Forms
{
    public partial class GenreMasterForm : Form
    {
        private List<Genre> _genres;

        public GenreMasterForm()
        {
            InitializeComponent();
        }

        private void GenreMasterForm_Load(object sender, EventArgs e)
        {
            GenreOperationTabControl.SelectedTab = RegisterTab;

            using (var context = new EntityTestWithGUIContext())
            {
                _genres = context.Genres.Where(genre => genre.Deleted == false).ToList();

                UpdateCombobox();
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            using (var context = new EntityTestWithGUIContext())
            {
                context.Genres.Add(new Genre
                {
                    Name = NameTextBoxOfRegister.Text,
                    Deleted = false
                });
                context.SaveChanges();

                _genres = context.Genres.Where(genre => genre.Deleted == false).ToList();
            }

            MessageBox.Show("登録完了", "登録完了", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateCombobox();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var selectedGenre = _genres.Single(
                genre => genre.ID == Convert.ToInt32(IdComboBoxOfUpdate.SelectedItem));

            using (var context = new EntityTestWithGUIContext())
            {
                context.Genres.Attach(selectedGenre);
                selectedGenre.Name = NameTextBoxOfUpdate.Text;
                context.SaveChanges();

                _genres = context.Genres.Where(genre => genre.Deleted == false).ToList();
            }

            MessageBox.Show("更新完了", "更新完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selectedGenre = _genres.Single(
                genre => genre.ID == Convert.ToInt32(IdComboBoxOfDelete.SelectedItem));

            using (var context = new EntityTestWithGUIContext())
            {
                context.Genres.Attach(selectedGenre);
                selectedGenre.Deleted = true;
                context.SaveChanges();

                _genres = context.Genres.Where(genre => genre.Deleted == false).ToList();
            }

            MessageBox.Show("削除完了", "削除完了", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateCombobox();
        }

        private void IdComboBoxOfUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameTextBoxOfUpdate.Text = _genres.Single(
                genre => genre.ID == Convert.ToInt32(IdComboBoxOfUpdate.SelectedItem)).Name;
        }

        private void IdComboBoxOfDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameTextBoxOfDelete.Text = _genres.Single(
                genre => genre.ID == Convert.ToInt32(IdComboBoxOfDelete.SelectedItem)).Name;
        }

        private void UpdateCombobox()
        {
            // コンボボックスとテキストボックスをクリア
            IdComboBoxOfUpdate.Items.Clear();
            IdComboBoxOfDelete.Items.Clear();
            NameTextBoxOfUpdate.Text = string.Empty;
            NameTextBoxOfDelete.Text = string.Empty;

            foreach (var genre in _genres)
            {
                IdComboBoxOfUpdate.Items.Add(genre.ID);
                IdComboBoxOfDelete.Items.Add(genre.ID);
            }
        }
    }
}
