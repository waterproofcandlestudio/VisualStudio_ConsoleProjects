
namespace Clases2
{
    partial class Form1
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
            this.btnGo = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.lblNamePlayer = new System.Windows.Forms.Label();
            this.bgPlayer = new System.Windows.Forms.GroupBox();
            this.attackPlayer = new System.Windows.Forms.Button();
            this.damagePlayer = new System.Windows.Forms.Label();
            this.lblDamagePlayer = new System.Windows.Forms.Label();
            this.lblHealthPlayer = new System.Windows.Forms.Label();
            this.healthPlayer = new System.Windows.Forms.Label();
            this.namePlayer = new System.Windows.Forms.Label();
            this.cbCharacters = new System.Windows.Forms.ComboBox();
            this.bgEnemy = new System.Windows.Forms.GroupBox();
            this.attackEnemy = new System.Windows.Forms.Button();
            this.lblDamageEnemy = new System.Windows.Forms.Label();
            this.damageEnemy = new System.Windows.Forms.Label();
            this.lblHealthEnemy = new System.Windows.Forms.Label();
            this.healthEnemy = new System.Windows.Forms.Label();
            this.lblNameEnemy = new System.Windows.Forms.Label();
            this.nameEnemy = new System.Windows.Forms.Label();
            this.bgPlayer.SuspendLayout();
            this.bgEnemy.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(344, 249);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(94, 29);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // lblNamePlayer
            // 
            this.lblNamePlayer.AutoSize = true;
            this.lblNamePlayer.Location = new System.Drawing.Point(87, 44);
            this.lblNamePlayer.Name = "lblNamePlayer";
            this.lblNamePlayer.Size = new System.Drawing.Size(12, 20);
            this.lblNamePlayer.TabIndex = 1;
            this.lblNamePlayer.Text = ".";
            // 
            // bgPlayer
            // 
            this.bgPlayer.Controls.Add(this.attackPlayer);
            this.bgPlayer.Controls.Add(this.damagePlayer);
            this.bgPlayer.Controls.Add(this.lblDamagePlayer);
            this.bgPlayer.Controls.Add(this.lblHealthPlayer);
            this.bgPlayer.Controls.Add(this.healthPlayer);
            this.bgPlayer.Controls.Add(this.namePlayer);
            this.bgPlayer.Controls.Add(this.lblNamePlayer);
            this.bgPlayer.Location = new System.Drawing.Point(12, 12);
            this.bgPlayer.Name = "bgPlayer";
            this.bgPlayer.Size = new System.Drawing.Size(307, 207);
            this.bgPlayer.TabIndex = 2;
            this.bgPlayer.TabStop = false;
            this.bgPlayer.Text = "Player1";
            // 
            // attackPlayer
            // 
            this.attackPlayer.Location = new System.Drawing.Point(23, 155);
            this.attackPlayer.Name = "attackPlayer";
            this.attackPlayer.Size = new System.Drawing.Size(94, 29);
            this.attackPlayer.TabIndex = 5;
            this.attackPlayer.Text = "Atacar";
            this.attackPlayer.UseVisualStyleBackColor = true;
            this.attackPlayer.Click += new System.EventHandler(this.AttackPlayer_Click);
            // 
            // damagePlayer
            // 
            this.damagePlayer.AutoSize = true;
            this.damagePlayer.Location = new System.Drawing.Point(23, 118);
            this.damagePlayer.Name = "damagePlayer";
            this.damagePlayer.Size = new System.Drawing.Size(45, 20);
            this.damagePlayer.TabIndex = 4;
            this.damagePlayer.Text = "Daño";
            // 
            // lblDamagePlayer
            // 
            this.lblDamagePlayer.AutoSize = true;
            this.lblDamagePlayer.Location = new System.Drawing.Point(87, 118);
            this.lblDamagePlayer.Name = "lblDamagePlayer";
            this.lblDamagePlayer.Size = new System.Drawing.Size(12, 20);
            this.lblDamagePlayer.TabIndex = 3;
            this.lblDamagePlayer.Text = ".";
            // 
            // lblHealthPlayer
            // 
            this.lblHealthPlayer.AutoSize = true;
            this.lblHealthPlayer.Location = new System.Drawing.Point(87, 82);
            this.lblHealthPlayer.Name = "lblHealthPlayer";
            this.lblHealthPlayer.Size = new System.Drawing.Size(12, 20);
            this.lblHealthPlayer.TabIndex = 2;
            this.lblHealthPlayer.Text = ".";
            // 
            // healthPlayer
            // 
            this.healthPlayer.AutoSize = true;
            this.healthPlayer.Location = new System.Drawing.Point(23, 82);
            this.healthPlayer.Name = "healthPlayer";
            this.healthPlayer.Size = new System.Drawing.Size(39, 20);
            this.healthPlayer.TabIndex = 1;
            this.healthPlayer.Text = "Vida";
            // 
            // namePlayer
            // 
            this.namePlayer.AutoSize = true;
            this.namePlayer.Location = new System.Drawing.Point(23, 44);
            this.namePlayer.Name = "namePlayer";
            this.namePlayer.Size = new System.Drawing.Size(64, 20);
            this.namePlayer.TabIndex = 0;
            this.namePlayer.Text = "Nombre";
            // 
            // cbCharacters
            // 
            this.cbCharacters.FormattingEnabled = true;
            this.cbCharacters.Location = new System.Drawing.Point(12, 249);
            this.cbCharacters.Name = "cbCharacters";
            this.cbCharacters.Size = new System.Drawing.Size(307, 28);
            this.cbCharacters.TabIndex = 3;
            this.cbCharacters.SelectedIndexChanged += new System.EventHandler(this.cbCharacters_SelectedIndexChanged);
            // 
            // bgEnemy
            // 
            this.bgEnemy.Controls.Add(this.attackEnemy);
            this.bgEnemy.Controls.Add(this.lblDamageEnemy);
            this.bgEnemy.Controls.Add(this.damageEnemy);
            this.bgEnemy.Controls.Add(this.lblHealthEnemy);
            this.bgEnemy.Controls.Add(this.healthEnemy);
            this.bgEnemy.Controls.Add(this.lblNameEnemy);
            this.bgEnemy.Controls.Add(this.nameEnemy);
            this.bgEnemy.Location = new System.Drawing.Point(344, 12);
            this.bgEnemy.Name = "bgEnemy";
            this.bgEnemy.Size = new System.Drawing.Size(307, 207);
            this.bgEnemy.TabIndex = 4;
            this.bgEnemy.TabStop = false;
            this.bgEnemy.Text = "Player2";
            this.bgEnemy.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // attackEnemy
            // 
            this.attackEnemy.Location = new System.Drawing.Point(24, 155);
            this.attackEnemy.Name = "attackEnemy";
            this.attackEnemy.Size = new System.Drawing.Size(94, 29);
            this.attackEnemy.TabIndex = 6;
            this.attackEnemy.Text = "Atacar";
            this.attackEnemy.UseVisualStyleBackColor = true;
            this.attackEnemy.Click += new System.EventHandler(this.AttackEnemy_Click);
            // 
            // lblDamageEnemy
            // 
            this.lblDamageEnemy.AutoSize = true;
            this.lblDamageEnemy.Location = new System.Drawing.Point(91, 118);
            this.lblDamageEnemy.Name = "lblDamageEnemy";
            this.lblDamageEnemy.Size = new System.Drawing.Size(12, 20);
            this.lblDamageEnemy.TabIndex = 5;
            this.lblDamageEnemy.Text = ".";
            // 
            // damageEnemy
            // 
            this.damageEnemy.AutoSize = true;
            this.damageEnemy.Location = new System.Drawing.Point(24, 118);
            this.damageEnemy.Name = "damageEnemy";
            this.damageEnemy.Size = new System.Drawing.Size(45, 20);
            this.damageEnemy.TabIndex = 4;
            this.damageEnemy.Text = "Daño";
            // 
            // lblHealthEnemy
            // 
            this.lblHealthEnemy.AutoSize = true;
            this.lblHealthEnemy.Location = new System.Drawing.Point(91, 82);
            this.lblHealthEnemy.Name = "lblHealthEnemy";
            this.lblHealthEnemy.Size = new System.Drawing.Size(12, 20);
            this.lblHealthEnemy.TabIndex = 3;
            this.lblHealthEnemy.Text = ".";
            // 
            // healthEnemy
            // 
            this.healthEnemy.AutoSize = true;
            this.healthEnemy.Location = new System.Drawing.Point(24, 82);
            this.healthEnemy.Name = "healthEnemy";
            this.healthEnemy.Size = new System.Drawing.Size(39, 20);
            this.healthEnemy.TabIndex = 2;
            this.healthEnemy.Text = "Vida";
            // 
            // lblNameEnemy
            // 
            this.lblNameEnemy.AutoSize = true;
            this.lblNameEnemy.Location = new System.Drawing.Point(91, 44);
            this.lblNameEnemy.Name = "lblNameEnemy";
            this.lblNameEnemy.Size = new System.Drawing.Size(12, 20);
            this.lblNameEnemy.TabIndex = 1;
            this.lblNameEnemy.Text = ".";
            // 
            // nameEnemy
            // 
            this.nameEnemy.AutoSize = true;
            this.nameEnemy.Location = new System.Drawing.Point(24, 44);
            this.nameEnemy.Name = "nameEnemy";
            this.nameEnemy.Size = new System.Drawing.Size(64, 20);
            this.nameEnemy.TabIndex = 0;
            this.nameEnemy.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 301);
            this.Controls.Add(this.bgEnemy);
            this.Controls.Add(this.cbCharacters);
            this.Controls.Add(this.bgPlayer);
            this.Controls.Add(this.btnGo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bgPlayer.ResumeLayout(false);
            this.bgPlayer.PerformLayout();
            this.bgEnemy.ResumeLayout(false);
            this.bgEnemy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label lblNamePlayer;
        private System.Windows.Forms.GroupBox bgPlayer;
        private System.Windows.Forms.Label lblHealthPlayer;
        private System.Windows.Forms.Label healthPlayer;
        private System.Windows.Forms.Label namePlayer;
        private System.Windows.Forms.ComboBox cbCharacters;
        private System.Windows.Forms.GroupBox bgEnemy;
        private System.Windows.Forms.Button attackPlayer;
        private System.Windows.Forms.Label damagePlayer;
        private System.Windows.Forms.Label lblDamagePlayer;
        private System.Windows.Forms.Button attackEnemy;
        private System.Windows.Forms.Label lblDamageEnemy;
        private System.Windows.Forms.Label damageEnemy;
        private System.Windows.Forms.Label lblHealthEnemy;
        private System.Windows.Forms.Label healthEnemy;
        private System.Windows.Forms.Label lblNameEnemy;
        private System.Windows.Forms.Label nameEnemy;
    }
}

