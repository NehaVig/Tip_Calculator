
namespace Tip_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.tip_percentage = new System.Windows.Forms.NumericUpDown();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.input_people = new System.Windows.Forms.NumericUpDown();
            this.bill_textBox = new System.Windows.Forms.TextBox();
            this.people_label = new System.Windows.Forms.Label();
            this.tip_per_person = new System.Windows.Forms.Label();
            this.total_tip = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tip_percentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_people)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tip_percentage
            // 
            this.tip_percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip_percentage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tip_percentage.InterceptArrowKeys = false;
            this.tip_percentage.Location = new System.Drawing.Point(80, 242);
            this.tip_percentage.Margin = new System.Windows.Forms.Padding(4);
            this.tip_percentage.Name = "tip_percentage";
            this.tip_percentage.Size = new System.Drawing.Size(339, 46);
            this.tip_percentage.TabIndex = 1;
            this.tip_percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tip_percentage.ValueChanged += new System.EventHandler(this.tip_percentage_ValueChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(501, 554);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tip %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 346);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of people";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(552, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tip ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(540, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // input_people
            // 
            this.input_people.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_people.Location = new System.Drawing.Point(80, 402);
            this.input_people.Margin = new System.Windows.Forms.Padding(4);
            this.input_people.Name = "input_people";
            this.input_people.Size = new System.Drawing.Size(339, 46);
            this.input_people.TabIndex = 9;
            this.input_people.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_people.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // bill_textBox
            // 
            this.bill_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_textBox.Location = new System.Drawing.Point(80, 94);
            this.bill_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.bill_textBox.Name = "bill_textBox";
            this.bill_textBox.Size = new System.Drawing.Size(349, 46);
            this.bill_textBox.TabIndex = 10;
            this.bill_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // people_label
            // 
            this.people_label.AutoSize = true;
            this.people_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.people_label.ForeColor = System.Drawing.Color.Coral;
            this.people_label.Location = new System.Drawing.Point(117, 467);
            this.people_label.Name = "people_label";
            this.people_label.Size = new System.Drawing.Size(0, 32);
            this.people_label.TabIndex = 13;
            // 
            // tip_per_person
            // 
            this.tip_per_person.AutoSize = true;
            this.tip_per_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip_per_person.ForeColor = System.Drawing.Color.Black;
            this.tip_per_person.Location = new System.Drawing.Point(827, 123);
            this.tip_per_person.Name = "tip_per_person";
            this.tip_per_person.Size = new System.Drawing.Size(242, 29);
            this.tip_per_person.TabIndex = 18;
            this.tip_per_person.Text = "tip_per_person_label";
            // 
            // total_tip
            // 
            this.total_tip.AutoSize = true;
            this.total_tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_tip.ForeColor = System.Drawing.Color.Black;
            this.total_tip.Location = new System.Drawing.Point(826, 247);
            this.total_tip.Name = "total_tip";
            this.total_tip.Size = new System.Drawing.Size(316, 36);
            this.total_tip.TabIndex = 19;
            this.total_tip.Text = "tip_per_person_label";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(542, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "per person";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(542, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "per person";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1176, 554);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.total_tip);
            this.Controls.Add(this.tip_per_person);
            this.Controls.Add(this.people_label);
            this.Controls.Add(this.bill_textBox);
            this.Controls.Add(this.input_people);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tip_percentage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tip Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.tip_percentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_people)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tip_percentage;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        
        private System.Windows.Forms.NumericUpDown input_people;
        private System.Windows.Forms.TextBox bill_textBox;

       
        private System.Windows.Forms.Label people_label;
        private System.Windows.Forms.Label tip_per_person;
        private System.Windows.Forms.Label total_tip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

