namespace MazeSolver
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
            this.btnManualPlay = new System.Windows.Forms.Button();
            this.btnSolveBFS = new System.Windows.Forms.Button();
            this.btnSolveDFS = new System.Windows.Forms.Button();
            this.btnSolveAStar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnManualPlay
            // 
            this.btnManualPlay.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnManualPlay.Location = new System.Drawing.Point(803, 41);
            this.btnManualPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnManualPlay.Name = "btnManualPlay";
            this.btnManualPlay.Size = new System.Drawing.Size(143, 40);
            this.btnManualPlay.TabIndex = 0;
            this.btnManualPlay.Text = "Manual Mode";
            this.btnManualPlay.UseVisualStyleBackColor = true;
            this.btnManualPlay.Click += new System.EventHandler(this.btnManualPlay_Click);
            // 
            // btnSolveBFS
            // 
            this.btnSolveBFS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSolveBFS.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSolveBFS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSolveBFS.Location = new System.Drawing.Point(803, 113);
            this.btnSolveBFS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSolveBFS.Name = "btnSolveBFS";
            this.btnSolveBFS.Size = new System.Drawing.Size(143, 40);
            this.btnSolveBFS.TabIndex = 1;
            this.btnSolveBFS.Text = "Solve with BFS";
            this.btnSolveBFS.UseVisualStyleBackColor = false;
            this.btnSolveBFS.Click += new System.EventHandler(this.btnSolveBFS_Click);
            // 
            // btnSolveDFS
            // 
            this.btnSolveDFS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSolveDFS.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSolveDFS.Location = new System.Drawing.Point(803, 176);
            this.btnSolveDFS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSolveDFS.Name = "btnSolveDFS";
            this.btnSolveDFS.Size = new System.Drawing.Size(143, 40);
            this.btnSolveDFS.TabIndex = 2;
            this.btnSolveDFS.Text = "Solve with DFS";
            this.btnSolveDFS.UseVisualStyleBackColor = true;
            this.btnSolveDFS.Click += new System.EventHandler(this.btnSolveDFS_Click);
            // 
            // btnSolveAStar
            // 
            this.btnSolveAStar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSolveAStar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSolveAStar.Location = new System.Drawing.Point(803, 250);
            this.btnSolveAStar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSolveAStar.Name = "btnSolveAStar";
            this.btnSolveAStar.Size = new System.Drawing.Size(143, 40);
            this.btnSolveAStar.TabIndex = 3;
            this.btnSolveAStar.Text = "Solve with A*";
            this.btnSolveAStar.UseVisualStyleBackColor = true;
            this.btnSolveAStar.Click += new System.EventHandler(this.btnSolveAStar_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReset.Location = new System.Drawing.Point(803, 319);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(143, 40);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(29, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 500);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSolveAStar);
            this.Controls.Add(this.btnSolveDFS);
            this.Controls.Add(this.btnSolveBFS);
            this.Controls.Add(this.btnManualPlay);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Maze ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManualPlay;
        private System.Windows.Forms.Button btnSolveBFS;
        private System.Windows.Forms.Button btnSolveDFS;
        private System.Windows.Forms.Button btnSolveAStar;
        private System.Windows.Forms.Button btnReset;
        public System.Windows.Forms.Panel panel1;
    }
}

