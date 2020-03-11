namespace Lesson_7_JulySudarenko
{
    partial class FirstGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.Main = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonYes
            // 
            this.ButtonYes.BackColor = System.Drawing.Color.ForestGreen;
            this.ButtonYes.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonYes.ForeColor = System.Drawing.Color.OldLace;
            this.ButtonYes.Location = new System.Drawing.Point(0, 0);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.Size = new System.Drawing.Size(59, 317);
            this.ButtonYes.TabIndex = 0;
            this.ButtonYes.Text = "Да";
            this.ButtonYes.UseVisualStyleBackColor = false;
            this.ButtonYes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonYes_MouseClick);
            // 
            // buttonNo
            // 
            this.buttonNo.BackColor = System.Drawing.Color.Crimson;
            this.buttonNo.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNo.ForeColor = System.Drawing.Color.OldLace;
            this.buttonNo.Location = new System.Drawing.Point(477, 0);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(58, 317);
            this.buttonNo.TabIndex = 1;
            this.buttonNo.Text = "Нет";
            this.buttonNo.UseVisualStyleBackColor = false;
            this.buttonNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonNo_MouseClick);
            this.buttonNo.MouseEnter += new System.EventHandler(this.ButtonNo_MouseEnter);
            this.buttonNo.MouseLeave += new System.EventHandler(this.ButtonNo_MouseLeave);
            // 
            // Main
            // 
            this.Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main.BackColor = System.Drawing.Color.Transparent;
            this.Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main.ForeColor = System.Drawing.Color.Blue;
            this.Main.Location = new System.Drawing.Point(88, 98);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(386, 317);
            this.Main.TabIndex = 2;
            this.Main.Text = "Ты хороший программист?";
            this.Main.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FirstGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 317);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.ButtonYes);
            this.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Name = "FirstGame";
            this.Text = "FirstGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonYes;
        private System.Windows.Forms.Button buttonNo;
        public System.Windows.Forms.Label Main;
    }
}

