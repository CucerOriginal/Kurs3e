
namespace Kurs3e
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Clients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeOper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientNewName = new System.Windows.Forms.TextBox();
            this.BasicSum = new System.Windows.Forms.TextBox();
            this.dateClientTime = new System.Windows.Forms.DateTimePicker();
            this.AddClient = new System.Windows.Forms.Button();
            this.DeleteClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SumOper = new System.Windows.Forms.TextBox();
            this.dateOperTime = new System.Windows.Forms.DateTimePicker();
            this.PopoltinSumButton = new System.Windows.Forms.Button();
            this.DeleteOperButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OperNameClient = new System.Windows.Forms.ComboBox();
            this.SnatSumButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clients,
            this.Sum});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(508, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // Clients
            // 
            this.Clients.HeaderText = "Клиенты";
            this.Clients.Name = "Clients";
            // 
            // Sum
            // 
            this.Sum.HeaderText = "Баланс";
            this.Sum.Name = "Sum";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.DateTimeOper});
            this.dataGridView2.Location = new System.Drawing.Point(532, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(508, 283);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // DateTimeOper
            // 
            this.DateTimeOper.HeaderText = "Время";
            this.DateTimeOper.Name = "DateTimeOper";
            // 
            // ClientNewName
            // 
            this.ClientNewName.Location = new System.Drawing.Point(66, 382);
            this.ClientNewName.Name = "ClientNewName";
            this.ClientNewName.Size = new System.Drawing.Size(100, 23);
            this.ClientNewName.TabIndex = 2;
            // 
            // BasicSum
            // 
            this.BasicSum.Location = new System.Drawing.Point(66, 433);
            this.BasicSum.Name = "BasicSum";
            this.BasicSum.Size = new System.Drawing.Size(100, 23);
            this.BasicSum.TabIndex = 3;
            // 
            // dateClientTime
            // 
            this.dateClientTime.Location = new System.Drawing.Point(54, 335);
            this.dateClientTime.Name = "dateClientTime";
            this.dateClientTime.Size = new System.Drawing.Size(129, 23);
            this.dateClientTime.TabIndex = 5;
            // 
            // AddClient
            // 
            this.AddClient.Location = new System.Drawing.Point(378, 358);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(114, 23);
            this.AddClient.TabIndex = 6;
            this.AddClient.Text = "Добавить клиента";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // DeleteClient
            // 
            this.DeleteClient.Location = new System.Drawing.Point(378, 409);
            this.DeleteClient.Name = "DeleteClient";
            this.DeleteClient.Size = new System.Drawing.Size(114, 23);
            this.DeleteClient.TabIndex = 7;
            this.DeleteClient.Text = "Удалить клиента";
            this.DeleteClient.UseVisualStyleBackColor = true;
            this.DeleteClient.Click += new System.EventHandler(this.DeleteClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя клиента ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Начальная сумма";
            // 
            // SumOper
            // 
            this.SumOper.Location = new System.Drawing.Point(597, 405);
            this.SumOper.Name = "SumOper";
            this.SumOper.Size = new System.Drawing.Size(100, 23);
            this.SumOper.TabIndex = 12;
            // 
            // dateOperTime
            // 
            this.dateOperTime.Location = new System.Drawing.Point(800, 351);
            this.dateOperTime.Name = "dateOperTime";
            this.dateOperTime.Size = new System.Drawing.Size(129, 23);
            this.dateOperTime.TabIndex = 13;
            // 
            // PopoltinSumButton
            // 
            this.PopoltinSumButton.Location = new System.Drawing.Point(725, 404);
            this.PopoltinSumButton.Name = "PopoltinSumButton";
            this.PopoltinSumButton.Size = new System.Drawing.Size(129, 23);
            this.PopoltinSumButton.TabIndex = 14;
            this.PopoltinSumButton.Text = "Пополнить средства";
            this.PopoltinSumButton.UseVisualStyleBackColor = true;
            this.PopoltinSumButton.Click += new System.EventHandler(this.PopoltinSumButton_Click);
            // 
            // DeleteOperButton
            // 
            this.DeleteOperButton.Location = new System.Drawing.Point(800, 444);
            this.DeleteOperButton.Name = "DeleteOperButton";
            this.DeleteOperButton.Size = new System.Drawing.Size(129, 23);
            this.DeleteOperButton.TabIndex = 16;
            this.DeleteOperButton.Text = "Удалить операцию";
            this.DeleteOperButton.UseVisualStyleBackColor = true;
            this.DeleteOperButton.Click += new System.EventHandler(this.DeleteOperButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(609, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Имя клиента ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Сумма";
            // 
            // OperNameClient
            // 
            this.OperNameClient.FormattingEnabled = true;
            this.OperNameClient.Location = new System.Drawing.Point(586, 353);
            this.OperNameClient.Name = "OperNameClient";
            this.OperNameClient.Size = new System.Drawing.Size(121, 23);
            this.OperNameClient.TabIndex = 19;
            // 
            // SnatSumButton
            // 
            this.SnatSumButton.Location = new System.Drawing.Point(897, 404);
            this.SnatSumButton.Name = "SnatSumButton";
            this.SnatSumButton.Size = new System.Drawing.Size(129, 23);
            this.SnatSumButton.TabIndex = 20;
            this.SnatSumButton.Text = "Снять средаства";
            this.SnatSumButton.UseVisualStyleBackColor = true;
            this.SnatSumButton.Click += new System.EventHandler(this.SnatSumButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem1});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.saveToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 498);
            this.Controls.Add(this.SnatSumButton);
            this.Controls.Add(this.OperNameClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeleteOperButton);
            this.Controls.Add(this.PopoltinSumButton);
            this.Controls.Add(this.dateOperTime);
            this.Controls.Add(this.SumOper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteClient);
            this.Controls.Add(this.AddClient);
            this.Controls.Add(this.dateClientTime);
            this.Controls.Add(this.BasicSum);
            this.Controls.Add(this.ClientNewName);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox ClientNewName;
        private System.Windows.Forms.TextBox BasicSum;
        private System.Windows.Forms.DateTimePicker dateClientTime;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.Button DeleteClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SumOper;
        private System.Windows.Forms.DateTimePicker dateOperTime;
        private System.Windows.Forms.Button PopoltinSumButton;
        private System.Windows.Forms.Button DeleteOperButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox OperNameClient;
        private System.Windows.Forms.Button SnatSumButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeOper;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
    }
}

