
namespace Windforms_Project_6
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
            this.ResetGame = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.A1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.PlayerOne = new System.Windows.Forms.Label();
            this.PlayerTwo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResetGame
            // 
            this.ResetGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ResetGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetGame.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ResetGame.Location = new System.Drawing.Point(242, 347);
            this.ResetGame.Name = "ResetGame";
            this.ResetGame.Size = new System.Drawing.Size(100, 50);
            this.ResetGame.TabIndex = 0;
            this.ResetGame.Text = "Reset Game";
            this.ResetGame.UseVisualStyleBackColor = false;
            this.ResetGame.Click += new System.EventHandler(this.ResetGame_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.A1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.C3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.C2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.C1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.B3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.B2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.B1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.A3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.A2, 1, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(92, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(395, 280);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // A1
            // 
            this.A1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.ForeColor = System.Drawing.Color.Black;
            this.A1.Location = new System.Drawing.Point(3, 3);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(125, 87);
            this.A1.TabIndex = 9;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.A1_Click);
            // 
            // C3
            // 
            this.C3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.ForeColor = System.Drawing.Color.Black;
            this.C3.Location = new System.Drawing.Point(265, 189);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(127, 88);
            this.C3.TabIndex = 8;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.A1_Click);
            // 
            // C2
            // 
            this.C2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.ForeColor = System.Drawing.Color.Black;
            this.C2.Location = new System.Drawing.Point(134, 189);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(125, 88);
            this.C2.TabIndex = 7;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.A1_Click);
            // 
            // C1
            // 
            this.C1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.ForeColor = System.Drawing.Color.Black;
            this.C1.Location = new System.Drawing.Point(3, 189);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(125, 88);
            this.C1.TabIndex = 6;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.A1_Click);
            // 
            // B3
            // 
            this.B3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.ForeColor = System.Drawing.Color.Black;
            this.B3.Location = new System.Drawing.Point(265, 96);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(127, 87);
            this.B3.TabIndex = 5;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.A1_Click);
            // 
            // B2
            // 
            this.B2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.ForeColor = System.Drawing.Color.Black;
            this.B2.Location = new System.Drawing.Point(134, 96);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(125, 87);
            this.B2.TabIndex = 4;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.A1_Click);
            // 
            // B1
            // 
            this.B1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.ForeColor = System.Drawing.Color.Black;
            this.B1.Location = new System.Drawing.Point(3, 96);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(125, 87);
            this.B1.TabIndex = 3;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.A1_Click);
            // 
            // A3
            // 
            this.A3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.ForeColor = System.Drawing.Color.Black;
            this.A3.Location = new System.Drawing.Point(265, 3);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(127, 87);
            this.A3.TabIndex = 2;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.A1_Click);
            // 
            // A2
            // 
            this.A2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.ForeColor = System.Drawing.Color.Black;
            this.A2.Location = new System.Drawing.Point(134, 3);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(125, 87);
            this.A2.TabIndex = 1;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.A1_Click);
            // 
            // PlayerOne
            // 
            this.PlayerOne.AutoSize = true;
            this.PlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerOne.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PlayerOne.Location = new System.Drawing.Point(92, 334);
            this.PlayerOne.Name = "PlayerOne";
            this.PlayerOne.Size = new System.Drawing.Size(83, 73);
            this.PlayerOne.TabIndex = 3;
            this.PlayerOne.Text = "O";
            // 
            // PlayerTwo
            // 
            this.PlayerTwo.AutoSize = true;
            this.PlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerTwo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PlayerTwo.Location = new System.Drawing.Point(421, 334);
            this.PlayerTwo.Name = "PlayerTwo";
            this.PlayerTwo.Size = new System.Drawing.Size(0, 73);
            this.PlayerTwo.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.PlayerTwo);
            this.Controls.Add(this.PlayerOne);
            this.Controls.Add(this.ResetGame);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Bisque;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic - Tac- Toe";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ResetGame;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Label PlayerOne;
        private System.Windows.Forms.Label PlayerTwo;
    }
}

