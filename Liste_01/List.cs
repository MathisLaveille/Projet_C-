using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste_01
{
    internal class List
    {
        Cell head;     // pointeur vers la première cellule de la liste
        Cell tail;      // pointeur vers la dernière cellule de la liste
        public List()   // créer une liste vide
        {
            this.head = null;     // Pas de première cellule de la liste
            this.tail = null;     // Pas de dernière cellule de la liste
        }
        public void add(int x)       //--- ajouter un élément en queue de liste
        {
            Cell aux = new Cell();   // 1
            aux.value = x;

            if (this.head == null)
            {   //--- Cas particulier : liste vide
                this.head = aux;
                this.tail = aux;
            }
            else
            {   //--- Cas général
                this.tail.next = aux;    // 2
                this.tail = aux;         // 3
            }
        }
        public void push(int x)      //--- ajouter un élément en tête de liste
        {
            Cell aux = new Cell();   // 1
            aux.value = x;
            aux.next = this.head;    // 2
            this.head = aux;         // 3
            if (this.tail == null)   // Si c'était un liste vide
                this.tail = aux;     // Mise à jour de la queue
        }
        public int pop()             //--- retirer de la tête de liste
        {
            if (this.head == null) return -1;  // cas d'erreur liste vide !

            int val = this.head.value;   // 1
            this.head = this.head.next;  // 2
            if (this.head == null)       // cas particulier liste à 1 élement
                this.tail = null;
            return val;
        }

        public int getNbr()         //--- renvoyer le nombre d'élements
        {
            if (this.head == null) return 0;

            int nbr = 0;
            Cell pointeur = this.head;
            while (pointeur != null)   
            {
                nbr++;
                pointeur = pointeur.next;      // passer à la cellule suivante
            }
            return nbr;  
        }

        public int getEle(int n)    //--- renvoyer le n' élement
        {
            if (n < 0) return 9999;
            if (this.head == null) return 9999;

            Cell cpt = this.head;  
            int index = 0;          
            while (cpt != null)     
            {
                if (index == n)    
                {
                    return cpt.value;   
                }
                index++;
                cpt = cpt.next;     
            }
            return 9999;
        }

        public void write()
        {
            Console.Write("(");
            Cell aux = this.head;

            while (aux != null)
            {
                Console.Write("" + aux.value + " ");
                aux = aux.next;      // passer à la cellule suivante
            }
            Console.WriteLine(")");
        }

    }
    internal class Cell
    {
        public int value;
        public Cell next;
    }
    internal class Array    // tableau de 10 entiers maximum
    {
        private int[] values;     // tableau des valeurs
        private int nbr;     // nbr de valeurs dans le tableau
        public Array()   // créer une tableau vide
        {
            this.values = new int[100];  // 10 entiers maxi 
            this.nbr = 0;               // vide au départ
            for (int i = 0; i < 100; i++)
                this.values[i] = 9999;      // toutes les cases
        }
        public void add(int x)       //--- ajouter un élément en queue de liste
        {
            if (this.nbr >= 100) return; // PB !
            this.values[this.nbr] = x;
            this.nbr++;
        }
        public void push(int x)      //--- ajouter un élément en tête de liste
        {
            if (this.nbr >= 100) return; // PB !

            for (int i = this.nbr; i > 0; i--)  // décalage du tableau
                this.values[i] = this.values[i - 1];

            this.values[0] = x;
            this.nbr++;
        }
        public int pop()             //--- retirer de la tête de liste
        {
            return -1;
        }
        public int getNbr()          //--- renvoyer le nombre d'élements
        {
            return this.nbr;
        }
        public int getEle(int n)     //--- renvoyer le n' élement
        {
            if (n >= this.nbr) return 9999; // PB
            return this.values[n];
        }

        public void write()
        {
            Console.Write("[");
            for (int i = 0; i < this.nbr; i++)
                Console.Write(this.values[i] + " ");
            Console.WriteLine("]");
        }
    }

}
