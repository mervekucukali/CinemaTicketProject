namespace CinemaTicketProject
{
    partial class MovieAddScreen
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
            this.movietheaterComb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sellticketBtn = new System.Windows.Forms.Button();
            this.movietimeComb = new System.Windows.Forms.ComboBox();
            this.movieNamecmb = new System.Windows.Forms.ComboBox();
            this.ticketLbl = new System.Windows.Forms.Label();
            this.ticketQuatityTxt = new System.Windows.Forms.TextBox();
            this.ticketLb = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cuscmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Name";
            // 
            // movietheaterComb
            // 
            this.movietheaterComb.FormattingEnabled = true;
            this.movietheaterComb.Location = new System.Drawing.Point(205, 109);
            this.movietheaterComb.Name = "movietheaterComb";
            this.movietheaterComb.Size = new System.Drawing.Size(269, 24);
            this.movietheaterComb.TabIndex = 2;
            this.movietheaterComb.SelectedIndexChanged += new System.EventHandler(this.movietheaterComb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(560, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Movie Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Movie Theater";
            // 
            // sellticketBtn
            // 
            this.sellticketBtn.Location = new System.Drawing.Point(717, 121);
            this.sellticketBtn.Name = "sellticketBtn";
            this.sellticketBtn.Size = new System.Drawing.Size(269, 40);
            this.sellticketBtn.TabIndex = 7;
            this.sellticketBtn.Text = "Sell Ticket";
            this.sellticketBtn.UseVisualStyleBackColor = true;
            this.sellticketBtn.Click += new System.EventHandler(this.movieaddBtn_Click);
            // 
            // movietimeComb
            // 
            this.movietimeComb.FormattingEnabled = true;
            this.movietimeComb.Location = new System.Drawing.Point(717, 18);
            this.movietimeComb.Name = "movietimeComb";
            this.movietimeComb.Size = new System.Drawing.Size(269, 24);
            this.movietimeComb.TabIndex = 8;
            this.movietimeComb.SelectedIndexChanged += new System.EventHandler(this.movietimeComb_SelectedIndexChanged);
            // 
            // movieNamecmb
            // 
            this.movieNamecmb.FormattingEnabled = true;
            this.movieNamecmb.Location = new System.Drawing.Point(205, 68);
            this.movieNamecmb.Name = "movieNamecmb";
            this.movieNamecmb.Size = new System.Drawing.Size(269, 24);
            this.movieNamecmb.TabIndex = 9;
            this.movieNamecmb.SelectedIndexChanged += new System.EventHandler(this.movieNamecmb_SelectedIndexChanged);
            // 
            // ticketLbl
            // 
            this.ticketLbl.AutoSize = true;
            this.ticketLbl.BackColor = System.Drawing.Color.Transparent;
            this.ticketLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ticketLbl.ForeColor = System.Drawing.Color.White;
            this.ticketLbl.Location = new System.Drawing.Point(560, 65);
            this.ticketLbl.Name = "ticketLbl";
            this.ticketLbl.Size = new System.Drawing.Size(136, 20);
            this.ticketLbl.TabIndex = 3;
            this.ticketLbl.Text = "Ticket Quantity";
            // 
            // ticketQuatityTxt
            // 
            this.ticketQuatityTxt.Location = new System.Drawing.Point(717, 67);
            this.ticketQuatityTxt.Name = "ticketQuatityTxt";
            this.ticketQuatityTxt.Size = new System.Drawing.Size(269, 22);
            this.ticketQuatityTxt.TabIndex = 10;
            // 
            // ticketLb
            // 
            this.ticketLb.FormattingEnabled = true;
            this.ticketLb.ItemHeight = 16;
            this.ticketLb.Location = new System.Drawing.Point(52, 187);
            this.ticketLb.Name = "ticketLb";
            this.ticketLb.Size = new System.Drawing.Size(1116, 132);
            this.ticketLb.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Customer Id";
            // 
            // cuscmb
            // 
            this.cuscmb.FormattingEnabled = true;
            this.cuscmb.Location = new System.Drawing.Point(205, 21);
            this.cuscmb.Name = "cuscmb";
            this.cuscmb.Size = new System.Drawing.Size(269, 24);
            this.cuscmb.TabIndex = 14;
           
            // 
            // MovieAddScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = global::CinemaTicketProject.Properties.Resources._1642646898_42_phonoteka_org_p_fon_kino_44;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1327, 431);
            this.Controls.Add(this.cuscmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ticketLb);
            this.Controls.Add(this.ticketQuatityTxt);
            this.Controls.Add(this.movieNamecmb);
            this.Controls.Add(this.movietimeComb);
            this.Controls.Add(this.sellticketBtn);
            this.Controls.Add(this.ticketLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.movietheaterComb);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MovieAddScreen";
            this.Text = "TicketSalesScreen";
            this.Load += new System.EventHandler(this.MovieAddScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox movietheaterComb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sellticketBtn;
        private System.Windows.Forms.ComboBox movietimeComb;
        private System.Windows.Forms.ComboBox movieNamecmb;
        private System.Windows.Forms.Label ticketLbl;
        private System.Windows.Forms.TextBox ticketQuatityTxt;
        private System.Windows.Forms.ListBox ticketLb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cuscmb;
    }
}