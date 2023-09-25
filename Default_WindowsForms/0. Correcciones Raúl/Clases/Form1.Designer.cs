
namespace Clases
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
            this.lblName = new System.Windows.Forms.Label();
            this.gbCharacter = new System.Windows.Forms.GroupBox();
            this.lblHealth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCharacters = new System.Windows.Forms.ComboBox();
            this.gbCharacter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(105, 213);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(94, 29);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(80, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(12, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = ".";
            // 
            // gbCharacter
            // 
            this.gbCharacter.Controls.Add(this.lblHealth);
            this.gbCharacter.Controls.Add(this.label2);
            this.gbCharacter.Controls.Add(this.label1);
            this.gbCharacter.Controls.Add(this.lblName);
            this.gbCharacter.Location = new System.Drawing.Point(25, 28);
            this.gbCharacter.Name = "gbCharacter";
            this.gbCharacter.Size = new System.Drawing.Size(250, 125);
            this.gbCharacter.TabIndex = 2;
            this.gbCharacter.TabStop = false;
            this.gbCharacter.Text = "Character";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(79, 83);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(12, 20);
            this.lblHealth.TabIndex = 4;
            this.lblHealth.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Health:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // cbCharacters
            // 
            this.cbCharacters.FormattingEnabled = true;
            this.cbCharacters.Location = new System.Drawing.Point(75, 179);
            this.cbCharacters.Name = "cbCharacters";
            this.cbCharacters.Size = new System.Drawing.Size(151, 28);
            this.cbCharacters.TabIndex = 3;
            this.cbCharacters.SelectedIndexChanged += new System.EventHandler(this.cbCharacters_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 267);
            this.Controls.Add(this.cbCharacters);
            this.Controls.Add(this.gbCharacter);
            this.Controls.Add(this.btnGo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCharacter.ResumeLayout(false);
            this.gbCharacter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbCharacter;
        private System.Windows.Forms.ComboBox cbCharacters;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

