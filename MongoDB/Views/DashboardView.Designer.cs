namespace MongoDB.Views {
    partial class DashboardView {
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
            this.bikePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addBikeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bikePanel
            // 
            this.bikePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bikePanel.Location = new System.Drawing.Point(0, 48);
            this.bikePanel.Name = "bikePanel";
            this.bikePanel.Size = new System.Drawing.Size(800, 378);
            this.bikePanel.TabIndex = 0;
            // 
            // addBikeButton
            // 
            this.addBikeButton.Location = new System.Drawing.Point(3, 3);
            this.addBikeButton.Name = "addBikeButton";
            this.addBikeButton.Size = new System.Drawing.Size(121, 39);
            this.addBikeButton.TabIndex = 0;
            this.addBikeButton.Text = "Add Bike";
            this.addBikeButton.UseVisualStyleBackColor = true;
            this.addBikeButton.Click += new System.EventHandler(this.addBikeButtonOnClick);
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addBikeButton);
            this.Controls.Add(this.bikePanel);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(800, 426);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel bikePanel;
        private System.Windows.Forms.Button addBikeButton;
    }
}
