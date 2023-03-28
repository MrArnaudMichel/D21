using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mode_déconnecté
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string chcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=U:\Voyages2010.mdb";
        DataSet ds = new DataSet();
        OleDbConnection conn = new OleDbConnection();

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach(DataRow d in ds.Tables["tblReservations"].Rows)
            {
                if (d["CodeVoyage"].ToString() == cbbDestinations.SelectedValue.ToString())
                    i++;
            }
            MessageBox.Show(i.ToString());
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            cbbDestinations.DataSource = ds.Tables["tblVoyages"];
            cbbDestinations.DisplayMember = "Destination";
            cbbDestinations.ValueMember = "CodeVoyage";
            cbbDestinations.SelectedIndex = -1;

            foreach (DataRow d in ds.Tables["tblReservations"].Rows)
            {
                cbbid.Items.Add(d["CodeVoyage"].ToString() + d["NumClient"].ToString());
            }
        }

        private void ChargementDsLocal()
        {
            conn.Open();
            DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] {null, null, null, "Table"});
            foreach (DataRow dr in dt.Rows)
            {
                string nomTable = dr["TABLE_NAME"].ToString();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM " + nomTable, conn);
                da.Fill(ds, nomTable);
            }
            conn.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = chcon;
            ChargementDsLocal();
            cbbDest.DataSource = ds.Tables["tblVoyages"];
            cbbDest.DisplayMember = "Destination";
            cbbDest.ValueMember = "CodeVoyage";
            cbbDest.SelectedIndex = -1;

            cbbClient.DataSource = ds.Tables["tblClients"];
            cbbClient.DisplayMember = "NomClient";
            cbbClient.ValueMember = "NumClient";
            cbbClient.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cbbDest.Visible = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            cbbClient.Visible = checkBox3.Checked;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnrecherche_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string request = "";
            bool first = true;
            if (checkBox1.Checked)
            {
                request += "CodeVoyage = '" + cbbDest.SelectedValue.ToString() + "' ";
                first = false;
            }
            if (checkBox2.Checked)
            {
                if (!first)
                {
                    request += "AND ";
                }
                first = false;
                request += "DateReservation = #"+dateTimePicker1.Value.Month.ToString()+ "/" + dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Year.ToString() + "# ";
            }
            if (checkBox3.Checked)
            {
                if (!first)
                {
                    request += "AND ";
                }
                request += "NumClient = '" + cbbClient.SelectedValue.ToString() + "'";
            }
            MessageBox.Show(request);
            DataRow[] drs = ds.Tables["tblReservations"].Select(request);
            dt = drs.CopyToDataTable();
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ds.Tables["tblReservations"].Select("CodeVoyage = '" + cbbDestinations.SelectedValue + "'").Length.ToString());
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string request = "INSERT INTO tblReservations(NumClient, CodeVoyage, DateReservation) values('" + cbbDest.SelectedValue.ToString() + "', #" + dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Year.ToString() + "#, '" + cbbClient.SelectedValue.ToString() + "')";
            DataRow datarow = new 
        }
    }
}
