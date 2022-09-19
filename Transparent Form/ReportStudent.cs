using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transparent_Form
{
    public partial class ReportStudent : Form
    {
        public ReportStudent()
        {
            InitializeComponent();
        }

        private void ReportStudent_Load(object sender, EventArgs e)
        {
            DBconnect conn = new DBconnect();
            // TODO: This line of code loads data into the 'StudentDataSet.student' table. You can move, or remove it, as needed.
            MySqlCommand command = new MySqlCommand("Select * from student", conn.getconnection);
            MySqlDataAdapter d = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("StudentDataSet", dt);
            reportViewer1.LocalReport.ReportPath = @"D:\New folder\Student-Management-System\Transparent Form\StudentReport.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();

            //this.studentTableAdapter.Fill(this.StudentDataSet.student);

            //this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
