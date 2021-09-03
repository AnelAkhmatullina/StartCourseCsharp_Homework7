
namespace WindowsFormsApp1
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
            this.Btn_Play = new System.Windows.Forms.Button();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Play
            // 
            this.Btn_Play.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Play.Location = new System.Drawing.Point(317, 131);
            this.Btn_Play.Name = "Btn_Play";
            this.Btn_Play.Size = new System.Drawing.Size(75, 23);
            this.Btn_Play.TabIndex = 0;
            this.Btn_Play.Text = "Играть";
            this.Btn_Play.UseVisualStyleBackColor = true;
            this.Btn_Play.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_exit
            // 
            this.Btn_exit.Location = new System.Drawing.Point(317, 206);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(75, 23);
            this.Btn_exit.TabIndex = 1;
            this.Btn_exit.Text = "Выход";
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.Btn_Play);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Play;
        private System.Windows.Forms.Button Btn_exit;
    }
}

