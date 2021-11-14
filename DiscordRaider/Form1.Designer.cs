
namespace DiscordRaider
{
    partial class DiscordRaider_form
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
            this.MainLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InviteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InviteBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SpamButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.ChannelBox = new System.Windows.Forms.TextBox();
            this.tokenTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 10);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // MainLabel
            // 
            this.MainLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.White;
            this.MainLabel.Location = new System.Drawing.Point(3, 18);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(220, 33);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "Discord Raider";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.InviteButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.InviteBox);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(9, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invite";
            // 
            // InviteButton
            // 
            this.InviteButton.BackColor = System.Drawing.Color.Green;
            this.InviteButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InviteButton.Location = new System.Drawing.Point(39, 102);
            this.InviteButton.Name = "InviteButton";
            this.InviteButton.Size = new System.Drawing.Size(196, 38);
            this.InviteButton.TabIndex = 2;
            this.InviteButton.Text = "Invite";
            this.InviteButton.UseVisualStyleBackColor = false;
            this.InviteButton.Click += new System.EventHandler(this.InviteButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Invite Code";
            // 
            // InviteBox
            // 
            this.InviteBox.BackColor = System.Drawing.Color.Gray;
            this.InviteBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InviteBox.Location = new System.Drawing.Point(42, 58);
            this.InviteBox.Multiline = true;
            this.InviteBox.Name = "InviteBox";
            this.InviteBox.Size = new System.Drawing.Size(172, 24);
            this.InviteBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SpamButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.MessageBox);
            this.groupBox2.Controls.Add(this.ChannelBox);
            this.groupBox2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(9, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 203);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spam";
            // 
            // SpamButton
            // 
            this.SpamButton.BackColor = System.Drawing.Color.Green;
            this.SpamButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpamButton.Location = new System.Drawing.Point(42, 149);
            this.SpamButton.Name = "SpamButton";
            this.SpamButton.Size = new System.Drawing.Size(196, 39);
            this.SpamButton.TabIndex = 3;
            this.SpamButton.Text = "Spam";
            this.SpamButton.UseVisualStyleBackColor = false;
            this.SpamButton.Click += new System.EventHandler(this.SpamButton_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(35, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Message";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(35, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Channel ID";
            // 
            // MessageBox
            // 
            this.MessageBox.BackColor = System.Drawing.Color.Gray;
            this.MessageBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBox.Location = new System.Drawing.Point(52, 105);
            this.MessageBox.Multiline = true;
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(172, 24);
            this.MessageBox.TabIndex = 1;
            // 
            // ChannelBox
            // 
            this.ChannelBox.BackColor = System.Drawing.Color.Gray;
            this.ChannelBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChannelBox.Location = new System.Drawing.Point(52, 53);
            this.ChannelBox.Multiline = true;
            this.ChannelBox.Name = "ChannelBox";
            this.ChannelBox.Size = new System.Drawing.Size(172, 24);
            this.ChannelBox.TabIndex = 0;
            // 
            // tokenTextBox
            // 
            this.tokenTextBox.BackColor = System.Drawing.Color.Gray;
            this.tokenTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.tokenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokenTextBox.ForeColor = System.Drawing.Color.White;
            this.tokenTextBox.Location = new System.Drawing.Point(448, 87);
            this.tokenTextBox.Multiline = true;
            this.tokenTextBox.Name = "tokenTextBox";
            this.tokenTextBox.ReadOnly = true;
            this.tokenTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tokenTextBox.Size = new System.Drawing.Size(433, 372);
            this.tokenTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(540, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 42);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tokens Loaded";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(802, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(448, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DiscordRaider_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(893, 471);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tokenTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiscordRaider_form";
            this.Text = "DiscordRaider_form";
            this.Load += new System.EventHandler(this.DiscordRaider_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InviteBox;
        private System.Windows.Forms.Button InviteButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.TextBox ChannelBox;
        private System.Windows.Forms.Button SpamButton;
        private System.Windows.Forms.TextBox tokenTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

