
namespace EXAMEN_MPOO_Miguel_RodríguezGallego
{
    partial class Ej01Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbEnSword = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPlayerDamage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPlayer = new System.Windows.Forms.ComboBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pgbEnSpear = new System.Windows.Forms.ProgressBar();
            this.pgbEnAxe = new System.Windows.Forms.ProgressBar();
            this.pgbEnSword = new System.Windows.Forms.ProgressBar();
            this.label18 = new System.Windows.Forms.Label();
            this.lblEnSpearName = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblEnAxeName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEnSwordName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbEnSpear = new System.Windows.Forms.PictureBox();
            this.pbEnAxe = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbEnSword)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnSpear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnAxe)).BeginInit();
            this.SuspendLayout();
            // 
            // pbEnSword
            // 
            this.pbEnSword.BackColor = System.Drawing.SystemColors.Control;
            this.pbEnSword.BackgroundImage = global::EXAMEN_MPOO_Miguel_RodríguezGallego.Properties.Resources.SwordSoldier01;
            this.pbEnSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbEnSword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEnSword.Location = new System.Drawing.Point(6, 26);
            this.pbEnSword.Name = "pbEnSword";
            this.pbEnSword.Size = new System.Drawing.Size(164, 147);
            this.pbEnSword.TabIndex = 0;
            this.pbEnSword.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPlayerDamage);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblPlayerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbPlayer);
            this.groupBox1.Controls.Add(this.btnAttack);
            this.groupBox1.Controls.Add(this.pbPlayer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player";
            // 
            // lblPlayerDamage
            // 
            this.lblPlayerDamage.AutoSize = true;
            this.lblPlayerDamage.Location = new System.Drawing.Point(211, 232);
            this.lblPlayerDamage.Name = "lblPlayerDamage";
            this.lblPlayerDamage.Size = new System.Drawing.Size(12, 20);
            this.lblPlayerDamage.TabIndex = 7;
            this.lblPlayerDamage.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Damage";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(211, 199);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(12, 20);
            this.lblPlayerName.TabIndex = 5;
            this.lblPlayerName.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Character";
            // 
            // cbPlayer
            // 
            this.cbPlayer.FormattingEnabled = true;
            this.cbPlayer.Location = new System.Drawing.Point(26, 315);
            this.cbPlayer.Name = "cbPlayer";
            this.cbPlayer.Size = new System.Drawing.Size(214, 28);
            this.cbPlayer.TabIndex = 2;
            this.cbPlayer.SelectedIndexChanged += new System.EventHandler(this.cbPlayer_SelectedIndexChanged);
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(246, 283);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(184, 60);
            this.btnAttack.TabIndex = 1;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlayer.Location = new System.Drawing.Point(139, 26);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(172, 150);
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pgbEnSpear);
            this.groupBox2.Controls.Add(this.pgbEnAxe);
            this.groupBox2.Controls.Add(this.pgbEnSword);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lblEnSpearName);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblEnAxeName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblTimer);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblEnSwordName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pbEnSpear);
            this.groupBox2.Controls.Add(this.pbEnAxe);
            this.groupBox2.Controls.Add(this.pbEnSword);
            this.groupBox2.Location = new System.Drawing.Point(464, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 364);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enemy";
            // 
            // pgbEnSpear
            // 
            this.pgbEnSpear.Location = new System.Drawing.Point(406, 232);
            this.pgbEnSpear.Name = "pgbEnSpear";
            this.pgbEnSpear.Size = new System.Drawing.Size(113, 19);
            this.pgbEnSpear.TabIndex = 19;
            // 
            // pgbEnAxe
            // 
            this.pgbEnAxe.Location = new System.Drawing.Point(235, 233);
            this.pgbEnAxe.Name = "pgbEnAxe";
            this.pgbEnAxe.Size = new System.Drawing.Size(110, 19);
            this.pgbEnAxe.TabIndex = 18;
            // 
            // pgbEnSword
            // 
            this.pgbEnSword.Location = new System.Drawing.Point(66, 232);
            this.pgbEnSword.Name = "pgbEnSword";
            this.pgbEnSword.Size = new System.Drawing.Size(104, 20);
            this.pgbEnSword.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(351, 232);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 20);
            this.label18.TabIndex = 15;
            this.label18.Text = "Health";
            // 
            // lblEnSpearName
            // 
            this.lblEnSpearName.AutoSize = true;
            this.lblEnSpearName.Location = new System.Drawing.Point(406, 199);
            this.lblEnSpearName.Name = "lblEnSpearName";
            this.lblEnSpearName.Size = new System.Drawing.Size(12, 20);
            this.lblEnSpearName.TabIndex = 14;
            this.lblEnSpearName.Text = ".";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(351, 199);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 20);
            this.label16.TabIndex = 13;
            this.label16.Text = "Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(176, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "Health";
            // 
            // lblEnAxeName
            // 
            this.lblEnAxeName.AutoSize = true;
            this.lblEnAxeName.Location = new System.Drawing.Point(235, 199);
            this.lblEnAxeName.Name = "lblEnAxeName";
            this.lblEnAxeName.Size = new System.Drawing.Size(12, 20);
            this.lblEnAxeName.TabIndex = 10;
            this.lblEnAxeName.Text = ".";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(176, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Name";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(102, 315);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(12, 20);
            this.lblTimer.TabIndex = 8;
            this.lblTimer.Text = ".";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Health";
            // 
            // lblEnSwordName
            // 
            this.lblEnSwordName.AutoSize = true;
            this.lblEnSwordName.Location = new System.Drawing.Point(66, 199);
            this.lblEnSwordName.Name = "lblEnSwordName";
            this.lblEnSwordName.Size = new System.Drawing.Size(12, 20);
            this.lblEnSwordName.TabIndex = 4;
            this.lblEnSwordName.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Name";
            // 
            // pbEnSpear
            // 
            this.pbEnSpear.BackgroundImage = global::EXAMEN_MPOO_Miguel_RodríguezGallego.Properties.Resources.SpearSoldier01;
            this.pbEnSpear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbEnSpear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEnSpear.Location = new System.Drawing.Point(351, 26);
            this.pbEnSpear.Name = "pbEnSpear";
            this.pbEnSpear.Size = new System.Drawing.Size(168, 147);
            this.pbEnSpear.TabIndex = 2;
            this.pbEnSpear.TabStop = false;
            // 
            // pbEnAxe
            // 
            this.pbEnAxe.BackgroundImage = global::EXAMEN_MPOO_Miguel_RodríguezGallego.Properties.Resources.AxeSoldier02;
            this.pbEnAxe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbEnAxe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEnAxe.Location = new System.Drawing.Point(176, 26);
            this.pbEnAxe.Name = "pbEnAxe";
            this.pbEnAxe.Size = new System.Drawing.Size(169, 147);
            this.pbEnAxe.TabIndex = 1;
            this.pbEnAxe.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
            // 
            // Ej01Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 388);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ej01Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ej01Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEnSword)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnSpear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnAxe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPlayerDamage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPlayer;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblEnSpearName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblEnAxeName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEnSwordName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbEnSpear;
        private System.Windows.Forms.PictureBox pbEnAxe;
        private System.Windows.Forms.PictureBox pbEnSword;
        private System.Windows.Forms.ProgressBar pgbEnSpear;
        private System.Windows.Forms.ProgressBar pgbEnAxe;
        private System.Windows.Forms.ProgressBar pgbEnSword;
        private System.Windows.Forms.Timer timer;
    }
}

