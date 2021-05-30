
namespace GIMPsimp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.captionLists = new System.Windows.Forms.RichTextBox();
            this.doubleLineType = new System.Windows.Forms.RadioButton();
            this.singleLineType = new System.Windows.Forms.RadioButton();
            this.captionTypeSelector = new System.Windows.Forms.GroupBox();
            this.cursorSettings = new System.Windows.Forms.Button();
            this.captionTypeSelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(118, 172);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(144, 74);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "START!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // captionLists
            // 
            this.captionLists.Location = new System.Drawing.Point(12, 12);
            this.captionLists.Name = "captionLists";
            this.captionLists.Size = new System.Drawing.Size(250, 154);
            this.captionLists.TabIndex = 5;
            this.captionLists.Text = "AAAAAAAAAAAAAAAAA\nHANAHANAHANAHANA\nWANGYWANGYWANGY\nHUHAHUHAHUHAHUHA";
            // 
            // doubleLineType
            // 
            this.doubleLineType.AutoSize = true;
            this.doubleLineType.Checked = true;
            this.doubleLineType.Location = new System.Drawing.Point(6, 47);
            this.doubleLineType.Name = "doubleLineType";
            this.doubleLineType.Size = new System.Drawing.Size(88, 19);
            this.doubleLineType.TabIndex = 7;
            this.doubleLineType.TabStop = true;
            this.doubleLineType.Text = "Double Line";
            this.doubleLineType.UseVisualStyleBackColor = true;
            this.doubleLineType.CheckedChanged += new System.EventHandler(this.doubleLineType_CheckedChanged);
            // 
            // singleLineType
            // 
            this.singleLineType.AutoSize = true;
            this.singleLineType.Location = new System.Drawing.Point(6, 22);
            this.singleLineType.Name = "singleLineType";
            this.singleLineType.Size = new System.Drawing.Size(82, 19);
            this.singleLineType.TabIndex = 8;
            this.singleLineType.Text = "Single Line";
            this.singleLineType.UseVisualStyleBackColor = true;
            // 
            // captionTypeSelector
            // 
            this.captionTypeSelector.Controls.Add(this.singleLineType);
            this.captionTypeSelector.Controls.Add(this.doubleLineType);
            this.captionTypeSelector.Location = new System.Drawing.Point(12, 172);
            this.captionTypeSelector.Name = "captionTypeSelector";
            this.captionTypeSelector.Size = new System.Drawing.Size(100, 74);
            this.captionTypeSelector.TabIndex = 9;
            this.captionTypeSelector.TabStop = false;
            this.captionTypeSelector.Text = "Caption Type:";
            // 
            // cursorSettings
            // 
            this.cursorSettings.Location = new System.Drawing.Point(12, 252);
            this.cursorSettings.Name = "cursorSettings";
            this.cursorSettings.Size = new System.Drawing.Size(250, 23);
            this.cursorSettings.TabIndex = 10;
            this.cursorSettings.Text = "Cursor Coordinate Settings...";
            this.cursorSettings.UseVisualStyleBackColor = true;
            this.cursorSettings.Click += new System.EventHandler(this.cursorSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 286);
            this.Controls.Add(this.cursorSettings);
            this.Controls.Add(this.captionTypeSelector);
            this.Controls.Add(this.captionLists);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.captionTypeSelector.ResumeLayout(false);
            this.captionTypeSelector.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RichTextBox captionLists;
        private System.Windows.Forms.RadioButton doubleLineType;
        private System.Windows.Forms.RadioButton singleLineType;
        private System.Windows.Forms.GroupBox captionTypeSelector;
        private System.Windows.Forms.Button cursorSettings;
    }
}

