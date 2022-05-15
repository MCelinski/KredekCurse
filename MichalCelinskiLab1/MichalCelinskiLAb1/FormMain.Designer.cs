
namespace MichalCelinskiLAb1
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonColor2 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.timerCounter = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonNewWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(12, 12);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(94, 29);
            this.buttonColor.TabIndex = 0;
            this.buttonColor.Text = "zmień kolor";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColor2
            // 
            this.buttonColor2.Location = new System.Drawing.Point(806, 12);
            this.buttonColor2.Name = "buttonColor2";
            this.buttonColor2.Size = new System.Drawing.Size(94, 29);
            this.buttonColor2.TabIndex = 1;
            this.buttonColor2.Text = "zmiana koloru2";
            this.buttonColor2.UseVisualStyleBackColor = true;
            this.buttonColor2.Click += new System.EventHandler(this.buttonColor2_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 85);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "zwiększ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(202, 87);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(94, 27);
            this.textBoxAdd.TabIndex = 3;
            this.textBoxAdd.Text = "1";
            // 
            // timerCounter
            // 
            this.timerCounter.Tick += new System.EventHandler(this.timerCounter_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 173);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(94, 29);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonNewWindow
            // 
            this.buttonNewWindow.Location = new System.Drawing.Point(12, 256);
            this.buttonNewWindow.Name = "buttonNewWindow";
            this.buttonNewWindow.Size = new System.Drawing.Size(94, 29);
            this.buttonNewWindow.TabIndex = 5;
            this.buttonNewWindow.Text = "Nowe okno";
            this.buttonNewWindow.UseVisualStyleBackColor = true;
            this.buttonNewWindow.Click += new System.EventHandler(this.buttonNewWindow_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 540);
            this.Controls.Add(this.buttonNewWindow);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonColor2);
            this.Controls.Add(this.buttonColor);
            this.DoubleBuffered = true;
            this.Name = "FormMain";
            this.Text = "Michal Celinski Lab1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonColor2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Timer timerCounter;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer m;
        private System.Windows.Forms.Button buttonNewWindow;
    }
}

