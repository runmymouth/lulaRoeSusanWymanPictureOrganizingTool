namespace WindowsFormsApplication1
{
    partial class MainView
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
            this.buildFolderButton = new System.Windows.Forms.Button();
            this.runStatusLabel = new System.Windows.Forms.Label();
            this.cancelBuild = new System.Windows.Forms.Button();
            this.addAlbumCovers = new System.Windows.Forms.CheckBox();
            this.addSizeCards = new System.Windows.Forms.CheckBox();
            this.SizesToLookFor = new System.Windows.Forms.TextBox();
            this.SizesToLookForLabel = new System.Windows.Forms.Label();
            this.AlbumCoverLocationLabel = new System.Windows.Forms.Label();
            this.AlbumCoverLocation = new System.Windows.Forms.TextBox();
            this.AlbumSizeCardsLocationLabel = new System.Windows.Forms.Label();
            this.AlbumSizeCardsLocation = new System.Windows.Forms.TextBox();
            this.pictureAlbumLocationLabel = new System.Windows.Forms.Label();
            this.pictureAlbumLocation = new System.Windows.Forms.TextBox();
            this.StyleNamesToLookForLabel = new System.Windows.Forms.Label();
            this.StyleNamesToLookFor = new System.Windows.Forms.TextBox();
            this.outputLocationLabel = new System.Windows.Forms.Label();
            this.outputLocation = new System.Windows.Forms.TextBox();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.exclusionPatternsLabel = new System.Windows.Forms.Label();
            this.exclusionPatterns = new System.Windows.Forms.TextBox();
            this.statusLabelDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buildFolderButton
            // 
            this.buildFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildFolderButton.Location = new System.Drawing.Point(17, 533);
            this.buildFolderButton.Name = "buildFolderButton";
            this.buildFolderButton.Size = new System.Drawing.Size(107, 29);
            this.buildFolderButton.TabIndex = 0;
            this.buildFolderButton.Text = "Start";
            this.buildFolderButton.UseVisualStyleBackColor = true;
            this.buildFolderButton.Click += new System.EventHandler(this.buildFolderButton_Click);
            // 
            // runStatusLabel
            // 
            this.runStatusLabel.AutoSize = true;
            this.runStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runStatusLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.runStatusLabel.Location = new System.Drawing.Point(117, 503);
            this.runStatusLabel.Name = "runStatusLabel";
            this.runStatusLabel.Size = new System.Drawing.Size(104, 20);
            this.runStatusLabel.TabIndex = 1;
            this.runStatusLabel.Text = "Ready to run.";
            // 
            // cancelBuild
            // 
            this.cancelBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBuild.Location = new System.Drawing.Point(130, 533);
            this.cancelBuild.Name = "cancelBuild";
            this.cancelBuild.Size = new System.Drawing.Size(122, 29);
            this.cancelBuild.TabIndex = 2;
            this.cancelBuild.Text = "Stop";
            this.cancelBuild.UseVisualStyleBackColor = true;
            this.cancelBuild.Click += new System.EventHandler(this.cancelBuild_Click);
            // 
            // addAlbumCovers
            // 
            this.addAlbumCovers.AutoSize = true;
            this.addAlbumCovers.Checked = true;
            this.addAlbumCovers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addAlbumCovers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAlbumCovers.Location = new System.Drawing.Point(12, 12);
            this.addAlbumCovers.Name = "addAlbumCovers";
            this.addAlbumCovers.Size = new System.Drawing.Size(159, 24);
            this.addAlbumCovers.TabIndex = 3;
            this.addAlbumCovers.Text = "Add Album Covers";
            this.addAlbumCovers.UseVisualStyleBackColor = true;
            // 
            // addSizeCards
            // 
            this.addSizeCards.AutoSize = true;
            this.addSizeCards.Checked = true;
            this.addSizeCards.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addSizeCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSizeCards.Location = new System.Drawing.Point(12, 41);
            this.addSizeCards.Name = "addSizeCards";
            this.addSizeCards.Size = new System.Drawing.Size(138, 24);
            this.addSizeCards.TabIndex = 4;
            this.addSizeCards.Text = "Add Size Cards";
            this.addSizeCards.UseVisualStyleBackColor = true;
            // 
            // SizesToLookFor
            // 
            this.SizesToLookFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizesToLookFor.Location = new System.Drawing.Point(11, 98);
            this.SizesToLookFor.Name = "SizesToLookFor";
            this.SizesToLookFor.Size = new System.Drawing.Size(480, 26);
            this.SizesToLookFor.TabIndex = 5;
            this.SizesToLookFor.Text = "2,3,4,5,6,7,8,9,10,11,12,13,14,xxs,xs,s,m,l,xl,xxl,xxxl";
            // 
            // SizesToLookForLabel
            // 
            this.SizesToLookForLabel.AutoSize = true;
            this.SizesToLookForLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizesToLookForLabel.Location = new System.Drawing.Point(13, 75);
            this.SizesToLookForLabel.Name = "SizesToLookForLabel";
            this.SizesToLookForLabel.Size = new System.Drawing.Size(137, 20);
            this.SizesToLookForLabel.TabIndex = 6;
            this.SizesToLookForLabel.Text = "Sizes To Look For";
            // 
            // AlbumCoverLocationLabel
            // 
            this.AlbumCoverLocationLabel.AutoSize = true;
            this.AlbumCoverLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumCoverLocationLabel.Location = new System.Drawing.Point(13, 129);
            this.AlbumCoverLocationLabel.Name = "AlbumCoverLocationLabel";
            this.AlbumCoverLocationLabel.Size = new System.Drawing.Size(159, 20);
            this.AlbumCoverLocationLabel.TabIndex = 8;
            this.AlbumCoverLocationLabel.Text = "Album cover location:";
            // 
            // AlbumCoverLocation
            // 
            this.AlbumCoverLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumCoverLocation.Location = new System.Drawing.Point(12, 152);
            this.AlbumCoverLocation.Name = "AlbumCoverLocation";
            this.AlbumCoverLocation.Size = new System.Drawing.Size(480, 26);
            this.AlbumCoverLocation.TabIndex = 7;
            this.AlbumCoverLocation.Text = "C:\\LLR\\albumCovers";
            // 
            // AlbumSizeCardsLocationLabel
            // 
            this.AlbumSizeCardsLocationLabel.AutoSize = true;
            this.AlbumSizeCardsLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumSizeCardsLocationLabel.Location = new System.Drawing.Point(13, 190);
            this.AlbumSizeCardsLocationLabel.Name = "AlbumSizeCardsLocationLabel";
            this.AlbumSizeCardsLocationLabel.Size = new System.Drawing.Size(204, 20);
            this.AlbumSizeCardsLocationLabel.TabIndex = 10;
            this.AlbumSizeCardsLocationLabel.Text = "Album Size Cards Location:";
            // 
            // AlbumSizeCardsLocation
            // 
            this.AlbumSizeCardsLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumSizeCardsLocation.Location = new System.Drawing.Point(12, 212);
            this.AlbumSizeCardsLocation.Name = "AlbumSizeCardsLocation";
            this.AlbumSizeCardsLocation.Size = new System.Drawing.Size(480, 26);
            this.AlbumSizeCardsLocation.TabIndex = 9;
            this.AlbumSizeCardsLocation.Text = "C:\\LLR\\sizeCards";
            // 
            // pictureAlbumLocationLabel
            // 
            this.pictureAlbumLocationLabel.AutoSize = true;
            this.pictureAlbumLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureAlbumLocationLabel.Location = new System.Drawing.Point(13, 248);
            this.pictureAlbumLocationLabel.Name = "pictureAlbumLocationLabel";
            this.pictureAlbumLocationLabel.Size = new System.Drawing.Size(184, 20);
            this.pictureAlbumLocationLabel.TabIndex = 12;
            this.pictureAlbumLocationLabel.Text = "Picture Albums Location:";
            // 
            // pictureAlbumLocation
            // 
            this.pictureAlbumLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureAlbumLocation.Location = new System.Drawing.Point(12, 271);
            this.pictureAlbumLocation.Name = "pictureAlbumLocation";
            this.pictureAlbumLocation.Size = new System.Drawing.Size(480, 26);
            this.pictureAlbumLocation.TabIndex = 11;
            this.pictureAlbumLocation.Text = "C:\\LLR\\Inventory";
            // 
            // StyleNamesToLookForLabel
            // 
            this.StyleNamesToLookForLabel.AutoSize = true;
            this.StyleNamesToLookForLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StyleNamesToLookForLabel.Location = new System.Drawing.Point(13, 310);
            this.StyleNamesToLookForLabel.Name = "StyleNamesToLookForLabel";
            this.StyleNamesToLookForLabel.Size = new System.Drawing.Size(183, 20);
            this.StyleNamesToLookForLabel.TabIndex = 14;
            this.StyleNamesToLookForLabel.Text = "Style Names to Look For";
            // 
            // StyleNamesToLookFor
            // 
            this.StyleNamesToLookFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StyleNamesToLookFor.Location = new System.Drawing.Point(12, 333);
            this.StyleNamesToLookFor.Name = "StyleNamesToLookFor";
            this.StyleNamesToLookFor.Size = new System.Drawing.Size(480, 26);
            this.StyleNamesToLookFor.TabIndex = 13;
            this.StyleNamesToLookFor.Text = "amelia,dds";
            // 
            // outputLocationLabel
            // 
            this.outputLocationLabel.AutoSize = true;
            this.outputLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLocationLabel.Location = new System.Drawing.Point(13, 371);
            this.outputLocationLabel.Name = "outputLocationLabel";
            this.outputLocationLabel.Size = new System.Drawing.Size(127, 20);
            this.outputLocationLabel.TabIndex = 16;
            this.outputLocationLabel.Text = "Output Location:";
            // 
            // outputLocation
            // 
            this.outputLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLocation.Location = new System.Drawing.Point(12, 394);
            this.outputLocation.Name = "outputLocation";
            this.outputLocation.Size = new System.Drawing.Size(480, 26);
            this.outputLocation.TabIndex = 15;
            this.outputLocation.Text = "c:\\LLR\\picturesOutput";
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSettingsButton.Location = new System.Drawing.Point(258, 533);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(133, 29);
            this.saveSettingsButton.TabIndex = 17;
            this.saveSettingsButton.Text = "Save Settings";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // exclusionPatternsLabel
            // 
            this.exclusionPatternsLabel.AutoSize = true;
            this.exclusionPatternsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exclusionPatternsLabel.Location = new System.Drawing.Point(13, 432);
            this.exclusionPatternsLabel.Name = "exclusionPatternsLabel";
            this.exclusionPatternsLabel.Size = new System.Drawing.Size(144, 20);
            this.exclusionPatternsLabel.TabIndex = 19;
            this.exclusionPatternsLabel.Text = "Exclusion Patterns:";
            // 
            // exclusionPatterns
            // 
            this.exclusionPatterns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exclusionPatterns.Location = new System.Drawing.Point(12, 455);
            this.exclusionPatterns.Name = "exclusionPatterns";
            this.exclusionPatterns.Size = new System.Drawing.Size(480, 26);
            this.exclusionPatterns.TabIndex = 18;
            this.exclusionPatterns.Text = "_ignore,_forget";
            // 
            // statusLabelDescription
            // 
            this.statusLabelDescription.AutoSize = true;
            this.statusLabelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabelDescription.ForeColor = System.Drawing.Color.Red;
            this.statusLabelDescription.Location = new System.Drawing.Point(17, 503);
            this.statusLabelDescription.Name = "statusLabelDescription";
            this.statusLabelDescription.Size = new System.Drawing.Size(94, 20);
            this.statusLabelDescription.TabIndex = 20;
            this.statusLabelDescription.Text = "Run Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 577);
            this.Controls.Add(this.statusLabelDescription);
            this.Controls.Add(this.exclusionPatternsLabel);
            this.Controls.Add(this.exclusionPatterns);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.outputLocationLabel);
            this.Controls.Add(this.outputLocation);
            this.Controls.Add(this.StyleNamesToLookForLabel);
            this.Controls.Add(this.StyleNamesToLookFor);
            this.Controls.Add(this.pictureAlbumLocationLabel);
            this.Controls.Add(this.pictureAlbumLocation);
            this.Controls.Add(this.AlbumSizeCardsLocationLabel);
            this.Controls.Add(this.AlbumSizeCardsLocation);
            this.Controls.Add(this.AlbumCoverLocationLabel);
            this.Controls.Add(this.AlbumCoverLocation);
            this.Controls.Add(this.SizesToLookForLabel);
            this.Controls.Add(this.SizesToLookFor);
            this.Controls.Add(this.addSizeCards);
            this.Controls.Add(this.addAlbumCovers);
            this.Controls.Add(this.cancelBuild);
            this.Controls.Add(this.runStatusLabel);
            this.Controls.Add(this.buildFolderButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buildFolderButton;
        private System.Windows.Forms.Label runStatusLabel;
        private System.Windows.Forms.Button cancelBuild;
        private System.Windows.Forms.CheckBox addAlbumCovers;
        private System.Windows.Forms.CheckBox addSizeCards;
        private System.Windows.Forms.TextBox SizesToLookFor;
        private System.Windows.Forms.Label SizesToLookForLabel;
        private System.Windows.Forms.Label AlbumCoverLocationLabel;
        private System.Windows.Forms.TextBox AlbumCoverLocation;
        private System.Windows.Forms.Label AlbumSizeCardsLocationLabel;
        private System.Windows.Forms.TextBox AlbumSizeCardsLocation;
        private System.Windows.Forms.Label pictureAlbumLocationLabel;
        private System.Windows.Forms.TextBox pictureAlbumLocation;
        private System.Windows.Forms.Label StyleNamesToLookForLabel;
        private System.Windows.Forms.TextBox StyleNamesToLookFor;
        private System.Windows.Forms.Label outputLocationLabel;
        private System.Windows.Forms.TextBox outputLocation;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.Label exclusionPatternsLabel;
        private System.Windows.Forms.TextBox exclusionPatterns;
        private System.Windows.Forms.Label statusLabelDescription;
    }
}

