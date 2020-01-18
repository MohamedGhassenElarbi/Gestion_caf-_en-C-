using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
using System.Drawing.Printing;

namespace WindowsFormsApplication1
{
    public partial class recetteint : Form
    {
        public recetteint()
        {
            InitializeComponent();
            try
            {
                string connexionString = (@"Data Source=C:\Users\pc\documents\visual studio 2010\Projects\gestion_café\gestion_café\base_café.sdf");
                SqlCeConnection connexion = new SqlCeConnection(connexionString);
                connexion.Open();

                SqlCeCommand cmd5 = new SqlCeCommand("select prenom from caissiers;", connexion);

                SqlCeDataReader rdr = null;
                rdr = cmd5.ExecuteReader();


                while (rdr.Read())
                {

                    comboBox1.Items.Add((rdr[0].ToString()));



                }
                rdr.Close();
                connexion.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void recetteint_Load(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("fail execusion", "test");
            DataTable table1 = new DataTable();
            
            table1.Columns.Add("Caissier", typeof(string));
            table1.Columns.Add("Produit", typeof(string));
            table1.Columns.Add("Qantité", typeof(string));
            table1.Columns.Add("Prix_unitaire", typeof(string));
            table1.Columns.Add("Prix_total", typeof(string));
            //table.Columns.Add("Date", typeof(DateTime));
            dataGridView1.DataSource = table1;
            
            try
            {

                string connexionString = (@"Data Source=C:\Users\pc\documents\visual studio 2010\Projects\gestion_café\gestion_café\base_café.sdf");
                SqlCeConnection connexion = new SqlCeConnection(connexionString);
                connexion.Open();

                SqlCeCommand cmd8 = new SqlCeCommand("select * from recette where caissier=@prenom_saisie AND  date=@dt", connexion);


                string varprenom = comboBox1.Text;
               // DateTime dt =  DateTime.Parse(dateTimePicker1.Text);
                cmd8.Parameters.AddWithValue("@prenom_saisie", varprenom);
                cmd8.Parameters.AddWithValue("@dt", dateTimePicker1.Text);
                SqlCeDataReader rdr = null;
                rdr = cmd8.ExecuteReader();
                table1.Columns.Add("Caissier", typeof(string));
                table1.Columns.Add("Produit", typeof(string));
                table1.Columns.Add("Qantité", typeof(string));
                table1.Columns.Add("Prix_unitaire", typeof(string));
                table1.Columns.Add("Prix_total", typeof(string));
                while (rdr.Read())
                {
                   
                   string a = rdr.GetString(0);
                    string b =rdr.GetString(1);
                    string c = rdr.GetString(2);
                    string d = rdr.GetString(3);
                    string f = rdr.GetString(4);
                   // MessageBox.Show("fail execusion", "test");
                    table1.Rows.Add(a,b,c,d,f);
                    dataGridView1.DataSource = table1;

                }
                rdr.Close();
                connexion.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            interfacegerant m = new interfacegerant();
            m.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*StreamWriter fichier = new StreamWriter("@c:\\IHM\\Recette.txt");
            PrintDocument document = new PrintDocument();
            document.Print();*/
        }
    }
}
