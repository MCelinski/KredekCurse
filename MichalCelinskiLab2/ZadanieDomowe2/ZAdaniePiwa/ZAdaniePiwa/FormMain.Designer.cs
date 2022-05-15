
namespace ZAdaniePiwa
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
            this.dataGridViewBeers = new System.Windows.Forms.DataGridView();
            this.buttonDeleteBeer = new System.Windows.Forms.Button();
            this.buttonEditBeer = new System.Windows.Forms.Button();
            this.buttonClearTextBoxes = new System.Windows.Forms.Button();
            this.buttonAddBeer = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelBrewery = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelStyle = new System.Windows.Forms.Label();
            this.labelAbv = new System.Windows.Forms.Label();
            this.labelIbu = new System.Windows.Forms.Label();
            this.labelAward = new System.Windows.Forms.Label();
            this.labelHop = new System.Windows.Forms.Label();
            this.labelPackage = new System.Windows.Forms.Label();
            this.textBoxBrewery = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxStyle = new System.Windows.Forms.TextBox();
            this.textBoxAbv = new System.Windows.Forms.TextBox();
            this.textBoxIbu = new System.Windows.Forms.TextBox();
            this.textBoxAwards = new System.Windows.Forms.TextBox();
            this.textBoxHop = new System.Windows.Forms.TextBox();
            this.textBoxPackage = new System.Windows.Forms.TextBox();
            this.labelLastAction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBeers
            // 
            this.dataGridViewBeers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBeers.Location = new System.Drawing.Point(36, 32);
            this.dataGridViewBeers.Name = "dataGridViewBeers";
            this.dataGridViewBeers.RowHeadersWidth = 51;
            this.dataGridViewBeers.RowTemplate.Height = 29;
            this.dataGridViewBeers.Size = new System.Drawing.Size(1035, 188);
            this.dataGridViewBeers.TabIndex = 0;
            this.dataGridViewBeers.SelectionChanged += new System.EventHandler(this.dataGridViewBeers_SelectionChanged);
            // 
            // buttonDeleteBeer
            // 
            this.buttonDeleteBeer.Location = new System.Drawing.Point(960, 390);
            this.buttonDeleteBeer.Name = "buttonDeleteBeer";
            this.buttonDeleteBeer.Size = new System.Drawing.Size(128, 29);
            this.buttonDeleteBeer.TabIndex = 1;
            this.buttonDeleteBeer.Text = "usuń piwo";
            this.buttonDeleteBeer.UseVisualStyleBackColor = true;
            this.buttonDeleteBeer.Click += new System.EventHandler(this.buttonDeleteBeer_Click);
            // 
            // buttonEditBeer
            // 
            this.buttonEditBeer.Location = new System.Drawing.Point(960, 441);
            this.buttonEditBeer.Name = "buttonEditBeer";
            this.buttonEditBeer.Size = new System.Drawing.Size(128, 29);
            this.buttonEditBeer.TabIndex = 1;
            this.buttonEditBeer.Text = "Edytuj piwo";
            this.buttonEditBeer.UseVisualStyleBackColor = true;
            this.buttonEditBeer.Click += new System.EventHandler(this.buttonEditBeer_Click_1);
            // 
            // buttonClearTextBoxes
            // 
            this.buttonClearTextBoxes.Location = new System.Drawing.Point(960, 491);
            this.buttonClearTextBoxes.Name = "buttonClearTextBoxes";
            this.buttonClearTextBoxes.Size = new System.Drawing.Size(128, 29);
            this.buttonClearTextBoxes.TabIndex = 1;
            this.buttonClearTextBoxes.Text = "Wyczyść pola";
            this.buttonClearTextBoxes.UseVisualStyleBackColor = true;
            this.buttonClearTextBoxes.Click += new System.EventHandler(this.buttonClearTextBoxes_Click);
            // 
            // buttonAddBeer
            // 
            this.buttonAddBeer.Location = new System.Drawing.Point(960, 541);
            this.buttonAddBeer.Name = "buttonAddBeer";
            this.buttonAddBeer.Size = new System.Drawing.Size(128, 29);
            this.buttonAddBeer.TabIndex = 1;
            this.buttonAddBeer.Text = "Dodaj Piwo";
            this.buttonAddBeer.UseVisualStyleBackColor = true;
            this.buttonAddBeer.Click += new System.EventHandler(this.buttonAddBeer_Click_1);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(53, 244);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(25, 20);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "Id:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, -2);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(40, 20);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Piwa";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(244, 241);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(301, 27);
            this.textBoxId.TabIndex = 2;
            // 
            // labelBrewery
            // 
            this.labelBrewery.AutoSize = true;
            this.labelBrewery.Location = new System.Drawing.Point(53, 275);
            this.labelBrewery.Name = "labelBrewery";
            this.labelBrewery.Size = new System.Drawing.Size(63, 20);
            this.labelBrewery.TabIndex = 3;
            this.labelBrewery.Text = "Browar: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(53, 306);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 20);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Nazwa:";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(53, 337);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(77, 20);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Kategoria:";
            // 
            // labelStyle
            // 
            this.labelStyle.AutoSize = true;
            this.labelStyle.Location = new System.Drawing.Point(53, 368);
            this.labelStyle.Name = "labelStyle";
            this.labelStyle.Size = new System.Drawing.Size(36, 20);
            this.labelStyle.TabIndex = 3;
            this.labelStyle.Text = "Styl:";
            // 
            // labelAbv
            // 
            this.labelAbv.AutoSize = true;
            this.labelAbv.Location = new System.Drawing.Point(53, 399);
            this.labelAbv.Name = "labelAbv";
            this.labelAbv.Size = new System.Drawing.Size(40, 20);
            this.labelAbv.TabIndex = 3;
            this.labelAbv.Text = "ABV:";
            // 
            // labelIbu
            // 
            this.labelIbu.AutoSize = true;
            this.labelIbu.Location = new System.Drawing.Point(53, 430);
            this.labelIbu.Name = "labelIbu";
            this.labelIbu.Size = new System.Drawing.Size(35, 20);
            this.labelIbu.TabIndex = 3;
            this.labelIbu.Text = "IBU:";
            // 
            // labelAward
            // 
            this.labelAward.AutoSize = true;
            this.labelAward.Location = new System.Drawing.Point(53, 461);
            this.labelAward.Name = "labelAward";
            this.labelAward.Size = new System.Drawing.Size(75, 20);
            this.labelAward.TabIndex = 3;
            this.labelAward.Text = "Nagroda: ";
            // 
            // labelHop
            // 
            this.labelHop.AutoSize = true;
            this.labelHop.Location = new System.Drawing.Point(53, 492);
            this.labelHop.Name = "labelHop";
            this.labelHop.Size = new System.Drawing.Size(58, 20);
            this.labelHop.TabIndex = 3;
            this.labelHop.Text = "Chmiel:";
            // 
            // labelPackage
            // 
            this.labelPackage.AutoSize = true;
            this.labelPackage.Location = new System.Drawing.Point(53, 523);
            this.labelPackage.Name = "labelPackage";
            this.labelPackage.Size = new System.Drawing.Size(147, 20);
            this.labelPackage.TabIndex = 3;
            this.labelPackage.Text = "Rodzaj opakowania: ";
            // 
            // textBoxBrewery
            // 
            this.textBoxBrewery.Location = new System.Drawing.Point(244, 272);
            this.textBoxBrewery.Name = "textBoxBrewery";
            this.textBoxBrewery.Size = new System.Drawing.Size(301, 27);
            this.textBoxBrewery.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(244, 303);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(301, 27);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(244, 332);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(301, 27);
            this.textBoxCategory.TabIndex = 2;
            // 
            // textBoxStyle
            // 
            this.textBoxStyle.Location = new System.Drawing.Point(244, 365);
            this.textBoxStyle.Name = "textBoxStyle";
            this.textBoxStyle.Size = new System.Drawing.Size(301, 27);
            this.textBoxStyle.TabIndex = 2;
            // 
            // textBoxAbv
            // 
            this.textBoxAbv.Location = new System.Drawing.Point(244, 396);
            this.textBoxAbv.Name = "textBoxAbv";
            this.textBoxAbv.Size = new System.Drawing.Size(301, 27);
            this.textBoxAbv.TabIndex = 2;
            // 
            // textBoxIbu
            // 
            this.textBoxIbu.Location = new System.Drawing.Point(244, 427);
            this.textBoxIbu.Name = "textBoxIbu";
            this.textBoxIbu.Size = new System.Drawing.Size(301, 27);
            this.textBoxIbu.TabIndex = 2;
            // 
            // textBoxAwards
            // 
            this.textBoxAwards.Location = new System.Drawing.Point(244, 458);
            this.textBoxAwards.Name = "textBoxAwards";
            this.textBoxAwards.Size = new System.Drawing.Size(301, 27);
            this.textBoxAwards.TabIndex = 2;
            // 
            // textBoxHop
            // 
            this.textBoxHop.Location = new System.Drawing.Point(244, 489);
            this.textBoxHop.Name = "textBoxHop";
            this.textBoxHop.Size = new System.Drawing.Size(301, 27);
            this.textBoxHop.TabIndex = 2;
            // 
            // textBoxPackage
            // 
            this.textBoxPackage.Location = new System.Drawing.Point(244, 522);
            this.textBoxPackage.Name = "textBoxPackage";
            this.textBoxPackage.Size = new System.Drawing.Size(301, 27);
            this.textBoxPackage.TabIndex = 2;
            // 
            // labelLastAction
            // 
            this.labelLastAction.AutoSize = true;
            this.labelLastAction.Location = new System.Drawing.Point(960, 593);
            this.labelLastAction.Name = "labelLastAction";
            this.labelLastAction.Size = new System.Drawing.Size(66, 20);
            this.labelLastAction.TabIndex = 5;
            this.labelLastAction.Text = "Zrobiłeś.";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 624);
            this.Controls.Add(this.dataGridViewBeers);
            this.Controls.Add(this.labelLastAction);
            this.Controls.Add(this.labelPackage);
            this.Controls.Add(this.labelHop);
            this.Controls.Add(this.labelAward);
            this.Controls.Add(this.labelIbu);
            this.Controls.Add(this.labelAbv);
            this.Controls.Add(this.labelStyle);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelBrewery);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxIbu);
            this.Controls.Add(this.textBoxAwards);
            this.Controls.Add(this.textBoxHop);
            this.Controls.Add(this.textBoxPackage);
            this.Controls.Add(this.textBoxAbv);
            this.Controls.Add(this.textBoxStyle);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxBrewery);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonAddBeer);
            this.Controls.Add(this.buttonClearTextBoxes);
            this.Controls.Add(this.buttonEditBeer);
            this.Controls.Add(this.buttonDeleteBeer);
            this.Name = "FormMain";
            this.Text = "Piwa";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBeers;
        private System.Windows.Forms.Button buttonDeleteBeer;
        private System.Windows.Forms.Button buttonEditBeer;
        private System.Windows.Forms.Button buttonClearTextBoxes;
        private System.Windows.Forms.Button buttonAddBeer;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelBrewery;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelStyle;
        private System.Windows.Forms.Label labelAbv;
        private System.Windows.Forms.Label labelIbu;
        private System.Windows.Forms.Label labelAward;
        private System.Windows.Forms.Label labelHop;
        private System.Windows.Forms.Label labelPackage;
        private System.Windows.Forms.TextBox textBoxBrewery;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxStyle;
        private System.Windows.Forms.TextBox textBoxAbv;
        private System.Windows.Forms.TextBox textBoxIbu;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox textBoxHop;
        private System.Windows.Forms.TextBox textBoxPackage;
        private System.Windows.Forms.TextBox textBoxAwards;
        private System.Windows.Forms.Label labelLastAction;
    }
}

