
namespace Test
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.listBoxControl1 = new ComponentsLibrary22.ListBoxControl();
            this.textboxControl1 = new ComponentsLibrary22.TextboxControl();
            this.comboboxControl1 = new ComponentsLibrary22.ComboboxControl();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 228);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(308, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(369, 22);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.SelectedIndex = -1;
            this.listBoxControl1.Size = new System.Drawing.Size(349, 155);
            this.listBoxControl1.TabIndex = 4;
            // 
            // textboxControl1
            // 
            this.textboxControl1.Location = new System.Drawing.Point(12, 167);
            this.textboxControl1.Name = "textboxControl1";
            this.textboxControl1.Size = new System.Drawing.Size(337, 66);
            this.textboxControl1.TabIndex = 2;
            // 
            // comboboxControl1
            // 
            this.comboboxControl1.Location = new System.Drawing.Point(12, 12);
            this.comboboxControl1.Name = "comboboxControl1";
            this.comboboxControl1.SelectedIndex = 0;
            this.comboboxControl1.Size = new System.Drawing.Size(308, 90);
            this.comboboxControl1.TabIndex = 0;
            this.comboboxControl1.ComboBoxSelectedElementChange += new System.EventHandler(this.comboboxControl1_ComboBoxSelectedElementChange);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(386, 167);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(311, 23);
            this.buttonSelect.TabIndex = 5;
            this.buttonSelect.Text = "Выбрать";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textboxControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboboxControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentsLibrary22.ComboboxControl comboboxControl1;
        private System.Windows.Forms.Button button1;
        private ComponentsLibrary22.TextboxControl textboxControl1;
        private System.Windows.Forms.Button buttonOk;
        private ComponentsLibrary22.ListBoxControl listBoxControl1;
        private System.Windows.Forms.Button buttonSelect;
    }
}

