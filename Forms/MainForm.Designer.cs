namespace VkListInfo {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonToken = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonIdInput = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonJson = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonToken,
            this.toolStripButtonIdInput,
            this.toolStripButtonStart,
            this.toolStripButtonJson});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1160, 36);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonToken
            // 
            this.toolStripButtonToken.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonToken.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButtonToken.ForeColor = System.Drawing.Color.White;
            this.toolStripButtonToken.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonToken.Image")));
            this.toolStripButtonToken.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonToken.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolStripButtonToken.Name = "toolStripButtonToken";
            this.toolStripButtonToken.Padding = new System.Windows.Forms.Padding(3);
            this.toolStripButtonToken.Size = new System.Drawing.Size(158, 33);
            this.toolStripButtonToken.Text = "1. Авторизация";
            this.toolStripButtonToken.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButtonToken.Click += new System.EventHandler(this.toolStripButtonToken_Click);
            // 
            // toolStripButtonIdInput
            // 
            this.toolStripButtonIdInput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonIdInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButtonIdInput.ForeColor = System.Drawing.Color.White;
            this.toolStripButtonIdInput.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIdInput.Image")));
            this.toolStripButtonIdInput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIdInput.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolStripButtonIdInput.Name = "toolStripButtonIdInput";
            this.toolStripButtonIdInput.Padding = new System.Windows.Forms.Padding(3);
            this.toolStripButtonIdInput.Size = new System.Drawing.Size(107, 33);
            this.toolStripButtonIdInput.Text = "2. Ввод ID";
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonStart.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButtonStart.ForeColor = System.Drawing.Color.White;
            this.toolStripButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStart.Image")));
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Padding = new System.Windows.Forms.Padding(3);
            this.toolStripButtonStart.Size = new System.Drawing.Size(91, 33);
            this.toolStripButtonStart.Text = "3. Старт";
            // 
            // toolStripButtonJson
            // 
            this.toolStripButtonJson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonJson.Font = new System.Drawing.Font("Roboto", 10.8F);
            this.toolStripButtonJson.ForeColor = System.Drawing.Color.White;
            this.toolStripButtonJson.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonJson.Image")));
            this.toolStripButtonJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonJson.Name = "toolStripButtonJson";
            this.toolStripButtonJson.Padding = new System.Windows.Forms.Padding(3);
            this.toolStripButtonJson.Size = new System.Drawing.Size(146, 33);
            this.toolStripButtonJson.Text = "4. Вывод Json";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 695);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1160, 733);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VkListInfo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonToken;
        private System.Windows.Forms.ToolStripButton toolStripButtonIdInput;
        private System.Windows.Forms.ToolStripButton toolStripButtonStart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton toolStripButtonJson;
    }
}

