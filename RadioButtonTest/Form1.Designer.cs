
namespace RadioButtonTest
{
    partial class RadioButton
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.radioButtonTesting = new System.Windows.Forms.GroupBox();
            this.dialogueBoxTest = new System.Windows.Forms.GroupBox();
            this.purchasButton = new System.Windows.Forms.Button();
            this.responseText = new System.Windows.Forms.Label();
            this.radioButtonTesting.SuspendLayout();
            this.dialogueBoxTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(70, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(175, 53);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fufu";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(70, 112);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(175, 53);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Dufu";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(70, 187);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(175, 53);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Mufu";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(297, 86);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(187, 90);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // radioButtonTesting
            // 
            this.radioButtonTesting.Controls.Add(this.btnShow);
            this.radioButtonTesting.Controls.Add(this.radioButton1);
            this.radioButtonTesting.Controls.Add(this.radioButton3);
            this.radioButtonTesting.Controls.Add(this.radioButton2);
            this.radioButtonTesting.Location = new System.Drawing.Point(106, 12);
            this.radioButtonTesting.Name = "radioButtonTesting";
            this.radioButtonTesting.Size = new System.Drawing.Size(550, 247);
            this.radioButtonTesting.TabIndex = 4;
            this.radioButtonTesting.TabStop = false;
            this.radioButtonTesting.Text = "groupBox1";
            // 
            // dialogueBoxTest
            // 
            this.dialogueBoxTest.Controls.Add(this.responseText);
            this.dialogueBoxTest.Controls.Add(this.purchasButton);
            this.dialogueBoxTest.Location = new System.Drawing.Point(12, 276);
            this.dialogueBoxTest.Name = "dialogueBoxTest";
            this.dialogueBoxTest.Size = new System.Drawing.Size(270, 233);
            this.dialogueBoxTest.TabIndex = 5;
            this.dialogueBoxTest.TabStop = false;
            this.dialogueBoxTest.Text = "dialoguboxTesting";
            // 
            // purchasButton
            // 
            this.purchasButton.Location = new System.Drawing.Point(28, 36);
            this.purchasButton.Name = "purchasButton";
            this.purchasButton.Size = new System.Drawing.Size(178, 60);
            this.purchasButton.TabIndex = 0;
            this.purchasButton.Text = "Purchase";
            this.purchasButton.UseVisualStyleBackColor = true;
            this.purchasButton.Click += new System.EventHandler(this.purchasButton_Click);
            // 
            // responseText
            // 
            this.responseText.AutoSize = true;
            this.responseText.Location = new System.Drawing.Point(28, 119);
            this.responseText.Name = "responseText";
            this.responseText.Size = new System.Drawing.Size(16, 13);
            this.responseText.TabIndex = 1;
            this.responseText.Text = "...";
            // 
            // RadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 756);
            this.Controls.Add(this.dialogueBoxTest);
            this.Controls.Add(this.radioButtonTesting);
            this.Name = "RadioButton";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.radioButtonTesting.ResumeLayout(false);
            this.dialogueBoxTest.ResumeLayout(false);
            this.dialogueBoxTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox radioButtonTesting;
        private System.Windows.Forms.GroupBox dialogueBoxTest;
        private System.Windows.Forms.Button purchasButton;
        private System.Windows.Forms.Label responseText;
    }
}

