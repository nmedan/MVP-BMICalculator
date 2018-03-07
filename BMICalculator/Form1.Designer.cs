using BMICalculator.View;

namespace BMICalculator
{
    partial class BMICalculator 
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
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbGenderFemale = new System.Windows.Forms.RadioButton();
            this.rbGenderMale = new System.Windows.Forms.RadioButton();
            this.gbCalculation = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.lblResultComment = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.gbGender.SuspendLayout();
            this.gbCalculation.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbGenderFemale);
            this.gbGender.Controls.Add(this.rbGenderMale);
            this.gbGender.Location = new System.Drawing.Point(12, 12);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(189, 67);
            this.gbGender.TabIndex = 0;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbGenderFemale
            // 
            this.rbGenderFemale.AutoSize = true;
            this.rbGenderFemale.Location = new System.Drawing.Point(60, 28);
            this.rbGenderFemale.Name = "rbGenderFemale";
            this.rbGenderFemale.Size = new System.Drawing.Size(59, 17);
            this.rbGenderFemale.TabIndex = 1;
            this.rbGenderFemale.TabStop = true;
            this.rbGenderFemale.Text = "Female";
            this.rbGenderFemale.UseVisualStyleBackColor = true;
            // 
            // rbGenderMale
            // 
            this.rbGenderMale.AutoSize = true;
            this.rbGenderMale.Location = new System.Drawing.Point(6, 28);
            this.rbGenderMale.Name = "rbGenderMale";
            this.rbGenderMale.Size = new System.Drawing.Size(48, 17);
            this.rbGenderMale.TabIndex = 0;
            this.rbGenderMale.TabStop = true;
            this.rbGenderMale.Text = "Male";
            this.rbGenderMale.UseVisualStyleBackColor = true;
            // 
            // gbCalculation
            // 
            this.gbCalculation.Controls.Add(this.btnCalculate);
            this.gbCalculation.Controls.Add(this.lblWeight);
            this.gbCalculation.Controls.Add(this.lblHeight);
            this.gbCalculation.Controls.Add(this.txtWeight);
            this.gbCalculation.Controls.Add(this.txtHeight);
            this.gbCalculation.Location = new System.Drawing.Point(12, 85);
            this.gbCalculation.Name = "gbCalculation";
            this.gbCalculation.Size = new System.Drawing.Size(189, 148);
            this.gbCalculation.TabIndex = 1;
            this.gbCalculation.TabStop = false;
            this.gbCalculation.Text = "Calculate BMI";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(54, 96);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(63, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(6, 73);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(44, 13);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Weight:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(7, 47);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height:";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(54, 70);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 1;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(54, 44);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 0;
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.lblResultComment);
            this.gbResult.Controls.Add(this.lblResult);
            this.gbResult.Controls.Add(this.lblBMI);
            this.gbResult.Location = new System.Drawing.Point(208, 12);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(163, 221);
            this.gbResult.TabIndex = 2;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            this.gbResult.Enter += new System.EventHandler(this.gbResult_Enter);
            // 
            // lblResultComment
            // 
            this.lblResultComment.AutoSize = false;
            this.lblResultComment.Size = new System.Drawing.Size(150, 13);
            this.lblResultComment.Location = new System.Drawing.Point((this.gbResult.Width - this.lblResultComment.Width)/2, 151);
            this.lblResultComment.Name = "lblResultComment";      
            this.lblResultComment.TabIndex = 2;
            this.lblResultComment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResultComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBMI
            // 
            this.lblBMI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBMI.AutoSize = false;
            this.lblBMI.MinimumSize = new System.Drawing.Size(150, 60);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(120, 60);
            this.lblBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBMI.Location = new System.Drawing.Point((this.gbResult.Width - this.lblBMI.Width) / 2, 58);       
            this.lblBMI.TabIndex = 1;
            this.lblBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = false;
            this.lblResult.Size = new System.Drawing.Size(150, 13);
            this.lblResult.Location = new System.Drawing.Point((this.gbResult.Width - this.lblResult.Width) / 2, 28);
            this.lblResult.Name = "lblResult";     
            this.lblResult.TabIndex = 0;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 245);
            this.Controls.Add(this.gbCalculation);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.gbResult);
            this.Name = "BMICalculator";
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.gbCalculation.ResumeLayout(false);
            this.gbCalculation.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbGenderMale;
        private System.Windows.Forms.RadioButton rbGenderFemale;
        private System.Windows.Forms.GroupBox gbCalculation;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblResultComment;

       

    }
}

