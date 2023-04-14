using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Voyage;

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

            cbbthem.DataSource = ds.Tables["tblThematique"];
            cbbthem.DisplayMember = "libThem";
            cbbthem.ValueMember = "codeThem";
            cbbthem.SelectedIndex = -1;
            /*
            cbbdestmaitre.DataSource = ds.Tables["tblVoyages"];
            cbbdestmaitre.DisplayMember = "Destination";
            cbbdestmaitre.ValueMember = "CodeVoyage";
            cbbdestmaitre.SelectedIndex = -1;*/
            
            DataRelation dr = new DataRelation("VoyageDestination", ds.Tables["tblVoyages"].Columns["CodeVoyage"], ds.Tables["tblReservations"].Columns["CodeVoyage"]);
            ds.Relations.Add(dr);

            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            bs.DataMember = "tblVoyages";

            BindingSource bs2 = new BindingSource();
            bs2.DataSource = bs;
            bs2.DataMember = "VoyageDestination";

            cbbdestmaitre.DataSource = bs;
            cbbdestmaitre.DisplayMember = "Destination";
            dgwMaitre.DataSource = bs2;

            cbbdestiationuc.DataSource = ds.Tables["tblVoyages"];
            cbbdestiationuc.DisplayMember = "Destination";
            cbbdestiationuc.ValueMember = "CodeVoyage";
            cbbdestiationuc.SelectedIndex = -1;
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
            DataRow[] drs = ds.Tables["tblReservations"].Select(request);
            if (drs.Length == 0)
            {
                MessageBox.Show("Aucune réservation ne correspond à votre recherche");
                return;
            }
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnrecherch_Click(object sender, EventArgs e)
        {
            datagridrecherche.DataSource = ds.Tables["tblVoyages"];
            datagridrecherche.Refresh();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
            if (e.Value != null && cbbthem.SelectedIndex != -1 && txtprix.Text != "" && datagridrecherche.Rows[e.RowIndex].Cells["TypeThematique"].Value.ToString() == cbbthem.SelectedValue.ToString() && int.Parse(datagridrecherche.Rows[e.RowIndex].Cells["Prix"].Value.ToString()) < int.Parse(txtprix.Text.ToString()))
            {
                e.CellStyle.BackColor = Color.LightGreen;
              
            }
        }

        List<DataGridViewRow> lines = new List<DataGridViewRow>();

        private void button3_Click_1(object sender, EventArgs e)
        {
            lines = new List<DataGridViewRow>();
            foreach (DataGridViewRow dataRow in datagridrecherche.SelectedRows)
            {
                lines.Add(dataRow);
                datagridrecherche.Rows.Remove(dataRow);
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            ds.RejectChanges();
        }

        private void buttonPS_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" });
            foreach (DataRow row in dt.Rows)
            {
                string nomTable = row[2].ToString();
                //MessageBox.Show(nomTable);
                if (nomTable == "tblClientsParisiens")
                {
                    string request = "DROP TABLE tblClientsParisiens";
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = request;
                    cmd.ExecuteNonQuery();
                }
            }
            OleDbCommand oleDbCommand = new OleDbCommand();
            oleDbCommand.CommandType = CommandType.StoredProcedure;
            oleDbCommand.CommandText = "rqtClientsParisiens";
            oleDbCommand.Connection = conn;
            oleDbCommand.ExecuteNonQuery();

            DataTable datatable = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM " + "tblClientsParisiens", conn);
            da.Fill(datatable);
            dgvParis.DataSource = datatable;
            conn.Close();

        }

        private void btnpsp_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" });
            foreach (DataRow row in dt.Rows)
            {
                string nomTable = row[2].ToString();
                if (nomTable == "tblClientsVilleParametree")
                {
                    string request = "DROP TABLE tblClientsVilleParametree";
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = request;
                    cmd.ExecuteNonQuery();
                }
            }
            OleDbCommand oleDbCommand = new OleDbCommand();
            oleDbCommand.CommandType = CommandType.StoredProcedure;
            oleDbCommand.CommandText = "rqtClientsVilleAuChoix";
            oleDbCommand.Parameters.AddWithValue("@ville", txtpara.Text);
            oleDbCommand.Connection = conn;
            oleDbCommand.ExecuteNonQuery();

            DataTable datatable = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM " + "tblClientsVilleParametree", conn);
            da.Fill(datatable);
            dgvParis.DataSource = datatable;
            conn.Close();
        }

        private void rtxtModif_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            DataTable changes = ds.Tables["tblVoyages"].GetChanges();
            rtxtModif.Clear();
            rtxtModif.Text += "Toute les Modification \n\n";

            foreach (DataRow row in changes.Rows)
            {
                if (row.RowState == DataRowState.Deleted)
                {
                    rtxtModif.Text += "Ligne supprimer " + row["CodeVoyage", DataRowVersion.Original].ToString() + "\n";
                }
                else if (row.RowState == DataRowState.Modified)
                {
                    rtxtModif.Text += "Ligne modifier " + row["CodeVoyage"] + "\n";
                }
            }
            {

            }
        }

        private void btnconstr_Click(object sender, EventArgs e)
        {
            ds.Tables["tblVoyages"].PrimaryKey = new DataColumn[] { ds.Tables["tblVoyages"].Columns["CodeVoyage"] };
            /*DataRelation dre = new DataRelation("VoyageReservation", ds.Tables["tblVoyages"].Columns["CodeVoyage"], ds.Tables["tblReservations"].Columns["CodeVoyage"]);
            ds.Relations.Add(dre);*/
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            DataRow dataRow = ds.Tables["tblReservations"].NewRow();
            try
            {
                dataRow["CodeVoyage"] = "VY0001";
                dataRow["NumClient"] = 5;
                dataRow["DateReservation"] = DateTime.Now;
                ds.Tables["tblReservations"].Rows.Add(dataRow);
            }
            catch
            {
                MessageBox.Show("La destnation n'existe pas");
            }
        }

        private void dbbdestmaitre_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            DataTable tblLogin = new DataTable("tblLogin");
            tblLogin.Columns.Add("NumClient", typeof(int));
            tblLogin.Columns.Add("Login", typeof(string));
            tblLogin.Columns.Add("Mdp", typeof(string));
            tblLogin.Columns.Add("Date", typeof(DateTime));
            tblLogin.PrimaryKey = new DataColumn[] { tblLogin.Columns["NumClient"] };
            if (ds.Tables.Contains("tblLogin"))
            {
                ds.Tables.Remove("tblLogin");
            }
            ds.Tables.Add(tblLogin);

            foreach (DataRow row in ds.Tables["tblClients"].Rows)
            {
                DataRow dataRow = tblLogin.NewRow();
                dataRow["NumClient"] = row["NumClient"];
                dataRow["Login"] = row["Prenom"].ToString()[0] + row["NomClient"].ToString().Substring(0, 4);
                dataRow["Mdp"] = row["Prenom"].ToString() + row["NumClient"].ToString();
                dataRow["Date"] = DateTime.Now;
                tblLogin.Rows.Add(dataRow);
            }

            dtglogin.DataSource = tblLogin;
        }

        private void btnrech_Click(object sender, EventArgs e)
        {
            if (cbbdestiationuc.SelectedIndex != -1)
            {
                CardVoyage cardVoyage = new CardVoyage();
                cardVoyage.Left = 10;
                cardVoyage.Top = 50;
                this.tabPage7.Controls.Add(cardVoyage);
                cardVoyage.Destination = cbbdestiationuc.Text;

            }
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
