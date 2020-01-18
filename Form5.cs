using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace WindowsFormsApplication1
{
    public partial class intcaissier : Form
    {
        public intcaissier()
        {
            InitializeComponent();
           // double pu = 0;
            resulttxt.Text = "Commande|  Quantité|  Prix Unitaire|  Prix Totale" + Environment.NewLine + Environment.NewLine;

        }
       public static double pu = 0;
       double tot = 0;
      // Boolean test;
        private void intcaissier_Load(object sender, EventArgs e)
        {
            name.Text = Connexion.name_c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            commandetxt.Text = "Café crème";
            double p1 = 2;            
            pu = p1;
            quantitetxt.Text = "";
            prixtxt.Text = "";
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double p1 = 1.1;
            pu = p1;
            commandetxt.Text = "Boissons Gazeuses";
            quantitetxt.Text = "";
            prixtxt.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double p1 = 1.5;
            pu = p1;
            commandetxt.Text = "Gâteau";
            quantitetxt.Text = "";
            prixtxt.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double p1 = 1;
            pu = p1;
            commandetxt.Text = "Capucin";
            quantitetxt.Text = "";
            prixtxt.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double p1 = 2.5;
            pu = p1;
            commandetxt.Text = "Jus de Fuits";
            quantitetxt.Text = "";
            prixtxt.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double p1 = 4;
            pu = p1;
            commandetxt.Text = "Chicha";
            quantitetxt.Text = "";
            prixtxt.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double p1 = 0.7;
            pu = p1;
            commandetxt.Text = "Thé";            
         
            quantitetxt.Text = "";
            prixtxt.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double p1 = 1;
            pu = p1;
            commandetxt.Text = "Eau en bouteille";
            quantitetxt.Text = "";
            prixtxt.Text = "";
        }

        private void quantitetxt_TextChanged(object sender, EventArgs e)
        {
        }
      
        private void button9_Click(object sender, EventArgs e)
        {

            double quant = Convert.ToDouble(quantitetxt.Text);
            double t = quant * pu;
            tot = tot + t;
            prixtxt.Text = Convert.ToString(t);
            tottxt.Text = Convert.ToString(tot);

            resulttxt.Text = resulttxt.Text + commandetxt.Text + "/  " + quantitetxt.Text + "/   " + (pu.ToString() + "/  " + prixtxt.Text + Environment.NewLine);
           

            
             /* try
              {
                  string connexionnString = (@"Data Source=C:\Users\pc\documents\visual studio 2010\Projects\gestion_café\gestion_café\base_café.sdf");
                  SqlCeConnection connexion = new SqlCeConnection(connexionnString);
                  connexion.Open();

                  SqlCeCommand cmd8 = new SqlCeCommand("select * from recette where Caissier=@prenom_saisie AND  date=@dt AND  Produit=@prod", connexion);


                  string varprenom = name.Text;
                  string varprod = commandetxt.Text;
                  DateTime dt = DateTime.Parse(dateTimePicker1.Text);
                  cmd8.Parameters.AddWithValue("@prenom_saisie", varprenom);
                  cmd8.Parameters.AddWithValue("@dt", dt);
                  cmd8.Parameters.AddWithValue("@prod",varprod);
                  SqlCeDataReader rdr = null;
                  rdr = cmd8.ExecuteReader();                                   
                  while (rdr.Read())
                  {

                      if ((rdr.GetInt32(2)) >= 1)
                      {
                          test = true;
                          MessageBox.Show("test= true", "test");
                          
                      }
                      else {
                          test = false;
                         
                      }
                  }
                 
                  
                 
                  rdr.Close();
                  connexion.Close();
            // MessageBox.Show("fail", "test");

              }
              catch (Exception ex)
              {
                  Console.WriteLine(ex.Message);
                  MessageBox.Show("Opération 1 échouer", "Opération échouer");

              }*/
             // if (test == false)
             // {
                 try
                  {
                      string connexionnString = (@"Data Source=C:\Users\pc\documents\visual studio 2010\Projects\gestion_café\gestion_café\base_café.sdf");
                      SqlCeConnection connexion2 = new SqlCeConnection(connexionnString);
                      connexion2.Open();
                      SqlCeCommand cmde = new SqlCeCommand("INSERT INTO recette  VALUES (@nom_p,@com,@qte,@prix_u,@prix_t,@mydate)", connexion2);
                      cmde.Parameters.AddWithValue("@nom_p", name.Text);
                      cmde.Parameters.AddWithValue("@com", commandetxt.Text);
                      //int varqte = Int32.Parse(quantitetxt.Text);
                      cmde.Parameters.AddWithValue("@qte", quantitetxt.Text);
                     // double varpu = Convert.ToDouble(pu);
                      cmde.Parameters.AddWithValue("@prix_u", pu.ToString());

                     // double varpt = Convert.ToDouble(prixtxt.Text);

                      cmde.Parameters.AddWithValue("@prix_t", prixtxt.Text);

                      cmde.Parameters.AddWithValue("@mydate", (dateTimePicker1.Text).ToString());

                     // MessageBox.Show("fail execusion", "test");
                      int x = cmde.ExecuteNonQuery();
                      
                      connexion2.Close();


                  }
                  catch (Exception ex)
                  {
                      Console.WriteLine(ex.Message);
                      MessageBox.Show("Opération  échouer", "Opération échouer");
                  }
              
            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            tottxt.Text = "";
            tot = 0;
            prixtxt.Text = "";
            quantitetxt.Text = "";
            commandetxt.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
            Connexion n = new Connexion();
            n.Show();
        }
    }
}
