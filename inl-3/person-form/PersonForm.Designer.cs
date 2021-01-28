namespace person_form
{
    partial class PersonForm
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
            this.sendButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.informationLabel = new System.Windows.Forms.Label();
            this.identityNumberLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.identityNumberBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(110, 190);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Skicka";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(110, 246);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 21);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Avbryt";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // informationLabel
            // 
            this.informationLabel.Location = new System.Drawing.Point(49, 35);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(181, 43);
            this.informationLabel.TabIndex = 1;
            this.informationLabel.Text = "Vänligen fyll i namn, efternamn och personnummer i formuläret nedan";
            // 
            // identityNumberLabel
            // 
            this.identityNumberLabel.AutoSize = true;
            this.identityNumberLabel.Location = new System.Drawing.Point(15, 153);
            this.identityNumberLabel.Name = "identityNumberLabel";
            this.identityNumberLabel.Size = new System.Drawing.Size(89, 15);
            this.identityNumberLabel.TabIndex = 1;
            this.identityNumberLabel.Text = "Personnummer";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(42, 124);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(62, 15);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Efternamn";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(49, 95);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(55, 15);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "Förnamn";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(250, 35);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(232, 193);
            this.resultBox.TabIndex = 2;
            // 
            // identityNumberBox
            // 
            this.identityNumberBox.Location = new System.Drawing.Point(110, 150);
            this.identityNumberBox.Name = "identityNumberBox";
            this.identityNumberBox.Size = new System.Drawing.Size(100, 23);
            this.identityNumberBox.TabIndex = 2;
            this.identityNumberBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.identityNumberBox_KeyDown);
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(110, 121);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(100, 23);
            this.lastNameBox.TabIndex = 2;
            this.lastNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lastNameBox_KeyDown);
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(110, 92);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(100, 23);
            this.firstNameBox.TabIndex = 2;
            this.firstNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firstNameBox_KeyDown);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(110, 219);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 21);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "Rensa";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 284);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.identityNumberBox);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.identityNumberLabel);
            this.Controls.Add(this.informationLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sendButton);
            this.Name = "PersonForm";
            this.Text = "PersonForm";
            this.Load += new System.EventHandler(this.PersonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.Label identityNumberLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox identityNumberBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Button clearButton;
    }
}

