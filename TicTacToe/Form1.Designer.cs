namespace TicTacToe
{
    partial class MainForm
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
            this.BtnA1 = new System.Windows.Forms.Button();
            this.BtnB1 = new System.Windows.Forms.Button();
            this.BtnC1 = new System.Windows.Forms.Button();
            this.BtnA2 = new System.Windows.Forms.Button();
            this.BtnB2 = new System.Windows.Forms.Button();
            this.BtnC2 = new System.Windows.Forms.Button();
            this.BtnA3 = new System.Windows.Forms.Button();
            this.BtnB3 = new System.Windows.Forms.Button();
            this.BtnC3 = new System.Windows.Forms.Button();
            this.GameCounterLabel = new System.Windows.Forms.Label();
            this.lblCounterLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.lblDraws = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWinable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnA1
            // 
            this.BtnA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnA1.Location = new System.Drawing.Point(13, 13);
            this.BtnA1.Name = "BtnA1";
            this.BtnA1.Size = new System.Drawing.Size(75, 75);
            this.BtnA1.TabIndex = 0;
            this.BtnA1.UseVisualStyleBackColor = true;
            this.BtnA1.Click += new System.EventHandler(this.BtnA1_Click);
            // 
            // BtnB1
            // 
            this.BtnB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnB1.Location = new System.Drawing.Point(94, 13);
            this.BtnB1.Name = "BtnB1";
            this.BtnB1.Size = new System.Drawing.Size(75, 75);
            this.BtnB1.TabIndex = 1;
            this.BtnB1.UseVisualStyleBackColor = true;
            this.BtnB1.Click += new System.EventHandler(this.BtnA1_Click);
            // 
            // BtnC1
            // 
            this.BtnC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnC1.Location = new System.Drawing.Point(175, 13);
            this.BtnC1.Name = "BtnC1";
            this.BtnC1.Size = new System.Drawing.Size(75, 75);
            this.BtnC1.TabIndex = 2;
            this.BtnC1.UseVisualStyleBackColor = true;
            this.BtnC1.Click += new System.EventHandler(this.BtnA1_Click);
            // 
            // BtnA2
            // 
            this.BtnA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnA2.Location = new System.Drawing.Point(13, 94);
            this.BtnA2.Name = "BtnA2";
            this.BtnA2.Size = new System.Drawing.Size(75, 75);
            this.BtnA2.TabIndex = 3;
            this.BtnA2.UseVisualStyleBackColor = true;
            this.BtnA2.Click += new System.EventHandler(this.BtnA1_Click);
            // 
            // BtnB2
            // 
            this.BtnB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnB2.Location = new System.Drawing.Point(94, 94);
            this.BtnB2.Name = "BtnB2";
            this.BtnB2.Size = new System.Drawing.Size(75, 75);
            this.BtnB2.TabIndex = 4;
            this.BtnB2.UseVisualStyleBackColor = true;
            this.BtnB2.Click += new System.EventHandler(this.BtnA1_Click);
            // 
            // BtnC2
            // 
            this.BtnC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnC2.Location = new System.Drawing.Point(175, 94);
            this.BtnC2.Name = "BtnC2";
            this.BtnC2.Size = new System.Drawing.Size(75, 75);
            this.BtnC2.TabIndex = 5;
            this.BtnC2.UseVisualStyleBackColor = true;
            this.BtnC2.Click += new System.EventHandler(this.BtnA1_Click);
            // 
            // BtnA3
            // 
            this.BtnA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnA3.Location = new System.Drawing.Point(13, 175);
            this.BtnA3.Name = "BtnA3";
            this.BtnA3.Size = new System.Drawing.Size(75, 75);
            this.BtnA3.TabIndex = 6;
            this.BtnA3.UseVisualStyleBackColor = true;
            this.BtnA3.Click += new System.EventHandler(this.BtnA1_Click);
            // 
            // BtnB3
            // 
            this.BtnB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnB3.Location = new System.Drawing.Point(94, 175);
            this.BtnB3.Name = "BtnB3";
            this.BtnB3.Size = new System.Drawing.Size(75, 75);
            this.BtnB3.TabIndex = 7;
            this.BtnB3.UseVisualStyleBackColor = true;
            this.BtnB3.Click += new System.EventHandler(this.BtnA1_Click);
            // 
            // BtnC3
            // 
            this.BtnC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnC3.Location = new System.Drawing.Point(175, 175);
            this.BtnC3.Name = "BtnC3";
            this.BtnC3.Size = new System.Drawing.Size(75, 75);
            this.BtnC3.TabIndex = 8;
            this.BtnC3.UseVisualStyleBackColor = true;
            this.BtnC3.Click += new System.EventHandler(this.BtnA1_Click);
            // 
            // GameCounterLabel
            // 
            this.GameCounterLabel.AutoSize = true;
            this.GameCounterLabel.Location = new System.Drawing.Point(13, 257);
            this.GameCounterLabel.Name = "GameCounterLabel";
            this.GameCounterLabel.Size = new System.Drawing.Size(72, 13);
            this.GameCounterLabel.TabIndex = 9;
            this.GameCounterLabel.Text = "Nr. of Games:";
            // 
            // lblCounterLabel
            // 
            this.lblCounterLabel.AutoSize = true;
            this.lblCounterLabel.Location = new System.Drawing.Point(89, 257);
            this.lblCounterLabel.Name = "lblCounterLabel";
            this.lblCounterLabel.Size = new System.Drawing.Size(0, 13);
            this.lblCounterLabel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Losses:";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Location = new System.Drawing.Point(89, 279);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(0, 13);
            this.lblLosses.TabIndex = 12;
            // 
            // lblDraws
            // 
            this.lblDraws.AutoSize = true;
            this.lblDraws.Location = new System.Drawing.Point(89, 299);
            this.lblDraws.Name = "lblDraws";
            this.lblDraws.Size = new System.Drawing.Size(0, 13);
            this.lblDraws.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Draws:";
            // 
            // btnWinable
            // 
            this.btnWinable.Location = new System.Drawing.Point(175, 256);
            this.btnWinable.Name = "btnWinable";
            this.btnWinable.Size = new System.Drawing.Size(75, 23);
            this.btnWinable.TabIndex = 15;
            this.btnWinable.Text = "wanna win?";
            this.btnWinable.UseVisualStyleBackColor = true;
            this.btnWinable.Click += new System.EventHandler(this.btnWinable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Wins:";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(211, 283);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(47, 13);
            this.lblWins.TabIndex = 17;
            this.lblWins.Text = "(Defualt)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 321);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWinable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDraws);
            this.Controls.Add(this.lblLosses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCounterLabel);
            this.Controls.Add(this.GameCounterLabel);
            this.Controls.Add(this.BtnC3);
            this.Controls.Add(this.BtnB3);
            this.Controls.Add(this.BtnA3);
            this.Controls.Add(this.BtnC2);
            this.Controls.Add(this.BtnB2);
            this.Controls.Add(this.BtnA2);
            this.Controls.Add(this.BtnC1);
            this.Controls.Add(this.BtnB1);
            this.Controls.Add(this.BtnA1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnA1;
        private System.Windows.Forms.Button BtnB1;
        private System.Windows.Forms.Button BtnC1;
        private System.Windows.Forms.Button BtnA2;
        private System.Windows.Forms.Button BtnB2;
        private System.Windows.Forms.Button BtnC2;
        private System.Windows.Forms.Button BtnA3;
        private System.Windows.Forms.Button BtnB3;
        private System.Windows.Forms.Button BtnC3;
        private System.Windows.Forms.Label GameCounterLabel;
        private System.Windows.Forms.Label lblCounterLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Label lblDraws;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnWinable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWins;
    }
}

