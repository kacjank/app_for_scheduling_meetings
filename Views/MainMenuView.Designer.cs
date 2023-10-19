namespace Aplikacja_do_awizacji
{
    partial class MainMenuView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuView));
            label1 = new Label();
            titleLabel = new Label();
            workerButton = new Button();
            guestButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(183, 135);
            label1.Name = "label1";
            label1.Size = new Size(205, 23);
            label1.TabIndex = 3;
            label1.Text = "Kto korzysta z programu?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(118, 82);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(338, 32);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Aplikacja do awizowania gości.";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // workerButton
            // 
            workerButton.Anchor = AnchorStyles.Top;
            workerButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            workerButton.CausesValidation = false;
            workerButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            workerButton.Location = new Point(112, 174);
            workerButton.Name = "workerButton";
            workerButton.Size = new Size(165, 60);
            workerButton.TabIndex = 1;
            workerButton.Text = "Pracownik";
            workerButton.UseVisualStyleBackColor = true;
            workerButton.Click += workerButton_Click;
            // 
            // guestButton
            // 
            guestButton.Anchor = AnchorStyles.Top;
            guestButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            guestButton.CausesValidation = false;
            guestButton.Location = new Point(291, 174);
            guestButton.Name = "guestButton";
            guestButton.Size = new Size(165, 60);
            guestButton.TabIndex = 2;
            guestButton.Text = "Gość";
            guestButton.UseVisualStyleBackColor = true;
            guestButton.Click += guestButton_Click;
            // 
            // MainMenuView
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            CausesValidation = false;
            ClientSize = new Size(582, 353);
            Controls.Add(guestButton);
            Controls.Add(workerButton);
            Controls.Add(label1);
            Controls.Add(titleLabel);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 400);
            Name = "MainMenuView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplikacja do awizacji - Start";
            Load += MainMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label titleLabel;
        private Button workerButton;
        private Button guestButton;
    }
}