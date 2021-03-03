
namespace FootSquare
{
    partial class FootSquare
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFoot = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.FS = new System.Windows.Forms.Label();
            this.MS = new System.Windows.Forms.Label();
            this.lbAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbFoot
            // 
            this.tbFoot.Location = new System.Drawing.Point(97, 87);
            this.tbFoot.Name = "tbFoot";
            this.tbFoot.Size = new System.Drawing.Size(136, 20);
            this.tbFoot.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(122, 172);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // FS
            // 
            this.FS.AutoSize = true;
            this.FS.Location = new System.Drawing.Point(12, 90);
            this.FS.Name = "FS";
            this.FS.Size = new System.Drawing.Size(68, 13);
            this.FS.TabIndex = 3;
            this.FS.Text = "FootSquare :";
            // 
            // MS
            // 
            this.MS.AutoSize = true;
            this.MS.Location = new System.Drawing.Point(12, 127);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(74, 13);
            this.MS.TabIndex = 4;
            this.MS.Text = "MeterSquare :";
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.Location = new System.Drawing.Point(97, 126);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(0, 13);
            this.lbAnswer.TabIndex = 5;
            // 
            // FootSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 232);
            this.Controls.Add(this.lbAnswer);
            this.Controls.Add(this.MS);
            this.Controls.Add(this.FS);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.tbFoot);
            this.Name = "FootSquare";
            this.Text = "FootSquare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFoot;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label FS;
        private System.Windows.Forms.Label MS;
        private System.Windows.Forms.Label lbAnswer;
    }
}

