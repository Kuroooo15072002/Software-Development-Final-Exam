using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Admission
{
    public partial class AdS : Form
    {
        public AdS()
        {
            InitializeComponent();
        }
        Modify modify=new Modify();
        AdmissionStudent admissionStudent;
        private void Form2_Load (object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource= modify.getAllAdmissionStudent();
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Notify " +ex.Message, "Add successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            string ID = this.AdSID.Text;
            string FullName = this.AdSFullName.Text;
            DateTime DateOfBirth = this.AdSDateOfBirth.Value;
            string Sex = this.AdSSex.Text;
            string Address = this.AdSAddress.Text;
            string Email = this.AdSEmail.Text;
            string Phone = this.AdSPhone.Text;
            string ExamResult = this.AdSExamResult.Text;
            string Choice = this.AdSChoice.Text;
            admissionStudent = new AdmissionStudent(ID, FullName, DateOfBirth, Sex, Address, Email, Phone, ExamResult, Choice);
            if (modify.Add(admissionStudent))
            {
                dataGridView1.DataSource = modify.getAllAdmissionStudent();
            }
            else
            {
                MessageBox.Show("Add successfully", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Update_Click(object sender, EventArgs e)
        {
            string ID = this.AdSID.Text;
            string FullName = this.AdSFullName.Text;
            DateTime DateOfBirth = this.AdSDateOfBirth.Value;
            string Sex = this.AdSSex.Text;
            string Address = this.AdSAddress.Text;
            string Email = this.AdSEmail.Text;
            string Phone = this.AdSPhone.Text;
            string ExamResult = this.AdSExamResult.Text;
            string Choice = this.AdSChoice.Text;
            admissionStudent = new AdmissionStudent(ID, FullName, DateOfBirth, Sex, Address, Email, Phone, ExamResult, Choice);
            if (modify.Update(admissionStudent))
            {
                dataGridView1.DataSource = modify.getAllAdmissionStudent();
            }
            else
            {
                MessageBox.Show("Update successfully", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            string ID= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if(modify.Delete(ID))
            {
                dataGridView1.DataSource=modify.getAllAdmissionStudent();
            }
            else
            {
                MessageBox.Show("Delete successfully", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

