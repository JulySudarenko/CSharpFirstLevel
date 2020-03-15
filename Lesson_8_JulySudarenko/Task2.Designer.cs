namespace Lesson_8_JulySudarenko
{
    partial class Task2
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.counterUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.counterUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(50, 48);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(92, 26);
            this.textBox.TabIndex = 0;
            // 
            // counterUpDown
            // 
            this.counterUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.counterUpDown.Location = new System.Drawing.Point(50, 84);
            this.counterUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.counterUpDown.Name = "counterUpDown";
            this.counterUpDown.Size = new System.Drawing.Size(92, 26);
            this.counterUpDown.TabIndex = 1;
            this.counterUpDown.ValueChanged += new System.EventHandler(this.CounterUpDown_ValueChanged);
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 153);
            this.Controls.Add(this.counterUpDown);
            this.Controls.Add(this.textBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Task2";
            this.Text = "Task2";
            ((System.ComponentModel.ISupportInitialize)(this.counterUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.NumericUpDown counterUpDown;
    }
}