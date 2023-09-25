// Miguel Rodríguez Gallego
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFinal2_MiguelRodriguezGallego
{
    public partial class BlackJack : Form
    {
        private Player p1 = new Player      ("", 100, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        private Player p2 = new Player      ("", 100, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

        private Banking bank = new Banking  (20, 0);

        private Deck deck = new Deck();
        private int[] cardArrayPlayers = new int[11];

        // Para hacer los turnos de los jugadores
        int activePlayer = 1;
        // Carta q coge el jugador de la mesa
        int pickedCard;
        // Puntos necesarios para ganar (lo pongo en una variable para modificarlo con los modificadores "Muutus")
        int pointsLimit21 = 21;

        public BlackJack()
        {
            p1.coin = 5;
            p2.coin = 5;
            InitializeComponent();
            lblCardsOnTable.Text = deck.NumCards.ToString();
            RefreshStatistics();

            panelMuutusP2.Visible = false;
            panelTotalCards1P2.Visible = false;
            panelBetP2.Visible = false;

            panelMuutusP1.Visible = true;
            panelTotalCards1P1.Visible = true;
            panelBetP1.Visible = true;
        }

        // Método para ir actualizando las estadísticas de los jugadores durante la partida
        private void RefreshStatistics()
        {
            lblNamePlayer1.Text = p1.name;
            lblNamePlayer2.Text = p2.name;

            // Vida, daño y escudo d ambos jugadores
            if (p1.health > 0){ pbPlayer1.Value = p1.health;    lblDamagePlayer1.Text = p1.damage.ToString();   lblShieldPlayer1.Text = p1.shield.ToString();   }
            if (p2.health > 0){ pbPlayer2.Value = p2.health;    lblDamagePlayer2.Text = p2.damage.ToString();   lblShieldPlayer2.Text = p2.shield.ToString();   }

            // Muestro por pantalla d quien es el turno
            if (activePlayer == 1)      {   lblTurn.Text = p1.name; }
            if (activePlayer == 2)      {   lblTurn.Text = p2.name; }

            // Doy info por pantalla ==> cambio del límite d puntos d victoria necesarios para ganar
            lblVPL.Text = pointsLimit21.ToString();

            // Puntos totales d ambos
            lblTotalPointsP1.Text = p1.totalPoints.ToString();
            lblTotalPointsP2.Text = p2.totalPoints.ToString();

            // Nº d modificadores Player 1
            lblMuutus1P1.Text = p1.rb10Damage.ToString();
            lblMuutus2P1.Text = p1.rb10Shield.ToString();
            lblMuutus3P1.Text = p1.returnLastCard.ToString();
            lblMuutus4P1.Text = p1.rbLimit24.ToString();
            lblMuutus5P1.Text = p1.rbLimit27.ToString();
            lblMuutus6P1.Text = p1.rbCardNumMinus2.ToString();
            // ... Player 2
            lblMuutus1P2.Text = p2.rb10Damage.ToString();
            lblMuutus2P2.Text = p2.rb10Shield.ToString();
            lblMuutus3P2.Text = p2.returnLastCard.ToString();
            lblMuutus4P2.Text = p2.rbLimit24.ToString();
            lblMuutus5P2.Text = p2.rbLimit27.ToString();
            lblMuutus6P2.Text = p2.rbCardNumMinus2.ToString();

            lblCoinsP1.Text = p1.coin.ToString();
            lblCoinsP2.Text = p2.coin.ToString();

            lblBankCoins.Text = bank.coin.ToString();

            // Reviso si algun jugador tiene un as y pasa d 21 para cambiar su valor d 11 ==> 1
            if (p1.ace == 1 && p1.totalPoints > pointsLimit21)      {   p1.totalPoints -= 10;   p1.ace--;   }
            if (p2.ace == 1 && p2.totalPoints > pointsLimit21)      {   p2.totalPoints -= 10;   p2.ace--;   }

            lblBetP1.Text = p1.bet.ToString();
            lblBetP2.Text = p2.bet.ToString();
        }
        private void RefillPlayersArray()
        {
            cardArrayPlayers[0] = 0;
            cardArrayPlayers[1] = 0;
            cardArrayPlayers[2] = 0;
            cardArrayPlayers[3] = 0;
            cardArrayPlayers[4] = 0;
            cardArrayPlayers[5] = 0;
            cardArrayPlayers[6] = 0;
            cardArrayPlayers[7] = 0;
            cardArrayPlayers[8] = 0;
            cardArrayPlayers[9] = 0;
            cardArrayPlayers[10] = 0;
        }
        private void RestartRound()
        {
            CheckVictory();
            RefreshStatistics();
            // Cartas sobre la mesa
            deck.NumCards = 11;
            lblCardsOnTable.Text = deck.NumCards.ToString();
            // Repongo los valores los arrays de cartas de los jugadores
            RefillPlayersArray();
            iDC = 0;
            jDC = 0;
            p1.totalPoints = 0;
            lblTotalPointsP1.Text = p1.totalPoints.ToString();
            p2.totalPoints = 0;
            lblTotalPointsP2.Text = p2.totalPoints.ToString();

            // Reinicio el límite d puntos d victoria por si se modificaron con un modificador "Muutus".
            pointsLimit21 = 21;
            // Doy info por pantalla del cambio d límite d puntos d victoria
            lblVPL.Text = pointsLimit21.ToString();

            // Reinicio "lbl" cartas "Player1"
            lblCard1Player1.Text = ".";
            lblCard2Player1.Text = ".";
            lblCard3Player1.Text = ".";
            lblCard4Player1.Text = ".";
            lblCard5Player1.Text = ".";
            lblCard6Player1.Text = ".";
            // ... "Player2"
            lblCard1Player2.Text = ".";
            lblCard2Player2.Text = ".";
            lblCard3Player2.Text = ".";
            lblCard4Player2.Text = ".";
            lblCard5Player2.Text = ".";
            lblCard6Player2.Text = ".";

            // Reinicio la cantidad de ases q tiene cada jugador
            p1.ace = 0;
            p2.ace = 0;

            // Reinicio la variable de pasar turno
            PT = 0;
        }

        // Índice d "Player1" para mostrar sus cartas por pantalla conforme avanzan los turnos
        int iDC = 0;
        // Índice d "Player2"...
        int jDC = 0;
        // El método se llama "deleteCard" pero no elimina la carta, la copia al "arrayPlayers" para q en la 
        //  excepción d "btnPickCard_Click_1" no la pueda volver a coger al ya existir en ese array.
        private void DeleteCard(int pickedCard)
        {
            // Meto el valor en el "arrayPlayers" para comprobar si se repite y evitarlo a la hora d coger cartas
            cardArrayPlayers[pickedCard - 1] = pickedCard;

            // Mostrar cartas cuando sea el turno de "Player1"
            if (activePlayer == 1)
            {
                // Mostrar carta 1 del "Player1" por pantalla
                if (iDC == 0)   {   lblCard1Player1.Text = pickedCard.ToString();   }
                // Carta 2
                if (iDC == 1)   {   lblCard2Player1.Text = pickedCard.ToString();   }
                // Carta 3...
                if (iDC == 2)   {   lblCard3Player1.Text = pickedCard.ToString();   }
                if (iDC == 3)   {   lblCard4Player1.Text = pickedCard.ToString();   }
                if (iDC == 4)   {   lblCard5Player1.Text = pickedCard.ToString();   }
                if (iDC == 5)   {   lblCard6Player1.Text = pickedCard.ToString();   }
                if (iDC == 6)   {   lblCard7Player1.Text = pickedCard.ToString();   }
                if (iDC == 7)   {   lblCard8Player1.Text = pickedCard.ToString();   }
                if (iDC == 8)   {   lblCard9Player1.Text = pickedCard.ToString();   }
                if (iDC == 9)   {   lblCard10Player1.Text = pickedCard.ToString();  }
                if (iDC == 10)  {   lblCard11Player1.Text = pickedCard.ToString();  }
                // Índice i en Delete
                iDC++;

                // Sumo al total de puntos del "Player1" el valor de la carta cogida
                //  Si es un as sumo directamente 11 y tmb sumo 1 a la variable q detectará si el usuario se pasa d puntos a final d ronda para q valga 1
                if (pickedCard == 1)    {   p1.totalPoints += 11;  p1.ace++;   }
                // Si no es "as" sumo su valor directo
                else                    {   p1.totalPoints += pickedCard;   }

                // Paso turno a "Player2"
                activePlayer = 2;
            }
            // ... cuando "Player2"
            else
            {
                if  (jDC == 0)   {  lblCard1Player2.Text = pickedCard.ToString();   }
                if  (jDC == 1)   {  lblCard2Player2.Text = pickedCard.ToString();   }
                if  (jDC == 2)   {  lblCard3Player2.Text = pickedCard.ToString();   }
                if  (jDC == 3)   {  lblCard4Player2.Text = pickedCard.ToString();   }
                if  (jDC == 4)   {  lblCard5Player2.Text = pickedCard.ToString();   }
                if  (jDC == 5)   {  lblCard6Player2.Text = pickedCard.ToString();   }
                if  (jDC == 6)   {  lblCard7Player2.Text = pickedCard.ToString();   }
                if  (jDC == 7)   {  lblCard8Player2.Text = pickedCard.ToString();   }
                if  (jDC == 8)   {  lblCard9Player2.Text = pickedCard.ToString();   }
                if  (jDC == 9)   {  lblCard10Player2.Text = pickedCard.ToString();  }
                if  (jDC == 10)  {  lblCard11Player2.Text = pickedCard.ToString();  }
                // Índice j 
                jDC++;

                // Sumo al total de puntos del "Player2" el valor de la carta cogida
                //  Si es un as sumo directamente 11 y tmb sumo 1 a la variable q detectará si el usuario se pasa d puntos a final d ronda para q valga 1
                if  (pickedCard == 1)   {   p2.totalPoints += 11;   p2.ace++;  }
                // Si no es "as" sumo su valor directo
                else                    {   p2.totalPoints += pickedCard;   }

                // Paso turno
                activePlayer = 1;
            }
            // Doy info al usuario d las cartas q hay en la mesa con la instancia del objeto "deck"/baraja. Esto no toca la lista
            deck.NumCards -= 1;
            lblCardsOnTable.Text = deck.NumCards.ToString();

            RefreshStatistics();
        }
        private void ReturnLastCardMuutus(int pickedCard)
        {
            // Mostrar cartas cuando sea el turno de "Player1"
            if (activePlayer == 1)
            {
                // Elimino el valor en el "arrayPlayers" para q no se repita y poder volver a cogerlo 
                cardArrayPlayers[p1.lastCard - 1] -= p1.lastCard;

                // Mostrar carta 1 del "Player1" por pantalla
                if  (iDC == 1)      {   lblCard1Player1.Text = ".";     }
                // Carta 2
                if  (iDC == 2)      {   lblCard2Player1.Text = ".";     }
                // Carta 3
                if  (iDC == 3)      {   lblCard3Player1.Text = ".";     }
                if  (iDC == 4)      {   lblCard4Player1.Text = ".";     }
                if  (iDC == 5)      {   lblCard5Player1.Text = ".";     }
                if  (iDC == 6)      {   lblCard6Player1.Text = ".";     }
                if  (iDC == 7)      {   lblCard7Player1.Text = ".";     }
                if  (iDC == 8)      {   lblCard8Player1.Text = ".";     }
                if  (iDC == 9)      {   lblCard9Player1.Text = ".";     }
                if  (iDC == 10)     {   lblCard10Player1.Text = ".";    }
                if  (iDC == 11)     {   lblCard11Player1.Text = ".";    }
                // Rebajo el índice para que no se me salga de los límites establecidos de cartas sobre la mesa
                iDC--;

                // Resto al total de puntos del "Player1" el valor de la carta devuelta
                if (p1.lastCard == 1)   {   p1.totalPoints -= 11;   p1.ace--;   }
                else                    {   p1.totalPoints -= p1.lastCard;      }      
            }
            // ... cuando "Player2"
            else
            {
                cardArrayPlayers[p2.lastCard - 1] -= p2.lastCard;

                // Mostrar carta 1 del "Player2" por pantalla
                if  (jDC == 1)      {   lblCard1Player2.Text = ".";     }
                // Carta 2
                if  (jDC == 2)      {   lblCard2Player2.Text = ".";     }
                // Carta 3
                if  (jDC == 3)      {   lblCard3Player2.Text = ".";     }
                if  (jDC == 4)      {   lblCard4Player2.Text = ".";     }
                if  (jDC == 5)      {   lblCard5Player2.Text = ".";     }
                if  (jDC == 6)      {   lblCard6Player2.Text = ".";     }
                if  (jDC == 7)      {   lblCard7Player2.Text = ".";     }
                if  (jDC == 8)      {   lblCard8Player2.Text = ".";     }
                if  (jDC == 9)      {   lblCard9Player2.Text = ".";     }
                if  (jDC == 10)     {   lblCard10Player2.Text = ".";    }
                if  (jDC == 11)     {   lblCard11Player2.Text = ".";    }
                // Rebajo el índice para que no se me salga de los límites establecidos de cartas sobre la mesa
                jDC--;

                // Resto al total de puntos del "Player1" el valor de la carta devuelta
                if  (p2.lastCard == 1)  {   p2.totalPoints -= 11;   p2.ace--;   }
                else                    {   p2.totalPoints -= p2.lastCard;      }
            }

            // Doy info al usuario d las cartas q hay en la mesa con la instancia del objeto "deck"/baraja. Esto no toca la lista
            deck.NumCards += 1;
            lblCardsOnTable.Text = deck.NumCards.ToString();

            RefreshStatistics();
        }

        private void CheckVictory()
        {
            // Actualizo datos por si algun jugador tiene un as y pasó d 21 para q le cuente como 1.
            RefreshStatistics();
            int roundWin = Banking.CheckWhoWins(pointsLimit21, p1.totalPoints, p2.totalPoints);

            // Si ambos se pasan de 21
            if  (roundWin == 3)     {   MessageBox.Show("Both lose: " + p1.totalPoints + " - " + p2.totalPoints, "Result");     }
            // Si ambos empatan a puntos por debajo de 21
            if  (roundWin == 4)     {   MessageBox.Show("Nobody wins: " + p1.totalPoints + " - " + p2.totalPoints, "Result");   }

            // Si "Player1" Gana
            if (roundWin == 1)
            {
                MessageBox.Show(p1.name + " Wins: " + p1.totalPoints + " - " + p2.totalPoints, "Result");
                p2.ReceiveDamagePlayer(p2.health, p1.damage, p2.shield);
                p1.DamageTo0(p2.damage);

                // Reparto de monedas
                if (bank.coin > 0) { p2.coin++; bank.coin--; }
                if (bank.coin > 0) { p1.coin++; bank.coin--; }
                if (bank.coin > 0) { p2.coin++; bank.coin--; }
                p1.BetVictory(p1.coin, p1.bet, p2.bet);
                p1.BetReset(p1.bet);    
                p2.BetReset(p2.bet);
            }
            // Si "Player2" Gana
            if (roundWin == 2)
            {
                MessageBox.Show(p2.name + " Wins: " + p1.totalPoints + " - " + p2.totalPoints, "Result");
                p1.ReceiveDamagePlayer(p1.health, p2.damage, p1.shield);
                p2.DamageTo0(p1.damage);

                // Reparto de monedas
                if (bank.coin > 0) { p1.coin++; bank.coin--; }
                if (bank.coin > 0) { p2.coin++; bank.coin--; }
                if (bank.coin > 0) { p1.coin++; bank.coin--; }
                p2.BetVictory(p2.coin, p2.bet, p1.bet);
                p2.BetReset(p2.bet);    
                p1.BetReset(p1.bet);
            }

            // Comprobación resultado final del juego si la vida de algún "Player" <= 0
            // [CASO SUPUESTAMENTE IMPOSIBLE] Empate (Hago esta excepción por si acaso, pero en principio debería ser imposible que ocurriese
            int endGame = Banking.EndGameResult(p1.health, p2.health);

            if  (endGame == 0)      {   MessageBox.Show("Tie! Nobody Wins", "End of Game"); Application.Restart();  }
            // Gana "Player1"
            if  (endGame == 1)      {   MessageBox.Show(p1.name + " Wins", "End of Game");  Application.Restart();  }
            // Gana "Player2"
            if  (endGame == 2)      {   MessageBox.Show(p2.name + " Wins", "End of Game");  Application.Restart();  }
            RefreshStatistics();
        }

        private void RandomMuutusBuy()
        {
            if (activePlayer == 1)
            {
                // Player 1
                int randMuutusP1 = Utilities.RandMuutusPlayer();
                p1.RandomMuutusChecker( randMuutusP1, p1.rb10Damage, p1.rb10Shield, p1.returnLastCard, p1.rbLimit24, p1.rbLimit27, p1.rbCardNumMinus2);
                // Según el modificador aleatorio que toque añado 1 uso suyo para poder usarlo el usuario
                if  (randMuutusP1 == 0)     {   lblMuutus1P1.Text   =   p1.rb10Damage.ToString();       }
                if  (randMuutusP1 == 1)     {   lblMuutus2P1.Text   =   p1.rb10Shield.ToString();       }
                if  (randMuutusP1 == 2)     {   lblMuutus3P1.Text   =   p1.returnLastCard.ToString();   }
                if  (randMuutusP1 == 3)     {   lblMuutus4P1.Text   =   p1.rbLimit24.ToString();        }
                if  (randMuutusP1 == 4)     {   lblMuutus5P1.Text   =   p1.rbLimit27.ToString();        }
                if  (randMuutusP1 == 5)     {   lblMuutus6P1.Text   =   p1.rbCardNumMinus2.ToString();  }
            }
            else
            {
                // Player 2
                int randMuutusP2 = Utilities.RandMuutusPlayer();
                p2.RandomMuutusChecker(randMuutusP2, p2.rb10Damage, p2.rb10Shield, p2.returnLastCard, p2.rbLimit24, p2.rbLimit27, p2.rbCardNumMinus2);
                
                // Según el modificador aleatorio que toque añado 1 uso suyo para poder usarlo el usuario
                if  (randMuutusP2 == 0)     {   lblMuutus1P2.Text   =   p2.rb10Damage.ToString();       }
                if  (randMuutusP2 == 1)     {   lblMuutus2P2.Text   =   p2.rb10Shield.ToString();       }
                if  (randMuutusP2 == 2)     {   lblMuutus3P2.Text   =   p2.returnLastCard.ToString();   }
                if  (randMuutusP2 == 3)     {   lblMuutus4P2.Text   =   p2.rbLimit24.ToString();        }
                if  (randMuutusP2 == 4)     {   lblMuutus5P2.Text   =   p2.rbLimit27.ToString();        }
                if  (randMuutusP2 == 5)     {   lblMuutus6P2.Text   =   p2.rbCardNumMinus2.ToString();  }
            }
            RefreshStatistics();
        }
        // Revisa el valor d la variable d cada modificador para activar/desactivar su panel y q el usuario pueda usarlo o no.
        private void EnableOrDisablePlayerGroupBox()
        {            
            MessageBox.Show("Pending confirmation for next turn...", "Shift change");   

            if (activePlayer == 1)
            {
                panelMuutusP2.Visible = false;
                panelTotalCards1P2.Visible = false;
                panelBetP2.Visible = false;

                panelMuutusP1.Visible = true;
                panelTotalCards1P1.Visible = true;
                panelBetP1.Visible = true;
            }

            if (activePlayer == 2)
            {
                panelMuutusP2.Visible = true;
                panelTotalCards1P2.Visible = true;
                panelBetP2.Visible = true;

                panelMuutusP1.Visible = false;
                panelTotalCards1P1.Visible = false;
                panelBetP1.Visible = false;
            }
        }
        
        private void btnPickCard_Click_1(object sender, EventArgs e)
        {
            // Cojo una carta "random" de las 11 posibles de la baraja
            pickedCard = Utilities.RandomCard();

            // Inicializo pasar turno
            PT = 0;

            if (deck.NumCards > 0)
            {
                if (activePlayer == 1)
                {
                    // Vuelvo a ejecutar el boton de coger carta para q lo vuelva a intentar
                    if (cardArrayPlayers[pickedCard - 1] == pickedCard)     {   btnPickCard_Click_1(sender, e);  }
                    else
                    {
                        // Guardo la última carta cogida d p1 para q pueda devolverla
                        p1.GetLastCard(p1.lastCard, pickedCard);

                        // Elimino la carta d la lista d cartas d la mesa
                        DeleteCard(pickedCard);

                        // Paso turno al jugador 2
                        activePlayer = 2;

                        // Oculto los groupbox d info del jugador al contrincante al pasar d turno
                        EnableOrDisablePlayerGroupBox();
                        RefreshStatistics();
                    }
                }
                else
                {
                    // Vuelvo a ejecutar el boton de coger carta para q lo vuelva a intentar
                    if (cardArrayPlayers[pickedCard - 1] == pickedCard)     {   btnPickCard_Click_1(sender, e);  }
                    else
                    {
                        // Guardo la última carta cogida d p2 para q pueda devolverla
                        p2.GetLastCard(p2.lastCard, pickedCard);

                        // Elimino la carta d la lista d cartas d la mesa
                        DeleteCard(pickedCard);

                        // Paso turno al jugador 1
                        activePlayer = 1;

                        // Oculto los groupbox d info del jugador al contrincante al pasar d turno
                        EnableOrDisablePlayerGroupBox();
                        RefreshStatistics();
                    }
                }
            }
            // Reinicio el juego cuando no haya cartas sobre la mesa
            if (deck.NumCards <= 0)     {   RestartRound();  }
        }

        // [ERROR!] Si paso y luego paso turno 2 "picks" después se termina directamente la partida
        // Índice de fin de partida por si pasan los 2 de turno
        int PT = 0;
        private void btnPassTurn_Click(object sender, EventArgs e)
        {
            if (deck.NumCards > 0)
            {
                // Baso los turnos de los jugadores en si el nº d cartas d la baraja es par/impar
                if      (activePlayer == 1) {   activePlayer = 2;   EnableOrDisablePlayerGroupBox();    }
                else                        {   activePlayer = 1;   EnableOrDisablePlayerGroupBox();    }
            }
            // Reinicio el juego cuando no haya cartas sobre la mesa
            if  (deck.NumCards <= 0)    {   RestartRound();   }

            // Sistema para recoger si ambos players pasan turno 1 tras otro ==> Finalizar ronda
            PT++;
            if  (PT == 2)               {   RestartRound();   }
            // Oculto los groupbox d info del jugador al contrincante al pasar d turno
            RefreshStatistics();
        }
        // Botones Muutus Player 1
        private void buyMuutusP1_Click(object sender, EventArgs e)  {   if (activePlayer == 1 && p1.coin > 0)   {   RandomMuutusBuy();  p1.coin--;  RefreshStatistics();    }   }
        private void useMuutusP1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Si "Player 1"
                if (activePlayer == 1)
                {
                    // Segun el "radio button" activo...
                    // Damage
                    if (rbMuutus1P1.Checked)
                    {
                        if  (p1.rb10Damage > 0)  {  p1.damage += 10;    p1.rb10Damage--;    }
                    }
                    // Shield
                    if (rbMuutus2P1.Checked)
                    {
                        if  (p1.rb10Shield > 0)  {   p1.shield += 10;    p1.rb10Shield--;    }
                    }
                    // Return last card
                    if (rbMuutus3P1.Checked)
                    {
                        if  (p1.returnLastCard > 0) {   ReturnLastCardMuutus(pickedCard);   p1.returnLastCard--;    }
                    }
                    // Victory points 24
                    if (rbMuutus4P1.Checked)
                    {
                        // Le cambio directamente la variable local
                        if  (p1.rbLimit24 > 0)  {   pointsLimit21 = 24;     p1.rbLimit24--; }
                    }
                    // Victory points 27
                    if (rbMuutus5P1.Checked)
                    {
                        if  (p1.rbLimit27 > 0)  {   pointsLimit21 = 27;     p1.rbLimit27--; }
                    }
                    // Card num -2
                    if (rbMuutus6P1.Checked)
                    {
                        if  (p1.rbCardNumMinus2 > 0)    {   p1.totalPoints -= 2;    p1.rbCardNumMinus2--;   }
                    }
                }
                // "Player 2"
                else
                {
                    // Damage
                    if (rbMuutus1P2.Checked)
                    {
                        if  (p2.rb10Damage > 0) {   p2.damage += 10;    p2.rb10Damage--;    }
                    }
                    // Shield
                    if (rbMuutus2P2.Checked)
                    {
                        if  (p2.rb10Shield > 0) {   p2.shield += 10;    p2.rb10Shield--;    }
                    }
                    // Return last card
                    if (rbMuutus3P2.Checked)
                    {
                        if  (p2.returnLastCard > 0) {   ReturnLastCardMuutus(pickedCard);   p2.returnLastCard--;    }
                    }
                    // Victory points 24
                    if (rbMuutus4P2.Checked)
                    {
                        if  (p2.rbLimit24 > 0)  {   pointsLimit21 = 24; p2.rbLimit24--; }
                    }
                    // Victory points 27
                    if (rbMuutus5P2.Checked)
                    {
                        if  (p2.rbLimit27 > 0)  {   pointsLimit21 = 27; p2.rbLimit27--; }
                    }
                    // Card num -2
                    if (rbMuutus6P2.Checked)
                    {
                        if  (p2.rbCardNumMinus2 > 0)    {   p2.totalPoints -= 2;    p2.rbCardNumMinus2--;   }
                    }
                }
            }
            catch       {   MessageBox.Show("Error al usar el Muutus", "Error!");   }
            PT = 0;
            RefreshStatistics();
        }
        // Botones Muutus Player 2
        private void buyMuutusP2_Click(object sender, EventArgs e)  {   if (activePlayer == 2 && p2.coin > 0)   {RandomMuutusBuy();  p2.coin--;  RefreshStatistics();    }  }
        private void useMuutusP2_Click(object sender, EventArgs e)  {   useMuutusP1_Click_1(sender, e);   }
        private void btnPlay_Click(object sender, EventArgs e)      
        {   
            panelStart.Visible = false;     
            btnPlay.Visible = false;
            lblBlackJackStart.Visible = false;
            panelInstructions.Visible = false;
        }
        private void betPlayer1_Click_1(object sender, EventArgs e) {   if (p1.coin > 0) {  p1.coin--; p1.bet++; lblBetP1.Text = p1.bet.ToString(); RefreshStatistics();    }       }
        private void betPlayer2_Click_1(object sender, EventArgs e) {   if (p2.coin > 0) {  p2.coin--; p2.bet++; lblBetP1.Text = p2.bet.ToString(); RefreshStatistics();    }       }
        private void btnRestart_Click(object sender, EventArgs e) => Application.Restart();
        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();
    }
}