namespace ObserverPatternDemo
{
    partial class frmObserver1
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
            lblData = new Label();
            btnSubscribe = new Button();
            btnUnsubscribe = new Button();
            SuspendLayout();
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(194, 187);
            lblData.Name = "lblData";
            lblData.Size = new Size(103, 20);
            lblData.TabIndex = 0;
            lblData.Text = "Updated Data";
            // 
            // btnSubscribe
            // 
            btnSubscribe.Location = new Point(203, 91);
            btnSubscribe.Name = "btnSubscribe";
            btnSubscribe.Size = new Size(94, 29);
            btnSubscribe.TabIndex = 1;
            btnSubscribe.Text = "Register";
            btnSubscribe.UseVisualStyleBackColor = true;
            btnSubscribe.Click += btnSubscribe_Click;
            // 
            // btnUnsubscribe
            // 
            btnUnsubscribe.Location = new Point(203, 138);
            btnUnsubscribe.Name = "btnUnsubscribe";
            btnUnsubscribe.Size = new Size(94, 29);
            btnUnsubscribe.TabIndex = 2;
            btnUnsubscribe.Text = "De-Register";
            btnUnsubscribe.UseVisualStyleBackColor = true;
            btnUnsubscribe.Click += btnUnsubscribe_Click;
            // 
            // frmObserver1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUnsubscribe);
            Controls.Add(btnSubscribe);
            Controls.Add(lblData);
            Name = "frmObserver1";
            Text = "frmObserver1";
            Load += frmObserver1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblData;
        private Button btnSubscribe;
        private Button btnUnsubscribe;
    }
}