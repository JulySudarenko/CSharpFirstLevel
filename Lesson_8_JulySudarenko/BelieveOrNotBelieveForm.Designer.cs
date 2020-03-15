namespace Lesson_8_JulySudarenko
{
    partial class BelieveOrNotBelieveForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.progInfoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.trueTextBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.referenceMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(529, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenu,
            this.openMenu,
            this.saveMenu,
            this.saveAsMenu,
            this.toolStripSeparator1,
            this.exitMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(53, 23);
            this.fileMenu.Text = "Файл";
            // 
            // newMenu
            // 
            this.newMenu.Name = "newMenu";
            this.newMenu.Size = new System.Drawing.Size(170, 24);
            this.newMenu.Text = "Создать";
            this.newMenu.Click += new System.EventHandler(this.newMenu_Click);
            // 
            // openMenu
            // 
            this.openMenu.Name = "openMenu";
            this.openMenu.Size = new System.Drawing.Size(170, 24);
            this.openMenu.Text = "Открыть";
            this.openMenu.Click += new System.EventHandler(this.openMenu_Click);
            // 
            // saveMenu
            // 
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.Size = new System.Drawing.Size(170, 24);
            this.saveMenu.Text = "Сохранить";
            this.saveMenu.Click += new System.EventHandler(this.saveMenu_Click);
            // 
            // saveAsMenu
            // 
            this.saveAsMenu.Name = "saveAsMenu";
            this.saveAsMenu.Size = new System.Drawing.Size(170, 24);
            this.saveAsMenu.Text = "Сохранить как";
            this.saveAsMenu.Click += new System.EventHandler(this.saveAsMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(180, 24);
            this.exitMenu.Text = "Выход";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click_1);
            // 
            // referenceMenu
            // 
            this.referenceMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenu,
            this.progInfoMenu});
            this.referenceMenu.Name = "referenceMenu";
            this.referenceMenu.Size = new System.Drawing.Size(74, 23);
            this.referenceMenu.Text = "Справка";
            // 
            // helpMenu
            // 
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(164, 24);
            this.helpMenu.Text = "Помощь";
            // 
            // progInfoMenu
            // 
            this.progInfoMenu.Name = "progInfoMenu";
            this.progInfoMenu.Size = new System.Drawing.Size(180, 24);
            this.progInfoMenu.Text = "О программе";
            this.progInfoMenu.Click += new System.EventHandler(this.progInfoMenu_Click);
            // 
            // questionTextBox
            // 
            this.questionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionTextBox.Location = new System.Drawing.Point(12, 34);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(505, 159);
            this.questionTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(12, 199);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(108, 34);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(126, 199);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(108, 34);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(240, 199);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 34);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // numUpDown
            // 
            this.numUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDown.Location = new System.Drawing.Point(358, 204);
            this.numUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(59, 26);
            this.numUpDown.TabIndex = 5;
            this.numUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown.ValueChanged += new System.EventHandler(this.numUpDown_ValueChanged);
            // 
            // trueTextBox
            // 
            this.trueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trueTextBox.Location = new System.Drawing.Point(430, 204);
            this.trueTextBox.Name = "trueTextBox";
            this.trueTextBox.Size = new System.Drawing.Size(87, 29);
            this.trueTextBox.TabIndex = 6;
            this.trueTextBox.Text = "Правда";
            this.trueTextBox.UseVisualStyleBackColor = true;
            // 
            // BelieveOrNotBelieveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 256);
            this.Controls.Add(this.trueTextBox);
            this.Controls.Add(this.numUpDown);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BelieveOrNotBelieveForm";
            this.Text = "Верю - не верю";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newMenu;
        private System.Windows.Forms.ToolStripMenuItem openMenu;
        private System.Windows.Forms.ToolStripMenuItem saveMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.CheckBox trueTextBox;
        private System.Windows.Forms.ToolStripMenuItem referenceMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem progInfoMenu;
    }
}

