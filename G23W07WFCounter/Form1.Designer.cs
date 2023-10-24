namespace G23W07WFCounter
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
            label1 = new Label();
            btnAdd = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Info;
            label1.Font = new Font("맑은 고딕", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(351, 269);
            label1.TabIndex = 0;
            label1.Text = "0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 281);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(170, 74);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "증가";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += onAdd;
            // 
            // button1
            // 
            button1.Location = new Point(188, 281);
            button1.Name = "button1";
            button1.Size = new Size(175, 74);
            button1.TabIndex = 2;
            button1.Text = "감소";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 367);
            Controls.Add(button1);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "카운터";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private Button button1;
    }
}