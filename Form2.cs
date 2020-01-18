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

namespace WindowsFormsApplication1
{
    public partial class interfacegerant : Form
    {
        public interfacegerant()
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

        private void interfacegerant_Load(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Connexion n = new Connexion();
            n.Show();
            
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            ajouterc a = new ajouterc();
            a.Show();
            this.Close();
        }

        private void chercher_Click(object sender, EventArgs e)
        {
            Boolean mytest = false;
          //  string x = "";


            try
            {
                string connexionString = (@"Data Source=C:\Users\pc\documents\visual studio 2010\Projects\gestion_café\gestion_café\base_café.sdf");
                SqlCeConnection connexion = new SqlCeConnection(connexionString);
                connexion.Open();

                SqlCeCommand cmd2 = new SqlCeCommand("select * from caissiers where prenom=@prenom_saisie", connexion);


                string varprenom = idtxt.Text;
                cmd2.Parameters.AddWithValue("@prenom_saisie", varprenom);
                SqlCeDataReader rdr = null;
                rdr = cmd2.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr.GetString(2) == varprenom)
                    {
                        mytest = true;
                        panel1.Visible = (true);
                        verifid.Visible = (false);
                        pictureBox1.Visible = (false);



                        idntxt.Text = rdr.GetString(0);
                        nomtxt.Text = rdr.GetString(1);
                        prenomtxt.Text = rdr.GetString(2);
                        dntxt.Text = rdr.GetString(3);
                        teletxt.Text = rdr.GetString(4);
                        
                        var imgByData=(Byte[])rdr["pic"];
                        var bitmap = new Bitmap(new MemoryStream(imgByData));
                        pictureBox2.Image = bitmap;
                    }



                }

                if (mytest == false)
                {
                    panel1.Visible = (false);
                    verifid.Visible = (true);
                    verifid.Text = "Caissier Inexistant";
                    verifid.ForeColor = Color.Red;
                    verifid.Font = new Font("Arial", 9);
                    idntxt.Text = "";
                    nomtxt.Text = "";
                    prenomtxt.Text = "";
                    dntxt.Text = "";
                    teletxt.Text = "";
                    
                }



                connexion.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }


            comboBox1.Text = "Choisir un caissier";

           
        }
     

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer définitivement ce caissier ?", "effacer le caissier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string connexionString = (@"Data Source=C:\Users\pc\documents\visual studio 2010\Projects\gestion_café\gestion_café\base_café.sdf");
                    SqlCeConnection connexion = new SqlCeConnection(connexionString);
                    connexion.Open();

                    SqlCeCommand cmd4 = new SqlCeCommand("DELETE from caissiers where id=@id_eff", connexion);

                    string varid = idntxt.Text;
                    cmd4.Parameters.AddWithValue("@id_eff", varid);
                    cmd4.ExecuteNonQuery();
                    MessageBox.Show("Caissier effaceé avec succés", "effacer un caissier");
                    verifid.Text = "Compte Inexistant";
                    verifid.ForeColor = Color.Red;
                    idntxt.Text = "";
                    nomtxt.Text = "";
                    prenomtxt.Text = "";
                    dntxt.Text = "";
                    teletxt.Text = "";
                    
                    panel1.Visible = (false);
                    pictureBox1.Visible = (true);
                    idtxt.Text = "";
                    connexion.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("opération échouer", "effacer un caissier");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connexionString = (@"Data Source=C:\Users\pc\documents\visual studio 2010\Projects\gestion_café\gestion_café\base_café.sdf");
                SqlCeConnection connexion = new SqlCeConnection(connexionString);
                connexion.Open();

                SqlCeCommand cmd6 = new SqlCeCommand("select * from caissiers where prenom=@prenom_saisie", connexion);


                string varprenom = comboBox1.Text;
                cmd6.Parameters.AddWithValue("@prenom_saisie", varprenom);
                SqlCeDataReader rdr = null;
                rdr = cmd6.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr.GetString(2) == varprenom)
                    {
                        
                        panel1.Visible = (true);
                        verifid.Visible = (false);
                        pictureBox1.Visible = (false);

                        idntxt.Text = rdr.GetString(0);
                        nomtxt.Text = rdr.GetString(1);
                        prenomtxt.Text = rdr.GetString(2);
                        
                        dntxt.Text = rdr.GetString(3);
                        teletxt.Text = rdr.GetString(4);
                                              
                        var imgByData = (Byte[])rdr["pic"];
                        var bitmap = new Bitmap(new MemoryStream(imgByData));
                        pictureBox2.Image = bitmap;
                        

                    }

                }
              
                connexion.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }
            idtxt.Text = "";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            recetteint b = new recetteint();
            b.Show();
            this.Close();
        }      

    }
}
