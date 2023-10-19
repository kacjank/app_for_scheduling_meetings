namespace Aplikacja_do_awizacji
{
    partial class LoggingView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggingView));
            loginLabel = new Label();
            passwordLabel = new Label();
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            infoLabel = new Label();
            returnButton = new Button();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.Anchor = AnchorStyles.Top;
            loginLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            loginLabel.Location = new Point(174, 106);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(56, 23);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Login:";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Top;
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(174, 148);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 23);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Hasło:";
            // 
            // loginTextBox
            // 
            loginTextBox.Anchor = AnchorStyles.Top;
            loginTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            loginTextBox.Location = new Point(236, 103);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(150, 30);
            loginTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top;
            passwordTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(236, 145);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(150, 30);
            passwordTextBox.TabIndex = 2;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top;
            loginButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.Location = new Point(236, 206);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 32);
            loginButton.TabIndex = 3;
            loginButton.Text = "Zaloguj się";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // infoLabel
            // 
            infoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            infoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            infoLabel.Location = new Point(152, 55);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(300, 45);
            infoLabel.TabIndex = 5;
            infoLabel.Text = "Logowanie do konta pracownika";
            infoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // returnButton
            // 
            returnButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            returnButton.Location = new Point(12, 12);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(94, 32);
            returnButton.TabIndex = 4;
            returnButton.Text = "Powrót";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // LoggingView
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(582, 353);
            Controls.Add(returnButton);
            Controls.Add(infoLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(loginLabel);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 4, 2, 4);
            MinimumSize = new Size(600, 400);
            Name = "LoggingView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplikacja do awizacji - Logowanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLabel;
        private Label passwordLabel;
        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Label infoLabel;
        private Button returnButton;
    }
}