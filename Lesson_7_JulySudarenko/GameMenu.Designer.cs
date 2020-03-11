namespace Lesson_7_JulySudarenko
{
    partial class GameMenu
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
            this.FirstGame = new System.Windows.Forms.Button();
            this.WF_Udvoitel = new System.Windows.Forms.Button();
            this.CountTrainer = new System.Windows.Forms.Button();
            this.GuessNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstGame
            // 
            this.FirstGame.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FirstGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstGame.Location = new System.Drawing.Point(12, 15);
            this.FirstGame.Name = "FirstGame";
            this.FirstGame.Size = new System.Drawing.Size(217, 40);
            this.FirstGame.TabIndex = 0;
            this.FirstGame.Text = "Учебная";
            this.FirstGame.UseVisualStyleBackColor = false;
            this.FirstGame.Click += new System.EventHandler(this.FirstGame_Click);
            // 
            // WF_Udvoitel
            // 
            this.WF_Udvoitel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.WF_Udvoitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WF_Udvoitel.Location = new System.Drawing.Point(12, 58);
            this.WF_Udvoitel.Name = "WF_Udvoitel";
            this.WF_Udvoitel.Size = new System.Drawing.Size(217, 40);
            this.WF_Udvoitel.TabIndex = 1;
            this.WF_Udvoitel.Text = "Удвоитель";
            this.WF_Udvoitel.UseVisualStyleBackColor = false;
            this.WF_Udvoitel.Click += new System.EventHandler(this.WF_Udvoitel_Click);
            // 
            // CountTrainer
            // 
            this.CountTrainer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CountTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountTrainer.Location = new System.Drawing.Point(12, 101);
            this.CountTrainer.Name = "CountTrainer";
            this.CountTrainer.Size = new System.Drawing.Size(217, 40);
            this.CountTrainer.TabIndex = 2;
            this.CountTrainer.Text = "Устный счет";
            this.CountTrainer.UseVisualStyleBackColor = false;
            this.CountTrainer.Click += new System.EventHandler(this.CountTrainer_Click);
            // 
            // GuessNumber
            // 
            this.GuessNumber.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GuessNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GuessNumber.Location = new System.Drawing.Point(12, 144);
            this.GuessNumber.Name = "GuessNumber";
            this.GuessNumber.Size = new System.Drawing.Size(217, 40);
            this.GuessNumber.TabIndex = 3;
            this.GuessNumber.Text = "Угадай число";
            this.GuessNumber.UseVisualStyleBackColor = false;
            this.GuessNumber.Click += new System.EventHandler(this.GuessNumber_Click);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 195);
            this.Controls.Add(this.GuessNumber);
            this.Controls.Add(this.CountTrainer);
            this.Controls.Add(this.WF_Udvoitel);
            this.Controls.Add(this.FirstGame);
            this.Name = "GameMenu";
            this.Text = "GameMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FirstGame;
        private System.Windows.Forms.Button WF_Udvoitel;
        private System.Windows.Forms.Button CountTrainer;
        private System.Windows.Forms.Button GuessNumber;
    }
}