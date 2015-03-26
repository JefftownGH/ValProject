namespace ValProject
{
    partial class ValParameterControl
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.minValueLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxValueLabel = new System.Windows.Forms.Label();
            this.parameterNameLabel = new System.Windows.Forms.Label();
            this.valueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.parametrDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.valueNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Мин";
            // 
            // minValueLabel
            // 
            this.minValueLabel.AutoSize = true;
            this.minValueLabel.Location = new System.Drawing.Point(2, 23);
            this.minValueLabel.Name = "minValueLabel";
            this.minValueLabel.Size = new System.Drawing.Size(35, 13);
            this.minValueLabel.TabIndex = 2;
            this.minValueLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Макс";
            // 
            // maxValueLabel
            // 
            this.maxValueLabel.AutoSize = true;
            this.maxValueLabel.Location = new System.Drawing.Point(188, 23);
            this.maxValueLabel.Name = "maxValueLabel";
            this.maxValueLabel.Size = new System.Drawing.Size(35, 13);
            this.maxValueLabel.TabIndex = 4;
            this.maxValueLabel.Text = "label4";
            // 
            // parameterNameLabel
            // 
            this.parameterNameLabel.AutoSize = true;
            this.parameterNameLabel.Location = new System.Drawing.Point(53, 0);
            this.parameterNameLabel.Name = "parameterNameLabel";
            this.parameterNameLabel.Size = new System.Drawing.Size(35, 13);
            this.parameterNameLabel.TabIndex = 6;
            this.parameterNameLabel.Text = "label6";
            // 
            // valueNumericUpDown
            // 
            this.valueNumericUpDown.Location = new System.Drawing.Point(56, 15);
            this.valueNumericUpDown.Name = "valueNumericUpDown";
            this.valueNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.valueNumericUpDown.TabIndex = 7;
            this.valueNumericUpDown.ValueChanged += new System.EventHandler(this.valueNumericUpDown_ValueChanged);
            // 
            // parametrDescriptionLabel
            // 
            this.parametrDescriptionLabel.AutoSize = true;
            this.parametrDescriptionLabel.Location = new System.Drawing.Point(229, 4);
            this.parametrDescriptionLabel.Name = "parametrDescriptionLabel";
            this.parametrDescriptionLabel.Size = new System.Drawing.Size(35, 13);
            this.parametrDescriptionLabel.TabIndex = 8;
            this.parametrDescriptionLabel.Text = "label5";
            this.parametrDescriptionLabel.Visible = false;
            // 
            // ValParameterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.parametrDescriptionLabel);
            this.Controls.Add(this.valueNumericUpDown);
            this.Controls.Add(this.parameterNameLabel);
            this.Controls.Add(this.maxValueLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minValueLabel);
            this.Controls.Add(this.label1);
            this.Name = "ValParameterControl";
            this.Size = new System.Drawing.Size(343, 39);
            ((System.ComponentModel.ISupportInitialize)(this.valueNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minValueLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label maxValueLabel;
        private System.Windows.Forms.Label parameterNameLabel;
        private System.Windows.Forms.NumericUpDown valueNumericUpDown;
        private System.Windows.Forms.Label parametrDescriptionLabel;
    }
}
