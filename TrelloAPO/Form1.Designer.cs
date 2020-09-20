namespace TrelloAPO
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
            this.btnBrdName = new System.Windows.Forms.Button();
            this.tcLists = new System.Windows.Forms.TabControl();
            this.btnCreateList = new System.Windows.Forms.Button();
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.btnRenameList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrdName
            // 
            this.btnBrdName.AutoSize = true;
            this.btnBrdName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrdName.BackColor = System.Drawing.Color.Transparent;
            this.btnBrdName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBrdName.Enabled = false;
            this.btnBrdName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrdName.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrdName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBrdName.Location = new System.Drawing.Point(11, 5);
            this.btnBrdName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrdName.Name = "btnBrdName";
            this.btnBrdName.Size = new System.Drawing.Size(154, 42);
            this.btnBrdName.TabIndex = 3;
            this.btnBrdName.Text = "Loading...";
            this.btnBrdName.UseVisualStyleBackColor = true;
            // 
            // tcLists
            // 
            this.tcLists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcLists.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tcLists.Location = new System.Drawing.Point(11, 87);
            this.tcLists.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tcLists.Multiline = true;
            this.tcLists.Name = "tcLists";
            this.tcLists.SelectedIndex = 0;
            this.tcLists.Size = new System.Drawing.Size(1686, 785);
            this.tcLists.TabIndex = 5;
            // 
            // btnCreateList
            // 
            this.btnCreateList.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnCreateList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreateList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateList.Location = new System.Drawing.Point(11, 51);
            this.btnCreateList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreateList.Name = "btnCreateList";
            this.btnCreateList.Size = new System.Drawing.Size(176, 33);
            this.btnCreateList.TabIndex = 6;
            this.btnCreateList.Text = "Создать список";
            this.btnCreateList.UseVisualStyleBackColor = false;
            this.btnCreateList.Click += new System.EventHandler(this.btnCreateList_ClickAsync);
            // 
            // btnDeleteList
            // 
            this.btnDeleteList.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnDeleteList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteList.Location = new System.Drawing.Point(210, 51);
            this.btnDeleteList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(176, 33);
            this.btnDeleteList.TabIndex = 7;
            this.btnDeleteList.Text = "Удалить список";
            this.btnDeleteList.UseVisualStyleBackColor = false;
            this.btnDeleteList.Click += new System.EventHandler(this.btnDeleteList_Click);
            // 
            // btnRenameList
            // 
            this.btnRenameList.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnRenameList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRenameList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenameList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRenameList.Location = new System.Drawing.Point(412, 51);
            this.btnRenameList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRenameList.Name = "btnRenameList";
            this.btnRenameList.Size = new System.Drawing.Size(254, 33);
            this.btnRenameList.TabIndex = 8;
            this.btnRenameList.Text = "Переименовать список";
            this.btnRenameList.UseVisualStyleBackColor = false;
            this.btnRenameList.Click += new System.EventHandler(this.btnRenameList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnRenameList);
            this.Controls.Add(this.btnDeleteList);
            this.Controls.Add(this.btnCreateList);
            this.Controls.Add(this.tcLists);
            this.Controls.Add(this.btnBrdName);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "TrelloAPI CRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBrdName;
        private System.Windows.Forms.TabControl tcLists;
        private System.Windows.Forms.Button btnCreateList;
        private System.Windows.Forms.Button btnDeleteList;
        private System.Windows.Forms.Button btnRenameList;
    }
}

