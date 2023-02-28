
namespace CW
{
    partial class Form1
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
            this.tbSideLength = new System.Windows.Forms.TextBox();
            this.bDraw = new System.Windows.Forms.Button();
            this.lSide = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbZ = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.lX = new System.Windows.Forms.Label();
            this.lY = new System.Windows.Forms.Label();
            this.lZ = new System.Windows.Forms.Label();
            this.tbStep = new System.Windows.Forms.TextBox();
            this.lStep = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.lCount = new System.Windows.Forms.Label();
            this.lStepY = new System.Windows.Forms.Label();
            this.tbStepY = new System.Windows.Forms.TextBox();
            this.lWidth = new System.Windows.Forms.Label();
            this.lHeight = new System.Windows.Forms.Label();
            this.lThickness = new System.Windows.Forms.Label();
            this.lDepth = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbThickness = new System.Windows.Forms.TextBox();
            this.tbDepth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSideLength
            // 
            this.tbSideLength.Location = new System.Drawing.Point(149, 37);
            this.tbSideLength.Name = "tbSideLength";
            this.tbSideLength.Size = new System.Drawing.Size(100, 22);
            this.tbSideLength.TabIndex = 0;
            this.tbSideLength.Text = "20";
            // 
            // bDraw
            // 
            this.bDraw.Location = new System.Drawing.Point(338, 371);
            this.bDraw.Name = "bDraw";
            this.bDraw.Size = new System.Drawing.Size(101, 43);
            this.bDraw.TabIndex = 1;
            this.bDraw.Text = "Draw";
            this.bDraw.UseVisualStyleBackColor = true;
            this.bDraw.Click += new System.EventHandler(this.bDraw_Click);
            // 
            // lSide
            // 
            this.lSide.AutoSize = true;
            this.lSide.Location = new System.Drawing.Point(12, 42);
            this.lSide.Name = "lSide";
            this.lSide.Size = new System.Drawing.Size(133, 17);
            this.lSide.TabIndex = 2;
            this.lSide.Text = "Длина стороны(a):";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(15, 301);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(59, 22);
            this.tbX.TabIndex = 3;
            this.tbX.Text = "1";
            // 
            // tbZ
            // 
            this.tbZ.Location = new System.Drawing.Point(186, 301);
            this.tbZ.Name = "tbZ";
            this.tbZ.Size = new System.Drawing.Size(59, 22);
            this.tbZ.TabIndex = 4;
            this.tbZ.Text = "1";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(99, 301);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(59, 22);
            this.tbY.TabIndex = 5;
            this.tbY.Text = "1";
            // 
            // lX
            // 
            this.lX.AutoSize = true;
            this.lX.Location = new System.Drawing.Point(26, 272);
            this.lX.Name = "lX";
            this.lX.Size = new System.Drawing.Size(14, 17);
            this.lX.TabIndex = 6;
            this.lX.Text = "x";
            // 
            // lY
            // 
            this.lY.AutoSize = true;
            this.lY.Location = new System.Drawing.Point(113, 272);
            this.lY.Name = "lY";
            this.lY.Size = new System.Drawing.Size(15, 17);
            this.lY.TabIndex = 7;
            this.lY.Text = "y";
            // 
            // lZ
            // 
            this.lZ.AutoSize = true;
            this.lZ.Location = new System.Drawing.Point(201, 272);
            this.lZ.Name = "lZ";
            this.lZ.Size = new System.Drawing.Size(15, 17);
            this.lZ.TabIndex = 8;
            this.lZ.Text = "z";
            // 
            // tbStep
            // 
            this.tbStep.BackColor = System.Drawing.Color.White;
            this.tbStep.Location = new System.Drawing.Point(149, 77);
            this.tbStep.Name = "tbStep";
            this.tbStep.Size = new System.Drawing.Size(100, 22);
            this.tbStep.TabIndex = 9;
            this.tbStep.Text = "21";
            // 
            // lStep
            // 
            this.lStep.AutoSize = true;
            this.lStep.Location = new System.Drawing.Point(12, 77);
            this.lStep.Name = "lStep";
            this.lStep.Size = new System.Drawing.Size(65, 17);
            this.lStep.TabIndex = 10;
            this.lStep.Text = "Шаг по Х";
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(149, 151);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(100, 22);
            this.tbCount.TabIndex = 11;
            this.tbCount.Text = "5";
            // 
            // lCount
            // 
            this.lCount.AutoSize = true;
            this.lCount.Location = new System.Drawing.Point(12, 154);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(86, 17);
            this.lCount.TabIndex = 12;
            this.lCount.Text = "Количество";
            // 
            // lStepY
            // 
            this.lStepY.AutoSize = true;
            this.lStepY.Location = new System.Drawing.Point(13, 118);
            this.lStepY.Name = "lStepY";
            this.lStepY.Size = new System.Drawing.Size(65, 17);
            this.lStepY.TabIndex = 18;
            this.lStepY.Text = "Шаг по Y";
            // 
            // tbStepY
            // 
            this.tbStepY.BackColor = System.Drawing.Color.White;
            this.tbStepY.Location = new System.Drawing.Point(149, 118);
            this.tbStepY.Name = "tbStepY";
            this.tbStepY.Size = new System.Drawing.Size(100, 22);
            this.tbStepY.TabIndex = 19;
            this.tbStepY.Text = "21";
            // 
            // lWidth
            // 
            this.lWidth.AutoSize = true;
            this.lWidth.Location = new System.Drawing.Point(525, 37);
            this.lWidth.Name = "lWidth";
            this.lWidth.Size = new System.Drawing.Size(59, 17);
            this.lWidth.TabIndex = 20;
            this.lWidth.Text = "Ширина";
            // 
            // lHeight
            // 
            this.lHeight.AutoSize = true;
            this.lHeight.Location = new System.Drawing.Point(525, 77);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(57, 17);
            this.lHeight.TabIndex = 21;
            this.lHeight.Text = "Высота";
            this.lHeight.Click += new System.EventHandler(this.lHeight_Click);
            // 
            // lThickness
            // 
            this.lThickness.AutoSize = true;
            this.lThickness.Location = new System.Drawing.Point(525, 118);
            this.lThickness.Name = "lThickness";
            this.lThickness.Size = new System.Drawing.Size(68, 17);
            this.lThickness.TabIndex = 23;
            this.lThickness.Text = "Толщина";
            // 
            // lDepth
            // 
            this.lDepth.AutoSize = true;
            this.lDepth.Location = new System.Drawing.Point(525, 156);
            this.lDepth.Name = "lDepth";
            this.lDepth.Size = new System.Drawing.Size(115, 17);
            this.lDepth.TabIndex = 24;
            this.lDepth.Text = "Глубина выреза";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(688, 32);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(100, 22);
            this.tbWidth.TabIndex = 25;
            this.tbWidth.Text = "100";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(688, 72);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(100, 22);
            this.tbHeight.TabIndex = 26;
            this.tbHeight.Text = "200";
            // 
            // tbThickness
            // 
            this.tbThickness.Location = new System.Drawing.Point(688, 113);
            this.tbThickness.Name = "tbThickness";
            this.tbThickness.Size = new System.Drawing.Size(100, 22);
            this.tbThickness.TabIndex = 27;
            this.tbThickness.Text = "80";
            // 
            // tbDepth
            // 
            this.tbDepth.Location = new System.Drawing.Point(688, 151);
            this.tbDepth.Name = "tbDepth";
            this.tbDepth.Size = new System.Drawing.Size(100, 22);
            this.tbDepth.TabIndex = 28;
            this.tbDepth.Text = "80";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Параметры четырехгранной полости:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Параметры призмы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Начальные координаты:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(307, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 96);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(28, 76);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(55, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "R>a";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(28, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "R=a";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "R<a";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CW.Properties.Resources._5luycd88m7i1;
            this.pictureBox1.Location = new System.Drawing.Point(307, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(549, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 96);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дополнительные возможности:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(206, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "полости не пересекаются ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 74);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(167, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "грани призмы целые";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDepth);
            this.Controls.Add(this.tbThickness);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.lDepth);
            this.Controls.Add(this.lThickness);
            this.Controls.Add(this.lHeight);
            this.Controls.Add(this.lWidth);
            this.Controls.Add(this.tbStepY);
            this.Controls.Add(this.lStepY);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lCount);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.lStep);
            this.Controls.Add(this.tbStep);
            this.Controls.Add(this.lZ);
            this.Controls.Add(this.lY);
            this.Controls.Add(this.lX);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbZ);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lSide);
            this.Controls.Add(this.bDraw);
            this.Controls.Add(this.tbSideLength);
            this.Name = "Form1";
            this.Text = "Конструирование четырехгранных полостей";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSideLength;
        private System.Windows.Forms.Button bDraw;
        private System.Windows.Forms.Label lSide;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbZ;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label lX;
        private System.Windows.Forms.Label lY;
        private System.Windows.Forms.Label lZ;
        private System.Windows.Forms.TextBox tbStep;
        private System.Windows.Forms.Label lStep;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lStepY;
        private System.Windows.Forms.TextBox tbStepY;
        private System.Windows.Forms.Label lWidth;
        private System.Windows.Forms.Label lHeight;
        private System.Windows.Forms.Label lThickness;
        private System.Windows.Forms.Label lDepth;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbThickness;
        private System.Windows.Forms.TextBox tbDepth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

