namespace KakuroHelper
{
    partial class KakuroHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KakuroHelper));
            this.lstbResult = new System.Windows.Forms.ListBox();
            this.lstbMust = new System.Windows.Forms.ListBox();
            this.lstbMustNot = new System.Windows.Forms.ListBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.lbNumber = new System.Windows.Forms.Label();
            this.lbLength = new System.Windows.Forms.Label();
            this.lbMust = new System.Windows.Forms.Label();
            this.lbMustNot = new System.Windows.Forms.Label();
            this.lbAbout = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbResult
            // 
            this.lstbResult.FormattingEnabled = true;
            this.lstbResult.Location = new System.Drawing.Point(12, 189);
            this.lstbResult.Name = "lstbResult";
            this.lstbResult.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbResult.Size = new System.Drawing.Size(212, 186);
            this.lstbResult.TabIndex = 0;
            this.lstbResult.TabStop = false;
            // 
            // lstbMust
            // 
            this.lstbMust.FormattingEnabled = true;
            this.lstbMust.Location = new System.Drawing.Point(118, 33);
            this.lstbMust.Name = "lstbMust";
            this.lstbMust.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbMust.Size = new System.Drawing.Size(48, 121);
            this.lstbMust.TabIndex = 4;
            this.lstbMust.SelectedValueChanged += new System.EventHandler(this.lstbMust_SelectedValueChanged);
            // 
            // lstbMustNot
            // 
            this.lstbMustNot.FormattingEnabled = true;
            this.lstbMustNot.Location = new System.Drawing.Point(172, 33);
            this.lstbMustNot.Name = "lstbMustNot";
            this.lstbMustNot.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbMustNot.Size = new System.Drawing.Size(50, 121);
            this.lstbMustNot.TabIndex = 5;
            this.lstbMustNot.SelectedValueChanged += new System.EventHandler(this.lstbMustNot_SelectedValueChanged);
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(52, 108);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(53, 20);
            this.tbNumber.TabIndex = 1;
            this.tbNumber.TextChanged += new System.EventHandler(this.tbNumber_TextChanged);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(12, 160);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(210, 23);
            this.btClear.TabIndex = 6;
            this.btClear.Text = "Löschen";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(52, 134);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(53, 20);
            this.tbLength.TabIndex = 2;
            this.tbLength.TextChanged += new System.EventHandler(this.tbLength_TextChanged);
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Location = new System.Drawing.Point(9, 115);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(28, 13);
            this.lbNumber.TabIndex = 7;
            this.lbNumber.Text = "Zahl";
            // 
            // lbLength
            // 
            this.lbLength.AutoSize = true;
            this.lbLength.Location = new System.Drawing.Point(9, 141);
            this.lbLength.Name = "lbLength";
            this.lbLength.Size = new System.Drawing.Size(37, 13);
            this.lbLength.TabIndex = 8;
            this.lbLength.Text = "Länge";
            // 
            // lbMust
            // 
            this.lbMust.AutoSize = true;
            this.lbMust.Location = new System.Drawing.Point(115, 17);
            this.lbMust.Name = "lbMust";
            this.lbMust.Size = new System.Drawing.Size(32, 13);
            this.lbMust.TabIndex = 9;
            this.lbMust.Text = "Muss";
            // 
            // lbMustNot
            // 
            this.lbMustNot.AutoSize = true;
            this.lbMustNot.Location = new System.Drawing.Point(169, 17);
            this.lbMustNot.Name = "lbMustNot";
            this.lbMustNot.Size = new System.Drawing.Size(53, 13);
            this.lbMustNot.TabIndex = 10;
            this.lbMustNot.Text = "Darf nicht";
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.Location = new System.Drawing.Point(7, 5);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(90, 65);
            this.lbAbout.TabIndex = 11;
            this.lbAbout.Text = "Kakuro Helper\r\nv0.0.1\r\nby Andreas Evers\r\npublished under\r\nGNU GPL v3";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbAbout);
            this.panel1.Location = new System.Drawing.Point(12, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 79);
            this.panel1.TabIndex = 12;
            // 
            // KakuroHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 385);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbMustNot);
            this.Controls.Add(this.lbMust);
            this.Controls.Add(this.lbLength);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.lstbMustNot);
            this.Controls.Add(this.lstbMust);
            this.Controls.Add(this.lstbResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KakuroHelper";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Kakuro Helper 0.0.1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbResult;
        private System.Windows.Forms.ListBox lstbMust;
        private System.Windows.Forms.ListBox lstbMustNot;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label lbLength;
        private System.Windows.Forms.Label lbMust;
        private System.Windows.Forms.Label lbMustNot;
        private System.Windows.Forms.Label lbAbout;
        private System.Windows.Forms.Panel panel1;
    }
}

