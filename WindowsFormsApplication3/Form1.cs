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
            {  // si champ de saisie vide alors pas de traitement
                MessageBox.Show("chaine vide non permise", "oulala", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {     // si champ de saisie non vide 
                string t = this.textBox2.Text; // affecte à la chaine t le contenu du textbox2
                if (P1 == null)
                {  // si Premier Objet de la liste est null => premiere affectation uniquement
                    P1 = new Person(t, null); // création de l'objet P1 avec commme nom t (contenu du texbbox) et suivant de typePerson null
                  //  MessageBox.Show("P1 vide première affectation ");
                }
                else
                {  // si P1 pas null
                    Person PLast = Person.getLast(this.P1);  // Objet Plast  (de type Person) = objet  retourné comme étant le dernier objet (suivant null)
                    Person Pn = new Person(t, null); // création d'objet de type Person nommé Pn avec T comme nom et null comme suivant
                    PLast.suivant = Pn; // le denier objet founi par Plast prend comme suivant l'objet Pn
                }
                this.labelCom.Text = this.textBox2.Text + " a été créé";

            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();  //efface la listebox
        }

        // public Person a = new Person(null, null);

        public void AfficheList() // ajoute les noms des objets dans leur ordre de dépendance (Suivant)
        {
            bool fin = false;
            var a = this.P1; //a = objet de type Person = P1 equivalent a :  var a = P1;
            do
            {  // tant que pas fin faire
                this.listBox1.Items.Add(a.GetLeNom());   // ajoute un item à la listbox : le contenu de nom de l'objet a          
                if (a.GetSuivant() == null)
                { // si suivant = null alors FIN
                    fin = true;
                }
                else
                {// si suivant différent de  null 
                    a = a.GetSuivant(); // l'objet a prend la valeur du suivant de cet objet a (Récursivité)
                }
            }
            while (fin == false);
        }

        private void BtResultat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Affichage dans la zone liste du premier nom puis de son suivant puis de son suivant...");
            AfficheList();
        }

    }
}
