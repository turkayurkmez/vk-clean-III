namespace SRP
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
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            buttonAdd = new Button();
            buttonChangeColor = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(47, 94);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(47, 123);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(98, 152);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Ekle";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonChangeColor
            // 
            buttonChangeColor.Location = new Point(143, 241);
            buttonChangeColor.Name = "buttonChangeColor";
            buttonChangeColor.Size = new Size(110, 23);
            buttonChangeColor.TabIndex = 3;
            buttonChangeColor.Text = "Renk Değiştir";
            buttonChangeColor.UseVisualStyleBackColor = true;
            buttonChangeColor.Click += buttonChangeColor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 276);
            Controls.Add(buttonChangeColor);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private Button buttonAdd;
        private Button buttonChangeColor;
    }
}
