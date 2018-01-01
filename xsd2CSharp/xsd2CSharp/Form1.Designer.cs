namespace xsd2CSharp
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.btnRemoveModel = new System.Windows.Forms.Button();
            this.btnClearModel = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddRef = new System.Windows.Forms.Button();
            this.btnRemoveRef = new System.Windows.Forms.Button();
            this.btnClearRef = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lsbModel = new System.Windows.Forms.ListBox();
            this.lsbRef = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNetVersions = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2462F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.7538F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbNetVersions, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStart, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(723, 406);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lsbModel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lsbRef, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(106, 93);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(614, 280);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.Controls.Add(this.btnAddModel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnRemoveModel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnClearModel, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 243);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(301, 34);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnAddModel
            // 
            this.btnAddModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddModel.Location = new System.Drawing.Point(3, 3);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(93, 28);
            this.btnAddModel.TabIndex = 0;
            this.btnAddModel.Text = "Add";
            this.btnAddModel.UseVisualStyleBackColor = true;
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);
            // 
            // btnRemoveModel
            // 
            this.btnRemoveModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveModel.Location = new System.Drawing.Point(102, 3);
            this.btnRemoveModel.Name = "btnRemoveModel";
            this.btnRemoveModel.Size = new System.Drawing.Size(96, 28);
            this.btnRemoveModel.TabIndex = 1;
            this.btnRemoveModel.Text = "Remove";
            this.btnRemoveModel.UseVisualStyleBackColor = true;
            this.btnRemoveModel.Click += new System.EventHandler(this.btnRemoveModel_Click);
            // 
            // btnClearModel
            // 
            this.btnClearModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearModel.Location = new System.Drawing.Point(204, 3);
            this.btnClearModel.Name = "btnClearModel";
            this.btnClearModel.Size = new System.Drawing.Size(94, 28);
            this.btnClearModel.TabIndex = 2;
            this.btnClearModel.Text = "Clear";
            this.btnClearModel.UseVisualStyleBackColor = true;
            this.btnClearModel.Click += new System.EventHandler(this.btnClearModel_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel4.Controls.Add(this.btnAddRef, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnRemoveRef, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnClearRef, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(310, 243);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(301, 34);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnAddRef
            // 
            this.btnAddRef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRef.Location = new System.Drawing.Point(3, 3);
            this.btnAddRef.Name = "btnAddRef";
            this.btnAddRef.Size = new System.Drawing.Size(93, 28);
            this.btnAddRef.TabIndex = 0;
            this.btnAddRef.Text = "Add";
            this.btnAddRef.UseVisualStyleBackColor = true;
            this.btnAddRef.Click += new System.EventHandler(this.btnAddRef_Click);
            // 
            // btnRemoveRef
            // 
            this.btnRemoveRef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveRef.Location = new System.Drawing.Point(102, 3);
            this.btnRemoveRef.Name = "btnRemoveRef";
            this.btnRemoveRef.Size = new System.Drawing.Size(96, 28);
            this.btnRemoveRef.TabIndex = 1;
            this.btnRemoveRef.Text = "Remove";
            this.btnRemoveRef.UseVisualStyleBackColor = true;
            this.btnRemoveRef.Click += new System.EventHandler(this.btnRemoveRef_Click);
            // 
            // btnClearRef
            // 
            this.btnClearRef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearRef.Location = new System.Drawing.Point(204, 3);
            this.btnClearRef.Name = "btnClearRef";
            this.btnClearRef.Size = new System.Drawing.Size(94, 28);
            this.btnClearRef.TabIndex = 2;
            this.btnClearRef.Text = "Clear";
            this.btnClearRef.UseVisualStyleBackColor = true;
            this.btnClearRef.Click += new System.EventHandler(this.btnClearRef_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genere XSD Files";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(310, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Refere XSD Files";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsbModel
            // 
            this.lsbModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbModel.FormattingEnabled = true;
            this.lsbModel.Location = new System.Drawing.Point(3, 33);
            this.lsbModel.Name = "lsbModel";
            this.lsbModel.Size = new System.Drawing.Size(301, 204);
            this.lsbModel.TabIndex = 4;
            // 
            // lsbRef
            // 
            this.lsbRef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbRef.FormattingEnabled = true;
            this.lsbRef.Location = new System.Drawing.Point(310, 33);
            this.lsbRef.Name = "lsbRef";
            this.lsbRef.Size = new System.Drawing.Size(301, 204);
            this.lsbRef.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output Folder";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = ".net Version";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbNetVersions
            // 
            this.cbNetVersions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNetVersions.FormattingEnabled = true;
            this.cbNetVersions.Location = new System.Drawing.Point(106, 33);
            this.cbNetVersions.Name = "cbNetVersions";
            this.cbNetVersions.Size = new System.Drawing.Size(614, 21);
            this.cbNetVersions.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtOutput);
            this.panel1.Controls.Add(this.btnOutput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(106, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 24);
            this.panel1.TabIndex = 4;
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(511, 24);
            this.txtOutput.TabIndex = 0;
            // 
            // btnOutput
            // 
            this.btnOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOutput.Location = new System.Drawing.Point(511, 0);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(103, 24);
            this.btnOutput.TabIndex = 1;
            this.btnOutput.Text = "Select Output";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(106, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(614, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Xsd2Class";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStart.Location = new System.Drawing.Point(568, 379);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(152, 24);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 406);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnAddModel;
        private System.Windows.Forms.Button btnRemoveModel;
        private System.Windows.Forms.Button btnClearModel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnAddRef;
        private System.Windows.Forms.Button btnRemoveRef;
        private System.Windows.Forms.Button btnClearRef;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lsbModel;
        private System.Windows.Forms.ListBox lsbRef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNetVersions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStart;
    }
}

