
namespace AdoNetDemo
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.gbxAddAProducts = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxUpdateAProducts = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.tbxUpdateStock = new System.Windows.Forms.TextBox();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.labelUpdateUnitPrice = new System.Windows.Forms.Label();
            this.lblUpdateStock = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxAddAProducts.SuspendLayout();
            this.gbxUpdateAProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(54, 36);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(930, 230);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(24, 89);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(69, 17);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(24, 137);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(95, 17);
            this.lblStockAmount.TabIndex = 3;
            this.lblStockAmount.Text = "Stock Amount";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(160, 44);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(131, 22);
            this.tbxName.TabIndex = 4;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(160, 88);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(131, 22);
            this.tbxUnitPrice.TabIndex = 5;
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(160, 134);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(131, 22);
            this.tbxStockAmount.TabIndex = 6;
            // 
            // gbxAddAProducts
            // 
            this.gbxAddAProducts.Controls.Add(this.btnAdd);
            this.gbxAddAProducts.Controls.Add(this.tbxName);
            this.gbxAddAProducts.Controls.Add(this.tbxStockAmount);
            this.gbxAddAProducts.Controls.Add(this.lblName);
            this.gbxAddAProducts.Controls.Add(this.tbxUnitPrice);
            this.gbxAddAProducts.Controls.Add(this.lblUnitPrice);
            this.gbxAddAProducts.Controls.Add(this.lblStockAmount);
            this.gbxAddAProducts.Location = new System.Drawing.Point(54, 328);
            this.gbxAddAProducts.Name = "gbxAddAProducts";
            this.gbxAddAProducts.Size = new System.Drawing.Size(361, 235);
            this.gbxAddAProducts.TabIndex = 7;
            this.gbxAddAProducts.TabStop = false;
            this.gbxAddAProducts.Text = "Add A Product";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(160, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 27);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxUpdateAProducts
            // 
            this.gbxUpdateAProducts.Controls.Add(this.btnUpdate);
            this.gbxUpdateAProducts.Controls.Add(this.tbxUpdateName);
            this.gbxUpdateAProducts.Controls.Add(this.tbxUpdateStock);
            this.gbxUpdateAProducts.Controls.Add(this.lblUpdateName);
            this.gbxUpdateAProducts.Controls.Add(this.tbxUpdateUnitPrice);
            this.gbxUpdateAProducts.Controls.Add(this.labelUpdateUnitPrice);
            this.gbxUpdateAProducts.Controls.Add(this.lblUpdateStock);
            this.gbxUpdateAProducts.Location = new System.Drawing.Point(623, 328);
            this.gbxUpdateAProducts.Name = "gbxUpdateAProducts";
            this.gbxUpdateAProducts.Size = new System.Drawing.Size(361, 235);
            this.gbxUpdateAProducts.TabIndex = 8;
            this.gbxUpdateAProducts.TabStop = false;
            this.gbxUpdateAProducts.Text = "Update A Product";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(160, 172);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 27);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Location = new System.Drawing.Point(160, 44);
            this.tbxUpdateName.Name = "tbxUpdateName";
            this.tbxUpdateName.Size = new System.Drawing.Size(131, 22);
            this.tbxUpdateName.TabIndex = 4;
            // 
            // tbxUpdateStock
            // 
            this.tbxUpdateStock.Location = new System.Drawing.Point(160, 134);
            this.tbxUpdateStock.Name = "tbxUpdateStock";
            this.tbxUpdateStock.Size = new System.Drawing.Size(131, 22);
            this.tbxUpdateStock.TabIndex = 6;
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Location = new System.Drawing.Point(24, 47);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(45, 17);
            this.lblUpdateName.TabIndex = 1;
            this.lblUpdateName.Text = "Name";
            // 
            // tbxUpdateUnitPrice
            // 
            this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(160, 88);
            this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(131, 22);
            this.tbxUpdateUnitPrice.TabIndex = 5;
            // 
            // labelUpdateUnitPrice
            // 
            this.labelUpdateUnitPrice.AutoSize = true;
            this.labelUpdateUnitPrice.Location = new System.Drawing.Point(24, 89);
            this.labelUpdateUnitPrice.Name = "labelUpdateUnitPrice";
            this.labelUpdateUnitPrice.Size = new System.Drawing.Size(69, 17);
            this.labelUpdateUnitPrice.TabIndex = 2;
            this.labelUpdateUnitPrice.Text = "Unit Price";
            // 
            // lblUpdateStock
            // 
            this.lblUpdateStock.AutoSize = true;
            this.lblUpdateStock.Location = new System.Drawing.Point(24, 137);
            this.lblUpdateStock.Name = "lblUpdateStock";
            this.lblUpdateStock.Size = new System.Drawing.Size(95, 17);
            this.lblUpdateStock.TabIndex = 3;
            this.lblUpdateStock.Text = "Stock Amount";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(452, 500);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(131, 27);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 592);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdateAProducts);
            this.Controls.Add(this.gbxAddAProducts);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxAddAProducts.ResumeLayout(false);
            this.gbxAddAProducts.PerformLayout();
            this.gbxUpdateAProducts.ResumeLayout(false);
            this.gbxUpdateAProducts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.GroupBox gbxAddAProducts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxUpdateAProducts;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUpdateName;
        private System.Windows.Forms.TextBox tbxUpdateStock;
        private System.Windows.Forms.Label lblUpdateName;
        private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
        private System.Windows.Forms.Label labelUpdateUnitPrice;
        private System.Windows.Forms.Label lblUpdateStock;
        private System.Windows.Forms.Button btnRemove;
    }
}

