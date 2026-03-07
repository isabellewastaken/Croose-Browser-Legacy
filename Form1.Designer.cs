namespace Croose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            txtUrl = new TextBox();
            btnaddTab = new Button();
            btnGo = new Button();
            btnremovetab = new Button();
            button2 = new Button();
            btnForward = new Button();
            btnHome = new Button();
            btnBack = new Button();
            btnHelp = new Button();
            button1 = new Button();
            btnShowPage = new Button();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Location = new Point(1, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(802, 424);
            tabControl1.TabIndex = 0;
            // 
            // txtUrl
            // 
            txtUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUrl.Location = new Point(217, 5);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(417, 23);
            txtUrl.TabIndex = 1;
            txtUrl.Text = "Search with Ecosia or enter a URL...";
            // 
            // btnaddTab
            // 
            btnaddTab.Location = new Point(1, 5);
            btnaddTab.Name = "btnaddTab";
            btnaddTab.Size = new Size(28, 23);
            btnaddTab.TabIndex = 2;
            btnaddTab.Text = "+";
            btnaddTab.UseVisualStyleBackColor = true;
            btnaddTab.Click += btnaddTab_Click;
            // 
            // btnGo
            // 
            btnGo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGo.Location = new Point(640, 5);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(50, 23);
            btnGo.TabIndex = 3;
            btnGo.Text = "⌕";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // btnremovetab
            // 
            btnremovetab.Location = new Point(35, 5);
            btnremovetab.Name = "btnremovetab";
            btnremovetab.Size = new Size(28, 23);
            btnremovetab.TabIndex = 4;
            btnremovetab.Text = "-";
            btnremovetab.UseVisualStyleBackColor = true;
            btnremovetab.Click += btnremovetab_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(137, 5);
            button2.Name = "button2";
            button2.Size = new Size(28, 23);
            button2.TabIndex = 6;
            button2.Text = "↻";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnForward
            // 
            btnForward.Location = new Point(103, 5);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(28, 23);
            btnForward.TabIndex = 7;
            btnForward.Text = "→";
            btnForward.UseVisualStyleBackColor = true;
            btnForward.Click += btnForward_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(171, 5);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(28, 23);
            btnHome.TabIndex = 8;
            btnHome.Text = "🏠︎";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(69, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(28, 23);
            btnBack.TabIndex = 9;
            btnBack.Text = "←";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnHelp
            // 
            btnHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHelp.Location = new Point(775, 4);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(21, 23);
            btnHelp.TabIndex = 10;
            btnHelp.Text = "\U0001f6df";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(724, 4);
            button1.Name = "button1";
            button1.Size = new Size(45, 23);
            button1.TabIndex = 11;
            button1.Text = "🚫🤖";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnShowPage
            // 
            btnShowPage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShowPage.Location = new Point(692, 3);
            btnShowPage.Name = "btnShowPage";
            btnShowPage.Size = new Size(26, 23);
            btnShowPage.TabIndex = 12;
            btnShowPage.Text = "🌐";
            btnShowPage.UseVisualStyleBackColor = true;
            btnShowPage.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowPage);
            Controls.Add(button1);
            Controls.Add(btnHelp);
            Controls.Add(btnBack);
            Controls.Add(btnHome);
            Controls.Add(btnForward);
            Controls.Add(button2);
            Controls.Add(btnremovetab);
            Controls.Add(btnGo);
            Controls.Add(btnaddTab);
            Controls.Add(txtUrl);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Croose Browser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TextBox txtUrl;
        private Button btnaddTab;
        private Button btnGo;
        private Button btnremovetab;
        private Button button2;
        private Button btnForward;
        private Button btnHome;
        private Button btnBack;
        private Button btnHelp;
        private Button button1;
        private Button btnShowPage;
    }
}
