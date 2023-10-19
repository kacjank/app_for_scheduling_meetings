namespace Aplikacja_do_awizacji
{
    partial class WorkerMeetingsView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerMeetingsView));
            meetingBindingSource = new BindingSource(components);
            logoutButton = new Button();
            titleLabel = new Label();
            meetingsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)meetingBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)meetingsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // meetingBindingSource
            // 
            meetingBindingSource.DataSource = typeof(Model.Meeting);
            // 
            // logoutButton
            // 
            logoutButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            logoutButton.Location = new Point(12, 309);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(106, 32);
            logoutButton.TabIndex = 8;
            logoutButton.Text = "Wyloguj się";
            logoutButton.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(126, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(338, 32);
            titleLabel.TabIndex = 9;
            titleLabel.Text = "Zaplanowane spotkania:";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // meetingsDataGridView
            // 
            meetingsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            meetingsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            meetingsDataGridView.Location = new Point(12, 44);
            meetingsDataGridView.Name = "meetingsDataGridView";
            meetingsDataGridView.RowHeadersWidth = 51;
            meetingsDataGridView.RowTemplate.Height = 29;
            meetingsDataGridView.Size = new Size(558, 259);
            meetingsDataGridView.TabIndex = 10;
            // 
            // WorkerMeetingsView
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(582, 353);
            Controls.Add(meetingsDataGridView);
            Controls.Add(titleLabel);
            Controls.Add(logoutButton);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 400);
            Name = "WorkerMeetingsView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplikacja do awizacji - Pracownik";
            ((System.ComponentModel.ISupportInitialize)meetingBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)meetingsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button logoutButton;
        private Label titleLabel;
        private BindingSource meetingBindingSource;
        private DataGridView meetingsDataGridView;
    }
}