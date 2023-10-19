namespace Aplikacja_do_awizacji
{
    partial class GuestSign_inView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestSign_inView));
            returnButton = new Button();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            surnameTextBox = new TextBox();
            surnameLabel = new Label();
            titleLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            phoneTextBox = new TextBox();
            phoneLabel = new Label();
            guestDetailsPanel = new Panel();
            acceptButton = new Button();
            guestDetailsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // returnButton
            // 
            returnButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            returnButton.Location = new Point(12, 12);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(94, 32);
            returnButton.TabIndex = 6;
            returnButton.Text = "Powrót";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top;
            nameTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(160, 17);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(150, 30);
            nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Top;
            nameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(18, 20);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(135, 24);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Imię:";
            // 
            // surnameTextBox
            // 
            surnameTextBox.Anchor = AnchorStyles.Top;
            surnameTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            surnameTextBox.Location = new Point(160, 56);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(150, 30);
            surnameTextBox.TabIndex = 2;
            // 
            // surnameLabel
            // 
            surnameLabel.Anchor = AnchorStyles.Top;
            surnameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            surnameLabel.Location = new Point(18, 59);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(135, 24);
            surnameLabel.TabIndex = 8;
            surnameLabel.Text = "Nazwisko:";
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(185, 44);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(220, 34);
            titleLabel.TabIndex = 12;
            titleLabel.Text = "Podaj swoje dane:";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Top;
            emailTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(160, 92);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(150, 30);
            emailTextBox.TabIndex = 3;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.Top;
            emailLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(18, 95);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(135, 24);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Adres e-mail:";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Anchor = AnchorStyles.Top;
            phoneTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            phoneTextBox.Location = new Point(160, 131);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(150, 30);
            phoneTextBox.TabIndex = 4;
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = AnchorStyles.Top;
            phoneLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            phoneLabel.Location = new Point(18, 134);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(135, 24);
            phoneLabel.TabIndex = 15;
            phoneLabel.Text = "Numer telefonu:";
            // 
            // guestDetailsPanel
            // 
            guestDetailsPanel.Anchor = AnchorStyles.Top;
            guestDetailsPanel.Controls.Add(acceptButton);
            guestDetailsPanel.Controls.Add(phoneTextBox);
            guestDetailsPanel.Controls.Add(phoneLabel);
            guestDetailsPanel.Controls.Add(emailTextBox);
            guestDetailsPanel.Controls.Add(emailLabel);
            guestDetailsPanel.Controls.Add(surnameTextBox);
            guestDetailsPanel.Controls.Add(surnameLabel);
            guestDetailsPanel.Controls.Add(nameTextBox);
            guestDetailsPanel.Controls.Add(nameLabel);
            guestDetailsPanel.Location = new Point(108, 81);
            guestDetailsPanel.Name = "guestDetailsPanel";
            guestDetailsPanel.Size = new Size(343, 224);
            guestDetailsPanel.TabIndex = 17;
            // 
            // acceptButton
            // 
            acceptButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            acceptButton.Location = new Point(246, 183);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(94, 32);
            acceptButton.TabIndex = 5;
            acceptButton.Text = "Zapisz";
            acceptButton.UseVisualStyleBackColor = true;
            // 
            // GuestSign_inView
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(582, 353);
            Controls.Add(guestDetailsPanel);
            Controls.Add(titleLabel);
            Controls.Add(returnButton);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 400);
            Name = "GuestSign_inView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplikacja do awizacji - Gość";
            guestDetailsPanel.ResumeLayout(false);
            guestDetailsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button returnButton;
        private TextBox nameTextBox;
        private Label nameLabel;
        private TextBox surnameTextBox;
        private Label surnameLabel;
        private Label titleLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox phoneTextBox;
        private Label phoneLabel;
        private Panel guestDetailsPanel;
        private Button acceptButton;
    }
}