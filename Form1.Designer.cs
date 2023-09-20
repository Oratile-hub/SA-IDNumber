namespace SA_IDNumber
{
    partial class Form1
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
            btnValidate = new Button();
            labelID = new Label();
            txtID = new TextBox();
            SuspendLayout();
            // 
            // btnValidate
            // 
            btnValidate.BackColor = SystemColors.ControlLightLight;
            btnValidate.Location = new Point(465, 292);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(112, 45);
            btnValidate.TabIndex = 0;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(215, 194);
            labelID.Name = "labelID";
            labelID.Size = new Size(145, 25);
            labelID.TabIndex = 1;
            labelID.Text = "Enter ID Number";
            // 
            // txtID
            // 
            txtID.Location = new Point(384, 194);
            txtID.Name = "txtID";
            txtID.Size = new Size(247, 31);
            txtID.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtID);
            Controls.Add(labelID);
            Controls.Add(btnValidate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValidate;
        private Label labelID;
        private TextBox txtID;
    }
}