using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ce code définit une classe Player avec un nom spécifié.
// La méthode PlaceShips permet de placer les navires sur le plateau de jeu du joueur,
// tandis que la méthode Attack permet de simuler une attaque sur l'adversaire.
// Les propriétés Name et Board permettent d'accéder au nom du joueur et à son plateau de jeu respectivement.

namespace Bataille_Navale_2.Classes
{
    class Player
    {
        private string name;
        private Board board;
        private bool lost;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Board Board
        {
            get { return this.board; }
            set { this.board = value; }
        }

        public bool Lost
        {
            get { return this.lost; }
            set { this.lost = value; }
        }

        public Player(string name)
        {
            this.Name = name;
            this.Board = new Board();
            this.Lost = false;
        }

        public void PlaceShips()
        {
            // Placer les navires sur le tableau
        }

        public bool Attack(int x, int y)
        {
            // Effectuer une attaque sur une case spécifiée
            // et retourner true si une attaque a réussi
            return this.Board.Attack(x, y);
        }
    }


}
