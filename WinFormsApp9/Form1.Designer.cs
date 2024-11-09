namespace WinFormsApp9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            toolStrip1 = new ToolStrip();
            TopLevelMenu = new TextBox();
            SubItem = new TextBox();
            MenuButton = new Button();
            SubButton = new Button();
            toolStripLabel1 = new ToolStripLabel();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // TopLevelMenu
            // 
            TopLevelMenu.Location = new Point(0, 100);
            TopLevelMenu.Name = "TopLevelMenu";
            TopLevelMenu.Size = new Size(100, 23);
            TopLevelMenu.TabIndex = 3;
            // 
            // SubItem
            // 
            SubItem.Location = new Point(106, 100);
            SubItem.Name = "SubItem";
            SubItem.Size = new Size(100, 23);
            SubItem.TabIndex = 4;
            // 
            // MenuButton
            // 
            MenuButton.Location = new Point(0, 129);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(100, 55);
            MenuButton.TabIndex = 5;
            MenuButton.Text = "Додати пункт меню";
            MenuButton.UseVisualStyleBackColor = true;
            MenuButton.Click += MenuButton_Click;
            // 
            // SubButton
            // 
            SubButton.Location = new Point(106, 129);
            SubButton.Name = "SubButton";
            SubButton.Size = new Size(100, 55);
            SubButton.TabIndex = 6;
            SubButton.Text = "Додати підменю";
            SubButton.UseVisualStyleBackColor = true;
            SubButton.Click += SubButton_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(0, 22);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SubButton);
            Controls.Add(MenuButton);
            Controls.Add(SubItem);
            Controls.Add(TopLevelMenu);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private TextBox TopLevelMenu;
        private TextBox SubItem;
        private Button MenuButton;
        private Button SubButton;
        private ToolStripLabel toolStripLabel1;
    }
}
