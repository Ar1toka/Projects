namespace ClassTest
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSee = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNumerator1 = new System.Windows.Forms.TextBox();
            this.txtNumerator2 = new System.Windows.Forms.TextBox();
            this.txtDenominator1 = new System.Windows.Forms.TextBox();
            this.txtDenominator2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.NumMult = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDenominator = new System.Windows.Forms.TextBox();
            this.txtNumerator = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSee
            // 
            this.btnSee.Location = new System.Drawing.Point(62, 18);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(93, 32);
            this.btnSee.TabIndex = 0;
            this.btnSee.Text = "Сложить";
            this.btnSee.UseVisualStyleBackColor = true;
            this.btnSee.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(62, 66);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(93, 32);
            this.btnMult.TabIndex = 0;
            this.btnMult.Text = "Умножить";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(62, 113);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(93, 32);
            this.btnDiv.TabIndex = 0;
            this.btnDiv.Text = "Разделить";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(584, 315);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Выход";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtNumerator1
            // 
            this.txtNumerator1.Location = new System.Drawing.Point(174, 47);
            this.txtNumerator1.Name = "txtNumerator1";
            this.txtNumerator1.Size = new System.Drawing.Size(89, 20);
            this.txtNumerator1.TabIndex = 1;
            this.txtNumerator1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNumerator2
            // 
            this.txtNumerator2.Location = new System.Drawing.Point(322, 47);
            this.txtNumerator2.Name = "txtNumerator2";
            this.txtNumerator2.Size = new System.Drawing.Size(89, 20);
            this.txtNumerator2.TabIndex = 1;
            this.txtNumerator2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDenominator1
            // 
            this.txtDenominator1.Location = new System.Drawing.Point(174, 73);
            this.txtDenominator1.Name = "txtDenominator1";
            this.txtDenominator1.Size = new System.Drawing.Size(89, 20);
            this.txtDenominator1.TabIndex = 1;
            // 
            // txtDenominator2
            // 
            this.txtDenominator2.Location = new System.Drawing.Point(322, 73);
            this.txtDenominator2.Name = "txtDenominator2";
            this.txtDenominator2.Size = new System.Drawing.Size(89, 20);
            this.txtDenominator2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.btnSee);
            this.groupBox1.Controls.Add(this.NumMult);
            this.groupBox1.Controls.Add(this.btnMult);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.btnDiv);
            this.groupBox1.Location = new System.Drawing.Point(477, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 297);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операции над дробями";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(62, 162);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 32);
            this.button7.TabIndex = 0;
            this.button7.Text = "Сократить";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // NumMult
            // 
            this.NumMult.Location = new System.Drawing.Point(62, 210);
            this.NumMult.Name = "NumMult";
            this.NumMult.Size = new System.Drawing.Size(93, 32);
            this.NumMult.TabIndex = 0;
            this.NumMult.Text = "Умн. на число";
            this.NumMult.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(62, 257);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 32);
            this.button5.TabIndex = 0;
            this.button5.Text = "Вычесть";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNumerator2);
            this.groupBox2.Controls.Add(this.Number);
            this.groupBox2.Controls.Add(this.txtNumerator1);
            this.groupBox2.Controls.Add(this.txtDenominator1);
            this.groupBox2.Controls.Add(this.txtDenominator2);
            this.groupBox2.Location = new System.Drawing.Point(29, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 170);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "2-я дробь";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Число";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "1-я дробь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Знаменатель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Числитель";
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(249, 120);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(90, 20);
            this.Number.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDenominator);
            this.groupBox3.Controls.Add(this.txtNumerator);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(31, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 109);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результат";
            // 
            // txtDenominator
            // 
            this.txtDenominator.Location = new System.Drawing.Point(264, 70);
            this.txtDenominator.Name = "txtDenominator";
            this.txtDenominator.Size = new System.Drawing.Size(90, 20);
            this.txtDenominator.TabIndex = 6;
            // 
            // txtNumerator
            // 
            this.txtNumerator.Location = new System.Drawing.Point(264, 19);
            this.txtNumerator.Name = "txtNumerator";
            this.txtNumerator.Size = new System.Drawing.Size(90, 20);
            this.txtNumerator.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Числитель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Знаменатель";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 351);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSee;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNumerator1;
        private System.Windows.Forms.TextBox txtNumerator2;
        private System.Windows.Forms.TextBox txtDenominator1;
        private System.Windows.Forms.TextBox txtDenominator2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button NumMult;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDenominator;
        private System.Windows.Forms.TextBox txtNumerator;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

