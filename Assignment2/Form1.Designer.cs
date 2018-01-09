namespace Assignment2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.diceImageBox = new System.Windows.Forms.PictureBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.cntPlayed = new System.Windows.Forms.Label();
            this.cntWon = new System.Windows.Forms.Label();
            this.cntLost = new System.Windows.Forms.Label();
            this.guessBox = new System.Windows.Forms.TextBox();
            this.warnLbl = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.GameInfo = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.diceImageBox)).BeginInit();
            this.GameInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // diceImageBox
            // 
            this.diceImageBox.InitialImage = null;
            this.diceImageBox.Location = new System.Drawing.Point(424, 85);
            this.diceImageBox.Name = "diceImageBox";
            this.diceImageBox.Size = new System.Drawing.Size(86, 90);
            this.diceImageBox.TabIndex = 0;
            this.diceImageBox.TabStop = false;
            // 
            // rollButton
            // 
            this.rollButton.BackColor = System.Drawing.Color.Green;
            this.rollButton.Location = new System.Drawing.Point(424, 200);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 23);
            this.rollButton.TabIndex = 1;
            this.rollButton.Text = "ROLL";
            this.rollButton.UseVisualStyleBackColor = false;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // cntPlayed
            // 
            this.cntPlayed.AutoSize = true;
            this.cntPlayed.Location = new System.Drawing.Point(29, 30);
            this.cntPlayed.Name = "cntPlayed";
            this.cntPlayed.Size = new System.Drawing.Size(125, 13);
            this.cntPlayed.TabIndex = 2;
            this.cntPlayed.Text = "Number of Times Played:";
            // 
            // cntWon
            // 
            this.cntWon.AutoSize = true;
            this.cntWon.Location = new System.Drawing.Point(29, 58);
            this.cntWon.Name = "cntWon";
            this.cntWon.Size = new System.Drawing.Size(116, 13);
            this.cntWon.TabIndex = 3;
            this.cntWon.Text = "Number of Times Won:";
            // 
            // cntLost
            // 
            this.cntLost.AutoSize = true;
            this.cntLost.Location = new System.Drawing.Point(29, 86);
            this.cntLost.Name = "cntLost";
            this.cntLost.Size = new System.Drawing.Size(116, 13);
            this.cntLost.TabIndex = 4;
            this.cntLost.Text = "Number of Times Lost: ";
            // 
            // guessBox
            // 
            this.guessBox.Location = new System.Drawing.Point(32, 112);
            this.guessBox.MaxLength = 1;
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(27, 20);
            this.guessBox.TabIndex = 5;
            // 
            // warnLbl
            // 
            this.warnLbl.AutoSize = true;
            this.warnLbl.Location = new System.Drawing.Point(74, 119);
            this.warnLbl.Name = "warnLbl";
            this.warnLbl.Size = new System.Drawing.Size(35, 13);
            this.warnLbl.TabIndex = 6;
            this.warnLbl.Text = "label1";
            this.warnLbl.Visible = false;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Red;
            this.resetBtn.Location = new System.Drawing.Point(424, 229);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 7;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // GameInfo
            // 
            this.GameInfo.BackColor = System.Drawing.Color.Yellow;
            this.GameInfo.Controls.Add(this.cntLost);
            this.GameInfo.Controls.Add(this.cntWon);
            this.GameInfo.Controls.Add(this.cntPlayed);
            this.GameInfo.Controls.Add(this.warnLbl);
            this.GameInfo.Controls.Add(this.guessBox);
            this.GameInfo.Location = new System.Drawing.Point(82, 76);
            this.GameInfo.Name = "GameInfo";
            this.GameInfo.Size = new System.Drawing.Size(277, 159);
            this.GameInfo.TabIndex = 9;
            this.GameInfo.TabStop = false;
            this.GameInfo.Text = "GameInfo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(82, 350);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.Size = new System.Drawing.Size(443, 182);
            this.dataGridView1.TabIndex = 10;
            
            // 
            // Column1
            // 
            this.Column1.HeaderText = "FACE";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "FREQUENCY";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PERCENT";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "NUMBER OF TIMES GUESSED";
            this.Column4.Name = "Column4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(661, 623);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GameInfo);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.diceImageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.diceImageBox)).EndInit();
            this.GameInfo.ResumeLayout(false);
            this.GameInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox diceImageBox;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label cntPlayed;
        private System.Windows.Forms.Label cntWon;
        private System.Windows.Forms.Label cntLost;
        private System.Windows.Forms.TextBox guessBox;
        private System.Windows.Forms.Label warnLbl;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.GroupBox GameInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

