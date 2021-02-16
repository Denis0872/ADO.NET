
using System;

namespace DBConnection
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.опцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.включитьбазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выключитьбазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПодключенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусБазыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.включеноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выключеноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сколько продуктов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опцияToolStripMenuItem,
            this.списокПодключенийToolStripMenuItem,
            this.статусБазыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // опцияToolStripMenuItem
            // 
            this.опцияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.включитьбазуToolStripMenuItem,
            this.выключитьбазуToolStripMenuItem});
            this.опцияToolStripMenuItem.Name = "опцияToolStripMenuItem";
            this.опцияToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.опцияToolStripMenuItem.Text = "Опция";
            this.опцияToolStripMenuItem.Click += new System.EventHandler(this.опцияToolStripMenuItem_Click);
            // 
            // включитьбазуToolStripMenuItem
            // 
            this.включитьбазуToolStripMenuItem.Name = "включитьбазуToolStripMenuItem";
            this.включитьбазуToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.включитьбазуToolStripMenuItem.Text = "Включить базу";
            this.включитьбазуToolStripMenuItem.Click += new System.EventHandler(this.включитьбазуToolStripMenuItem_Click);
            // 
            // выключитьбазуToolStripMenuItem
            // 
            this.выключитьбазуToolStripMenuItem.Name = "выключитьбазуToolStripMenuItem";
            this.выключитьбазуToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.выключитьбазуToolStripMenuItem.Text = "Выключить базу";
            this.выключитьбазуToolStripMenuItem.Click += new System.EventHandler(this.выключитьбазуToolStripMenuItem_Click);
            // 
            // списокПодключенийToolStripMenuItem
            // 
            this.списокПодключенийToolStripMenuItem.Name = "списокПодключенийToolStripMenuItem";
            this.списокПодключенийToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.списокПодключенийToolStripMenuItem.Text = "Список подключений";
            this.списокПодключенийToolStripMenuItem.Click += new System.EventHandler(this.списокПодключенийToolStripMenuItem_Click);
            // 
            // статусБазыToolStripMenuItem
            // 
            this.статусБазыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.включеноToolStripMenuItem,
            this.выключеноToolStripMenuItem});
            this.статусБазыToolStripMenuItem.Name = "статусБазыToolStripMenuItem";
            this.статусБазыToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.статусБазыToolStripMenuItem.Text = "Статус базы";
            this.статусБазыToolStripMenuItem.Click += new System.EventHandler(this.статусБазыToolStripMenuItem_Click);
            // 
            // включеноToolStripMenuItem
            // 
            this.включеноToolStripMenuItem.Name = "включеноToolStripMenuItem";
            this.включеноToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.включеноToolStripMenuItem.Text = "Включено";
            // 
            // выключеноToolStripMenuItem
            // 
            this.выключеноToolStripMenuItem.Name = "выключеноToolStripMenuItem";
            this.выключеноToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.выключеноToolStripMenuItem.Text = "Выключено";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сколько продуктов";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Список продуктов";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(554, 84);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(180, 270);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название продукта";
            this.columnHeader1.Width = 115;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button_1click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem опцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem включитьбазуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выключитьбазуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПодключенийToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem статусБазыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem включеноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выключеноToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

