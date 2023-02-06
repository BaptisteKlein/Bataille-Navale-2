using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ce code définit une classe AI qui hérite de la classe Player avec un nom spécifié.
// La méthode PlayTurn permet de simuler le tour de jeu de l'IA en attaquant l'adversaire.
// La propriété Name est héritée de la classe Player pour accéder au nom de l'IA.
// La propriété Board est également héritée pour accéder au plateau de jeu de l'IA.

namespace Bataille_Navale.Assets
{
    class AI
    {
        private Board board;
        private Random random;

        public AI(Board board)
        {
            this.board = board;
            random = new Random();
        }

        public void PlaceShips()
        {
            foreach (Ship ship in board.Ships)
            {
                bool isHorizontal = random.Next(2) == 0;
                int row = random.Next(board.Rows);
                int col = random.Next(board.Cols);
                if (isHorizontal)
                {
                    col = random.Next(board.Cols - ship.Length + 1);
                }
                else
                {
                    row = random.Next(board.Rows - ship.Length + 1);
                }
                ship.Place(row, col, isHorizontal);
            }
        }

        public void MakeMove()
        {
            int row = random.Next(board.Rows);
            int col = random.Next(board.Cols);
            board.Shoot(row, col);
        }
    }
}
