namespace Puzzle
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
            this.gamePanel = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonShuffle = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shuffleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heuristicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manhattanDistanceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.misplacedTilesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gamePanel.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamePanel.BackColor = System.Drawing.Color.Sienna;
            this.gamePanel.Controls.Add(this.button9);
            this.gamePanel.Controls.Add(this.button7);
            this.gamePanel.Controls.Add(this.button8);
            this.gamePanel.Controls.Add(this.button6);
            this.gamePanel.Controls.Add(this.button5);
            this.gamePanel.Controls.Add(this.button3);
            this.gamePanel.Controls.Add(this.button2);
            this.gamePanel.Controls.Add(this.button1);
            this.gamePanel.Controls.Add(this.button4);
            this.gamePanel.Location = new System.Drawing.Point(13, 52);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(4);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(366, 342);
            this.gamePanel.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.AllowDrop = true;
            this.button9.BackColor = System.Drawing.Color.Bisque;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(255, 235);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(93, 86);
            this.button9.TabIndex = 8;
            this.button9.Tag = "8";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button9.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button7
            // 
            this.button7.AllowDrop = true;
            this.button7.BackColor = System.Drawing.Color.Bisque;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(23, 235);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 86);
            this.button7.TabIndex = 7;
            this.button7.Tag = "6";
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button7.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button8
            // 
            this.button8.AllowDrop = true;
            this.button8.BackColor = System.Drawing.Color.Bisque;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(135, 235);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(93, 86);
            this.button8.TabIndex = 6;
            this.button8.Tag = "7";
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button8.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button6
            // 
            this.button6.AllowDrop = true;
            this.button6.BackColor = System.Drawing.Color.Bisque;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(255, 128);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 86);
            this.button6.TabIndex = 5;
            this.button6.Tag = "5";
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button6.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button5
            // 
            this.button5.AllowDrop = true;
            this.button5.BackColor = System.Drawing.Color.Bisque;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(135, 128);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 86);
            this.button5.TabIndex = 4;
            this.button5.Tag = "4";
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button5.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button3
            // 
            this.button3.AllowDrop = true;
            this.button3.BackColor = System.Drawing.Color.Bisque;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(255, 21);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 86);
            this.button3.TabIndex = 3;
            this.button3.Tag = "2";
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button3.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button2
            // 
            this.button2.AllowDrop = true;
            this.button2.BackColor = System.Drawing.Color.Bisque;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(135, 21);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 86);
            this.button2.TabIndex = 2;
            this.button2.Tag = "1";
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button2.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(23, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 86);
            this.button1.TabIndex = 1;
            this.button1.Tag = "0";
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // button4
            // 
            this.button4.AllowDrop = true;
            this.button4.BackColor = System.Drawing.Color.Bisque;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(23, 128);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 86);
            this.button4.TabIndex = 0;
            this.button4.Tag = "3";
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.DragDrop += new System.Windows.Forms.DragEventHandler(this.Button_DragDrop);
            this.button4.DragEnter += new System.Windows.Forms.DragEventHandler(this.Button_DragEnter);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonStart.Location = new System.Drawing.Point(420, 150);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(144, 69);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Solve";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // buttonShuffle
            // 
            this.buttonShuffle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShuffle.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonShuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShuffle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonShuffle.Location = new System.Drawing.Point(420, 52);
            this.buttonShuffle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShuffle.Name = "buttonShuffle";
            this.buttonShuffle.Size = new System.Drawing.Size(144, 67);
            this.buttonShuffle.TabIndex = 2;
            this.buttonShuffle.Text = "Shuffle";
            this.buttonShuffle.UseVisualStyleBackColor = false;
            this.buttonShuffle.Click += new System.EventHandler(this.ShuffleButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 422);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(612, 24);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.AutoSize = false;
            this.progressBar.Name = "progressBar";
            this.progressBar.Padding = new System.Windows.Forms.Padding(1, 1, 2, 1);
            this.progressBar.Size = new System.Drawing.Size(89, 16);
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 18);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.heuristicToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shuffleToolStripMenuItem,
            this.solveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // shuffleToolStripMenuItem
            // 
            this.shuffleToolStripMenuItem.Name = "shuffleToolStripMenuItem";
            this.shuffleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.shuffleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.shuffleToolStripMenuItem.Text = "Shuffle";
            this.shuffleToolStripMenuItem.Click += new System.EventHandler(this.ShuffleMenu_Click);
            // 
            // solveToolStripMenuItem
            // 
            this.solveToolStripMenuItem.Name = "solveToolStripMenuItem";
            this.solveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.solveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.solveToolStripMenuItem.Text = "Solve";
            this.solveToolStripMenuItem.Click += new System.EventHandler(this.SolveMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // heuristicToolStripMenuItem
            // 
            this.heuristicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manhattanDistanceMenu,
            this.misplacedTilesMenu});
            this.heuristicToolStripMenuItem.Name = "heuristicToolStripMenuItem";
            this.heuristicToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.heuristicToolStripMenuItem.Text = "&Heuristic";
            // 
            // manhattanDistanceMenu
            // 
            this.manhattanDistanceMenu.Name = "manhattanDistanceMenu";
            this.manhattanDistanceMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.manhattanDistanceMenu.Size = new System.Drawing.Size(277, 26);
            this.manhattanDistanceMenu.Text = "Manhattan Distance";
            this.manhattanDistanceMenu.Click += new System.EventHandler(this.ManhattanDistanceMenu_Click);
            // 
            // misplacedTilesMenu
            // 
            this.misplacedTilesMenu.Name = "misplacedTilesMenu";
            this.misplacedTilesMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.misplacedTilesMenu.Size = new System.Drawing.Size(277, 26);
            this.misplacedTilesMenu.Text = "Misplaced Tiles";
            this.misplacedTilesMenu.Click += new System.EventHandler(this.MisplacedTilesMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(612, 446);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonShuffle);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.gamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Munar_8 Puzzle Solver using A*";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gamePanel.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonShuffle;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heuristicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shuffleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manhattanDistanceMenu;
        private System.Windows.Forms.ToolStripMenuItem misplacedTilesMenu;
    }
}

