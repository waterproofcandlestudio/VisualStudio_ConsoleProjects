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
using EXAMEN_MPOO_Miguel_RodríguezGallego.Properties;

namespace EXAMEN_MPOO_Miguel_RodríguezGallego
{
    public partial class Ej01Form : Form
    {
        /// Variables...
        // Música
        SoundPlayer music = new SoundPlayer(Resources.PokBattle);
        // Marca si el enemigo sigue vivo o no para ponerle una lápida y dejarlo fuera del combate
        private bool[] enemAliv = new bool[] { true, true, true };
        // Nº aleatorio para ver a qn irá dirigido el ataque del jugador
        private Random rnd = new Random();
        // Contabilizar las muertes hasta 3 para ver cuando terminar el juego...
        private int killCount = 0;
        // Temporizador in-game
        private int timeCount = 0;

        /// Listas...
        // Lista de personajes "Player"
        private List<ChPlayer> playerList = new List<ChPlayer>()
        {
            { new ChPlayer(Resources.SwordCaptain01, Character.CharacterType.Sword, "El pibe q pasa la tarea", 50) },
            { new ChPlayer(Resources.AxeCaptain01, Character.CharacterType.Axe, "Una bts (IG d la minita?)", 50) },
            { new ChPlayer(Resources.SpearCaptain, Character.CharacterType.Spear, "El q t electrocutaba con el boli", 50) }
        };
        // Lista de personajes "Enemy"
        private List<ChEnemy> enemyList = new List<ChEnemy>()
        {
            { new ChEnemy(Character.CharacterType.Sword, "Q t rajo illo", 100) },
            { new ChEnemy(Character.CharacterType.Axe, "Tu khe mirah", 100) },
            { new ChEnemy(Character.CharacterType.Spear, "Tiene un leuro?", 100) }
        };

        public Ej01Form()
        {
            InitializeComponent();
        }
        // Nada más cargarse el form
        private void Ej01Form_Load(object sender, EventArgs e)
        {
            // Meto en la lista d "Player" los personajes q tiene para usar en el comboBox
            cbPlayer.Items.Add(playerList[0].name);
            cbPlayer.Items.Add(playerList[1].name);
            cbPlayer.Items.Add(playerList[2].name);
            // Q aparezca seleccionado 1 prsj al inicio
            cbPlayer.SelectedIndex = 0;
            UpdateComboBox(cbPlayer.SelectedIndex);

            // Estadísticas iniciales de los rivales (Nombre & Salud)
            lblEnSwordName.Text = enemyList[0].name;
            lblEnAxeName.Text = enemyList[1].name;
            lblEnSpearName.Text = enemyList[2].name;

            pgbEnSword.Value = enemyList[0].health;
            pgbEnAxe.Value = enemyList[1].health;
            pgbEnSpear.Value = enemyList[2].health;

            // Música
            music.PlayLooping();

            timer.Start();
            lblTimer.Text = timeCount.ToString();
        }

        // Actualizar estadísticas d los "enemy"
        private void UpdateEneHP(int i)
        {
            if (enemAliv[i])
            { 
                switch (i)
                {
                    case 0:
                        pgbEnSword.Value = enemyList[i].health;
                        break;
                    case 1:
                        pgbEnAxe.Value = enemyList[i].health;
                        break;
                    case 2:
                        pgbEnSpear.Value = enemyList[i].health;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (i)
                {
                    case 0:
                        pbEnSword.BackgroundImage = Resources.Grave;
                        pgbEnSword.Value = 0;
                        break;
                    case 1:
                        pbEnAxe.BackgroundImage = Resources.Grave;
                        pgbEnAxe.Value = 0;
                        break;
                    case 2:
                        pbEnSpear.BackgroundImage = Resources.Grave;
                        pgbEnSpear.Value = 0;
                        break;
                    default:
                        break;
                }
            }
        }

        // ComboBox ==> Selección de personaje del "Player" 
        private void cbPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // La selección dentro del "comboBox" funciona mediante un array,
            // así q le paso el valor del Nº del elemento escogido en el array al método q
            // ejecuta los cambios
            UpdateComboBox(cbPlayer.SelectedIndex);
        }
        // Cambiar la imagen & estadísticas del jugador segun el escogido en el "comboBox"
        private void UpdateComboBox(int index)
        {
            pbPlayer.Image = playerList[index].picture;
            lblPlayerName.Text = playerList[index].name;
            lblPlayerDamage.Text = playerList[index].GetDmg().ToString();
        }

        // Boton "Attack"
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
            AttackPlayer(playerList[cbPlayer.SelectedIndex], enemyList[randDefEnemy]);

            // Si el enemigo muere tras el ataque se suma 1 kill y se hacen comprobaciones...
            if (enemyList[randDefEnemy].health <= 0)
            {
                // Sumo 1 muerte al contador
                killCount++;
                // Actualizo el estado vital del booleano "enemAliv"
                enemAliv[randDefEnemy] = false;

                // Si el contador d muertes = la cantidad d enemigos d la batalla ==> Termina el juego!
                if (killCount == enemyList.Count)
                {
                    btnAttack.Enabled = false;
                    UpdateEneHP(randDefEnemy);

                    // Diálogo para q el jugador decida q hacer tras matar a todos
                    DialogResult result = MessageBox.Show
                        (
                            "Restart game", "You win!",
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
            }

            // Actualización estadísticas
            UpdateEneHP(randDefEnemy);
        }

        private static void AttackPlayer(IAttacker attacker, IDefender defender)
        {
            defender.ReceiveDmg(attacker.GetDmg(), attacker.GetDmgType());
        }

        // Cálculo enemigo aleatorio q defiende
        public int RandEnemy()
        {
            Random rndP1 = new Random();
            int randMuutusP1 = rndP1.Next(0, enemyList.Count);
            return randMuutusP1;
        }

        // Timer
        private void timer_Tick_1(object sender, EventArgs e)
        {
            timeCount++;
            lblTimer.Text = timeCount.ToString();
        }
    }
}
