﻿namespace APT
{
    partial class APT
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.butCheck = new System.Windows.Forms.Button();
            this.comPrinter = new System.Windows.Forms.ComboBox();
            this.labPrint = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labMInvoiceNumberS = new System.Windows.Forms.Label();
            this.labMInvoiceNumberE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butCheck
            // 
            this.butCheck.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butCheck.Location = new System.Drawing.Point(152, 61);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(102, 29);
            this.butCheck.TabIndex = 0;
            this.butCheck.Text = "確定";
            this.butCheck.UseVisualStyleBackColor = true;
            this.butCheck.Click += new System.EventHandler(this.butCheck_Click);
            // 
            // comPrinter
            // 
            this.comPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPrinter.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comPrinter.FormattingEnabled = true;
            this.comPrinter.Location = new System.Drawing.Point(3, 31);
            this.comPrinter.Name = "comPrinter";
            this.comPrinter.Size = new System.Drawing.Size(527, 24);
            this.comPrinter.TabIndex = 1;
            // 
            // labPrint
            // 
            this.labPrint.AutoSize = true;
            this.labPrint.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPrint.Location = new System.Drawing.Point(141, 9);
            this.labPrint.Name = "labPrint";
            this.labPrint.Size = new System.Drawing.Size(56, 16);
            this.labPrint.TabIndex = 2;
            this.labPrint.Text = "labPrint";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "請選擇印表機";
            // 
            // labMInvoiceNumberS
            // 
            this.labMInvoiceNumberS.AutoSize = true;
            this.labMInvoiceNumberS.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMInvoiceNumberS.Location = new System.Drawing.Point(0, 58);
            this.labMInvoiceNumberS.Name = "labMInvoiceNumberS";
            this.labMInvoiceNumberS.Size = new System.Drawing.Size(146, 16);
            this.labMInvoiceNumberS.TabIndex = 4;
            this.labMInvoiceNumberS.Text = "labMInvoiceNumberS";
            // 
            // labMInvoiceNumberE
            // 
            this.labMInvoiceNumberE.AutoSize = true;
            this.labMInvoiceNumberE.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMInvoiceNumberE.Location = new System.Drawing.Point(0, 74);
            this.labMInvoiceNumberE.Name = "labMInvoiceNumberE";
            this.labMInvoiceNumberE.Size = new System.Drawing.Size(147, 16);
            this.labMInvoiceNumberE.TabIndex = 5;
            this.labMInvoiceNumberE.Text = "labMInvoiceNumberE";
            // 
            // APT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 98);
            this.Controls.Add(this.labMInvoiceNumberE);
            this.Controls.Add(this.labMInvoiceNumberS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labPrint);
            this.Controls.Add(this.comPrinter);
            this.Controls.Add(this.butCheck);
            this.Name = "APT";
            this.Text = "APT請選擇印表機";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.ComboBox comPrinter;
        private System.Windows.Forms.Label labPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labMInvoiceNumberS;
        private System.Windows.Forms.Label labMInvoiceNumberE;
    }
}

