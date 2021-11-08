namespace Lab4_Nasledovanie
{
    partial class Form1
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

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRefill = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.txtOut = new System.Windows.Forms.RichTextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.rtbqueue = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnRefill
            // 
            this.btnRefill.BackColor = System.Drawing.Color.Pink;
            this.btnRefill.Location = new System.Drawing.Point(12, 12);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(387, 39);
            this.btnRefill.TabIndex = 0;
            this.btnRefill.Text = "Перезаполнить";
            this.btnRefill.UseVisualStyleBackColor = false;
            this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.Lavender;
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Location = new System.Drawing.Point(11, 57);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(388, 51);
            this.txtInfo.TabIndex = 1;
            this.txtInfo.Text = "";
            // 
            // txtOut
            // 
            this.txtOut.BackColor = System.Drawing.Color.SeaShell;
            this.txtOut.Location = new System.Drawing.Point(12, 125);
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.Size = new System.Drawing.Size(254, 181);
            this.txtOut.TabIndex = 2;
            this.txtOut.Text = "";
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.Pink;
            this.btnGet.Location = new System.Drawing.Point(272, 125);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(127, 181);
            this.btnGet.TabIndex = 3;
            this.btnGet.Text = "Взять";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // rtbqueue
            // 
            this.rtbqueue.BackColor = System.Drawing.Color.Lavender;
            this.rtbqueue.Location = new System.Drawing.Point(405, 12);
            this.rtbqueue.Name = "rtbqueue";
            this.rtbqueue.ReadOnly = true;
            this.rtbqueue.Size = new System.Drawing.Size(80, 294);
            this.rtbqueue.TabIndex = 4;
            this.rtbqueue.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(495, 318);
            this.Controls.Add(this.rtbqueue);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnRefill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Автомат";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefill;
        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.RichTextBox txtOut;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.RichTextBox rtbqueue;
    }
}

