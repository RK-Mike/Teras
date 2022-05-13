namespace Teräsmyynti2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tallennaBTN = new System.Windows.Forms.Button();
            this.poistaBTN = new System.Windows.Forms.Button();
            this.kkBTN = new System.Windows.Forms.Button();
            this.vBTN = new System.Windows.Forms.Button();
            this.vkBTN = new System.Windows.Forms.Button();
            this.TulostaBTN = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.kuittaaBTN = new System.Windows.Forms.Button();
            this.yhteenvetoBTN = new System.Windows.Forms.Button();
            this.Nimike = new System.Windows.Forms.Label();
            this.pdfConfig1 = new Syncfusion.Pdf.PdfConfig();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(104)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(104)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(104)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.GhostWhite;
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(104)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 493);
            this.dataGridView1.TabIndex = 0;
            // 
            // tallennaBTN
            // 
            this.tallennaBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tallennaBTN.BackColor = System.Drawing.Color.Silver;
            this.tallennaBTN.Location = new System.Drawing.Point(986, 74);
            this.tallennaBTN.Name = "tallennaBTN";
            this.tallennaBTN.Size = new System.Drawing.Size(75, 40);
            this.tallennaBTN.TabIndex = 1;
            this.tallennaBTN.Text = "Tallenna";
            this.tallennaBTN.UseVisualStyleBackColor = false;
            this.tallennaBTN.Click += new System.EventHandler(this.tallennaBTN_Click);
            // 
            // poistaBTN
            // 
            this.poistaBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.poistaBTN.BackColor = System.Drawing.Color.Silver;
            this.poistaBTN.Location = new System.Drawing.Point(905, 74);
            this.poistaBTN.Name = "poistaBTN";
            this.poistaBTN.Size = new System.Drawing.Size(75, 40);
            this.poistaBTN.TabIndex = 2;
            this.poistaBTN.Text = "Poista";
            this.poistaBTN.UseVisualStyleBackColor = false;
            this.poistaBTN.Click += new System.EventHandler(this.poistaBTN_Click);
            // 
            // kkBTN
            // 
            this.kkBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kkBTN.BackColor = System.Drawing.Color.Silver;
            this.kkBTN.Location = new System.Drawing.Point(451, 12);
            this.kkBTN.Name = "kkBTN";
            this.kkBTN.Size = new System.Drawing.Size(146, 23);
            this.kkBTN.TabIndex = 3;
            this.kkBTN.Text = "Kuukausittaiset";
            this.kkBTN.UseVisualStyleBackColor = false;
            this.kkBTN.Click += new System.EventHandler(this.kkBTN_Click);
            // 
            // vBTN
            // 
            this.vBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vBTN.BackColor = System.Drawing.Color.Silver;
            this.vBTN.Location = new System.Drawing.Point(603, 12);
            this.vBTN.Name = "vBTN";
            this.vBTN.Size = new System.Drawing.Size(111, 23);
            this.vBTN.TabIndex = 4;
            this.vBTN.Text = "Vuosittaiset";
            this.vBTN.UseVisualStyleBackColor = false;
            this.vBTN.Click += new System.EventHandler(this.vBTN_Click);
            // 
            // vkBTN
            // 
            this.vkBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vkBTN.BackColor = System.Drawing.Color.Silver;
            this.vkBTN.Location = new System.Drawing.Point(334, 12);
            this.vkBTN.Name = "vkBTN";
            this.vkBTN.Size = new System.Drawing.Size(111, 23);
            this.vkBTN.TabIndex = 5;
            this.vkBTN.Text = "Viikottaiset";
            this.vkBTN.UseVisualStyleBackColor = false;
            this.vkBTN.Click += new System.EventHandler(this.vkBTN_Click);
            // 
            // TulostaBTN
            // 
            this.TulostaBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TulostaBTN.BackColor = System.Drawing.Color.Silver;
            this.TulostaBTN.Location = new System.Drawing.Point(744, 74);
            this.TulostaBTN.Name = "TulostaBTN";
            this.TulostaBTN.Size = new System.Drawing.Size(74, 40);
            this.TulostaBTN.TabIndex = 6;
            this.TulostaBTN.Text = "Tulosta";
            this.TulostaBTN.UseVisualStyleBackColor = false;
            this.TulostaBTN.Click += new System.EventHandler(this.TulostaBTN_Click);
            // 
            // kuittaaBTN
            // 
            this.kuittaaBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kuittaaBTN.BackColor = System.Drawing.Color.Silver;
            this.kuittaaBTN.Location = new System.Drawing.Point(824, 74);
            this.kuittaaBTN.Name = "kuittaaBTN";
            this.kuittaaBTN.Size = new System.Drawing.Size(75, 40);
            this.kuittaaBTN.TabIndex = 7;
            this.kuittaaBTN.Text = "Kuittaa";
            this.kuittaaBTN.UseVisualStyleBackColor = false;
            this.kuittaaBTN.Click += new System.EventHandler(this.kuittaaBTN_Click_1);
            // 
            // yhteenvetoBTN
            // 
            this.yhteenvetoBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yhteenvetoBTN.BackColor = System.Drawing.Color.Silver;
            this.yhteenvetoBTN.Location = new System.Drawing.Point(743, 41);
            this.yhteenvetoBTN.Name = "yhteenvetoBTN";
            this.yhteenvetoBTN.Size = new System.Drawing.Size(75, 27);
            this.yhteenvetoBTN.TabIndex = 8;
            this.yhteenvetoBTN.Text = "Yhteenveto";
            this.yhteenvetoBTN.UseVisualStyleBackColor = false;
            this.yhteenvetoBTN.Click += new System.EventHandler(this.yhteenvetoBTN_Click);
            // 
            // Nimike
            // 
            this.Nimike.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nimike.Location = new System.Drawing.Point(448, 74);
            this.Nimike.Name = "Nimike";
            this.Nimike.Size = new System.Drawing.Size(149, 27);
            this.Nimike.TabIndex = 9;
            this.Nimike.Text = "Main";
            this.Nimike.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1073, 625);
            this.Controls.Add(this.Nimike);
            this.Controls.Add(this.yhteenvetoBTN);
            this.Controls.Add(this.kuittaaBTN);
            this.Controls.Add(this.TulostaBTN);
            this.Controls.Add(this.vkBTN);
            this.Controls.Add(this.vBTN);
            this.Controls.Add(this.kkBTN);
            this.Controls.Add(this.poistaBTN);
            this.Controls.Add(this.tallennaBTN);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teräsmyynti";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button tallennaBTN;
        private System.Windows.Forms.Button kkBTN;
        private System.Windows.Forms.Button vBTN;
        private System.Windows.Forms.Button vkBTN;
        private System.Windows.Forms.Button TulostaBTN;
        internal System.Windows.Forms.Button poistaBTN;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        internal System.Windows.Forms.Button kuittaaBTN;
        private System.Windows.Forms.Button yhteenvetoBTN;
        private System.Windows.Forms.Label Nimike;
        private Syncfusion.Pdf.PdfConfig pdfConfig1;
    }
}

