namespace Lab04_Pakhomov
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_time = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_size = new System.Windows.Forms.Label();
            this.button_KEYgenerator = new System.Windows.Forms.Button();
            this.button_fileKEYsave = new System.Windows.Forms.Button();
            this.button_fileKEYopen = new System.Windows.Forms.Button();
            this.textBox_fileKEY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_fileOUT = new System.Windows.Forms.Button();
            this.button_fileIN = new System.Windows.Forms.Button();
            this.textBox_fileOUT = new System.Windows.Forms.TextBox();
            this.textBox_fileIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Зберегти = new System.Windows.Forms.ToolTip(this.components);
            this.Скачати = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(395, 357);
            this.label_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(44, 16);
            this.label_time.TabIndex = 14;
            this.label_time.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 357);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Тривалість шифрування (хв:сек.мс)";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(564, 347);
            this.button_start.Margin = new System.Windows.Forms.Padding(2);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(79, 26);
            this.button_start.TabIndex = 12;
            this.button_start.Text = "Старт";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_size);
            this.groupBox2.Controls.Add(this.button_KEYgenerator);
            this.groupBox2.Controls.Add(this.button_fileKEYsave);
            this.groupBox2.Controls.Add(this.button_fileKEYopen);
            this.groupBox2.Controls.Add(this.textBox_fileKEY);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(125, 213);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(529, 125);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ключ";
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Location = new System.Drawing.Point(30, 67);
            this.label_size.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(44, 16);
            this.label_size.TabIndex = 5;
            this.label_size.Text = "label6";
            // 
            // button_KEYgenerator
            // 
            this.button_KEYgenerator.Image = ((System.Drawing.Image)(resources.GetObject("button_KEYgenerator.Image")));
            this.button_KEYgenerator.Location = new System.Drawing.Point(234, 79);
            this.button_KEYgenerator.Margin = new System.Windows.Forms.Padding(2);
            this.button_KEYgenerator.Name = "button_KEYgenerator";
            this.button_KEYgenerator.Size = new System.Drawing.Size(80, 26);
            this.button_KEYgenerator.TabIndex = 4;
            this.button_KEYgenerator.UseVisualStyleBackColor = true;
            this.button_KEYgenerator.Click += new System.EventHandler(this.button_KEYgenerator_Click_1);
            // 
            // button_fileKEYsave
            // 
            this.button_fileKEYsave.Image = ((System.Drawing.Image)(resources.GetObject("button_fileKEYsave.Image")));
            this.button_fileKEYsave.Location = new System.Drawing.Point(439, 79);
            this.button_fileKEYsave.Margin = new System.Windows.Forms.Padding(2);
            this.button_fileKEYsave.Name = "button_fileKEYsave";
            this.button_fileKEYsave.Size = new System.Drawing.Size(79, 26);
            this.button_fileKEYsave.TabIndex = 3;
            this.button_fileKEYsave.UseVisualStyleBackColor = true;
            this.button_fileKEYsave.Click += new System.EventHandler(this.button_fileKEYsave_Click);
            // 
            // button_fileKEYopen
            // 
            this.button_fileKEYopen.Image = ((System.Drawing.Image)(resources.GetObject("button_fileKEYopen.Image")));
            this.button_fileKEYopen.Location = new System.Drawing.Point(439, 35);
            this.button_fileKEYopen.Margin = new System.Windows.Forms.Padding(2);
            this.button_fileKEYopen.Name = "button_fileKEYopen";
            this.button_fileKEYopen.Size = new System.Drawing.Size(79, 25);
            this.button_fileKEYopen.TabIndex = 2;
            this.button_fileKEYopen.UseVisualStyleBackColor = true;
            this.button_fileKEYopen.Click += new System.EventHandler(this.button_fileKEYopen_Click);
            // 
            // textBox_fileKEY
            // 
            this.textBox_fileKEY.Location = new System.Drawing.Point(157, 35);
            this.textBox_fileKEY.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_fileKEY.Name = "textBox_fileKEY";
            this.textBox_fileKEY.Size = new System.Drawing.Size(269, 22);
            this.textBox_fileKEY.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Файл з ключем : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_fileOUT);
            this.groupBox1.Controls.Add(this.button_fileIN);
            this.groupBox1.Controls.Add(this.textBox_fileOUT);
            this.groupBox1.Controls.Add(this.textBox_fileIN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(125, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(551, 120);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файли";
            // 
            // button_fileOUT
            // 
            this.button_fileOUT.Location = new System.Drawing.Point(439, 63);
            this.button_fileOUT.Margin = new System.Windows.Forms.Padding(2);
            this.button_fileOUT.Name = "button_fileOUT";
            this.button_fileOUT.Size = new System.Drawing.Size(79, 26);
            this.button_fileOUT.TabIndex = 5;
            this.button_fileOUT.Text = "...";
            this.button_fileOUT.UseVisualStyleBackColor = true;
            this.button_fileOUT.Click += new System.EventHandler(this.button_fileOUT_Click);
            // 
            // button_fileIN
            // 
            this.button_fileIN.Location = new System.Drawing.Point(439, 28);
            this.button_fileIN.Margin = new System.Windows.Forms.Padding(2);
            this.button_fileIN.Name = "button_fileIN";
            this.button_fileIN.Size = new System.Drawing.Size(79, 28);
            this.button_fileIN.TabIndex = 4;
            this.button_fileIN.Text = "...";
            this.button_fileIN.UseVisualStyleBackColor = true;
            this.button_fileIN.Click += new System.EventHandler(this.button_fileIN_Click);
            // 
            // textBox_fileOUT
            // 
            this.textBox_fileOUT.Location = new System.Drawing.Point(157, 63);
            this.textBox_fileOUT.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_fileOUT.Name = "textBox_fileOUT";
            this.textBox_fileOUT.Size = new System.Drawing.Size(269, 22);
            this.textBox_fileOUT.TabIndex = 3;
            // 
            // textBox_fileIN
            // 
            this.textBox_fileIN.Location = new System.Drawing.Point(157, 31);
            this.textBox_fileIN.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_fileIN.Name = "textBox_fileIN";
            this.textBox_fileIN.Size = new System.Drawing.Size(269, 22);
            this.textBox_fileIN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Зберегти у файл :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Відкрити у файл :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.Button button_KEYgenerator;
        private System.Windows.Forms.Button button_fileKEYsave;
        private System.Windows.Forms.Button button_fileKEYopen;
        private System.Windows.Forms.TextBox textBox_fileKEY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_fileOUT;
        private System.Windows.Forms.Button button_fileIN;
        private System.Windows.Forms.TextBox textBox_fileOUT;
        private System.Windows.Forms.TextBox textBox_fileIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip Зберегти;
        private System.Windows.Forms.ToolTip Скачати;
    }
}

