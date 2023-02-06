using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Documents;

// Ce code initialise les objets Board, Player pour le joueur 1 et le joueur 2 lors de la création de l'objet Game.
// Les méthodes Start et End permettent de démarrer et de terminer une partie.
// Les propriétés Board, Player1 et Player2 permettent d'accéder aux objets correspondants.

namespace Bataille_Navale_2.Classes
{
    class Game
    {
        private Board board;
        private Player player1;
        private Player player2;
        private Player currentPlayer;

        public Game()
        {
            Game game = this;
            game.board = new Board();
            game.player1 = new Player();
            game.player2 = new Player();
        }

        public void Start()
        {
            // Démarrer la partie
        }

        public void End()
        {
            // Terminer la partie
        }

        public Board Board
        {
            get { return this.board; }
        }

        public Player Player1
        {
            get { return this.player1; }
            set { this.player1 = value; }
        }

        public Player Player2
        {
            get { return this.player2; }
            set { this.player2 = value; }
        }

        public Player CurrentPlayer
        {
            get { return this.currentPlayer; }
            set { this.currentPlayer = value; }
        }

        public Game(Player player1, Player player2)
        {
            this.Player1 = player1;
            this.Player2 = player2;
            this.CurrentPlayer = player1;
        }

        public void PlayTurn()
        {
            // Effectuer un tour de jeu
            if (this.CurrentPlayer is AI)
            {
                (this.CurrentPlayer as AI).PlayTurn(this.GetOpponent(this.CurrentPlayer));
            }
            else
            {
                // Demander à l'utilisateur de jouer
            }

            // Vérifier si le jeu est terminé
            if (this.IsGameOver())
            {
                // Afficher le résultat du jeu
            }
            else
            {
                // Passer au joueur suivant
                this.CurrentPlayer = this.GetOpponent(this.CurrentPlayer);
            }
        }

        private Player GetOpponent(Player player)
        {
            return player == this.Player1 ? this.Player2 : this.Player1;
        }

        private bool IsGameOver()
        {
            // Vérifier si un joueur a perdu
            return this.Player1.Lost || this.Player2.Lost;
        }
    }

}

