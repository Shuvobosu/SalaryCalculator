using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }
        Salary salary = new Salary();
        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
           string employeeName = employeeNameTextBox.Text;
           double totalSalary= salary.salaryReport(Convert.ToDouble(basicAmountTextBox.Text), Convert.ToDouble(homeRentTextBox.Text), Convert.ToDouble(medicalAllowanceTextBox.Text));
            MessageBox.Show(employeeName + " your salary is " + totalSalary);
        }
    }
}
