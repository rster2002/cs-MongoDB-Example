namespace MongoDB.Views {
    partial class NewBikeView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.bikeModelNameTextBox = new System.Windows.Forms.TextBox();
            this.confirmNewBikeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bikeModelNameTextBox
            // 
            this.bikeModelNameTextBox.Location = new System.Drawing.Point(122, 53);
            this.bikeModelNameTextBox.Name = "bikeModelNameTextBox";
            this.bikeModelNameTextBox.Size = new System.Drawing.Size(338, 26);
            this.bikeModelNameTextBox.TabIndex = 0;
            // 
            // confirmNewBikeButton
            // 
            this.confirmNewBikeButton.Location = new System.Drawing.Point(122, 85);
            this.confirmNewBikeButton.Name = "confirmNewBikeButton";
            this.confirmNewBikeButton.Size = new System.Drawing.Size(338, 29);
            this.confirmNewBikeButton.TabIndex = 1;
            this.confirmNewBikeButton.Text = "Add";
            this.confirmNewBikeButton.UseVisualStyleBackColor = true;
            this.confirmNewBikeButton.Click += new System.EventHandler(this.confirmNewBikeButtonOnClick);
            // 
            // NewBikeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.confirmNewBikeButton);
            this.Controls.Add(this.bikeModelNameTextBox);
            this.Name = "NewBikeView";
            this.Size = new System.Drawing.Size(800, 426);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bikeModelNameTextBox;
        private System.Windows.Forms.Button confirmNewBikeButton;
    }
}
