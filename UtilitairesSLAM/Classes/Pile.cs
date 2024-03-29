using System;
using System.Collections.Generic;

namespace MesOutils
{
    /// <summary>
    /// Pile contenant pouvant contenir des entiers.
    /// On ajoute après le dernier élément ajouté
    /// On retire toujours le dernier élément ajouté
    /// </summary>
    class Pile<T>
    {
        /// <summary>
        /// Nombre maximum d'élements de la Pile
        /// </summary>
        //private int nbMaxElt;

        /// <summary>
        /// Liste contenant les éléments de la pile
        /// </summary>
        private List<T> elements;

        public Pile()
        {
            //this.nbMaxElt = nbMaxElt;
            this.elements = new List<T>();
        }


        //public bool PilePleine()
        //{
        //    return (this.nbMaxElt == this.elements.Count);
        //}

        public bool PileVide()
        {
            return this.elements.Count == 0;
        }

        public void Empiler(T valeur)
        {
            //if (!PilePleine())
            //{
            this.elements.Add(valeur);
            //}
            //else
            //{
            //    throw new Exception("Pile pleine, impossible d'empiler un élément");
            //}
        }

        public T Depiler()
        {
            if (PileVide())
            {
                throw new Exception("Impossible de Dépiler , la pile est déjà vide");
            }
            else
            {


                T valeurDepilee = this.elements[this.elements.Count - 1];

                this.elements.RemoveAt(this.elements.Count - 1);

                return valeurDepilee;
            }



        }

        /// <summary>
        /// Obtient le nombre d'éléments actuellement présents dans la Pile
        /// </summary>
        public int Count { get => this.elements.Count; }

    }
}