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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appreciationLabelDescription = new System.Windows.Forms.Label();
            this.difficultyLabelDescription = new System.Windows.Forms.Label();
            this.validateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.utilityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.appreciationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.difficultyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appreciationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyNumericUpDown)).BeginInit();
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
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
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
            // utilityNumericUpDown
            // 
            this.utilityNumericUpDown.Location = new System.Drawing.Point(515, 19);
            this.utilityNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.utilityNumericUpDown.Name = "utilityNumericUpDown";
            this.utilityNumericUpDown.Size = new System.Drawing.Size(39, 20);
            this.utilityNumericUpDown.TabIndex = 11;
            // 
            // appreciationNumericUpDown
            // 
            this.appreciationNumericUpDown.Location = new System.Drawing.Point(515, 87);
            this.appreciationNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.appreciationNumericUpDown.Name = "appreciationNumericUpDown";
            this.appreciationNumericUpDown.Size = new System.Drawing.Size(39, 20);
            this.appreciationNumericUpDown.TabIndex = 12;
            // 
            // difficultyNumericUpDown
            // 
            this.difficultyNumericUpDown.Location = new System.Drawing.Point(515, 54);
            this.difficultyNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.difficultyNumericUpDown.Name = "difficultyNumericUpDown";
            this.difficultyNumericUpDown.Size = new System.Drawing.Size(39, 20);
            this.difficultyNumericUpDown.TabIndex = 13;
            // 
            // EvaluationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 155);
            this.Controls.Add(this.difficultyNumericUpDown);
            this.Controls.Add(this.appreciationNumericUpDown);
            this.Controls.Add(this.utilityNumericUpDown);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.difficultyLabelDescription);
            this.Controls.Add(this.appreciationLabelDescription);
            this.Controls.Add(this.utilityLabelDescription);
            this.Name = "EvaluationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Évaluation du cours";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appreciationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label utilityLabelDescription;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label appreciationLabelDescription;
        private System.Windows.Forms.Label difficultyLabelDescription;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown utilityNumericUpDown;
        private System.Windows.Forms.NumericUpDown appreciationNumericUpDown;
        private System.Windows.Forms.NumericUpDown difficultyNumericUpDown;
    }
}