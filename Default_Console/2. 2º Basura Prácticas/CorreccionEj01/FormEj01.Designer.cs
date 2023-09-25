
namespace CorreccionEj01
{
    partial class FormEj01
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
            this.gbPlayer = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerDmg = new System.Windows.Forms.Label();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.rbEnemy = new System.Windows.Forms.RadioButton();
            this.rbPlayer = new System.Windows.Forms.RadioButton();
            this.gbEnemy = new System.Windows.Forms.GroupBox();
            this.lblEnemyDmg = new System.Windows.Forms.Label();
            this.lblEnemyHealth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPlayerCritChance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPlayerCritMult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEnemyShield = new System.Windows.Forms.Label();
            this.gbPlayer.SuspendLayout();
            this.gbEnemy.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPlayer
            // 
            this.gbPlayer.Controls.Add(this.lblPlayerCritMult);
            this.gbPlayer.Controls.Add(this.label6);
            this.gbPlayer.Controls.Add(this.lblPlayerCritChance);
            this.gbPlayer.Controls.Add(this.label5);
            this.gbPlayer.Controls.Add(this.label2);
            this.gbPlayer.Controls.Add(this.label1);
            this.gbPlayer.Controls.Add(this.lblPlayerDmg);
            this.gbPlayer.Controls.Add(this.lblPlayerHealth);
            this.gbPlayer.Location = new System.Drawing.Point(12, 12);
            this.gbPlayer.Name = "gbPlayer";
            this.gbPlayer.Size = new System.Drawing.Size(188, 269);
            this.gbPlayer.TabIndex = 0;
            this.gbPlayer.TabStop = false;
            this.gbPlayer.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Damage:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Health:";
            // 
            // lblPlayerDmg
            // 
            this.lblPlayerDmg.AutoSize = true;
            this.lblPlayerDmg.Location = new System.Drawing.Point(111, 83);
            this.lblPlayerDmg.Name = "lblPlayerDmg";
            this.lblPlayerDmg.Size = new System.Drawing.Size(10, 15);
            this.lblPlayerDmg.TabIndex = 1;
            this.lblPlayerDmg.Text = ".";
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.Location = new System.Drawing.Point(111, 43);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(10, 15);
            this.lblPlayerHealth.TabIndex = 0;
            this.lblPlayerHealth.Text = ".";
            // 
            // rbEnemy
            // 
            this.rbEnemy.AutoSize = true;
            this.rbEnemy.Location = new System.Drawing.Point(172, 366);
            this.rbEnemy.Name = "rbEnemy";
            this.rbEnemy.Size = new System.Drawing.Size(28, 19);
            this.rbEnemy.TabIndex = 4;
            this.rbEnemy.Text = ".";
            this.rbEnemy.UseVisualStyleBackColor = true;
            // 
            // rbPlayer
            // 
            this.rbPlayer.AutoSize = true;
            this.rbPlayer.Checked = true;
            this.rbPlayer.Location = new System.Drawing.Point(172, 325);
            this.rbPlayer.Name = "rbPlayer";
            this.rbPlayer.Size = new System.Drawing.Size(28, 19);
            this.rbPlayer.TabIndex = 3;
            this.rbPlayer.TabStop = true;
            this.rbPlayer.Text = ".";
            this.rbPlayer.UseVisualStyleBackColor = true;
            // 
            // gbEnemy
            // 
            this.gbEnemy.Controls.Add(this.lblEnemyShield);
            this.gbEnemy.Controls.Add(this.label7);
            this.gbEnemy.Controls.Add(this.lblEnemyDmg);
            this.gbEnemy.Controls.Add(this.lblEnemyHealth);
            this.gbEnemy.Controls.Add(this.label3);
            this.gbEnemy.Controls.Add(this.label4);
            this.gbEnemy.Location = new System.Drawing.Point(206, 12);
            this.gbEnemy.Name = "gbEnemy";
            this.gbEnemy.Size = new System.Drawing.Size(204, 269);
            this.gbEnemy.TabIndex = 1;
            this.gbEnemy.TabStop = false;
            this.gbEnemy.Text = ".";
            // 
            // lblEnemyDmg
            // 
            this.lblEnemyDmg.AutoSize = true;
            this.lblEnemyDmg.Location = new System.Drawing.Point(121, 83);
            this.lblEnemyDmg.Name = "lblEnemyDmg";
            this.lblEnemyDmg.Size = new System.Drawing.Size(10, 15);
            this.lblEnemyDmg.TabIndex = 7;
            this.lblEnemyDmg.Text = ".";
            // 
            // lblEnemyHealth
            // 
            this.lblEnemyHealth.AutoSize = true;
            this.lblEnemyHealth.Location = new System.Drawing.Point(121, 43);
            this.lblEnemyHealth.Name = "lblEnemyHealth";
            this.lblEnemyHealth.Size = new System.Drawing.Size(10, 15);
            this.lblEnemyHealth.TabIndex = 6;
            this.lblEnemyHealth.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Damage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Health:";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(155, 408);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(106, 50);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "CritChance";
            // 
            // lblPlayerCritChance
            // 
            this.lblPlayerCritChance.AutoSize = true;
            this.lblPlayerCritChance.Location = new System.Drawing.Point(111, 128);
            this.lblPlayerCritChance.Name = "lblPlayerCritChance";
            this.lblPlayerCritChance.Size = new System.Drawing.Size(10, 15);
            this.lblPlayerCritChance.TabIndex = 5;
            this.lblPlayerCritChance.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "CritMult";
            // 
            // lblPlayerCritMult
            // 
            this.lblPlayerCritMult.AutoSize = true;
            this.lblPlayerCritMult.Location = new System.Drawing.Point(111, 170);
            this.lblPlayerCritMult.Name = "lblPlayerCritMult";
            this.lblPlayerCritMult.Size = new System.Drawing.Size(10, 15);
            this.lblPlayerCritMult.TabIndex = 7;
            this.lblPlayerCritMult.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Shield";
            // 
            // lblEnemyShield
            // 
            this.lblEnemyShield.AutoSize = true;
            this.lblEnemyShield.Location = new System.Drawing.Point(121, 127);
            this.lblEnemyShield.Name = "lblEnemyShield";
            this.lblEnemyShield.Size = new System.Drawing.Size(10, 15);
            this.lblEnemyShield.TabIndex = 9;
            this.lblEnemyShield.Text = ".";
            // 
            // FormEj01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 492);
            this.Controls.Add(this.rbEnemy);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.gbEnemy);
            this.Controls.Add(this.rbPlayer);
            this.Controls.Add(this.gbPlayer);
            this.Name = "FormEj01";
            this.Text = "Ejercicio01";
            this.gbPlayer.ResumeLayout(false);
            this.gbPlayer.PerformLayout();
            this.gbEnemy.ResumeLayout(false);
            this.gbEnemy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerDmg;
        private System.Windows.Forms.Label lblPlayerHealth;
        private System.Windows.Forms.GroupBox gbEnemy;
        private System.Windows.Forms.Label lblEnemyDmg;
        private System.Windows.Forms.Label lblEnemyHealth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.RadioButton rbPlayer;
        private System.Windows.Forms.RadioButton rbEnemy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPlayerCritMult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPlayerCritChance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEnemyShield;
    }
}

