
namespace GIMPsimp
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.cursorPosY = new System.Windows.Forms.TextBox();
            this.cursorPosX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.inputBoldPosY = new System.Windows.Forms.TextBox();
            this.inputPathFTextY = new System.Windows.Forms.TextBox();
            this.inputBoldPosX = new System.Windows.Forms.TextBox();
            this.inputPathFTextX = new System.Windows.Forms.TextBox();
            this.inputNewPosY = new System.Windows.Forms.TextBox();
            this.inputDistri2Y = new System.Windows.Forms.TextBox();
            this.inputDistri1Y = new System.Windows.Forms.TextBox();
            this.inputStartPosY = new System.Windows.Forms.TextBox();
            this.inputNewPosX = new System.Windows.Forms.TextBox();
            this.inputDistri2X = new System.Windows.Forms.TextBox();
            this.inputDistri1X = new System.Windows.Forms.TextBox();
            this.inputStartPosX = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveChange = new System.Windows.Forms.Button();
            this.timerPos = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cursorPosY
            // 
            this.cursorPosY.Location = new System.Drawing.Point(255, 201);
            this.cursorPosY.Name = "cursorPosY";
            this.cursorPosY.ReadOnly = true;
            this.cursorPosY.Size = new System.Drawing.Size(45, 23);
            this.cursorPosY.TabIndex = 57;
            this.cursorPosY.Text = "4096";
            // 
            // cursorPosX
            // 
            this.cursorPosX.Location = new System.Drawing.Point(204, 201);
            this.cursorPosX.Name = "cursorPosX";
            this.cursorPosX.ReadOnly = true;
            this.cursorPosX.Size = new System.Drawing.Size(45, 23);
            this.cursorPosX.TabIndex = 56;
            this.cursorPosX.Text = "4096";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 15);
            this.label5.TabIndex = 55;
            this.label5.Text = "Current Cursor Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 54;
            this.label7.Text = "Bold";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 53;
            this.label8.Text = "Path from Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "Text Layer Position After Distribute";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 51;
            this.label4.Text = "Distribute (2)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "Distribute (1)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "Start Position in Canvas";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(271, 9);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 15);
            this.labelY.TabIndex = 48;
            this.labelY.Text = "Y";
            this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(220, 9);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 15);
            this.labelX.TabIndex = 47;
            this.labelX.Text = "X";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputBoldPosY
            // 
            this.inputBoldPosY.Location = new System.Drawing.Point(255, 56);
            this.inputBoldPosY.Name = "inputBoldPosY";
            this.inputBoldPosY.Size = new System.Drawing.Size(45, 23);
            this.inputBoldPosY.TabIndex = 46;
            this.inputBoldPosY.Text = "4096";
            // 
            // inputPathFTextY
            // 
            this.inputPathFTextY.Location = new System.Drawing.Point(255, 172);
            this.inputPathFTextY.Name = "inputPathFTextY";
            this.inputPathFTextY.Size = new System.Drawing.Size(45, 23);
            this.inputPathFTextY.TabIndex = 45;
            this.inputPathFTextY.Text = "4096";
            // 
            // inputBoldPosX
            // 
            this.inputBoldPosX.Location = new System.Drawing.Point(204, 56);
            this.inputBoldPosX.Name = "inputBoldPosX";
            this.inputBoldPosX.Size = new System.Drawing.Size(45, 23);
            this.inputBoldPosX.TabIndex = 44;
            this.inputBoldPosX.Text = "4096";
            // 
            // inputPathFTextX
            // 
            this.inputPathFTextX.Location = new System.Drawing.Point(204, 172);
            this.inputPathFTextX.Name = "inputPathFTextX";
            this.inputPathFTextX.Size = new System.Drawing.Size(45, 23);
            this.inputPathFTextX.TabIndex = 43;
            this.inputPathFTextX.Text = "4096";
            // 
            // inputNewPosY
            // 
            this.inputNewPosY.Location = new System.Drawing.Point(255, 143);
            this.inputNewPosY.Name = "inputNewPosY";
            this.inputNewPosY.Size = new System.Drawing.Size(45, 23);
            this.inputNewPosY.TabIndex = 42;
            this.inputNewPosY.Text = "4096";
            // 
            // inputDistri2Y
            // 
            this.inputDistri2Y.Location = new System.Drawing.Point(255, 114);
            this.inputDistri2Y.Name = "inputDistri2Y";
            this.inputDistri2Y.Size = new System.Drawing.Size(45, 23);
            this.inputDistri2Y.TabIndex = 41;
            this.inputDistri2Y.Text = "4096";
            // 
            // inputDistri1Y
            // 
            this.inputDistri1Y.Location = new System.Drawing.Point(255, 85);
            this.inputDistri1Y.Name = "inputDistri1Y";
            this.inputDistri1Y.Size = new System.Drawing.Size(45, 23);
            this.inputDistri1Y.TabIndex = 40;
            this.inputDistri1Y.Text = "4096";
            // 
            // inputStartPosY
            // 
            this.inputStartPosY.Location = new System.Drawing.Point(255, 27);
            this.inputStartPosY.Name = "inputStartPosY";
            this.inputStartPosY.Size = new System.Drawing.Size(45, 23);
            this.inputStartPosY.TabIndex = 39;
            this.inputStartPosY.Text = "4096";
            // 
            // inputNewPosX
            // 
            this.inputNewPosX.Location = new System.Drawing.Point(204, 143);
            this.inputNewPosX.Name = "inputNewPosX";
            this.inputNewPosX.Size = new System.Drawing.Size(45, 23);
            this.inputNewPosX.TabIndex = 38;
            this.inputNewPosX.Text = "4096";
            // 
            // inputDistri2X
            // 
            this.inputDistri2X.Location = new System.Drawing.Point(204, 114);
            this.inputDistri2X.Name = "inputDistri2X";
            this.inputDistri2X.Size = new System.Drawing.Size(45, 23);
            this.inputDistri2X.TabIndex = 37;
            this.inputDistri2X.Text = "4096";
            // 
            // inputDistri1X
            // 
            this.inputDistri1X.Location = new System.Drawing.Point(204, 85);
            this.inputDistri1X.Name = "inputDistri1X";
            this.inputDistri1X.Size = new System.Drawing.Size(45, 23);
            this.inputDistri1X.TabIndex = 36;
            this.inputDistri1X.Text = "4096";
            // 
            // inputStartPosX
            // 
            this.inputStartPosX.Location = new System.Drawing.Point(204, 27);
            this.inputStartPosX.Name = "inputStartPosX";
            this.inputStartPosX.Size = new System.Drawing.Size(45, 23);
            this.inputStartPosX.TabIndex = 35;
            this.inputStartPosX.Text = "4096";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GIMPsimp.Properties.Resources.Guide__2_;
            this.pictureBox1.Location = new System.Drawing.Point(319, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 244);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // saveChange
            // 
            this.saveChange.Location = new System.Drawing.Point(12, 230);
            this.saveChange.Name = "saveChange";
            this.saveChange.Size = new System.Drawing.Size(288, 23);
            this.saveChange.TabIndex = 59;
            this.saveChange.Text = "Save Change";
            this.saveChange.UseVisualStyleBackColor = true;
            this.saveChange.Click += new System.EventHandler(this.saveChange_Click);
            // 
            // timerPos
            // 
            this.timerPos.Enabled = true;
            this.timerPos.Interval = 33;
            this.timerPos.Tick += new System.EventHandler(this.timerPos_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 261);
            this.Controls.Add(this.saveChange);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cursorPosY);
            this.Controls.Add(this.cursorPosX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.inputBoldPosY);
            this.Controls.Add(this.inputPathFTextY);
            this.Controls.Add(this.inputBoldPosX);
            this.Controls.Add(this.inputPathFTextX);
            this.Controls.Add(this.inputNewPosY);
            this.Controls.Add(this.inputDistri2Y);
            this.Controls.Add(this.inputDistri1Y);
            this.Controls.Add(this.inputStartPosY);
            this.Controls.Add(this.inputNewPosX);
            this.Controls.Add(this.inputDistri2X);
            this.Controls.Add(this.inputDistri1X);
            this.Controls.Add(this.inputStartPosX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cursorPosY;
        private System.Windows.Forms.TextBox cursorPosX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox inputBoldPosY;
        private System.Windows.Forms.TextBox inputPathFTextY;
        private System.Windows.Forms.TextBox inputBoldPosX;
        private System.Windows.Forms.TextBox inputPathFTextX;
        private System.Windows.Forms.TextBox inputNewPosY;
        private System.Windows.Forms.TextBox inputDistri2Y;
        private System.Windows.Forms.TextBox inputDistri1Y;
        private System.Windows.Forms.TextBox inputStartPosY;
        private System.Windows.Forms.TextBox inputNewPosX;
        private System.Windows.Forms.TextBox inputDistri2X;
        private System.Windows.Forms.TextBox inputDistri1X;
        private System.Windows.Forms.TextBox inputStartPosX;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveChange;
        private System.Windows.Forms.Timer timerPos;
    }
}