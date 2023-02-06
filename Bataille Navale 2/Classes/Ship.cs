using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ce code définit une classe Ship avec une taille spécifiée.
// La méthode SetPosition permet de définir la position et la direction du navire sur le plateau de jeu,
// tandis que la méthode Sink marque le navire comme étant coulé.
// Les propriétés Size, X, Y, Direction et IsSunk permettent
// d'accéder à la taille, à la position en x, à la position en y, à la direction et à l'état de coulage du navire respectivement.

namespace Bataille_Navale_2.Classes
{
    class Ship
    {
        private int size;
        private int x;
        private int y;
        private int direction;
        private bool isSunk;
        public int Row { get; set; }
        public int Col { get; set; }
        public int Length { get; set; }
        public bool IsHorizontal { get; set; }

        public Ship(int length)
        {
            Length = length;
            isSunk = false;
        }
        public int X
        {
            get { return this.x; }
        }
        public int Y
        {
            get { return this.y; }
        }
        public int Direction
        {
            get { return this.direction; }
        }
        public bool IsSunk
        {
            get { return this.isSunk; }
        }
        public void Place(int row, int col, bool isHorizontal)
        {
            Row = row;
            Col = col;
            IsHorizontal = isHorizontal;
        }

        public void SetPosition(int x, int y, int direction)
        {
            // Définir la position et la direction du navire
        }

        public void Sink()
        {
            // Marquer le navire comme coulé
            this.isSunk = true;
        }
        public bool IsAtLocation(int row, int col)
        {
            if (IsHorizontal)
            {
                return (Row == row) && (Col <= col) && (Col + Length > col);
            }
            else
            {
                return (Col == col) && (Row <= row) && (Row + Length > row);
            }
        }

        public void Shoot()
        {
            Length--;
            if (Length == 0)
            {
                isSunk = true;
            }
        }
        public int Size
        {
            get { return this.size; }
        }
     } 
}
