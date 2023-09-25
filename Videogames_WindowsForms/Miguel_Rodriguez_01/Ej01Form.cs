/*
 *  Modificado por: Miguel Rodríguez Gallego
 *  Fecha: 25.enero.2021
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Miguel_Rodriguez_01.Properties;

namespace Miguel_Rodriguez_01
{
    public partial class Ej01Form : Form
    {
        /// Variables...
        // Música
        SoundPlayer music = new SoundPlayer(Resources.PokBattle);
        // Marca si el enemigo sigue vivo o no para ponerle una lápida y dejarlo fuera del combate
        private bool[] enemAliv = new bool[] { true, true, true , true, true};
        // Nº aleatorio para ver a qn irá dirigido el ataque del jugador
        private Random rnd = new Random();
        // Temporizador in-game
        private int timeCount = 0;

        /// Listas...
        // Lista de personajes "Player"
        private List<ChPlayer> selectionList = new List<ChPlayer>()
        {
            { new ChPlayer(Resources.SwordCaptain01, Character.CharacterType.Sword, "Sword", 100, 50 )},
            { new ChPlayer(Resources.AxeCaptain01, Character.CharacterType.Axe, "Axe", 100, 50) },
            { new ChPlayer(Resources.SpearCaptain, Character.CharacterType.Spear, "Spear", 100, 50) }
        };

        private List<ChPlayer> playerList = new List<ChPlayer>()
        {

        };
        private List<ChPlayer> enemyList = new List<ChPlayer>()
        {

        };

        public Ej01Form()
        {
            InitializeComponent();
        }
        // Nada más cargarse el form
        private void Ej01Form_Load(object sender, EventArgs e)
        {
            // Música
            music.PlayLooping();

            timer.Start();
            lblTimer.Text = timeCount.ToString();
        }

        private static void AttackPlayer(IAttacker attacker)
        {
            attacker.ReceiveDmg(attacker.GetDmg(), attacker.GetDmgType());
        }

        // Cálculo enemigo aleatorio q defiende
        public int RandEnemy()
        {
            Random rndP1 = new Random();
            int randMuutusP1 = rndP1.Next(0, 3);
            return randMuutusP1;
        }

        // Timer
        private void timer_Tick(object sender, EventArgs e)
        {
            timeCount++;
            lblTimer.Text = timeCount.ToString();
        }

        // Start
        private void button6_Click(object sender, EventArgs e)
        {
            UpdatePlayersStart();            

            enemyList.Add(playerList[RandEnemy()]);
            enemyList.Add(playerList[RandEnemy()]);
            enemyList.Add(playerList[RandEnemy()]);
            enemyList.Add(playerList[RandEnemy()]);
            enemyList.Add(playerList[RandEnemy()]);
            UpdateEnemyStart();

            UpdateGeneralStats();

        }
        private void UpdateGeneralStats()
        {
            // health  Player
            if(playerList[0].health <= 0)
            {
                pbPlayer1.Value = 0;
            }
            else
            {
                pbPlayer1.Value = playerList[0].health;
                killcountEnemy++;
            }
            //2
            if (playerList[1].health <= 0)
            {
                pbPlayer2.Value = 0;
            }
            else
            {
                pbPlayer2.Value = playerList[1].health;
                killcountEnemy++;
            }
            //3
            if (playerList[2].health <= 0)
            {
                pbPlayer3.Value = 0;
            }
            else
            {
                pbPlayer3.Value = playerList[2].health;
                killcountEnemy++;
            }
            //4
            if (playerList[3].health <= 0)
            {
                pbPlayer4.Value = 0;
            }
            else
            {
                pbPlayer4.Value = playerList[3].health;
                killcountEnemy++;
            }
            //5
            if (playerList[4].health <= 0)
            {
                pbPlayer5.Value = 0;
            }
            else
            {
                pbPlayer5.Value = playerList[4].health;
                killcountEnemy++;
            }

            // health  Enemy
            if (enemyList[0].health <= 0)
            {
                pbEnemy1.Value = 0;
            }
            else
            {
                pbEnemy1.Value = enemyList[0].health;
                killcountPlayer++;
            }
            //2
            if (enemyList[1].health <= 0)
            {
                pbEnemy2.Value = 0;
            }
            else
            {
                pbEnemy2.Value = enemyList[1].health;
                killcountPlayer++;
            }
            //3
            if (enemyList[2].health <= 0)
            {
                pbEnemy3.Value = 0;
            }
            else
            {
                pbEnemy3.Value = enemyList[2].health;
                killcountPlayer++;
            }
            //4
            if (enemyList[3].health <= 0)
            {
                pbEnemy4.Value = 0;
            }
            else
            {
                pbEnemy4.Value = enemyList[3].health;
                killcountPlayer++;
            }
            //5
            if (enemyList[4].health <= 0)
            {
                pbEnemy5.Value = 0;
            }
            else
            {
                pbEnemy5.Value = enemyList[4].health;
                killcountPlayer++;
            }
        }
        private void UpdatePlayersStart()
        {
            // 1
            if (playerList[0].name == "Sword")
            {
                pb1Player.Image = Resources.SwordSoldier01;
            }
            if (playerList[0].name == "Axe")
            {
                pb1Player.Image = Resources.AxeSoldier01;
            }
            if (playerList[0].name == "Spear")
            {
                pb1Player.Image = Resources.SpearSoldier01;
            }
            // 2
            if (playerList[1].name == "Sword")
            {
                pb2Player.Image = Resources.SwordSoldier01;
            }
            if (playerList[1].name == "Axe")
            {
                pb2Player.Image = Resources.AxeSoldier01;
            }
            if (playerList[1].name == "Spear")
            {
                pb2Player.Image = Resources.SpearSoldier01;
            }
            // 3
            if (playerList[2].name == "Sword")
            {
                pb3Player.Image = Resources.SwordSoldier01;
            }
            if (playerList[2].name == "Axe")
            {
                pb3Player.Image = Resources.AxeSoldier01;
            }
            if (playerList[2].name == "Spear")
            {
                pb3Player.Image = Resources.SpearSoldier01;
            }
            // 4
            if (playerList[3].name == "Sword")
            {
                pb4Player.Image = Resources.SwordSoldier01;
            }
            if (playerList[3].name == "Axe")
            {
                pb4Player.Image = Resources.AxeSoldier01;
            }
            if (playerList[3].name == "Spear")
            {
                pb4Player.Image = Resources.SpearSoldier01;
            }
            //5
            if (playerList[4].name == "Sword")
            {
                pb5Player.Image = Resources.SwordSoldier01;
            }
            if (playerList[4].name == "Axe")
            {
                pb5Player.Image = Resources.AxeSoldier01;
            }
            if (playerList[4].name == "Spear")
            {
                pb5Player.Image = Resources.SpearSoldier01;
            }
        }
        private void UpdateEnemyStart()
        {
            // 1
            if (enemyList[0].name == "Sword")
            {
                pb1Enemy.Image = Resources.SwordSoldier01;
            }
            if (enemyList[0].name == "Axe")
            {
                pb1Enemy.Image = Resources.AxeSoldier01;
            }
            if (enemyList[0].name == "Spear")
            {
                pb1Enemy.Image = Resources.SpearSoldier01;
            }
            // 2
            if (enemyList[1].name == "Sword")
            {
                pb2Enemy.Image = Resources.SwordSoldier01;
            }
            if (enemyList[1].name == "Axe")
            {
                pb2Enemy.Image = Resources.AxeSoldier01;
            }
            if (enemyList[1].name == "Spear")
            {
                pb2Enemy.Image = Resources.SpearSoldier01;
            }
            // 3
            if (enemyList[2].name == "Sword")
            {
                pb3Enemy.Image = Resources.SwordSoldier01;
            }
            if (enemyList[2].name == "Axe")
            {
                pb3Enemy.Image = Resources.AxeSoldier01;
            }
            if (enemyList[2].name == "Spear")
            {
                pb3Enemy.Image = Resources.SpearSoldier01;
            }
            // 4
            if (enemyList[3].name == "Sword")
            {
                pb4Enemy.Image = Resources.SwordSoldier01;
            }
            if (enemyList[3].name == "Axe")
            {
                pb4Enemy.Image = Resources.AxeSoldier01;
            }
            if (enemyList[3].name == "Spear")
            {
                pb4Enemy.Image = Resources.SpearSoldier01;
            }
            //5
            if (enemyList[4].name == "Sword")
            {
                pb5Enemy.Image = Resources.SwordSoldier01;
            }
            if (enemyList[4].name == "Axe")
            {
                pb5Enemy.Image = Resources.AxeSoldier01;
            }
            if (enemyList[4].name == "Spear")
            {
                pb5Enemy.Image = Resources.SpearSoldier01;
            }
        }

        int playerLimit = 0;
        public int bless = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (playerLimit <= 5)
            {
                if (rbSword.Checked)
                {
                    playerList.Add(selectionList[0]);
                    if (bless == 0)
                    {
                        bless++;
                    }
                }
                if (rbAxe.Checked)
                {
                    playerList.Add(selectionList[1]);
                    if (bless == 0)
                    {
                        bless++;
                    }
                }
                if (rbSpear.Checked)
                {
                    playerList.Add(selectionList[2]);
                    if (bless == 0)
                    {
                        bless++;
                    }
                }
                playerLimit++;
            }
        }

        int killcountPlayer = 0;
        int killcountEnemy = 0;
        private void btnAttack_Click(object sender, EventArgs e)
        {
            // Enemigo aleatorio al q atacará
            int randDefEnemy = RandEnemy();
            // Si el enemigo q ha salido ya está muerto...
            //  se repite el proceso d elección hasta q salga 1 q siga vivo
            while (enemAliv[randDefEnemy] == false)
            {
                randDefEnemy = RandEnemy();
            }

            // Ataque
            AttackPlayer(playerList[0]);
            AttackPlayer(playerList[1]);
            AttackPlayer(playerList[2]);
            AttackPlayer(playerList[3]);
            AttackPlayer(playerList[4]);

            if (killcountPlayer == 5 && killcountEnemy == 5)
            {
                btnAttack.Enabled = false;
                UpdateGeneralStats();

                // Diálogo para q el jugador decida q hacer tras matar a todos
                DialogResult result = MessageBox.Show
                    (
                        "Restart game", "Empate!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                else
                {
                    Application.Exit();
                }

            }

            // Si el contador d muertes = la cantidad d enemigos d la batalla ==> Termina el juego!
            if (killcountEnemy == 5)
            {
                btnAttack.Enabled = false;
                UpdateGeneralStats();

                // Diálogo para q el jugador decida q hacer tras matar a todos
                DialogResult result = MessageBox.Show
                    (
                        "Restart game", "Enemy Wins!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                else
                {
                    Application.Exit();
                }
            }

            if (killcountPlayer == 5)
            {
                btnAttack.Enabled = false;
                UpdateGeneralStats();

                // Diálogo para q el jugador decida q hacer tras matar a todos
                DialogResult result = MessageBox.Show
                    (
                        "Restart game", "Player Wins!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                else
                {
                    Application.Exit();
                }
            }

            // Actualización estadísticas
            UpdateGeneralStats();
        }
    }
}
