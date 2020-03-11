namespace Lesson_7_JulySudarenko
{
    partial class GuessNumber
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
            this.InfoForUser = new System.Windows.Forms.Label();
            this.OKbutton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Play = new System.Windows.Forms.ToolStripMenuItem();
            this.UserAnswer = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoForUser
            // 
            this.InfoForUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoForUser.Location = new System.Drawing.Point(12, 43);
            this.InfoForUser.Name = "InfoForUser";
            this.InfoForUser.Size = new System.Drawing.Size(225, 60);
            this.InfoForUser.TabIndex = 1;
            this.InfoForUser.Text = "label1";
            // 
            // OKbutton
            // 
            this.OKbutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OKbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKbutton.Location = new System.Drawing.Point(81, 157);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(80, 30);
            this.OKbutton.TabIndex = 2;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = false;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Play});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(236, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Play
            // 
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(57, 20);
            this.Play.Text = "Играть";
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // UserAnswer
            // 
            this.UserAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserAnswer.Location = new System.Drawing.Point(97, 120);
            this.UserAnswer.Mask = "00000";
            this.UserAnswer.Name = "UserAnswer";
            this.UserAnswer.Size = new System.Drawing.Size(44, 26);
            this.UserAnswer.TabIndex = 4;
            this.UserAnswer.ValidatingType = typeof(int);
            // 
            // GuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 197);
            this.Controls.Add(this.UserAnswer);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.InfoForUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GuessNumber";
            this.Text = "GuessNumber";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label InfoForUser;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Play;
        private System.Windows.Forms.MaskedTextBox UserAnswer;
    }
}