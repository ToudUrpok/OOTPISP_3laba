﻿namespace WindowsFormsAppGraphicsEditor
{
    partial class FormEditorWindow
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
            this.btStart = new System.Windows.Forms.Button();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbSix = new System.Windows.Forms.RadioButton();
            this.rbEllipse = new System.Windows.Forms.RadioButton();
            this.pbPage = new System.Windows.Forms.PictureBox();
            this.SerializeButton = new System.Windows.Forms.Button();
            this.DrawAllShapesButton = new System.Windows.Forms.Button();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.lbFigures = new System.Windows.Forms.ListBox();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.tbY1 = new System.Windows.Forms.TextBox();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.tbY2 = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.btCorrect = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblY1 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblY2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(432, 546);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(93, 34);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Очистить";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(12, 12);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(71, 21);
            this.rbLine.TabIndex = 1;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Линия";
            this.rbLine.UseVisualStyleBackColor = true;
            this.rbLine.CheckedChanged += new System.EventHandler(this.rbLine_CheckedChanged);
            // 
            // rbTriangle
            // 
            this.rbTriangle.AutoSize = true;
            this.rbTriangle.Location = new System.Drawing.Point(99, 12);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(112, 21);
            this.rbTriangle.TabIndex = 2;
            this.rbTriangle.TabStop = true;
            this.rbTriangle.Text = "Треугольник";
            this.rbTriangle.UseVisualStyleBackColor = true;
            this.rbTriangle.CheckedChanged += new System.EventHandler(this.rbTriangle_CheckedChanged);
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(227, 13);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(130, 21);
            this.rbRectangle.TabIndex = 3;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Прямоугольник";
            this.rbRectangle.UseVisualStyleBackColor = true;
            this.rbRectangle.CheckedChanged += new System.EventHandler(this.rbRectangle_CheckedChanged);
            // 
            // rbSix
            // 
            this.rbSix.AutoSize = true;
            this.rbSix.Location = new System.Drawing.Point(374, 13);
            this.rbSix.Name = "rbSix";
            this.rbSix.Size = new System.Drawing.Size(128, 21);
            this.rbSix.TabIndex = 5;
            this.rbSix.TabStop = true;
            this.rbSix.Text = "Шестиугольник";
            this.rbSix.UseVisualStyleBackColor = true;
            this.rbSix.CheckedChanged += new System.EventHandler(this.rbSix_CheckedChanged);
            // 
            // rbEllipse
            // 
            this.rbEllipse.AutoSize = true;
            this.rbEllipse.Location = new System.Drawing.Point(523, 12);
            this.rbEllipse.Name = "rbEllipse";
            this.rbEllipse.Size = new System.Drawing.Size(77, 21);
            this.rbEllipse.TabIndex = 6;
            this.rbEllipse.TabStop = true;
            this.rbEllipse.Text = "Эллипс";
            this.rbEllipse.UseVisualStyleBackColor = true;
            this.rbEllipse.CheckedChanged += new System.EventHandler(this.rbEllipse_CheckedChanged);
            // 
            // pbPage
            // 
            this.pbPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPage.Location = new System.Drawing.Point(0, 40);
            this.pbPage.Margin = new System.Windows.Forms.Padding(4);
            this.pbPage.Name = "pbPage";
            this.pbPage.Size = new System.Drawing.Size(954, 499);
            this.pbPage.TabIndex = 7;
            this.pbPage.TabStop = false;
            this.pbPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPage_MouseDown);
            this.pbPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPage_MouseMove);
            this.pbPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPage_MouseUp);
            // 
            // SerializeButton
            // 
            this.SerializeButton.Location = new System.Drawing.Point(718, 5);
            this.SerializeButton.Margin = new System.Windows.Forms.Padding(4);
            this.SerializeButton.Name = "SerializeButton";
            this.SerializeButton.Size = new System.Drawing.Size(105, 27);
            this.SerializeButton.TabIndex = 32;
            this.SerializeButton.Text = "Сохранить";
            this.SerializeButton.UseVisualStyleBackColor = true;
            this.SerializeButton.Click += new System.EventHandler(this.SerializeButton_Click);
            // 
            // DrawAllShapesButton
            // 
            this.DrawAllShapesButton.Location = new System.Drawing.Point(849, 5);
            this.DrawAllShapesButton.Margin = new System.Windows.Forms.Padding(4);
            this.DrawAllShapesButton.Name = "DrawAllShapesButton";
            this.DrawAllShapesButton.Size = new System.Drawing.Size(105, 27);
            this.DrawAllShapesButton.TabIndex = 31;
            this.DrawAllShapesButton.Text = "Загрузить";
            this.DrawAllShapesButton.UseVisualStyleBackColor = true;
            this.DrawAllShapesButton.Click += new System.EventHandler(this.DrawAllShapesButton_Click);
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.Black;
            this.colorBox.Location = new System.Drawing.Point(644, 5);
            this.colorBox.Margin = new System.Windows.Forms.Padding(4);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(28, 28);
            this.colorBox.TabIndex = 33;
            this.colorBox.TabStop = false;
            this.colorBox.Click += new System.EventHandler(this.colorBox_Click);
            // 
            // lbFigures
            // 
            this.lbFigures.FormattingEnabled = true;
            this.lbFigures.ItemHeight = 16;
            this.lbFigures.Location = new System.Drawing.Point(961, 40);
            this.lbFigures.Name = "lbFigures";
            this.lbFigures.Size = new System.Drawing.Size(210, 180);
            this.lbFigures.TabIndex = 34;
            this.lbFigures.SelectedIndexChanged += new System.EventHandler(this.lbFigures_SelectedIndexChanged);
            // 
            // tbX1
            // 
            this.tbX1.Location = new System.Drawing.Point(995, 285);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(34, 22);
            this.tbX1.TabIndex = 35;
            this.tbX1.Visible = false;
            // 
            // tbY1
            // 
            this.tbY1.Location = new System.Drawing.Point(995, 323);
            this.tbY1.Name = "tbY1";
            this.tbY1.Size = new System.Drawing.Size(34, 22);
            this.tbY1.TabIndex = 36;
            this.tbY1.Visible = false;
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(1064, 285);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(34, 22);
            this.tbX2.TabIndex = 37;
            this.tbX2.Visible = false;
            // 
            // tbY2
            // 
            this.tbY2.Location = new System.Drawing.Point(1064, 323);
            this.tbY2.Name = "tbY2";
            this.tbY2.Size = new System.Drawing.Size(34, 22);
            this.tbY2.TabIndex = 38;
            this.tbY2.Visible = false;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(1016, 364);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(82, 22);
            this.tbName.TabIndex = 39;
            this.tbName.Visible = false;
            // 
            // pbColor
            // 
            this.pbColor.BackColor = System.Drawing.Color.Black;
            this.pbColor.Location = new System.Drawing.Point(1070, 402);
            this.pbColor.Margin = new System.Windows.Forms.Padding(4);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(28, 28);
            this.pbColor.TabIndex = 40;
            this.pbColor.TabStop = false;
            this.pbColor.Visible = false;
            this.pbColor.Click += new System.EventHandler(this.pbColor_Click);
            // 
            // btCorrect
            // 
            this.btCorrect.Location = new System.Drawing.Point(962, 237);
            this.btCorrect.Margin = new System.Windows.Forms.Padding(4);
            this.btCorrect.Name = "btCorrect";
            this.btCorrect.Size = new System.Drawing.Size(117, 27);
            this.btCorrect.TabIndex = 41;
            this.btCorrect.Text = "Редактировать";
            this.btCorrect.UseVisualStyleBackColor = true;
            this.btCorrect.Visible = false;
            this.btCorrect.Click += new System.EventHandler(this.btCorrect_Click);
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(981, 438);
            this.btChange.Margin = new System.Windows.Forms.Padding(4);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(117, 27);
            this.btChange.TabIndex = 42;
            this.btChange.Text = "Изменить";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Visible = false;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(964, 285);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(25, 17);
            this.lblX1.TabIndex = 43;
            this.lblX1.Text = "X1";
            this.lblX1.Visible = false;
            // 
            // lblY1
            // 
            this.lblY1.AutoSize = true;
            this.lblY1.Location = new System.Drawing.Point(964, 326);
            this.lblY1.Name = "lblY1";
            this.lblY1.Size = new System.Drawing.Size(25, 17);
            this.lblY1.TabIndex = 44;
            this.lblY1.Text = "Y1";
            this.lblY1.Visible = false;
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(1035, 285);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(25, 17);
            this.lblX2.TabIndex = 45;
            this.lblX2.Text = "X2";
            this.lblX2.Visible = false;
            // 
            // lblY2
            // 
            this.lblY2.AutoSize = true;
            this.lblY2.Location = new System.Drawing.Point(1035, 328);
            this.lblY2.Name = "lblY2";
            this.lblY2.Size = new System.Drawing.Size(25, 17);
            this.lblY2.TabIndex = 46;
            this.lblY2.Text = "Y2";
            this.lblY2.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(964, 367);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 17);
            this.lblName.TabIndex = 47;
            this.lblName.Text = "name";
            this.lblName.Visible = false;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(1013, 402);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(39, 17);
            this.lblColor.TabIndex = 48;
            this.lblColor.Text = "color";
            this.lblColor.Visible = false;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(1087, 237);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(84, 27);
            this.btDelete.TabIndex = 49;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Visible = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // FormEditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 592);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblY2);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.lblY1);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btCorrect);
            this.Controls.Add(this.pbColor);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbY2);
            this.Controls.Add(this.tbX2);
            this.Controls.Add(this.tbY1);
            this.Controls.Add(this.tbX1);
            this.Controls.Add(this.lbFigures);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.SerializeButton);
            this.Controls.Add(this.DrawAllShapesButton);
            this.Controls.Add(this.pbPage);
            this.Controls.Add(this.rbEllipse);
            this.Controls.Add(this.rbSix);
            this.Controls.Add(this.rbRectangle);
            this.Controls.Add(this.rbTriangle);
            this.Controls.Add(this.rbLine);
            this.Controls.Add(this.btStart);
            this.DoubleBuffered = true;
            this.Name = "FormEditorWindow";
            this.Text = "Graphics editor";
            ((System.ComponentModel.ISupportInitialize)(this.pbPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.RadioButton rbTriangle;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbSix;
        private System.Windows.Forms.RadioButton rbEllipse;
        private System.Windows.Forms.PictureBox pbPage;
        private System.Windows.Forms.Button SerializeButton;
        private System.Windows.Forms.Button DrawAllShapesButton;
        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ListBox lbFigures;
        private System.Windows.Forms.TextBox tbX1;
        private System.Windows.Forms.TextBox tbY1;
        private System.Windows.Forms.TextBox tbX2;
        private System.Windows.Forms.TextBox tbY2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.Button btCorrect;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label lblY1;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblY2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btDelete;
    }
}

