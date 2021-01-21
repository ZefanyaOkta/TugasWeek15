namespace TugasWeek15
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
            this.labelNamaItem = new System.Windows.Forms.Label();
            this.labelKategori = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.textBoxNamaItem = new System.Windows.Forms.TextBox();
            this.radioButtonMakanan = new System.Windows.Forms.RadioButton();
            this.radioButtonMinuman = new System.Windows.Forms.RadioButton();
            this.buttonInput = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBoxItem = new System.Windows.Forms.ListBox();
            this.listBoxItemCopy = new System.Windows.Forms.ListBox();
            this.checkBoxMakanan = new System.Windows.Forms.CheckBox();
            this.checkBoxMinuman = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelNamaItem
            // 
            this.labelNamaItem.AutoSize = true;
            this.labelNamaItem.Location = new System.Drawing.Point(32, 21);
            this.labelNamaItem.Name = "labelNamaItem";
            this.labelNamaItem.Size = new System.Drawing.Size(58, 13);
            this.labelNamaItem.TabIndex = 0;
            this.labelNamaItem.Text = "Nama Item";
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Location = new System.Drawing.Point(32, 58);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(46, 13);
            this.labelKategori.TabIndex = 1;
            this.labelKategori.Text = "Kategori";
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(207, 213);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(29, 13);
            this.labelFilter.TabIndex = 4;
            this.labelFilter.Text = "Filter";
            // 
            // textBoxNamaItem
            // 
            this.textBoxNamaItem.Location = new System.Drawing.Point(126, 18);
            this.textBoxNamaItem.Name = "textBoxNamaItem";
            this.textBoxNamaItem.Size = new System.Drawing.Size(100, 20);
            this.textBoxNamaItem.TabIndex = 7;
            // 
            // radioButtonMakanan
            // 
            this.radioButtonMakanan.AutoSize = true;
            this.radioButtonMakanan.Location = new System.Drawing.Point(125, 56);
            this.radioButtonMakanan.Name = "radioButtonMakanan";
            this.radioButtonMakanan.Size = new System.Drawing.Size(70, 17);
            this.radioButtonMakanan.TabIndex = 8;
            this.radioButtonMakanan.TabStop = true;
            this.radioButtonMakanan.Text = "Makanan";
            this.radioButtonMakanan.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinuman
            // 
            this.radioButtonMinuman.AutoSize = true;
            this.radioButtonMinuman.Location = new System.Drawing.Point(212, 56);
            this.radioButtonMinuman.Name = "radioButtonMinuman";
            this.radioButtonMinuman.Size = new System.Drawing.Size(68, 17);
            this.radioButtonMinuman.TabIndex = 9;
            this.radioButtonMinuman.TabStop = true;
            this.radioButtonMinuman.Text = "Minuman";
            this.radioButtonMinuman.UseVisualStyleBackColor = true;
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(126, 89);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(75, 23);
            this.buttonInput.TabIndex = 10;
            this.buttonInput.Text = "Input";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(204, 144);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(73, 23);
            this.buttonCopy.TabIndex = 11;
            this.buttonCopy.Text = ">";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(204, 173);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(73, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "X";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listBoxItem
            // 
            this.listBoxItem.FormattingEnabled = true;
            this.listBoxItem.Items.AddRange(new object[] {
            "Mie Instan",
            "Telor",
            "Susu Sapi",
            "Kopi",
            "Roti",
            "Keju",
            "Daging Giling",
            "Teh",
            "Bir"});
            this.listBoxItem.Location = new System.Drawing.Point(35, 136);
            this.listBoxItem.Name = "listBoxItem";
            this.listBoxItem.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxItem.Size = new System.Drawing.Size(126, 173);
            this.listBoxItem.TabIndex = 13;
            // 
            // listBoxItemCopy
            // 
            this.listBoxItemCopy.FormattingEnabled = true;
            this.listBoxItemCopy.Location = new System.Drawing.Point(318, 136);
            this.listBoxItemCopy.Name = "listBoxItemCopy";
            this.listBoxItemCopy.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxItemCopy.Size = new System.Drawing.Size(126, 173);
            this.listBoxItemCopy.TabIndex = 14;
            // 
            // checkBoxMakanan
            // 
            this.checkBoxMakanan.AutoSize = true;
            this.checkBoxMakanan.Location = new System.Drawing.Point(208, 233);
            this.checkBoxMakanan.Name = "checkBoxMakanan";
            this.checkBoxMakanan.Size = new System.Drawing.Size(71, 17);
            this.checkBoxMakanan.TabIndex = 15;
            this.checkBoxMakanan.Text = "Makanan";
            this.checkBoxMakanan.UseVisualStyleBackColor = true;
            this.checkBoxMakanan.CheckedChanged += new System.EventHandler(this.checkBoxMakanan_CheckedChanged);
            // 
            // checkBoxMinuman
            // 
            this.checkBoxMinuman.AutoSize = true;
            this.checkBoxMinuman.Location = new System.Drawing.Point(208, 256);
            this.checkBoxMinuman.Name = "checkBoxMinuman";
            this.checkBoxMinuman.Size = new System.Drawing.Size(69, 17);
            this.checkBoxMinuman.TabIndex = 16;
            this.checkBoxMinuman.Text = "Minuman";
            this.checkBoxMinuman.UseVisualStyleBackColor = true;
            this.checkBoxMinuman.CheckedChanged += new System.EventHandler(this.checkBoxMinuman_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 321);
            this.Controls.Add(this.checkBoxMinuman);
            this.Controls.Add(this.checkBoxMakanan);
            this.Controls.Add(this.listBoxItemCopy);
            this.Controls.Add(this.listBoxItem);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.radioButtonMinuman);
            this.Controls.Add(this.radioButtonMakanan);
            this.Controls.Add(this.textBoxNamaItem);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.labelKategori);
            this.Controls.Add(this.labelNamaItem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNamaItem;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.TextBox textBoxNamaItem;
        private System.Windows.Forms.RadioButton radioButtonMakanan;
        private System.Windows.Forms.RadioButton radioButtonMinuman;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxItem;
        private System.Windows.Forms.ListBox listBoxItemCopy;
        private System.Windows.Forms.CheckBox checkBoxMakanan;
        private System.Windows.Forms.CheckBox checkBoxMinuman;
    }
}

