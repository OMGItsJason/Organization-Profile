using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Organization_Profile
{

    public partial class frmConfirmation : Window
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;
        private string _Birthday;
        private string _Program;
        private string _Gender;
        private StudentInformationClass studentInfo;
        
        public frmConfirmation(StudentInformationClass studentInfo)
        {
            InitializeComponent();
            this.studentInfo = studentInfo;
        }

        private void BtnSubmit_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Submitted Na Po","Thank You");
        }

        private void FrmConfirmation_OnLoaded(object sender, RoutedEventArgs e)
        {
            _FullName = studentInfo.SetFullName;
            _Age = studentInfo.SetAge;
            _ContactNo = studentInfo.SetContactNo;
            _StudentNo = studentInfo.SetStudentNo;
            _Birthday = studentInfo.SetBirthday;
            _Program = studentInfo.SetProgram;
            _Gender = studentInfo.SetGender;

            lblName.Text = _FullName;
            lblAge.Text = _Age.ToString();
            lblContactNo.Text = _ContactNo.ToString();
            lblStudentNo.Text = _StudentNo.ToString();
            lblBirthday.Content = _Birthday;
            lblProgram.Content = _Program;
            lblGender.Content = _Gender;
        }
    }
}
