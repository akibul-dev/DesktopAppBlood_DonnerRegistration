using SimpleCrud_dotnet_desktopApp.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleCrud_dotnet_desktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
               



        static string connectionString = "data source=.; database=BloodDonorDB; Integrated Security= true";
        SqlConnection con = new SqlConnection(connectionString);

        private void btn_save_Click(object sender, EventArgs e)
        {
            Donor _donor = new Donor()
            {
                Name = txt_Name.Text,
                Address = txt_address.Text,
                Age = Convert.ToInt32(txt_age.Text),
                Gender = txt_gender.Text,
                PhoneNumber = txt_phoneNumber.Text,
                BloodGroup = txt_bloodGroup.Text,
                LastDonation = txt_Date.Text,

            };

            string query = "INSERT INTO tbl_donor(Donor_Name,Age , Gender, PhoneNumber, BloodGroup, Address, LastBloodDonation)" +
                "VALUES ('" + _donor.Name + "', '" + _donor.Age + "', '" + _donor.Gender + "', '" + _donor.PhoneNumber + "', '" + _donor.BloodGroup + "', '" + _donor.Address + "', '" + _donor.LastDonation + "');";

            con.Open();
            SqlCommand _sqlCmd = new SqlCommand(query, con);
            int success = _sqlCmd.ExecuteNonQuery();
            con.Close();
            if (success > 0)
            {
                MessageBox.Show("Data Saved Successfully");
                clear();
                gv_datalist.DataSource = getAll();
            }
            else
            {
                MessageBox.Show("Failed to Saved!!");
            }





        }

        public void clear()
        {
            txt_Name.Clear();
            txt_gender.Items.Clear();
            txt_bloodGroup.Items.Clear();
            txt_phoneNumber.Clear();
            txt_age.Clear();
            txt_address.Clear();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }





        private void gv_datalist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           




        }


        public DataTable getAll()
        {
            DataTable _dataTable = new DataTable();

            string query2 = "select* from tbl_donor";
            SqlCommand _sqlCmd = new SqlCommand(query2, con);
            

            SqlDataAdapter _dataAdapdet = new SqlDataAdapter(_sqlCmd);
            con.Open();

            _dataAdapdet.Fill(_dataTable);

            return _dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gv_datalist.DataSource = getAll();
        }
    }
}