namespace Yannick_CoursDeRecettes
{
    partial class EvaluationForm
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
            this.components = new System.ComponentModel.Container();
            this.utilityLabelDescription = new System.Windows.Forms.Label();
            this.utilityTextbox = new System.Windows.Forms.MaskedTextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appreciationLabelDescription = new System.Windows.Forms.Label();
            this.difficultyLabelDescription = new System.Windows.Forms.Label();
            this.validateButton = new System.Windows.Forms.Button();
            this.appreciationLabel = new System.Windows.Forms.MaskedTextBox();
            this.difficultyLabel = new System.Windows.Forms.MaskedTextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // utilityLabelDescription
            // 
            this.utilityLabelDescription.AutoSize = true;
            this.utilityLabelDescription.Location = new System.Drawing.Point(12, 19);
            this.utilityLabelDescription.Name = "utilityLabelDescription";
            this.utilityLabelDescription.Size = new System.Drawing.Size(467, 13);
            this.utilityLabelDescription.TabIndex = 0;
            this.utilityLabelDescription.Text = "Sur une note de 0 à 10, avez-vous trouvé ce cours utile, 0 étant pas du tout et 1" +
    "0 étant très utile?";
            // 
            // utilityTextbox
            // 
            this.utilityTextbox.Location = new System.Drawing.Point(517, 19);
            this.utilityTextbox.Name = "utilityTextbox";
            this.utilityTextbox.Size = new System.Drawing.Size(37, 20);
            this.utilityTextbox.TabIndex = 1;
            // 
            // appreciationLabelDescription
            // 
            this.appreciationLabelDescription.AutoSize = true;
            this.appreciationLabelDescription.Location = new System.Drawing.Point(12, 90);
            this.appreciationLabelDescription.Name = "appreciationLabelDescription";
            this.appreciationLabelDescription.Size = new System.Drawing.Size(501, 13);
            this.appreciationLabelDescription.TabIndex = 2;
            this.appreciationLabelDescription.Text = "Sur une note de 0 à 10, avez-vous apprécié ce cours, 0 étant pas du tout et 10 ét" +
    "ant vraiment apprécié?";
            // 
            // difficultyLabelDescription
            // 
            this.difficultyLabelDescription.AutoSize = true;
            this.difficultyLabelDescription.Location = new System.Drawing.Point(12, 56);
            this.difficultyLabelDescription.Name = "difficultyLabelDescription";
            this.difficultyLabelDescription.Size = new System.Drawing.Size(487, 13);
            this.difficultyLabelDescription.TabIndex = 4;
            this.difficultyLabelDescription.Text = "Sur une note de 0 à 10, quelle était la difficulté de ce cours, 0 étant très faci" +
    "le et 10 étant très difficile?";
            // 
            // validateButton
            // 
            this.validateButton.Location = new System.Drawing.Point(334, 113);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(101, 33);
            this.validateButton.TabIndex = 7;
            this.validateButton.Text = "Valider";
            this.validateButton.UseVisualStyleBackColor = true;
            // 
            // appreciationLabel
            // 
            this.appreciationLabel.Location = new System.Drawing.Point(517, 87);
            this.appreciationLabel.Name = "appreciationLabel";
            this.appreciationLabel.Size = new System.Drawing.Size(37, 20);
            this.appreciationLabel.TabIndex = 8;
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.Location = new System.Drawing.Point(517, 53);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(37, 20);
            this.difficultyLabel.TabIndex = 9;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(453, 113);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(101, 33);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EvaluationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 155);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.appreciationLabel);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.difficultyLabelDescription);
            this.Controls.Add(this.appreciationLabelDescription);
            this.Controls.Add(this.utilityTextbox);
            this.Controls.Add(this.utilityLabelDescription);
            this.Name = "EvaluationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Évaluation du cours";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label utilityLabelDescription;
        private System.Windows.Forms.MaskedTextBox utilityTextbox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label appreciationLabelDescription;
        private System.Windows.Forms.Label difficultyLabelDescription;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.MaskedTextBox appreciationLabel;
        private System.Windows.Forms.MaskedTextBox difficultyLabel;
        private System.Windows.Forms.Button cancelButton;
    }
}