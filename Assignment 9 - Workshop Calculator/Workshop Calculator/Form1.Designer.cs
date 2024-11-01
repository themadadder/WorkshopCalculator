namespace Workshop_Calculator
{
    partial class FormCalculator
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
            this.workshopLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.workshopList = new System.Windows.Forms.ListBox();
            this.locationList = new System.Windows.Forms.ListBox();
            this.registrationFeeLabel = new System.Windows.Forms.Label();
            this.lodgingFeeLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.registrationFeeOutputLabel = new System.Windows.Forms.Label();
            this.lodgingFeeOutputLabel = new System.Windows.Forms.Label();
            this.totalCostOutputLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.totalDaysLabel = new System.Windows.Forms.Label();
            this.totalDaysOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // workshopLabel
            // 
            this.workshopLabel.AutoSize = true;
            this.workshopLabel.Location = new System.Drawing.Point(14, 9);
            this.workshopLabel.Name = "workshopLabel";
            this.workshopLabel.Size = new System.Drawing.Size(112, 13);
            this.workshopLabel.TabIndex = 0;
            this.workshopLabel.Text = "Select your workshop:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(23, 80);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(103, 13);
            this.locationLabel.TabIndex = 1;
            this.locationLabel.Text = "Select your location:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(160, 284);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // workshopList
            // 
            this.workshopList.FormattingEnabled = true;
            this.workshopList.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotiation",
            "How to Interview"});
            this.workshopList.Location = new System.Drawing.Point(132, 9);
            this.workshopList.Name = "workshopList";
            this.workshopList.Size = new System.Drawing.Size(103, 69);
            this.workshopList.TabIndex = 1;
            this.workshopList.SelectedIndexChanged += new System.EventHandler(this.workshopList_SelectedIndexChanged);
            // 
            // locationList
            // 
            this.locationList.FormattingEnabled = true;
            this.locationList.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
            this.locationList.Location = new System.Drawing.Point(132, 80);
            this.locationList.Name = "locationList";
            this.locationList.Size = new System.Drawing.Size(103, 82);
            this.locationList.TabIndex = 2;
            // 
            // registrationFeeLabel
            // 
            this.registrationFeeLabel.AutoSize = true;
            this.registrationFeeLabel.Location = new System.Drawing.Point(4, 205);
            this.registrationFeeLabel.Name = "registrationFeeLabel";
            this.registrationFeeLabel.Size = new System.Drawing.Size(122, 13);
            this.registrationFeeLabel.TabIndex = 5;
            this.registrationFeeLabel.Text = "Your Registration Fee is:";
            // 
            // lodgingFeeLabel
            // 
            this.lodgingFeeLabel.AutoSize = true;
            this.lodgingFeeLabel.Location = new System.Drawing.Point(22, 234);
            this.lodgingFeeLabel.Name = "lodgingFeeLabel";
            this.lodgingFeeLabel.Size = new System.Drawing.Size(104, 13);
            this.lodgingFeeLabel.TabIndex = 6;
            this.lodgingFeeLabel.Text = "Your Lodging Fee is:";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(33, 263);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(93, 13);
            this.totalCostLabel.TabIndex = 7;
            this.totalCostLabel.Text = "Your Total Cost is:";
            // 
            // registrationFeeOutputLabel
            // 
            this.registrationFeeOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registrationFeeOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationFeeOutputLabel.Location = new System.Drawing.Point(132, 201);
            this.registrationFeeOutputLabel.Name = "registrationFeeOutputLabel";
            this.registrationFeeOutputLabel.Size = new System.Drawing.Size(103, 20);
            this.registrationFeeOutputLabel.TabIndex = 8;
            this.registrationFeeOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lodgingFeeOutputLabel
            // 
            this.lodgingFeeOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lodgingFeeOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lodgingFeeOutputLabel.Location = new System.Drawing.Point(132, 230);
            this.lodgingFeeOutputLabel.Name = "lodgingFeeOutputLabel";
            this.lodgingFeeOutputLabel.Size = new System.Drawing.Size(103, 20);
            this.lodgingFeeOutputLabel.TabIndex = 9;
            this.lodgingFeeOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCostOutputLabel
            // 
            this.totalCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostOutputLabel.Location = new System.Drawing.Point(132, 259);
            this.totalCostOutputLabel.Name = "totalCostOutputLabel";
            this.totalCostOutputLabel.Size = new System.Drawing.Size(103, 20);
            this.totalCostOutputLabel.TabIndex = 10;
            this.totalCostOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(12, 284);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 11;
            this.confirmButton.Text = "Calculate!";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // totalDaysLabel
            // 
            this.totalDaysLabel.AutoSize = true;
            this.totalDaysLabel.Location = new System.Drawing.Point(1, 176);
            this.totalDaysLabel.Name = "totalDaysLabel";
            this.totalDaysLabel.Size = new System.Drawing.Size(125, 13);
            this.totalDaysLabel.TabIndex = 12;
            this.totalDaysLabel.Text = "Total Days of Workshop:";
            // 
            // totalDaysOutputLabel
            // 
            this.totalDaysOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalDaysOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDaysOutputLabel.Location = new System.Drawing.Point(132, 172);
            this.totalDaysOutputLabel.Name = "totalDaysOutputLabel";
            this.totalDaysOutputLabel.Size = new System.Drawing.Size(103, 20);
            this.totalDaysOutputLabel.TabIndex = 13;
            this.totalDaysOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 319);
            this.Controls.Add(this.totalDaysOutputLabel);
            this.Controls.Add(this.totalDaysLabel);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.totalCostOutputLabel);
            this.Controls.Add(this.lodgingFeeOutputLabel);
            this.Controls.Add(this.registrationFeeOutputLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.lodgingFeeLabel);
            this.Controls.Add(this.registrationFeeLabel);
            this.Controls.Add(this.locationList);
            this.Controls.Add(this.workshopList);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.workshopLabel);
            this.Name = "FormCalculator";
            this.Text = "Workshop Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workshopLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox workshopList;
        private System.Windows.Forms.ListBox locationList;
        private System.Windows.Forms.Label registrationFeeLabel;
        private System.Windows.Forms.Label lodgingFeeLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label registrationFeeOutputLabel;
        private System.Windows.Forms.Label lodgingFeeOutputLabel;
        private System.Windows.Forms.Label totalCostOutputLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label totalDaysLabel;
        private System.Windows.Forms.Label totalDaysOutputLabel;
    }
}

