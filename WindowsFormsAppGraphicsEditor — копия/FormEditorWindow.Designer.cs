namespace WindowsFormsAppGraphicsEditor
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
            ((System.ComponentModel.ISupportInitialize)(this.pbPage)).BeginInit();
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
            this.SerializeButton.Location = new System.Drawing.Point(659, 6);
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
            this.DrawAllShapesButton.Location = new System.Drawing.Point(794, 6);
            this.DrawAllShapesButton.Margin = new System.Windows.Forms.Padding(4);
            this.DrawAllShapesButton.Name = "DrawAllShapesButton";
            this.DrawAllShapesButton.Size = new System.Drawing.Size(105, 27);
            this.DrawAllShapesButton.TabIndex = 31;
            this.DrawAllShapesButton.Text = "Загрузить";
            this.DrawAllShapesButton.UseVisualStyleBackColor = true;
            this.DrawAllShapesButton.Click += new System.EventHandler(this.DrawAllShapesButton_Click);
            // 
            // FormEditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 592);
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
    }
}

