namespace Yannick_CoursDeRecettes
{
    partial class CourseForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.courseNumberTextbox = new System.Windows.Forms.TextBox();
            this.courseNumberLabel = new System.Windows.Forms.Label();
            this.courseTypeDescriptionLabel = new System.Windows.Forms.Label();
            this.courseTypeLabel = new System.Windows.Forms.Label();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.registrationCostDescriptionLabel = new System.Windows.Forms.Label();
            this.registrationCostLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.commentsDescriptionLabel = new System.Windows.Forms.Label();
            this.difficultyLevelLabel = new System.Windows.Forms.Label();
            this.difficultyLevelDescriptionLabel = new System.Windows.Forms.Label();
            this.durationDescriptionLabel = new System.Windows.Forms.Label();
            this.courseNameDescriptionLabel = new System.Windows.Forms.Label();
            this.commentsListBox = new System.Windows.Forms.ListBox();
            this.moreInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionListBox = new System.Windows.Forms.ListBox();
            this.moreInformationDescriptionLabel = new System.Windows.Forms.Label();
            this.prerequisitesLabel = new System.Windows.Forms.Label();
            this.prerequisitiesDescriptionLabel = new System.Windows.Forms.Label();
            this.addEvaluationButton = new System.Windows.Forms.Button();
            this.courseInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.searchCourseButton = new System.Windows.Forms.Button();
            this.technicalNameLabel = new System.Windows.Forms.Label();
            this.technicalNameDescriptionLabel = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.moreInformationGroupBox.SuspendLayout();
            this.courseInformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // courseNumberTextbox
            // 
            this.courseNumberTextbox.Location = new System.Drawing.Point(82, 13);
            this.courseNumberTextbox.Name = "courseNumberTextbox";
            this.courseNumberTextbox.Size = new System.Drawing.Size(100, 20);
            this.courseNumberTextbox.TabIndex = 0;
            // 
            // courseNumberLabel
            // 
            this.courseNumberLabel.AutoSize = true;
            this.courseNumberLabel.Location = new System.Drawing.Point(16, 16);
            this.courseNumberLabel.Name = "courseNumberLabel";
            this.courseNumberLabel.Size = new System.Drawing.Size(57, 13);
            this.courseNumberLabel.TabIndex = 1;
            this.courseNumberLabel.Text = "No Cours :";
            // 
            // courseTypeDescriptionLabel
            // 
            this.courseTypeDescriptionLabel.AutoSize = true;
            this.courseTypeDescriptionLabel.Location = new System.Drawing.Point(4, 52);
            this.courseTypeDescriptionLabel.Name = "courseTypeDescriptionLabel";
            this.courseTypeDescriptionLabel.Size = new System.Drawing.Size(81, 13);
            this.courseTypeDescriptionLabel.TabIndex = 2;
            this.courseTypeDescriptionLabel.Text = "Type de cours :";
            // 
            // courseTypeLabel
            // 
            this.courseTypeLabel.AutoSize = true;
            this.courseTypeLabel.Location = new System.Drawing.Point(97, 52);
            this.courseTypeLabel.Name = "courseTypeLabel";
            this.courseTypeLabel.Size = new System.Drawing.Size(70, 13);
            this.courseTypeLabel.TabIndex = 3;
            this.courseTypeLabel.Text = "[TypeCourse]";
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "CourseName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.courseNameLabel.Location = new System.Drawing.Point(97, 28);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(74, 13);
            this.courseNameLabel.TabIndex = 4;
            this.courseNameLabel.Text = "[CourseName]";
            // 
            // registrationCostDescriptionLabel
            // 
            this.registrationCostDescriptionLabel.AutoSize = true;
            this.registrationCostDescriptionLabel.Location = new System.Drawing.Point(4, 80);
            this.registrationCostDescriptionLabel.Name = "registrationCostDescriptionLabel";
            this.registrationCostDescriptionLabel.Size = new System.Drawing.Size(93, 13);
            this.registrationCostDescriptionLabel.TabIndex = 5;
            this.registrationCostDescriptionLabel.Text = "Coût d\'inscription :";
            // 
            // registrationCostLabel
            // 
            this.registrationCostLabel.AutoSize = true;
            this.registrationCostLabel.Location = new System.Drawing.Point(97, 80);
            this.registrationCostLabel.Name = "registrationCostLabel";
            this.registrationCostLabel.Size = new System.Drawing.Size(34, 13);
            this.registrationCostLabel.TabIndex = 6;
            this.registrationCostLabel.Text = "[Cost]";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(97, 104);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(86, 13);
            this.durationLabel.TabIndex = 7;
            this.durationLabel.Text = "[CourseDuration]";
            // 
            // commentsDescriptionLabel
            // 
            this.commentsDescriptionLabel.AutoSize = true;
            this.commentsDescriptionLabel.Location = new System.Drawing.Point(229, 52);
            this.commentsDescriptionLabel.Name = "commentsDescriptionLabel";
            this.commentsDescriptionLabel.Size = new System.Drawing.Size(79, 13);
            this.commentsDescriptionLabel.TabIndex = 8;
            this.commentsDescriptionLabel.Text = "Commentaires :";
            // 
            // difficultyLevelLabel
            // 
            this.difficultyLevelLabel.AutoSize = true;
            this.difficultyLevelLabel.Location = new System.Drawing.Point(339, 28);
            this.difficultyLevelLabel.Name = "difficultyLevelLabel";
            this.difficultyLevelLabel.Size = new System.Drawing.Size(79, 13);
            this.difficultyLevelLabel.TabIndex = 9;
            this.difficultyLevelLabel.Text = "[DifficultyLevel]";
            // 
            // difficultyLevelDescriptionLabel
            // 
            this.difficultyLevelDescriptionLabel.AutoSize = true;
            this.difficultyLevelDescriptionLabel.Location = new System.Drawing.Point(229, 28);
            this.difficultyLevelDescriptionLabel.Name = "difficultyLevelDescriptionLabel";
            this.difficultyLevelDescriptionLabel.Size = new System.Drawing.Size(104, 13);
            this.difficultyLevelDescriptionLabel.TabIndex = 10;
            this.difficultyLevelDescriptionLabel.Text = "Niveau de difficulté :";
            // 
            // durationDescriptionLabel
            // 
            this.durationDescriptionLabel.AutoSize = true;
            this.durationDescriptionLabel.Location = new System.Drawing.Point(5, 104);
            this.durationDescriptionLabel.Name = "durationDescriptionLabel";
            this.durationDescriptionLabel.Size = new System.Drawing.Size(42, 13);
            this.durationDescriptionLabel.TabIndex = 11;
            this.durationDescriptionLabel.Text = "Durée :";
            // 
            // courseNameDescriptionLabel
            // 
            this.courseNameDescriptionLabel.AutoSize = true;
            this.courseNameDescriptionLabel.Location = new System.Drawing.Point(4, 28);
            this.courseNameDescriptionLabel.Name = "courseNameDescriptionLabel";
            this.courseNameDescriptionLabel.Size = new System.Drawing.Size(79, 13);
            this.courseNameDescriptionLabel.TabIndex = 12;
            this.courseNameDescriptionLabel.Text = "Nom du cours :";
            // 
            // commentsListBox
            // 
            this.commentsListBox.FormattingEnabled = true;
            this.commentsListBox.HorizontalScrollbar = true;
            this.commentsListBox.Location = new System.Drawing.Point(321, 52);
            this.commentsListBox.Name = "commentsListBox";
            this.commentsListBox.Size = new System.Drawing.Size(216, 69);
            this.commentsListBox.TabIndex = 13;
            // 
            // moreInformationGroupBox
            // 
            this.moreInformationGroupBox.Controls.Add(this.technicalNameLabel);
            this.moreInformationGroupBox.Controls.Add(this.technicalNameDescriptionLabel);
            this.moreInformationGroupBox.Controls.Add(this.descriptionListBox);
            this.moreInformationGroupBox.Controls.Add(this.moreInformationDescriptionLabel);
            this.moreInformationGroupBox.Controls.Add(this.prerequisitesLabel);
            this.moreInformationGroupBox.Controls.Add(this.prerequisitiesDescriptionLabel);
            this.moreInformationGroupBox.Location = new System.Drawing.Point(15, 179);
            this.moreInformationGroupBox.Name = "moreInformationGroupBox";
            this.moreInformationGroupBox.Size = new System.Drawing.Size(540, 92);
            this.moreInformationGroupBox.TabIndex = 15;
            this.moreInformationGroupBox.TabStop = false;
            this.moreInformationGroupBox.Text = "Infos supplémentaires";
            // 
            // descriptionListBox
            // 
            this.descriptionListBox.FormattingEnabled = true;
            this.descriptionListBox.HorizontalScrollbar = true;
            this.descriptionListBox.Location = new System.Drawing.Point(318, 40);
            this.descriptionListBox.Name = "descriptionListBox";
            this.descriptionListBox.Size = new System.Drawing.Size(216, 43);
            this.descriptionListBox.TabIndex = 16;
            // 
            // moreInformationDescriptionLabel
            // 
            this.moreInformationDescriptionLabel.AutoSize = true;
            this.moreInformationDescriptionLabel.Location = new System.Drawing.Point(315, 24);
            this.moreInformationDescriptionLabel.Name = "moreInformationDescriptionLabel";
            this.moreInformationDescriptionLabel.Size = new System.Drawing.Size(113, 13);
            this.moreInformationDescriptionLabel.TabIndex = 15;
            this.moreInformationDescriptionLabel.Text = "Description technique:";
            // 
            // prerequisitesLabel
            // 
            this.prerequisitesLabel.AutoSize = true;
            this.prerequisitesLabel.Location = new System.Drawing.Point(65, 27);
            this.prerequisitesLabel.Name = "prerequisitesLabel";
            this.prerequisitesLabel.Size = new System.Drawing.Size(103, 13);
            this.prerequisitesLabel.TabIndex = 13;
            this.prerequisitesLabel.Text = "[prerequisitesOrTitle]";
            // 
            // prerequisitiesDescriptionLabel
            // 
            this.prerequisitiesDescriptionLabel.AutoSize = true;
            this.prerequisitiesDescriptionLabel.Location = new System.Drawing.Point(6, 27);
            this.prerequisitiesDescriptionLabel.Name = "prerequisitiesDescriptionLabel";
            this.prerequisitiesDescriptionLabel.Size = new System.Drawing.Size(57, 13);
            this.prerequisitiesDescriptionLabel.TabIndex = 12;
            this.prerequisitiesDescriptionLabel.Text = "Prérequis :";
            // 
            // addEvaluationButton
            // 
            this.addEvaluationButton.Location = new System.Drawing.Point(15, 277);
            this.addEvaluationButton.Name = "addEvaluationButton";
            this.addEvaluationButton.Size = new System.Drawing.Size(128, 51);
            this.addEvaluationButton.TabIndex = 16;
            this.addEvaluationButton.Text = "Ajouter une évaluation";
            this.addEvaluationButton.UseVisualStyleBackColor = true;
            this.addEvaluationButton.Click += new System.EventHandler(this.addEvaluationButton_Click);
            // 
            // courseInformationGroupBox
            // 
            this.courseInformationGroupBox.Controls.Add(this.commentsListBox);
            this.courseInformationGroupBox.Controls.Add(this.courseTypeDescriptionLabel);
            this.courseInformationGroupBox.Controls.Add(this.courseTypeLabel);
            this.courseInformationGroupBox.Controls.Add(this.courseNameLabel);
            this.courseInformationGroupBox.Controls.Add(this.durationDescriptionLabel);
            this.courseInformationGroupBox.Controls.Add(this.registrationCostDescriptionLabel);
            this.courseInformationGroupBox.Controls.Add(this.durationLabel);
            this.courseInformationGroupBox.Controls.Add(this.courseNameDescriptionLabel);
            this.courseInformationGroupBox.Controls.Add(this.registrationCostLabel);
            this.courseInformationGroupBox.Controls.Add(this.commentsDescriptionLabel);
            this.courseInformationGroupBox.Controls.Add(this.difficultyLevelDescriptionLabel);
            this.courseInformationGroupBox.Controls.Add(this.difficultyLevelLabel);
            this.courseInformationGroupBox.Location = new System.Drawing.Point(12, 39);
            this.courseInformationGroupBox.Name = "courseInformationGroupBox";
            this.courseInformationGroupBox.Size = new System.Drawing.Size(543, 134);
            this.courseInformationGroupBox.TabIndex = 17;
            this.courseInformationGroupBox.TabStop = false;
            this.courseInformationGroupBox.Text = "Informations sur le cours";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(427, 277);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(128, 51);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "Fermer";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // searchCourseButton
            // 
            this.searchCourseButton.Location = new System.Drawing.Point(193, 9);
            this.searchCourseButton.Name = "searchCourseButton";
            this.searchCourseButton.Size = new System.Drawing.Size(128, 26);
            this.searchCourseButton.TabIndex = 19;
            this.searchCourseButton.Text = "Rechercher";
            this.searchCourseButton.UseVisualStyleBackColor = true;
            this.searchCourseButton.Click += new System.EventHandler(this.searchCourseButton_Click);
            // 
            // technicalNameLabel
            // 
            this.technicalNameLabel.AutoSize = true;
            this.technicalNameLabel.Location = new System.Drawing.Point(88, 52);
            this.technicalNameLabel.Name = "technicalNameLabel";
            this.technicalNameLabel.Size = new System.Drawing.Size(84, 13);
            this.technicalNameLabel.TabIndex = 18;
            this.technicalNameLabel.Text = "[technicalName]";
            // 
            // technicalNameDescriptionLabel
            // 
            this.technicalNameDescriptionLabel.AutoSize = true;
            this.technicalNameDescriptionLabel.Location = new System.Drawing.Point(6, 52);
            this.technicalNameDescriptionLabel.Name = "technicalNameDescriptionLabel";
            this.technicalNameDescriptionLabel.Size = new System.Drawing.Size(85, 13);
            this.technicalNameDescriptionLabel.TabIndex = 17;
            this.technicalNameDescriptionLabel.Text = "Nom technique :";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Yannick_CoursDeRecettes.Course);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 342);
            this.Controls.Add(this.searchCourseButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.courseInformationGroupBox);
            this.Controls.Add(this.addEvaluationButton);
            this.Controls.Add(this.moreInformationGroupBox);
            this.Controls.Add(this.courseNumberLabel);
            this.Controls.Add(this.courseNumberTextbox);
            this.Name = "CourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechercher un cours";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.moreInformationGroupBox.ResumeLayout(false);
            this.moreInformationGroupBox.PerformLayout();
            this.courseInformationGroupBox.ResumeLayout(false);
            this.courseInformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox courseNumberTextbox;
        private System.Windows.Forms.Label courseNumberLabel;
        private System.Windows.Forms.Label courseTypeDescriptionLabel;
        private System.Windows.Forms.Label courseTypeLabel;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label registrationCostDescriptionLabel;
        private System.Windows.Forms.Label registrationCostLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label commentsDescriptionLabel;
        private System.Windows.Forms.Label difficultyLevelLabel;
        private System.Windows.Forms.Label difficultyLevelDescriptionLabel;
        private System.Windows.Forms.Label durationDescriptionLabel;
        private System.Windows.Forms.Label courseNameDescriptionLabel;
        private System.Windows.Forms.ListBox commentsListBox;
        private System.Windows.Forms.GroupBox moreInformationGroupBox;
        private System.Windows.Forms.ListBox descriptionListBox;
        private System.Windows.Forms.Label moreInformationDescriptionLabel;
        private System.Windows.Forms.Label prerequisitesLabel;
        private System.Windows.Forms.Label prerequisitiesDescriptionLabel;
        private System.Windows.Forms.Button addEvaluationButton;
        private System.Windows.Forms.GroupBox courseInformationGroupBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button searchCourseButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label technicalNameLabel;
        private System.Windows.Forms.Label technicalNameDescriptionLabel;
    }
}

