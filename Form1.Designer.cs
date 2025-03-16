namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.winningsTB = new System.Windows.Forms.TextBox();
            this.creditWindow = new System.Windows.Forms.TextBox();
            this.bet1 = new System.Windows.Forms.Button();
            this.bet10 = new System.Windows.Forms.Button();
            this.bet1k = new System.Windows.Forms.Button();
            this.bet100 = new System.Windows.Forms.Button();
            this.refill = new System.Windows.Forms.Button();
            this.Sheet = new System.Windows.Forms.PictureBox();
            this.slot9 = new System.Windows.Forms.PictureBox();
            this.slot6 = new System.Windows.Forms.PictureBox();
            this.slot3 = new System.Windows.Forms.PictureBox();
            this.slot8 = new System.Windows.Forms.PictureBox();
            this.slot5 = new System.Windows.Forms.PictureBox();
            this.slot2 = new System.Windows.Forms.PictureBox();
            this.slot7 = new System.Windows.Forms.PictureBox();
            this.slot4 = new System.Windows.Forms.PictureBox();
            this.slot1 = new System.Windows.Forms.PictureBox();
            this.slotMachine = new System.Windows.Forms.PictureBox();
            this.SpinAgain = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Sheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotMachine)).BeginInit();
            this.SuspendLayout();
            // 
            // winningsTB
            // 
            this.winningsTB.BackColor = System.Drawing.Color.IndianRed;
            this.winningsTB.Font = new System.Drawing.Font("MingLiU-ExtB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winningsTB.Location = new System.Drawing.Point(35, 373);
            this.winningsTB.Name = "winningsTB";
            this.winningsTB.ReadOnly = true;
            this.winningsTB.Size = new System.Drawing.Size(374, 33);
            this.winningsTB.TabIndex = 10;
            this.winningsTB.Text = "Welcome to Klob\'s SlotMachine!";
            this.winningsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // creditWindow
            // 
            this.creditWindow.BackColor = System.Drawing.Color.Gray;
            this.creditWindow.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditWindow.Location = new System.Drawing.Point(438, 12);
            this.creditWindow.Name = "creditWindow";
            this.creditWindow.ReadOnly = true;
            this.creditWindow.Size = new System.Drawing.Size(174, 27);
            this.creditWindow.TabIndex = 11;
            this.creditWindow.Text = "Credits : 100 (ඞ)";
            this.creditWindow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bet1
            // 
            this.bet1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bet1.Location = new System.Drawing.Point(438, 45);
            this.bet1.Name = "bet1";
            this.bet1.Size = new System.Drawing.Size(84, 47);
            this.bet1.TabIndex = 12;
            this.bet1.Text = "ඞ";
            this.bet1.UseVisualStyleBackColor = true;
            this.bet1.Click += new System.EventHandler(this.bet1_Click);
            // 
            // bet10
            // 
            this.bet10.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bet10.Location = new System.Drawing.Point(528, 45);
            this.bet10.Name = "bet10";
            this.bet10.Size = new System.Drawing.Size(84, 47);
            this.bet10.TabIndex = 13;
            this.bet10.Text = "10 (ඞ)";
            this.bet10.UseVisualStyleBackColor = true;
            this.bet10.Click += new System.EventHandler(this.bet10_Click);
            // 
            // bet1k
            // 
            this.bet1k.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bet1k.Location = new System.Drawing.Point(528, 98);
            this.bet1k.Name = "bet1k";
            this.bet1k.Size = new System.Drawing.Size(84, 47);
            this.bet1k.TabIndex = 15;
            this.bet1k.Text = "1000 (ඞ)";
            this.bet1k.UseVisualStyleBackColor = true;
            this.bet1k.Click += new System.EventHandler(this.bet1k_Click);
            // 
            // bet100
            // 
            this.bet100.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bet100.Location = new System.Drawing.Point(438, 98);
            this.bet100.Name = "bet100";
            this.bet100.Size = new System.Drawing.Size(84, 47);
            this.bet100.TabIndex = 14;
            this.bet100.Text = "100 (ඞ)";
            this.bet100.UseVisualStyleBackColor = true;
            this.bet100.Click += new System.EventHandler(this.bet100_Click);
            // 
            // refill
            // 
            this.refill.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refill.Location = new System.Drawing.Point(438, 151);
            this.refill.Name = "refill";
            this.refill.Size = new System.Drawing.Size(174, 38);
            this.refill.TabIndex = 16;
            this.refill.Text = "Refill, when empty!";
            this.refill.UseVisualStyleBackColor = true;
            this.refill.Click += new System.EventHandler(this.refill_Click);
            // 
            // Sheet
            // 
            this.Sheet.Image = global::WindowsFormsApp1.Properties.Resources.Sheet;
            this.Sheet.Location = new System.Drawing.Point(438, 195);
            this.Sheet.Name = "Sheet";
            this.Sheet.Size = new System.Drawing.Size(174, 237);
            this.Sheet.TabIndex = 17;
            this.Sheet.TabStop = false;
            // 
            // slot9
            // 
            this.slot9.Image = global::WindowsFormsApp1.Properties.Resources.Actual_Joker;
            this.slot9.Location = new System.Drawing.Point(302, 253);
            this.slot9.Name = "slot9";
            this.slot9.Size = new System.Drawing.Size(68, 65);
            this.slot9.TabIndex = 9;
            this.slot9.TabStop = false;
            // 
            // slot6
            // 
            this.slot6.Image = global::WindowsFormsApp1.Properties.Resources.Clubs;
            this.slot6.Location = new System.Drawing.Point(302, 163);
            this.slot6.Name = "slot6";
            this.slot6.Size = new System.Drawing.Size(68, 65);
            this.slot6.TabIndex = 8;
            this.slot6.TabStop = false;
            // 
            // slot3
            // 
            this.slot3.Image = global::WindowsFormsApp1.Properties.Resources.Cherry;
            this.slot3.Location = new System.Drawing.Point(302, 79);
            this.slot3.Name = "slot3";
            this.slot3.Size = new System.Drawing.Size(68, 65);
            this.slot3.TabIndex = 7;
            this.slot3.TabStop = false;
            // 
            // slot8
            // 
            this.slot8.Image = global::WindowsFormsApp1.Properties.Resources.Heart;
            this.slot8.Location = new System.Drawing.Point(187, 253);
            this.slot8.Name = "slot8";
            this.slot8.Size = new System.Drawing.Size(68, 65);
            this.slot8.TabIndex = 6;
            this.slot8.TabStop = false;
            // 
            // slot5
            // 
            this.slot5.Image = global::WindowsFormsApp1.Properties.Resources.Clover;
            this.slot5.Location = new System.Drawing.Point(187, 163);
            this.slot5.Name = "slot5";
            this.slot5.Size = new System.Drawing.Size(68, 65);
            this.slot5.TabIndex = 5;
            this.slot5.TabStop = false;
            // 
            // slot2
            // 
            this.slot2.Image = global::WindowsFormsApp1.Properties.Resources.Coin;
            this.slot2.Location = new System.Drawing.Point(187, 79);
            this.slot2.Name = "slot2";
            this.slot2.Size = new System.Drawing.Size(68, 65);
            this.slot2.TabIndex = 4;
            this.slot2.TabStop = false;
            // 
            // slot7
            // 
            this.slot7.Image = global::WindowsFormsApp1.Properties.Resources.Diamond;
            this.slot7.Location = new System.Drawing.Point(66, 253);
            this.slot7.Name = "slot7";
            this.slot7.Size = new System.Drawing.Size(68, 65);
            this.slot7.TabIndex = 3;
            this.slot7.TabStop = false;
            // 
            // slot4
            // 
            this.slot4.Image = global::WindowsFormsApp1.Properties.Resources.Spade;
            this.slot4.Location = new System.Drawing.Point(66, 163);
            this.slot4.Name = "slot4";
            this.slot4.Size = new System.Drawing.Size(68, 65);
            this.slot4.TabIndex = 2;
            this.slot4.TabStop = false;
            // 
            // slot1
            // 
            this.slot1.Image = global::WindowsFormsApp1.Properties.Resources.Mong;
            this.slot1.Location = new System.Drawing.Point(66, 79);
            this.slot1.Name = "slot1";
            this.slot1.Size = new System.Drawing.Size(68, 65);
            this.slot1.TabIndex = 1;
            this.slot1.TabStop = false;
            // 
            // slotMachine
            // 
            this.slotMachine.Image = global::WindowsFormsApp1.Properties.Resources.Slots_outline;
            this.slotMachine.Location = new System.Drawing.Point(12, 12);
            this.slotMachine.Name = "slotMachine";
            this.slotMachine.Size = new System.Drawing.Size(420, 420);
            this.slotMachine.TabIndex = 0;
            this.slotMachine.TabStop = false;
            // 
            // SpinAgain
            // 
            this.SpinAgain.BackColor = System.Drawing.Color.DimGray;
            this.SpinAgain.Location = new System.Drawing.Point(585, 338);
            this.SpinAgain.Name = "SpinAgain";
            this.SpinAgain.ReadOnly = true;
            this.SpinAgain.Size = new System.Drawing.Size(27, 20);
            this.SpinAgain.TabIndex = 18;
            this.SpinAgain.Text = "0";
            this.SpinAgain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.SpinAgain);
            this.Controls.Add(this.Sheet);
            this.Controls.Add(this.refill);
            this.Controls.Add(this.bet1k);
            this.Controls.Add(this.bet100);
            this.Controls.Add(this.bet10);
            this.Controls.Add(this.bet1);
            this.Controls.Add(this.creditWindow);
            this.Controls.Add(this.winningsTB);
            this.Controls.Add(this.slot9);
            this.Controls.Add(this.slot6);
            this.Controls.Add(this.slot3);
            this.Controls.Add(this.slot8);
            this.Controls.Add(this.slot5);
            this.Controls.Add(this.slot2);
            this.Controls.Add(this.slot7);
            this.Controls.Add(this.slot4);
            this.Controls.Add(this.slot1);
            this.Controls.Add(this.slotMachine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Klob\'s SlotMachine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotMachine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox slotMachine;
        private System.Windows.Forms.PictureBox slot1;
        private System.Windows.Forms.PictureBox slot4;
        private System.Windows.Forms.PictureBox slot7;
        private System.Windows.Forms.PictureBox slot8;
        private System.Windows.Forms.PictureBox slot5;
        private System.Windows.Forms.PictureBox slot2;
        private System.Windows.Forms.PictureBox slot9;
        private System.Windows.Forms.PictureBox slot6;
        private System.Windows.Forms.PictureBox slot3;
        private System.Windows.Forms.TextBox winningsTB;
        private System.Windows.Forms.TextBox creditWindow;
        private System.Windows.Forms.Button bet1;
        private System.Windows.Forms.Button bet10;
        private System.Windows.Forms.Button bet1k;
        private System.Windows.Forms.Button bet100;
        private System.Windows.Forms.Button refill;
        private System.Windows.Forms.PictureBox Sheet;
        private System.Windows.Forms.TextBox SpinAgain;
    }
}

