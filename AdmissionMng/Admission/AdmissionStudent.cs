using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Admission
{
    class AdmissionStudent
    {
        private string _ID;
        private string _FullName;
        private DateTime _DateOfBirth;
        private string _Sex;
        private string _Address;
        private string _Email;
        private string _Phone;
        private string _ExamResult;
        private string _Choice;
        public AdmissionStudent()
        {

        }
        public AdmissionStudent(string ID, string FullName, DateTime DateOfBirth, string Sex, string Address, string Email, string Phone, string ExamResult, string Choice)
        {
            this.ID = ID;
            this.FullName = FullName;
            this.DateOfBirth = DateOfBirth;
            this.Sex = Sex;
            this.Address = Address;
            this.Email = Email;
            this.Phone = Phone;
            this.ExamResult = ExamResult;
            this.Choice = Choice;
        }
        public string ID { get => _ID; set => _ID = value; }
        public string FullName { get => _FullName; set => _FullName = value; }
        public DateTime DateOfBirth { get => _DateOfBirth; set => _DateOfBirth = value; }
        public string Sex { get => _Sex; set => _Sex = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Phone { get => _Phone; set => _Phone = value; }
        public string ExamResult { get => _ExamResult; set => _ExamResult = value; }
        public string Choice { get => _Choice; set => _Choice = value; }
    }
}
