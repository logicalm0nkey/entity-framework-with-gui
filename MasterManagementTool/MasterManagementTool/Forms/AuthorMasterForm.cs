using MasterManagementTool.Models;
using MasterManagementTool.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MasterManagementTool.Forms
{
    public partial class AuthorMasterForm : Form
    {
        /// <summary>
        /// 著者データ
        /// </summary>
        private List<Author> _authors;

        public AuthorMasterForm()
        {
            InitializeComponent();
        }

        private void AuthorMasterForm_Load(object sender, EventArgs e)
        {
            // 登録タブを初期表示
            AuthorOperationTabControl.SelectedTab = RegisterTab;

            using (var context = new EntityTestWithGUIContext())
            {
                // 著者データを取得
                _authors = context.Authors.Where(author => author.Deleted == false).ToList();
            }

            UpdateCombobox();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            using (var context = new EntityTestWithGUIContext())
            {
                // 著者データを登録
                context.Authors.Add(new Author
                {
                    Name = NameTextBoxOfRegister.Text,
                    Deleted = false
                });
                context.SaveChanges();

                // 著者データを取得
                _authors = context.Authors.Where(author => author.Deleted == false).ToList();
            }

            MessageBox.Show("登録完了", "登録完了", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateCombobox();
        }

        private void IdComboBoxOfUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameTextBoxOfUpdate.Text = _authors.Single(
                author => author.ID == Convert.ToInt32(IdComboBoxOfUpdate.SelectedItem)).Name;
        }

        private void IdComboBoxOfDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameTextBoxOfDelete.Text = _authors.Single(
                author => author.ID == Convert.ToInt32(IdComboBoxOfDelete.SelectedItem)).Name;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // 選択された ID の著者を取得
            var selectedAuthor = _authors.Single(
                author => author.ID == Convert.ToInt32(IdComboBoxOfUpdate.SelectedItem));

            using (var context = new EntityTestWithGUIContext())
            {
                // 著者名の変更
                context.Authors.Attach(selectedAuthor);
                selectedAuthor.Name = NameTextBoxOfUpdate.Text;
                context.SaveChanges();

                // 著者データを取得
                _authors = context.Authors.Where(author => author.Deleted == false).ToList();
            }

            MessageBox.Show("更新完了", "更新完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // 選択された ID の著者を取得
            var author = _authors.Single(
                author => author.ID == Convert.ToInt32(IdComboBoxOfDelete.SelectedItem));

            using (var context = new EntityTestWithGUIContext())
            {
                context.Authors.Attach(author);
                author.Deleted = true;
                context.SaveChanges();

                // 著者データを取得
                _authors = context.Authors.Where(author => author.Deleted == false).ToList();
            }

            MessageBox.Show("削除完了", "削除完了", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateCombobox();
        }

        private void UpdateCombobox()
        {
            // コンボボックスとテキストボックスをクリア
            IdComboBoxOfUpdate.Items.Clear();
            IdComboBoxOfDelete.Items.Clear();
            NameTextBoxOfUpdate.Text = string.Empty;
            NameTextBoxOfDelete.Text = string.Empty;

            foreach (var author in _authors)
            {
                IdComboBoxOfUpdate.Items.Add(author.ID);
                IdComboBoxOfDelete.Items.Add(author.ID);
            }
        }
    }
}
