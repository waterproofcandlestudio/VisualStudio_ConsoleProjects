// Miguel Rodríguez Gallego
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal2_MiguelRodriguezGallego
{
    class Banking
    {
        public int coin { get; set; }
        public int bet { get; set; }

        public Banking
        (
            int coin = 0,
            int bet = 0
        )
        {
            this.coin = coin;
            this.bet = bet;
        }

        public void BetVictory(int Coin, int bet1, int bet2)
        {
            this.coin = Coin + bet1 + bet2;
        }
        public void BetReset(int bet)            { this.bet = 0;    }

        // Finales de ronda
        //  1 == Player1            |     2 == Player2
        //  3 == Ambos pasan d 21   |     4 == Ambos empatan por debajo de 21
        public static int CheckWhoWins(int pointsLimit21, int p1TotalPoints, int p2TotalPoints)
        {
            // Si "Player1" Gana
            if (p1TotalPoints <= pointsLimit21)
            {
                if (p2TotalPoints > pointsLimit21)  {   return 1;   }
                if (p1TotalPoints > p2TotalPoints)  {   return 1;   }
            }
            // Si "Player2" Gana
            if (p2TotalPoints <= pointsLimit21)
            {
                if (p1TotalPoints > pointsLimit21)  {   return 2;   }
                if (p1TotalPoints < p2TotalPoints)  {   return 2;   }
            }

            // Si ambos se pasan de 21
            if (p1TotalPoints > pointsLimit21 && p2TotalPoints > pointsLimit21) {   return 3;   }
            // Si ambos empatan a puntos por debajo de 21
            if (p1TotalPoints == p2TotalPoints && p1TotalPoints <= pointsLimit21 && p2TotalPoints <= pointsLimit21) {   return 4;   }
            return 3;
        }
        public static int EndGameResult(int p1health, int p2Health)
        {
            // 0 == Empate | 1 == Player1 | 2 == Player2 | 3 == nada...
            if      (p2Health <= 0 && p1health <= 0) {   return  0;  }
            if      (p2Health <= 0 && p1health > 0 )    {   return  1;  }
            if      (p1health <= 0 && p2Health > 0 )    {   return  2;  }
            else return 3;
        }
    }
}
