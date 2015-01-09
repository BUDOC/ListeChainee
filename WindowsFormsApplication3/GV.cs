using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{

    public class Person     // déclaration de classe
    {
        public string nom; // variable publique
        public Person suivant;
      

        public Person(string n, Person suivant) //Constructeur
            {
            nom = n;}

        public string Qui //methode de construction get et set (a la Camille)
        {
            get { return  nom; }
            set { nom= value; }         
        }

         public void SetLeNom (string LeNom) //contruction du setteur
         {
             nom = LeNom;
        }
         public void SetSuivant(Person LeSuivant) //contruction du setteur
         {
             this.suivant  = LeSuivant;
         }
         public  Person GetSuivant() //contruction du setteur
         {
            return  this.suivant;
         }
         public string GetLeNom () // Construction du getteur
         {
             return this.nom;
         }
         public static Person getLast(Person P)
         {
             bool fin = false;
             var a = P;
             do
             {
                
                 if (a.GetSuivant()== null)
                 {
                     fin = true;
                 }
                 else
                 {
                     a = a.GetSuivant();
                 }
             }
             while (fin == false);
             return a;
         }
      
    }
}
