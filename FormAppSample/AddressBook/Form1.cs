﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        //住所データ管理用リスト
        BindingList<Person> listPerson = new BindingList<Person>();

        public Form1()
        {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
        }

        private void btPictureOpen_Click(object sender, EventArgs e)
        {
            if(ofdFileOpenDialog.ShowDialog() == DialogResult.OK)
            {

                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);


            }
              
        }

        private void btAddPerson_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person
            {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
            };

            listPerson.Add(newPerson);


        }
        
        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> GetCheckBoxGroup() {

            var listGroup = new List<Person.GroupType>();

            if (cbFamily.Checked) {

                listGroup.Add(Person.GroupType.家族);
            }
            if (cbFriend.Checked) {

                listGroup.Add(Person.GroupType.友人);
            }
            if (cbWork.Checked) {

                listGroup.Add(Person.GroupType.仕事);
            }
            if (cbOther.Checked) {

                listGroup.Add(Person.GroupType.その他);
            }
            return listGroup;
        }


        private void btPictureClear_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
        }

        private void dgvPersons_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void dgvPersons_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow index in dgvPersons.SelectedRows) {

                tbName.Text = listPerson[index.Index].Name.ToString();
                tbMailAddress.Text = listPerson[index.Index].MailAddress.ToString();
                tbAddress.Text = listPerson[index.Index].MailAddress.ToString();
                tbCompany.Text = listPerson[index.Index].Company.ToString();
                pbPicture.Image = listPerson[index.Index].Picture;

            }
        }
    }            
}