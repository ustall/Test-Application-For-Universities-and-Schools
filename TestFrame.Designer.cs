using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;

namespace mgri_tests
{
    partial class TestFrame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.MainQuestionLB = new System.Windows.Forms.Label();
            this.AnsLabel = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Button();
            this.VariantLB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MainQPanel = new System.Windows.Forms.Panel();
            this.SubQPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MainQPanel.SuspendLayout();
            this.SubQPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainQuestionLB
            // 
            this.MainQuestionLB.AutoSize = true;
            this.MainQuestionLB.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainQuestionLB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainQuestionLB.Location = new System.Drawing.Point(3, 0);
            this.MainQuestionLB.MaximumSize = new System.Drawing.Size(960, 0);
            this.MainQuestionLB.Name = "MainQuestionLB";
            this.MainQuestionLB.Size = new System.Drawing.Size(104, 29);
            this.MainQuestionLB.TabIndex = 0;
            this.MainQuestionLB.Text = "Question";
            this.MainQuestionLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AnsLabel
            // 
            this.AnsLabel.AutoSize = true;
            this.AnsLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnsLabel.Location = new System.Drawing.Point(3, 13);
            this.AnsLabel.Name = "AnsLabel";
            this.AnsLabel.Size = new System.Drawing.Size(121, 29);
            this.AnsLabel.TabIndex = 2;
            this.AnsLabel.Text = "Ваш ответ:";
            // 
            // Answer
            // 
            this.Answer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Answer.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer.Location = new System.Drawing.Point(130, 10);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(660, 37);
            this.Answer.TabIndex = 1;
            // 
            // next
            // 
            this.next.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.next.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.next.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next.Location = new System.Drawing.Point(796, 11);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(159, 37);
            this.next.TabIndex = 3;
            this.next.Text = "Далее";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // VariantLB
            // 
            this.VariantLB.AutoEllipsis = true;
            this.VariantLB.AutoSize = true;
            this.VariantLB.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VariantLB.Location = new System.Drawing.Point(4, 0);
            this.VariantLB.MaximumSize = new System.Drawing.Size(956, 0);
            this.VariantLB.Name = "VariantLB";
            this.VariantLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VariantLB.Size = new System.Drawing.Size(74, 29);
            this.VariantLB.TabIndex = 5;
            this.VariantLB.Text = "label1";
            this.VariantLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.MainQPanel);
            this.panel1.Controls.Add(this.SubQPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 611);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.AnsLabel);
            this.panel2.Controls.Add(this.Answer);
            this.panel2.Controls.Add(this.next);
            this.panel2.Location = new System.Drawing.Point(12, 556);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 52);
            this.panel2.TabIndex = 8;
            // 
            // MainQPanel
            // 
            this.MainQPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainQPanel.AutoScroll = true;
            this.MainQPanel.Controls.Add(this.MainQuestionLB);
            this.MainQPanel.Location = new System.Drawing.Point(12, 12);
            this.MainQPanel.Name = "MainQPanel";
            this.MainQPanel.Size = new System.Drawing.Size(960, 117);
            this.MainQPanel.TabIndex = 7;
            // 
            // SubQPanel
            // 
            this.SubQPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubQPanel.AutoScroll = true;
            this.SubQPanel.Controls.Add(this.VariantLB);
            this.SubQPanel.Location = new System.Drawing.Point(12, 135);
            this.SubQPanel.Name = "SubQPanel";
            this.SubQPanel.Size = new System.Drawing.Size(960, 415);
            this.SubQPanel.TabIndex = 6;
            // 
            // TestFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "TestFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестирование";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MainQPanel.ResumeLayout(false);
            this.MainQPanel.PerformLayout();
            this.SubQPanel.ResumeLayout(false);
            this.SubQPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label MainQuestionLB;
        private Label AnsLabel;
        private TextBox Answer;
        private Button next;
        private Label VariantLB;
        private Panel panel1;
        private Panel panel2;
        private Panel MainQPanel;
        private Panel SubQPanel;
    }
}

