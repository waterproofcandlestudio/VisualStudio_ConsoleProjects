
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
            this.lblName = new System.Windows.Forms.Label();
            this.bgCharacter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.cbCharacters = new System.Windows.Forms.ComboBox();
            this.bgCharacter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(116, 174);
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
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(87, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(12, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = ".";
            // 
            // bgCharacter
            // 
            this.bgCharacter.Controls.Add(this.label1);
            this.bgCharacter.Controls.Add(this.lblHealth);
            this.bgCharacter.Controls.Add(this.name);
            this.bgCharacter.Controls.Add(this.lblName);
            this.bgCharacter.Location = new System.Drawing.Point(12, 12);
            this.bgCharacter.Name = "bgCharacter";
            this.bgCharacter.Size = new System.Drawing.Size(307, 122);
            this.bgCharacter.TabIndex = 2;
            this.bgCharacter.TabStop = false;
            this.bgCharacter.Text = "Character";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = ".";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(23, 84);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(53, 20);
            this.lblHealth.TabIndex = 1;
            this.lblHealth.Text = "Health";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(23, 44);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(49, 20);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // cbCharacters
            // 
            this.cbCharacters.FormattingEnabled = true;
            this.cbCharacters.Location = new System.Drawing.Point(12, 140);
            this.cbCharacters.Name = "cbCharacters";
            this.cbCharacters.Size = new System.Drawing.Size(307, 28);
            this.cbCharacters.TabIndex = 3;
            this.cbCharacters.SelectedIndexChanged += new System.EventHandler(this.cbCharacters_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 216);
            this.Controls.Add(this.cbCharacters);
            this.Controls.Add(this.bgCharacter);
            this.Controls.Add(this.btnGo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bgCharacter.ResumeLayout(false);
            this.bgCharacter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox bgCharacter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ComboBox cbCharacters;
    }
}

