namespace _KonomenovKirillMikhailovich__PR03_GIT
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
            this.btnShowDateTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowDateTime
            // 
            this.btnShowDateTime.Location = new System.Drawing.Point(270, 233);
            this.btnShowDateTime.Name = "btnShowDateTime";
            this.btnShowDateTime.Size = new System.Drawing.Size(213, 92);
            this.btnShowDateTime.TabIndex = 0;
            this.btnShowDateTime.Text = "Показать дату и время";
            this.btnShowDateTime.UseVisualStyleBackColor = true;
            this.btnShowDateTime.Click += new System.EventHandler(this.btnShowDateTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnShowDateTime);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "KonomenovKirill";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowDateTime;
    }
}

