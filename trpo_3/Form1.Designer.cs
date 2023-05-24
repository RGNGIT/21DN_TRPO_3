namespace trpo_3
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
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControlGuide = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewClass = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ClassTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewObject = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ObjectTB = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridViewEstimation = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.estimationTB = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewLearner = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DataTimeD = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEstimation = new System.Windows.Forms.ComboBox();
            this.comboBoxObject = new System.Windows.Forms.ComboBox();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.patronymicTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.dataGridViewJournal = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridViewBuffer = new System.Windows.Forms.DataGridView();
            this.tabControlMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControlGuide.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObject)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstimation)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLearner)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJournal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuffer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabPage1);
            this.tabControlMenu.Controls.Add(this.tabPage2);
            this.tabControlMenu.Controls.Add(this.tabPage6);
            this.tabControlMenu.Location = new System.Drawing.Point(1, 2);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(1151, 563);
            this.tabControlMenu.TabIndex = 0;
            this.tabControlMenu.SelectedIndexChanged += new System.EventHandler(this.tabControlMenu_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControlGuide);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1143, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "заполнение справочника";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControlGuide
            // 
            this.tabControlGuide.Controls.Add(this.tabPage3);
            this.tabControlGuide.Controls.Add(this.tabPage4);
            this.tabControlGuide.Controls.Add(this.tabPage5);
            this.tabControlGuide.Location = new System.Drawing.Point(3, 3);
            this.tabControlGuide.Name = "tabControlGuide";
            this.tabControlGuide.SelectedIndex = 0;
            this.tabControlGuide.Size = new System.Drawing.Size(1134, 531);
            this.tabControlGuide.TabIndex = 1;
            this.tabControlGuide.SelectedIndexChanged += new System.EventHandler(this.tabControlGuide_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewClass);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.ClassTB);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1126, 505);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "класс";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClass
            // 
            this.dataGridViewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClass.Location = new System.Drawing.Point(165, 6);
            this.dataGridViewClass.Name = "dataGridViewClass";
            this.dataGridViewClass.Size = new System.Drawing.Size(955, 493);
            this.dataGridViewClass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Класс";
            // 
            // ClassTB
            // 
            this.ClassTB.Location = new System.Drawing.Point(6, 19);
            this.ClassTB.Name = "ClassTB";
            this.ClassTB.Size = new System.Drawing.Size(153, 20);
            this.ClassTB.TabIndex = 1;
            this.ClassTB.TextChanged += new System.EventHandler(this.ClassTB_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewObject);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.ObjectTB);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1126, 505);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "предмет";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewObject
            // 
            this.dataGridViewObject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObject.Location = new System.Drawing.Point(165, 6);
            this.dataGridViewObject.Name = "dataGridViewObject";
            this.dataGridViewObject.Size = new System.Drawing.Size(955, 493);
            this.dataGridViewObject.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Предмет";
            // 
            // ObjectTB
            // 
            this.ObjectTB.Location = new System.Drawing.Point(6, 19);
            this.ObjectTB.Name = "ObjectTB";
            this.ObjectTB.Size = new System.Drawing.Size(153, 20);
            this.ObjectTB.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridViewEstimation);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.estimationTB);
            this.tabPage5.Controls.Add(this.button3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1126, 505);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "оценка";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEstimation
            // 
            this.dataGridViewEstimation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstimation.Location = new System.Drawing.Point(162, 6);
            this.dataGridViewEstimation.Name = "dataGridViewEstimation";
            this.dataGridViewEstimation.Size = new System.Drawing.Size(958, 500);
            this.dataGridViewEstimation.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Оценка";
            // 
            // estimationTB
            // 
            this.estimationTB.Location = new System.Drawing.Point(6, 19);
            this.estimationTB.Name = "estimationTB";
            this.estimationTB.Size = new System.Drawing.Size(153, 20);
            this.estimationTB.TabIndex = 5;
            this.estimationTB.TextChanged += new System.EventHandler(this.estimationTB_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 476);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewLearner);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.DataTimeD);
            this.tabPage2.Controls.Add(this.comboBoxEstimation);
            this.tabPage2.Controls.Add(this.comboBoxObject);
            this.tabPage2.Controls.Add(this.comboBoxClass);
            this.tabPage2.Controls.Add(this.patronymicTB);
            this.tabPage2.Controls.Add(this.nameTB);
            this.tabPage2.Controls.Add(this.surnameTB);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1143, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "заполнение ученика";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLearner
            // 
            this.dataGridViewLearner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLearner.Location = new System.Drawing.Point(212, 7);
            this.dataGridViewLearner.Name = "dataGridViewLearner";
            this.dataGridViewLearner.Size = new System.Drawing.Size(923, 524);
            this.dataGridViewLearner.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Дата";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Оценка";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Предмет";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Класс";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Фамилия";
            // 
            // DataTimeD
            // 
            this.DataTimeD.Location = new System.Drawing.Point(6, 273);
            this.DataTimeD.Name = "DataTimeD";
            this.DataTimeD.Size = new System.Drawing.Size(200, 20);
            this.DataTimeD.TabIndex = 3;
            // 
            // comboBoxEstimation
            // 
            this.comboBoxEstimation.FormattingEnabled = true;
            this.comboBoxEstimation.Location = new System.Drawing.Point(6, 233);
            this.comboBoxEstimation.Name = "comboBoxEstimation";
            this.comboBoxEstimation.Size = new System.Drawing.Size(200, 21);
            this.comboBoxEstimation.TabIndex = 2;
            // 
            // comboBoxObject
            // 
            this.comboBoxObject.FormattingEnabled = true;
            this.comboBoxObject.Location = new System.Drawing.Point(6, 184);
            this.comboBoxObject.Name = "comboBoxObject";
            this.comboBoxObject.Size = new System.Drawing.Size(200, 21);
            this.comboBoxObject.TabIndex = 2;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(8, 144);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(198, 21);
            this.comboBoxClass.TabIndex = 2;
            // 
            // patronymicTB
            // 
            this.patronymicTB.Location = new System.Drawing.Point(8, 100);
            this.patronymicTB.Name = "patronymicTB";
            this.patronymicTB.Size = new System.Drawing.Size(198, 20);
            this.patronymicTB.TabIndex = 1;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(8, 62);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(198, 20);
            this.nameTB.TabIndex = 1;
            // 
            // surnameTB
            // 
            this.surnameTB.Location = new System.Drawing.Point(8, 23);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(198, 20);
            this.surnameTB.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 508);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.buttonFilter);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.textBoxFilter);
            this.tabPage6.Controls.Add(this.dataGridViewJournal);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1143, 537);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "журнал";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(249, 471);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 3;
            this.buttonFilter.Text = "button6";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.button6_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 445);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "фильтр по фамилии";
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(50, 471);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(163, 20);
            this.textBoxFilter.TabIndex = 1;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridViewJournal
            // 
            this.dataGridViewJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJournal.Location = new System.Drawing.Point(8, 7);
            this.dataGridViewJournal.Name = "dataGridViewJournal";
            this.dataGridViewJournal.Size = new System.Drawing.Size(1124, 393);
            this.dataGridViewJournal.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 647);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridViewBuffer
            // 
            this.dataGridViewBuffer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuffer.Location = new System.Drawing.Point(1230, 117);
            this.dataGridViewBuffer.Name = "dataGridViewBuffer";
            this.dataGridViewBuffer.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewBuffer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 562);
            this.Controls.Add(this.dataGridViewBuffer);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tabControlMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControlGuide.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObject)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstimation)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLearner)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJournal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuffer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControlGuide;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClassTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewObject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ObjectTB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridViewEstimation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox estimationTB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridViewLearner;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DataTimeD;
        private System.Windows.Forms.ComboBox comboBoxEstimation;
        private System.Windows.Forms.ComboBox comboBoxObject;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.TextBox patronymicTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridViewBuffer;
        private System.Windows.Forms.DataGridView dataGridViewJournal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button buttonFilter;
    }
}

