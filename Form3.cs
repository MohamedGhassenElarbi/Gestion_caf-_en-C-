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
    public partial class ajouterc : Form
    {
        public ajouterc()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            interfacegerant m = new interfacegerant();
            m.Show();
            this.Close();
        }
        private void ajphoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Image img = Image.FromFile(openFileDialog1.FileName);
            var imgMemoryStream = new MemoryStream();
            img.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] imgByData = imgMemoryStream.GetBuffer();
            try
             {
                 string connexionString = (@"Data Source=C:\Users\pc\documents\visual studio 2010\Projects\gestion_café\gestion_café\base_café.sdf");
                 SqlCeConnection connexion1 = new SqlCeConnection(connexionString);
                 connexion1.Open();



                 SqlCeCommand cmd9 = new SqlCeCommand("INSERT INTO caissiers(id,pic) VALUES(@id,@aj_pic)", connexion1);
                 cmd9.Parameters.AddWithValue("@id", ajidtxt.Text);
                 cmd9.Parameters.AddWithValue("@aj_pic", SqlDbType.Image).Value = imgByData;

                 int x = cmd9.ExecuteNonQuery();
                 MessageBox.Show("Image ajoutée avec succés", "Ajout d'un Nouveau image");
                 connexion1.Close();
               
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);
                 MessageBox.Show("Ajout d'une image échouer", "Ajout d'une image échouer");
             }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ajidtxt.Text == "" || ajnomtxt.Text == "" || ajprenomtxt.Text == "" || ajteltxt.Text == "" || ajdntxt.Text == "")
            {
                MessageBox.Show("Veillez remplir tout les champs" , "Ajout d'un Nouveau Caissier");
            }
            else
            {
                try
                {
                    string connexionString = (@"Data Source=C:\Users\pc\documents\visual studio 2010\Projects\gestion_café\gestion_café\base_café.sdf");
                    SqlCeConnection connexion1 = new SqlCeConnection(connexionString);
                    connexion1.Open();



                    SqlCeCommand cmd3 = new SqlCeCommand("UPDATE [caissiers] SET nom=@nom,prenom=@prenom,date_naissance=@date,tel=@tel where id=@id" /*"INSERT INTO caissiers(id,nom,prenom,date_naissance,tel,url) VALUES(@id,@nom,@prenom,@date,@tel,@url)"*/, connexion1);
                    cmd3.Parameters.AddWithValue("@id", ajidtxt.Text);
                    cmd3.Parameters.AddWithValue("@nom", ajnomtxt.Text);
                    cmd3.Parameters.AddWithValue("@prenom", ajprenomtxt.Text);
                    cmd3.Parameters.AddWithValue("@date", ajdntxt.Text);
                    cmd3.Parameters.AddWithValue("@tel", ajteltxt.Text);
                   
                  
                    int x = cmd3.ExecuteNonQuery();
                    MessageBox.Show("Caissier ajoutée avec succés", "Ajout d'un Nouveau Caissier");
                    connexion1.Close();
                    interfacegerant me = new interfacegerant();
                    me.Show();
                    this.SetVisibleCore(false);


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Ajout d'un nouveau Caissier échouer", "Ajout d'un nouveau Caissier");
                }

            }
        }

       
    }
}
