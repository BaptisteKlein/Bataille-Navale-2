using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ce code initialise un plateau de jeu 10x10 en utilisant un tableau 2D grid.
// La méthode PlaceShip permet de placer un navire sur le plateau de jeu,
// tandis que la méthode Attack permet de simuler une attaque sur les coordonnées spécifiées.
// Les propriétés Grid et GridSize permettent d'accéder à la grille du plateau de jeu et à sa taille respectivement.

namespace Bataille_Navale_2.Classes
{
    class Board
    {
        private int[,] board;
        private const int BOARD_SIZE = 10;

        public int[,] Grid
        {
            get { return this.board; }
            set { this.board = value; }
        }

        public Board()
        {
            this.board = new int[BOARD_SIZE, BOARD_SIZE];

            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    this.board[i, j] = 0;
                }
            }
        }

        public bool Attack(int x, int y)
        {
            // Effectuer une attaque sur une case spécifiée
            // et retourner true si une attaque a réussi
            return true;
        }

        public bool PlaceShip(int x, int y, int size, bool horizontal)
        {
            // Placer un navire sur une case spécifiée
            // et retourner true si le placement a réussi
            return true;
        }
    }


}
