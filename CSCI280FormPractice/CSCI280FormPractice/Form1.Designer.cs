namespace CSCI280FormPractice
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
            this.txtRules = new System.Windows.Forms.TextBox();
            this.cmdEvaluate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRules
            // 
            this.txtRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRules.Location = new System.Drawing.Point(12, 12);
            this.txtRules.Multiline = true;
            this.txtRules.Name = "txtRules";
            this.txtRules.Size = new System.Drawing.Size(897, 214);
            this.txtRules.TabIndex = 0;
            this.txtRules.Text = "IF ITEM_NO IS 10 THEN";
            // 
            // cmdEvaluate
            // 
            this.cmdEvaluate.Location = new System.Drawing.Point(12, 232);
            this.cmdEvaluate.Name = "cmdEvaluate";
            this.cmdEvaluate.Size = new System.Drawing.Size(75, 23);
            this.cmdEvaluate.TabIndex = 1;
            this.cmdEvaluate.Text = "Evaluate";
            this.cmdEvaluate.UseVisualStyleBackColor = true;
            this.cmdEvaluate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 362);
            this.Controls.Add(this.cmdEvaluate);
            this.Controls.Add(this.txtRules);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRules;
        private System.Windows.Forms.Button cmdEvaluate;
    }
}

