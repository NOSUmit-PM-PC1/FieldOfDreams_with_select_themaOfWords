namespace FieldOfDreams
{
    partial class FormSelectWords
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAnimals = new System.Windows.Forms.RadioButton();
            this.radioButtonFruits = new System.Windows.Forms.RadioButton();
            this.radioButtonFlowers = new System.Windows.Forms.RadioButton();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFlowers);
            this.groupBox1.Controls.Add(this.radioButtonFruits);
            this.groupBox1.Controls.Add(this.radioButtonAnimals);
            this.groupBox1.Location = new System.Drawing.Point(89, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите тему";
            // 
            // radioButtonAnimals
            // 
            this.radioButtonAnimals.AutoSize = true;
            this.radioButtonAnimals.Location = new System.Drawing.Point(98, 72);
            this.radioButtonAnimals.Name = "radioButtonAnimals";
            this.radioButtonAnimals.Size = new System.Drawing.Size(110, 24);
            this.radioButtonAnimals.TabIndex = 0;
            this.radioButtonAnimals.TabStop = true;
            this.radioButtonAnimals.Text = "животные";
            this.radioButtonAnimals.UseVisualStyleBackColor = true;
            // 
            // radioButtonFruits
            // 
            this.radioButtonFruits.AutoSize = true;
            this.radioButtonFruits.Location = new System.Drawing.Point(98, 126);
            this.radioButtonFruits.Name = "radioButtonFruits";
            this.radioButtonFruits.Size = new System.Drawing.Size(93, 24);
            this.radioButtonFruits.TabIndex = 1;
            this.radioButtonFruits.TabStop = true;
            this.radioButtonFruits.Text = "фрукты";
            this.radioButtonFruits.UseVisualStyleBackColor = true;
            // 
            // radioButtonFlowers
            // 
            this.radioButtonFlowers.AutoSize = true;
            this.radioButtonFlowers.Location = new System.Drawing.Point(98, 181);
            this.radioButtonFlowers.Name = "radioButtonFlowers";
            this.radioButtonFlowers.Size = new System.Drawing.Size(81, 24);
            this.radioButtonFlowers.TabIndex = 2;
            this.radioButtonFlowers.TabStop = true;
            this.radioButtonFlowers.Text = "цветы";
            this.radioButtonFlowers.UseVisualStyleBackColor = true;
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(89, 355);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(354, 54);
            this.buttonStartGame.TabIndex = 1;
            this.buttonStartGame.Text = "Начать игру";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            // 
            // FormSelectWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSelectWords";
            this.Text = "Выберите тему";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFlowers;
        private System.Windows.Forms.RadioButton radioButtonFruits;
        private System.Windows.Forms.RadioButton radioButtonAnimals;
        private System.Windows.Forms.Button buttonStartGame;
    }
}