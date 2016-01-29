namespace SneilonRun
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSnails = new System.Windows.Forms.Panel();
            this.panelShailsAdd = new System.Windows.Forms.Panel();
            this.tbSnailName = new System.Windows.Forms.TextBox();
            this.btAddSnail = new System.Windows.Forms.Button();
            this.panelSnailsLabel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPlayerAll = new System.Windows.Forms.Panel();
            this.panelPlayers = new System.Windows.Forms.Panel();
            this.panelPlayerAdd = new System.Windows.Forms.Panel();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.btAddPlayer = new System.Windows.Forms.Button();
            this.panelPlayersLabel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelAnteAll = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelAnteAdd = new System.Windows.Forms.Panel();
            this.tbAnteSum = new System.Windows.Forms.TextBox();
            this.cbSnail = new System.Windows.Forms.ComboBox();
            this.cbPlayer = new System.Windows.Forms.ComboBox();
            this.btAddAnte = new System.Windows.Forms.Button();
            this.panelAnteLabel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelShailsAdd.SuspendLayout();
            this.panelSnailsLabel.SuspendLayout();
            this.panelPlayerAll.SuspendLayout();
            this.panelPlayerAdd.SuspendLayout();
            this.panelPlayersLabel.SuspendLayout();
            this.panelAnteAll.SuspendLayout();
            this.panelAnteAdd.SuspendLayout();
            this.panelAnteLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelSnails);
            this.panel1.Controls.Add(this.panelShailsAdd);
            this.panel1.Controls.Add(this.panelSnailsLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 399);
            this.panel1.TabIndex = 0;
            // 
            // panelSnails
            // 
            this.panelSnails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSnails.Location = new System.Drawing.Point(0, 43);
            this.panelSnails.Name = "panelSnails";
            this.panelSnails.Size = new System.Drawing.Size(310, 356);
            this.panelSnails.TabIndex = 2;
            // 
            // panelShailsAdd
            // 
            this.panelShailsAdd.Controls.Add(this.tbSnailName);
            this.panelShailsAdd.Controls.Add(this.btAddSnail);
            this.panelShailsAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShailsAdd.Location = new System.Drawing.Point(0, 18);
            this.panelShailsAdd.Name = "panelShailsAdd";
            this.panelShailsAdd.Size = new System.Drawing.Size(310, 25);
            this.panelShailsAdd.TabIndex = 1;
            // 
            // tbSnailName
            // 
            this.tbSnailName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSnailName.Location = new System.Drawing.Point(0, 0);
            this.tbSnailName.Name = "tbSnailName";
            this.tbSnailName.Size = new System.Drawing.Size(241, 20);
            this.tbSnailName.TabIndex = 3;
            // 
            // btAddSnail
            // 
            this.btAddSnail.Dock = System.Windows.Forms.DockStyle.Right;
            this.btAddSnail.Location = new System.Drawing.Point(241, 0);
            this.btAddSnail.Name = "btAddSnail";
            this.btAddSnail.Size = new System.Drawing.Size(69, 25);
            this.btAddSnail.TabIndex = 0;
            this.btAddSnail.Text = "Добавить";
            this.btAddSnail.UseVisualStyleBackColor = true;
            this.btAddSnail.Click += new System.EventHandler(this.BtAddSnail_Click);
            // 
            // panelSnailsLabel
            // 
            this.panelSnailsLabel.Controls.Add(this.label2);
            this.panelSnailsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSnailsLabel.Location = new System.Drawing.Point(0, 0);
            this.panelSnailsLabel.Name = "panelSnailsLabel";
            this.panelSnailsLabel.Size = new System.Drawing.Size(310, 18);
            this.panelSnailsLabel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Спортсмены";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPlayerAll
            // 
            this.panelPlayerAll.Controls.Add(this.panelPlayers);
            this.panelPlayerAll.Controls.Add(this.panelPlayerAdd);
            this.panelPlayerAll.Controls.Add(this.panelPlayersLabel);
            this.panelPlayerAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPlayerAll.Location = new System.Drawing.Point(691, 0);
            this.panelPlayerAll.Name = "panelPlayerAll";
            this.panelPlayerAll.Size = new System.Drawing.Size(203, 399);
            this.panelPlayerAll.TabIndex = 1;
            // 
            // panelPlayers
            // 
            this.panelPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlayers.Location = new System.Drawing.Point(0, 43);
            this.panelPlayers.Name = "panelPlayers";
            this.panelPlayers.Size = new System.Drawing.Size(203, 356);
            this.panelPlayers.TabIndex = 2;
            // 
            // panelPlayerAdd
            // 
            this.panelPlayerAdd.Controls.Add(this.tbPlayerName);
            this.panelPlayerAdd.Controls.Add(this.btAddPlayer);
            this.panelPlayerAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlayerAdd.Location = new System.Drawing.Point(0, 18);
            this.panelPlayerAdd.Name = "panelPlayerAdd";
            this.panelPlayerAdd.Size = new System.Drawing.Size(203, 25);
            this.panelPlayerAdd.TabIndex = 1;
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPlayerName.Location = new System.Drawing.Point(0, 0);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(134, 20);
            this.tbPlayerName.TabIndex = 3;
            // 
            // btAddPlayer
            // 
            this.btAddPlayer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btAddPlayer.Location = new System.Drawing.Point(134, 0);
            this.btAddPlayer.Name = "btAddPlayer";
            this.btAddPlayer.Size = new System.Drawing.Size(69, 25);
            this.btAddPlayer.TabIndex = 0;
            this.btAddPlayer.Text = "Добавить";
            this.btAddPlayer.UseVisualStyleBackColor = true;
            this.btAddPlayer.Click += new System.EventHandler(this.BtAddPlayer_Click);
            // 
            // panelPlayersLabel
            // 
            this.panelPlayersLabel.Controls.Add(this.label3);
            this.panelPlayersLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlayersLabel.Location = new System.Drawing.Point(0, 0);
            this.panelPlayersLabel.Name = "panelPlayersLabel";
            this.panelPlayersLabel.Size = new System.Drawing.Size(203, 18);
            this.panelPlayersLabel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Игроки";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAnteAll
            // 
            this.panelAnteAll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAnteAll.Controls.Add(this.button4);
            this.panelAnteAll.Controls.Add(this.button3);
            this.panelAnteAll.Controls.Add(this.button2);
            this.panelAnteAll.Controls.Add(this.button1);
            this.panelAnteAll.Controls.Add(this.panelAnteAdd);
            this.panelAnteAll.Controls.Add(this.panelAnteLabel);
            this.panelAnteAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnteAll.Location = new System.Drawing.Point(310, 0);
            this.panelAnteAll.Name = "panelAnteAll";
            this.panelAnteAll.Size = new System.Drawing.Size(381, 399);
            this.panelAnteAll.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(274, 333);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(274, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Play);
            // 
            // panelAnteAdd
            // 
            this.panelAnteAdd.Controls.Add(this.tbAnteSum);
            this.panelAnteAdd.Controls.Add(this.cbSnail);
            this.panelAnteAdd.Controls.Add(this.cbPlayer);
            this.panelAnteAdd.Controls.Add(this.btAddAnte);
            this.panelAnteAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAnteAdd.Location = new System.Drawing.Point(0, 18);
            this.panelAnteAdd.Name = "panelAnteAdd";
            this.panelAnteAdd.Size = new System.Drawing.Size(377, 25);
            this.panelAnteAdd.TabIndex = 1;
            // 
            // tbAnteSum
            // 
            this.tbAnteSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAnteSum.Location = new System.Drawing.Point(242, 0);
            this.tbAnteSum.Name = "tbAnteSum";
            this.tbAnteSum.Size = new System.Drawing.Size(66, 20);
            this.tbAnteSum.TabIndex = 6;
            // 
            // cbSnail
            // 
            this.cbSnail.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbSnail.FormattingEnabled = true;
            this.cbSnail.Location = new System.Drawing.Point(121, 0);
            this.cbSnail.Name = "cbSnail";
            this.cbSnail.Size = new System.Drawing.Size(121, 21);
            this.cbSnail.TabIndex = 5;
            // 
            // cbPlayer
            // 
            this.cbPlayer.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbPlayer.FormattingEnabled = true;
            this.cbPlayer.Location = new System.Drawing.Point(0, 0);
            this.cbPlayer.Name = "cbPlayer";
            this.cbPlayer.Size = new System.Drawing.Size(121, 21);
            this.cbPlayer.TabIndex = 4;
            // 
            // btAddAnte
            // 
            this.btAddAnte.Dock = System.Windows.Forms.DockStyle.Right;
            this.btAddAnte.Location = new System.Drawing.Point(308, 0);
            this.btAddAnte.Name = "btAddAnte";
            this.btAddAnte.Size = new System.Drawing.Size(69, 25);
            this.btAddAnte.TabIndex = 2;
            this.btAddAnte.Text = "Добавить";
            this.btAddAnte.UseVisualStyleBackColor = true;
            this.btAddAnte.Click += new System.EventHandler(this.BtAddAnte_Click);
            // 
            // panelAnteLabel
            // 
            this.panelAnteLabel.Controls.Add(this.label1);
            this.panelAnteLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAnteLabel.Location = new System.Drawing.Point(0, 0);
            this.panelAnteLabel.Name = "panelAnteLabel";
            this.panelAnteLabel.Size = new System.Drawing.Size(377, 18);
            this.panelAnteLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ставки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 399);
            this.Controls.Add(this.panelAnteAll);
            this.Controls.Add(this.panelPlayerAll);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelShailsAdd.ResumeLayout(false);
            this.panelShailsAdd.PerformLayout();
            this.panelSnailsLabel.ResumeLayout(false);
            this.panelPlayerAll.ResumeLayout(false);
            this.panelPlayerAdd.ResumeLayout(false);
            this.panelPlayerAdd.PerformLayout();
            this.panelPlayersLabel.ResumeLayout(false);
            this.panelAnteAll.ResumeLayout(false);
            this.panelAnteAdd.ResumeLayout(false);
            this.panelAnteAdd.PerformLayout();
            this.panelAnteLabel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelShailsAdd;
        private System.Windows.Forms.TextBox tbSnailName;
        private System.Windows.Forms.Button btAddSnail;
        private System.Windows.Forms.Panel panelSnails;
        private System.Windows.Forms.Panel panelPlayerAll;
        private System.Windows.Forms.Panel panelPlayerAdd;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.Button btAddPlayer;
        private System.Windows.Forms.Panel panelAnteAll;
        private System.Windows.Forms.Panel panelAnteAdd;
        private System.Windows.Forms.TextBox tbAnteSum;
        private System.Windows.Forms.ComboBox cbSnail;
        private System.Windows.Forms.ComboBox cbPlayer;
        private System.Windows.Forms.Button btAddAnte;
        private System.Windows.Forms.Panel panelAnteLabel;
        private System.Windows.Forms.Panel panelSnailsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPlayers;
        private System.Windows.Forms.Panel panelPlayersLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

