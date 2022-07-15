namespace RandoCharacter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.generateButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.abilities = new System.Windows.Forms.Label();
            this.strengths = new System.Windows.Forms.Label();
            this.weaknesses = new System.Windows.Forms.Label();
            this.middleName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("generateButton.BackgroundImage")));
            this.generateButton.Location = new System.Drawing.Point(282, 176);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(241, 73);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate Character";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(87, 273);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Abilities:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Strengths:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(667, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Weaknesses:";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(87, 291);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(0, 13);
            this.firstName.TabIndex = 5;
            // 
            // abilities
            // 
            this.abilities.AutoSize = true;
            this.abilities.Location = new System.Drawing.Point(250, 291);
            this.abilities.Name = "abilities";
            this.abilities.Size = new System.Drawing.Size(0, 13);
            this.abilities.TabIndex = 6;
            // 
            // strengths
            // 
            this.strengths.AutoSize = true;
            this.strengths.Location = new System.Drawing.Point(462, 291);
            this.strengths.Name = "strengths";
            this.strengths.Size = new System.Drawing.Size(0, 13);
            this.strengths.TabIndex = 7;
            // 
            // weaknesses
            // 
            this.weaknesses.AutoSize = true;
            this.weaknesses.Location = new System.Drawing.Point(640, 291);
            this.weaknesses.Name = "weaknesses";
            this.weaknesses.Size = new System.Drawing.Size(0, 13);
            this.weaknesses.TabIndex = 8;
            // 
            // middleName
            // 
            this.middleName.AutoSize = true;
            this.middleName.Location = new System.Drawing.Point(87, 318);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(0, 13);
            this.middleName.TabIndex = 9;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(87, 345);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(0, 13);
            this.lastName.TabIndex = 10;
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.Location = new System.Drawing.Point(324, 401);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(0, 13);
            this.rating.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.weaknesses);
            this.Controls.Add(this.strengths);
            this.Controls.Add(this.abilities);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.generateButton);
            this.Name = "Form1";
            this.Text = "Random Character Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label abilities;
        private System.Windows.Forms.Label strengths;
        private System.Windows.Forms.Label weaknesses;
        private System.Windows.Forms.Label middleName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label rating;
    }
}

