namespace Windows_Form_teste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.btnJson = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(143)))), ((int)(((byte)(45)))));
            this.BtnAbrir.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("BtnAbrir.Image")));
            this.BtnAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbrir.Location = new System.Drawing.Point(95, 52);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(140, 44);
            this.BtnAbrir.TabIndex = 0;
            this.BtnAbrir.Text = "Abrir";
            this.BtnAbrir.UseVisualStyleBackColor = false;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // btnJson
            // 
            this.btnJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(143)))), ((int)(((byte)(45)))));
            this.btnJson.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.btnJson.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnJson.Image = ((System.Drawing.Image)(resources.GetObject("btnJson.Image")));
            this.btnJson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJson.Location = new System.Drawing.Point(241, 53);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(154, 43);
            this.btnJson.TabIndex = 1;
            this.btnJson.Text = "JSON";
            this.btnJson.UseVisualStyleBackColor = false;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // btnXml
            // 
            this.btnXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(143)))), ((int)(((byte)(45)))));
            this.btnXml.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.btnXml.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXml.Image = ((System.Drawing.Image)(resources.GetObject("btnXml.Image")));
            this.btnXml.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXml.Location = new System.Drawing.Point(401, 53);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(144, 43);
            this.btnXml.TabIndex = 2;
            this.btnXml.Text = "XML";
            this.btnXml.UseVisualStyleBackColor = false;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(95, 140);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(450, 420);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(718, 588);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnJson);
            this.Controls.Add(this.BtnAbrir);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.Button btnJson;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

