
namespace TDD.UI
{
    partial class Form1View
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.CalculationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CalculationButton
            // 
            this.CalculationButton.Location = new System.Drawing.Point(70, 195);
            this.CalculationButton.Name = "CalculationButton";
            this.CalculationButton.Size = new System.Drawing.Size(75, 23);
            this.CalculationButton.TabIndex = 0;
            this.CalculationButton.Text = "計算";
            this.CalculationButton.UseVisualStyleBackColor = true;
            this.CalculationButton.Click += new System.EventHandler(this.CalculationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(216, 107);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(23, 12);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "xxx";
            // 
            // ATextBox
            // 
            this.ATextBox.Location = new System.Drawing.Point(29, 107);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(59, 19);
            this.ATextBox.TabIndex = 4;
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(111, 107);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(64, 19);
            this.BTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.ATextBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculationButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.TextBox BTextBox;
    }
}

