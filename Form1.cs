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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
            
            
        }
        public static string name_c;
        private void sortirbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void connectionbtn_Click(object sender, EventArgs e)
        {
          /*  Boolean accessg = false;
            Boolean accessc = false;
            string ss;
            try
            {
                string connexionString = (@"Data Source=C:\Users\pc\documents\visual studio 2010\Projects\gestion_café\gestion_café\base_café.sdf");
                SqlCeConnection connection = new SqlCeConnection(connexionString);
                connection.Open();

                SqlCeCommand cmd1 = new SqlCeCommand("select * from login where id=@id_log and mdp=@psw ", connection);

                string psw = mdp.Text;
                string id_log = Nom.Text;
               
                cmd1.Parameters.AddWithValue("@id_log", id_log);
                cmd1.Parameters.AddWithValue("@psw", psw);
                SqlCeDataReader rdr = null;
                rdr = cmd1.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr.GetString(0) == id_log && rdr.GetString(1) == psw)
                    {
                        string s = "gerant";
                        ss=rdr.GetString(2);
                        name_c = ss;
                        if (ss == s)

                        { accessg = true; }
                        else { accessc = true; }


                    }
                   
           


                }
                if (accessg == true)
                {
                    interfacegerant m = new interfacegerant();
                    m.Show();
                    this.SetVisibleCore(false);
                }
                else if (accessc == true)
                {
                    intcaissier n = new intcaissier();
                    n.Show();
                    
                  
                    this.SetVisibleCore(false);
                    

                }
                else
                {
                    MessageBox.Show("Connexion Echouer", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connexion n = new Connexion();
                }
                connection.Close();
            }
            catch (Exception exc) { Console.WriteLine(exc.Message); }*/
            if((mdp.Text)=="gerant"&&(Nom.Text)=="gerant")
            {
                interfacegerant m = new interfacegerant();
                m.Show();
                this.SetVisibleCore(false);
            }
            else if ((mdp.Text) == "caissier" && (Nom.Text) == "caissier") {
                intcaissier n = new intcaissier();
                n.Show();
                this.SetVisibleCore(false);
            }
            else
            {
                MessageBox.Show("Connexion Echouer", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connexion n = new Connexion();
            }
           
        }
     
    }
}
