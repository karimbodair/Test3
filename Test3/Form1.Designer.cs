using System;

namespace Test3
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
            this.podcastList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.avsnittList = new System.Windows.Forms.ListView();
            this.kategoriList = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.frekvensBox = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.kategoriBox = new System.Windows.Forms.ComboBox();
            this.beskrivningList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // podcastList
            // 
            this.podcastList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.podcastList.HideSelection = false;
            this.podcastList.Location = new System.Drawing.Point(28, 21);
            this.podcastList.Name = "podcastList";
            this.podcastList.Size = new System.Drawing.Size(332, 132);
            this.podcastList.TabIndex = 0;
            this.podcastList.UseCompatibleStateImageBehavior = false;
            this.podcastList.View = System.Windows.Forms.View.Details;
            this.podcastList.SelectedIndexChanged += new System.EventHandler(this.podcastList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Titel";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Uppdateringsfrekvens";
            this.columnHeader2.Width = 131;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kategori";
            this.columnHeader3.Width = 190;
            // 
            // avsnittList
            // 
            this.avsnittList.HideSelection = false;
            this.avsnittList.Location = new System.Drawing.Point(29, 258);
            this.avsnittList.Name = "avsnittList";
            this.avsnittList.Size = new System.Drawing.Size(332, 153);
            this.avsnittList.TabIndex = 1;
            this.avsnittList.UseCompatibleStateImageBehavior = false;
            this.avsnittList.SelectedIndexChanged += new System.EventHandler(this.avsnittList_SelectedIndexChanged);
            // 
            // kategoriList
            // 
            this.kategoriList.HideSelection = false;
            this.kategoriList.Location = new System.Drawing.Point(453, 21);
            this.kategoriList.Name = "kategoriList";
            this.kategoriList.Size = new System.Drawing.Size(306, 132);
            this.kategoriList.TabIndex = 2;
            this.kategoriList.UseCompatibleStateImageBehavior = false;
            this.kategoriList.View = System.Windows.Forms.View.List;
            this.kategoriList.SelectedIndexChanged += new System.EventHandler(this.kategoriList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 172);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lägg till";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click_Add);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 172);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ändra";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(305, 197);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ta bort";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(582, 166);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Lägg till";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(642, 166);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Ändra";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(703, 166);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Ta bort";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Uppdateringsfrekvens:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kategori:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Avsnitt:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(453, 168);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 14;
            // 
            // frekvensBox
            // 
            this.frekvensBox.FormattingEnabled = true;
            this.frekvensBox.Location = new System.Drawing.Point(28, 212);
            this.frekvensBox.Margin = new System.Windows.Forms.Padding(2);
            this.frekvensBox.Name = "frekvensBox";
            this.frekvensBox.Size = new System.Drawing.Size(118, 21);
            this.frekvensBox.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(28, 172);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 17;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // kategoriBox
            // 
            this.kategoriBox.FormattingEnabled = true;
            this.kategoriBox.Location = new System.Drawing.Point(150, 212);
            this.kategoriBox.Margin = new System.Windows.Forms.Padding(2);
            this.kategoriBox.Name = "kategoriBox";
            this.kategoriBox.Size = new System.Drawing.Size(118, 21);
            this.kategoriBox.TabIndex = 18;
            this.kategoriBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // beskrivningList
            // 
            this.beskrivningList.HideSelection = false;
            this.beskrivningList.Location = new System.Drawing.Point(453, 212);
            this.beskrivningList.Name = "beskrivningList";
            this.beskrivningList.Size = new System.Drawing.Size(306, 199);
            this.beskrivningList.TabIndex = 19;
            this.beskrivningList.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.beskrivningList);
            this.Controls.Add(this.kategoriBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.frekvensBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kategoriList);
            this.Controls.Add(this.avsnittList);
            this.Controls.Add(this.podcastList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void kategoriList_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ListView podcastList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView avsnittList;
        private System.Windows.Forms.ListView kategoriList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox frekvensBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox kategoriBox;
        private System.Windows.Forms.ListView beskrivningList;
    }
}

