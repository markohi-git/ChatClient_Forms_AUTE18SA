namespace ChatClient_Forms_AUTE18SA
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
            this.IpTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.PORT = new System.Windows.Forms.Label();
            this.yhdistaButton = new System.Windows.Forms.Button();
            this.katkaiseButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lahetaTextBox = new System.Windows.Forms.TextBox();
            this.lahetaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IpTextBox
            // 
            this.IpTextBox.Location = new System.Drawing.Point(43, 32);
            this.IpTextBox.Name = "IpTextBox";
            this.IpTextBox.Size = new System.Drawing.Size(120, 20);
            this.IpTextBox.TabIndex = 0;
            this.IpTextBox.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(187, 31);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 20);
            this.portTextBox.TabIndex = 2;
            this.portTextBox.Text = "5000";
            // 
            // PORT
            // 
            this.PORT.AutoSize = true;
            this.PORT.Location = new System.Drawing.Point(187, 13);
            this.PORT.Name = "PORT";
            this.PORT.Size = new System.Drawing.Size(26, 13);
            this.PORT.TabIndex = 3;
            this.PORT.Text = "Port";
            // 
            // yhdistaButton
            // 
            this.yhdistaButton.Location = new System.Drawing.Point(326, 28);
            this.yhdistaButton.Name = "yhdistaButton";
            this.yhdistaButton.Size = new System.Drawing.Size(75, 23);
            this.yhdistaButton.TabIndex = 4;
            this.yhdistaButton.Text = "Yhdistä";
            this.yhdistaButton.UseVisualStyleBackColor = true;
            this.yhdistaButton.Click += new System.EventHandler(this.yhdistaButton_Click);
            // 
            // katkaiseButton
            // 
            this.katkaiseButton.Location = new System.Drawing.Point(441, 28);
            this.katkaiseButton.Name = "katkaiseButton";
            this.katkaiseButton.Size = new System.Drawing.Size(91, 23);
            this.katkaiseButton.TabIndex = 5;
            this.katkaiseButton.Text = "Katkaise yhteys";
            this.katkaiseButton.UseVisualStyleBackColor = true;
            this.katkaiseButton.Click += new System.EventHandler(this.katkaiseButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 92);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(588, 272);
            this.textBox1.TabIndex = 6;
            // 
            // lahetaTextBox
            // 
            this.lahetaTextBox.Location = new System.Drawing.Point(42, 396);
            this.lahetaTextBox.Name = "lahetaTextBox";
            this.lahetaTextBox.Size = new System.Drawing.Size(245, 20);
            this.lahetaTextBox.TabIndex = 7;
            // 
            // lahetaButton
            // 
            this.lahetaButton.Location = new System.Drawing.Point(326, 393);
            this.lahetaButton.Name = "lahetaButton";
            this.lahetaButton.Size = new System.Drawing.Size(119, 23);
            this.lahetaButton.TabIndex = 8;
            this.lahetaButton.Text = "Lähetä";
            this.lahetaButton.UseVisualStyleBackColor = true;
            this.lahetaButton.Click += new System.EventHandler(this.lahetaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lahetaButton);
            this.Controls.Add(this.lahetaTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.katkaiseButton);
            this.Controls.Add(this.yhdistaButton);
            this.Controls.Add(this.PORT);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IpTextBox);
            this.Name = "Form1";
            this.Text = "127.0.0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IpTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label PORT;
        private System.Windows.Forms.Button yhdistaButton;
        private System.Windows.Forms.Button katkaiseButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox lahetaTextBox;
        private System.Windows.Forms.Button lahetaButton;
    }
}

