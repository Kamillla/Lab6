
namespace Lab6oop
{
    partial class Form1
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
            this.paintBox = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.pPink = new System.Windows.Forms.Panel();
            this.pRed = new System.Windows.Forms.Panel();
            this.pBlue = new System.Windows.Forms.Panel();
            this.pWhite = new System.Windows.Forms.Panel();
            this.pGreen = new System.Windows.Forms.Panel();
            this.pYellow = new System.Windows.Forms.Panel();
            this.gBoxShapes = new System.Windows.Forms.GroupBox();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.paintBox)).BeginInit();
            this.panel.SuspendLayout();
            this.gBoxShapes.SuspendLayout();
            this.SuspendLayout();
            // 
            // paintBox
            // 
            this.paintBox.BackColor = System.Drawing.Color.White;
            this.paintBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintBox.Location = new System.Drawing.Point(0, 0);
            this.paintBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paintBox.Name = "paintBox";
            this.paintBox.Size = new System.Drawing.Size(662, 449);
            this.paintBox.TabIndex = 0;
            this.paintBox.TabStop = false;
            this.paintBox.Paint += new System.Windows.Forms.PaintEventHandler(this.paintBox_Paint);
            this.paintBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paintBox_MouseClick);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.SlateGray;
            this.panel.Controls.Add(this.pPink);
            this.panel.Controls.Add(this.pRed);
            this.panel.Controls.Add(this.pBlue);
            this.panel.Controls.Add(this.pWhite);
            this.panel.Controls.Add(this.pGreen);
            this.panel.Controls.Add(this.pYellow);
            this.panel.Controls.Add(this.gBoxShapes);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(662, 67);
            this.panel.TabIndex = 1;
            // 
            // pPink
            // 
            this.pPink.BackColor = System.Drawing.Color.Fuchsia;
            this.pPink.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pPink.Location = new System.Drawing.Point(187, 20);
            this.pPink.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pPink.Name = "pPink";
            this.pPink.Size = new System.Drawing.Size(24, 25);
            this.pPink.TabIndex = 7;
            this.pPink.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // pRed
            // 
            this.pRed.BackColor = System.Drawing.Color.Red;
            this.pRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pRed.Location = new System.Drawing.Point(39, 20);
            this.pRed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pRed.Name = "pRed";
            this.pRed.Size = new System.Drawing.Size(24, 25);
            this.pRed.TabIndex = 4;
            this.pRed.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // pBlue
            // 
            this.pBlue.BackColor = System.Drawing.Color.Blue;
            this.pBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBlue.Location = new System.Drawing.Point(149, 20);
            this.pBlue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBlue.Name = "pBlue";
            this.pBlue.Size = new System.Drawing.Size(24, 25);
            this.pBlue.TabIndex = 6;
            this.pBlue.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // pWhite
            // 
            this.pWhite.BackColor = System.Drawing.Color.White;
            this.pWhite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pWhite.Location = new System.Drawing.Point(223, 20);
            this.pWhite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pWhite.Name = "pWhite";
            this.pWhite.Size = new System.Drawing.Size(24, 25);
            this.pWhite.TabIndex = 8;
            this.pWhite.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // pGreen
            // 
            this.pGreen.BackColor = System.Drawing.Color.Lime;
            this.pGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pGreen.Location = new System.Drawing.Point(111, 20);
            this.pGreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pGreen.Name = "pGreen";
            this.pGreen.Size = new System.Drawing.Size(24, 25);
            this.pGreen.TabIndex = 6;
            this.pGreen.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // pYellow
            // 
            this.pYellow.BackColor = System.Drawing.Color.Yellow;
            this.pYellow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pYellow.Location = new System.Drawing.Point(74, 20);
            this.pYellow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pYellow.Name = "pYellow";
            this.pYellow.Size = new System.Drawing.Size(24, 25);
            this.pYellow.TabIndex = 5;
            this.pYellow.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // gBoxShapes
            // 
            this.gBoxShapes.BackColor = System.Drawing.Color.White;
            this.gBoxShapes.Controls.Add(this.rbLine);
            this.gBoxShapes.Controls.Add(this.rbTriangle);
            this.gBoxShapes.Controls.Add(this.rbSquare);
            this.gBoxShapes.Controls.Add(this.rbCircle);
            this.gBoxShapes.Location = new System.Drawing.Point(298, 11);
            this.gBoxShapes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxShapes.Name = "gBoxShapes";
            this.gBoxShapes.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxShapes.Size = new System.Drawing.Size(338, 44);
            this.gBoxShapes.TabIndex = 0;
            this.gBoxShapes.TabStop = false;
            this.gBoxShapes.Text = "Фигура";
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(254, 17);
            this.rbLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(66, 17);
            this.rbLine.TabIndex = 3;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "отрезок";
            this.rbLine.UseVisualStyleBackColor = true;
            this.rbLine.CheckedChanged += new System.EventHandler(this.rbCircle_CheckedChanged);
            // 
            // rbTriangle
            // 
            this.rbTriangle.AutoSize = true;
            this.rbTriangle.Location = new System.Drawing.Point(81, 17);
            this.rbTriangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(88, 17);
            this.rbTriangle.TabIndex = 2;
            this.rbTriangle.TabStop = true;
            this.rbTriangle.Text = "треугольник";
            this.rbTriangle.UseVisualStyleBackColor = true;
            this.rbTriangle.CheckedChanged += new System.EventHandler(this.rbCircle_CheckedChanged);
            // 
            // rbSquare
            // 
            this.rbSquare.AutoSize = true;
            this.rbSquare.Location = new System.Drawing.Point(177, 17);
            this.rbSquare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(66, 17);
            this.rbSquare.TabIndex = 1;
            this.rbSquare.TabStop = true;
            this.rbSquare.Text = "квадрат";
            this.rbSquare.UseVisualStyleBackColor = true;
            this.rbSquare.CheckedChanged += new System.EventHandler(this.rbCircle_CheckedChanged);
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Location = new System.Drawing.Point(26, 17);
            this.rbCircle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(47, 17);
            this.rbCircle.TabIndex = 0;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "круг";
            this.rbCircle.UseVisualStyleBackColor = true;
            this.rbCircle.CheckedChanged += new System.EventHandler(this.rbCircle_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 449);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.paintBox);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Shapes";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.paintBox)).EndInit();
            this.panel.ResumeLayout(false);
            this.gBoxShapes.ResumeLayout(false);
            this.gBoxShapes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox paintBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox gBoxShapes;
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.RadioButton rbTriangle;
        private System.Windows.Forms.Panel pGreen;
        private System.Windows.Forms.Panel pYellow;
        private System.Windows.Forms.Panel pRed;
        private System.Windows.Forms.Panel pBlue;
        private System.Windows.Forms.Panel pPink;
        private System.Windows.Forms.Panel pWhite;
    }
}

