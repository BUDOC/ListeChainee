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
      

        public Person(string n, Person suivant) //Constructeur Person = objet ( texte, Objet de type Person)
            {
                nom = n;                            // affectation de la variable publique "nom" avec le Texte passé en argument
            }

        public string Qui //methode de construction get et set (à la Camille)
        {
            get { return  nom; }
            set { nom= value; }         
        }

         public void SetLeNom (string LeNom) //contruction du setteur
         {
             nom = LeNom; // affectation de la variable publique "nom" avec le Texte passé "LeNom" en argument
            }        
         public void SetSuivant(Person LeSuivant) //contruction du setteur
         {
             this.suivant = LeSuivant; // affectation du suivant (ojet) à l'objet courant de type Person 
         }
         public  Person GetSuivant() //contruction du setteur
         {
            return  this.suivant; // retourne le suivant (type objet Person) de l'objet de type Person courant
         }
         public string GetLeNom () // Construction du getteur
         {
             return this.nom; // retourne le nom (Texte) de l'objet de type Person courant
         }
         public static Person getLast(Person P)  // retourne le suivant d'un objet de type Person Passé en argument P
         {
             bool fin = false;
             var a = P; // obet a = objet P passé en paramètre
             do
             {                
                 if (a.GetSuivant()== null)  // si  l'objet A n'a pas de suivant
                 {
                     fin = true;            // Fin
                 }
                 else
                 {                           // si  l'objet A a un suivant
                     a = a.GetSuivant();    // l'objet A prend la valeur du suivant de ce même A
                 }
             }
             while (fin == false);
             return a;                      // retourne l'Objet A
         }
      
    }
}
