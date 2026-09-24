namespace homeassigment
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
            this.lbldayoftheweek = new System.Windows.Forms.Label();
            this.nameofthemonth = new System.Windows.Forms.Label();
            this.numericofthemonth = new System.Windows.Forms.Label();
            this.nameoftheyear = new System.Windows.Forms.Label();
            this.lblouput = new System.Windows.Forms.Label();
            this.dayoftheweek = new System.Windows.Forms.TextBox();
            this.txtoftheyear = new System.Windows.Forms.TextBox();
            this.txtnumericofthemonth = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.btnshowdate = new System.Windows.Forms.Button();
            this.btnclar = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldayoftheweek
            // 
            this.lbldayoftheweek.AutoSize = true;
            this.lbldayoftheweek.Location = new System.Drawing.Point(77, 49);
            this.lbldayoftheweek.Name = "lbldayoftheweek";
            this.lbldayoftheweek.Size = new System.Drawing.Size(182, 20);
            this.lbldayoftheweek.TabIndex = 0;
            this.lbldayoftheweek.Text = "enter day of the week";
            // 
            // nameofthemonth
            // 
            this.nameofthemonth.AutoSize = true;
            this.nameofthemonth.Location = new System.Drawing.Point(77, 120);
            this.nameofthemonth.Name = "nameofthemonth";
            this.nameofthemonth.Size = new System.Drawing.Size(207, 20);
            this.nameofthemonth.TabIndex = 1;
            this.nameofthemonth.Text = "enter name of the month";
            // 
            // numericofthemonth
            // 
            this.numericofthemonth.AutoSize = true;
            this.numericofthemonth.Location = new System.Drawing.Point(58, 186);
            this.numericofthemonth.Name = "numericofthemonth";
            this.numericofthemonth.Size = new System.Drawing.Size(226, 20);
            this.numericofthemonth.TabIndex = 2;
            this.numericofthemonth.Text = "enter numeric of the month";
            // 
            // nameoftheyear
            // 
            this.nameoftheyear.AutoSize = true;
            this.nameoftheyear.Location = new System.Drawing.Point(77, 238);
            this.nameoftheyear.Name = "nameoftheyear";
            this.nameoftheyear.Size = new System.Drawing.Size(171, 20);
            this.nameoftheyear.TabIndex = 3;
            this.nameoftheyear.Text = "enternameoftheyear";
            // 
            // lblouput
            // 
            this.lblouput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblouput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblouput.Location = new System.Drawing.Point(81, 301);
            this.lblouput.Name = "lblouput";
            this.lblouput.Size = new System.Drawing.Size(591, 64);
            this.lblouput.TabIndex = 4;
            // 
            // dayoftheweek
            // 
            this.dayoftheweek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayoftheweek.Location = new System.Drawing.Point(304, 42);
            this.dayoftheweek.Name = "dayoftheweek";
            this.dayoftheweek.Size = new System.Drawing.Size(220, 26);
            this.dayoftheweek.TabIndex = 5;
            // 
            // txtoftheyear
            // 
            this.txtoftheyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtoftheyear.Location = new System.Drawing.Point(304, 250);
            this.txtoftheyear.Name = "txtoftheyear";
            this.txtoftheyear.Size = new System.Drawing.Size(220, 26);
            this.txtoftheyear.TabIndex = 6;
            // 
            // txtnumericofthemonth
            // 
            this.txtnumericofthemonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumericofthemonth.Location = new System.Drawing.Point(304, 184);
            this.txtnumericofthemonth.Name = "txtnumericofthemonth";
            this.txtnumericofthemonth.Size = new System.Drawing.Size(220, 26);
            this.txtnumericofthemonth.TabIndex = 7;
            // 
            // txtmonth
            // 
            this.txtmonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmonth.Location = new System.Drawing.Point(304, 120);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(220, 26);
            this.txtmonth.TabIndex = 8;
            // 
            // btnshowdate
            // 
            this.btnshowdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowdate.Location = new System.Drawing.Point(71, 368);
            this.btnshowdate.Name = "btnshowdate";
            this.btnshowdate.Size = new System.Drawing.Size(124, 63);
            this.btnshowdate.TabIndex = 9;
            this.btnshowdate.Text = "showdate";
            this.btnshowdate.UseVisualStyleBackColor = true;
            this.btnshowdate.Click += new System.EventHandler(this.btnshowdate_Click);
            // 
            // btnclar
            // 
            this.btnclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclar.Location = new System.Drawing.Point(277, 368);
            this.btnclar.Name = "btnclar";
            this.btnclar.Size = new System.Drawing.Size(114, 63);
            this.btnclar.TabIndex = 10;
            this.btnclar.Text = "clear";
            this.btnclar.UseVisualStyleBackColor = true;
            this.btnclar.Click += new System.EventHandler(this.btnclar_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(464, 368);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(100, 63);
            this.btnclose.TabIndex = 11;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclar);
            this.Controls.Add(this.btnshowdate);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtnumericofthemonth);
            this.Controls.Add(this.txtoftheyear);
            this.Controls.Add(this.dayoftheweek);
            this.Controls.Add(this.lblouput);
            this.Controls.Add(this.nameoftheyear);
            this.Controls.Add(this.numericofthemonth);
            this.Controls.Add(this.nameofthemonth);
            this.Controls.Add(this.lbldayoftheweek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldayoftheweek;
        private System.Windows.Forms.Label nameofthemonth;
        private System.Windows.Forms.Label numericofthemonth;
        private System.Windows.Forms.Label nameoftheyear;
        private System.Windows.Forms.Label lblouput;
        private System.Windows.Forms.TextBox dayoftheweek;
        private System.Windows.Forms.TextBox txtoftheyear;
        private System.Windows.Forms.TextBox txtnumericofthemonth;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.Button btnshowdate;
        private System.Windows.Forms.Button btnclar;
        private System.Windows.Forms.Button btnclose;
    }
}

