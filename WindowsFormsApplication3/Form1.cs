using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Person P1 = null;  //déclaration initialisation de l'objet

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(P1.GetLeNom());  // affiche le nom par la méthode getlenom
        }


        private void BtAffecte_Click(object sender, EventArgs e)  // CREATION AFFECTATION DE LA PERSONNE
        {
            if (this.textBox2.Text == "")
            {
                MessageBox.Show("chaine vide non permise", "oulala", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //P1.SetLeNom("DEBUT");
                // P1.SetSuivant(null)
            }
            else
            {
                string t = this.textBox2.Text;
                if (P1 == null)
                {
                    P1 = new Person(t, null);
                    MessageBox.Show("P1 vide");                   
                }
                else
                {
                    Person PLast = Person.getLast(this.P1);
                    Person Pn = new Person(t, null);
                    PLast.suivant = Pn;
                }
            }
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

        }

        // public Person a = new Person(null, null);

        public void AfficheList()
        {
            bool fin = false;
            var a = this.P1;
            MessageBox.Show(a.GetLeNom());
            do
            {
                 this.listBox1.Items.Add(a.GetLeNom());            
                MessageBox.Show(a.GetLeNom());
                if (a.GetSuivant() == null)
                {
                    fin = true;
                }
                else
                {
                    a = a.GetSuivant();
                }
            }
            while (fin == false);
        }

        private void BtResultat_Click(object sender, EventArgs e)
        {
            AfficheList();
        }

    }
}
