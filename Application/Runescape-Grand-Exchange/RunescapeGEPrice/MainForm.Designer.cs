namespace RunescapeGEPrice
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overallaverageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellaverageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyaverageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalprofitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rSItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HighTB = new System.Windows.Forms.NumericUpDown();
            this.LowTB = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PriceRangeMax = new System.Windows.Forms.NumericUpDown();
            this.PriceRangeMin = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ProfitRangeMax = new System.Windows.Forms.NumericUpDown();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.ProfitRangeMin = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.amountTB = new System.Windows.Forms.NumericUpDown();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSItemBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HighTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowTB)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceRangeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceRangeMin)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfitRangeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfitRangeMin)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountTB)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(780, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fletch Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Highest";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lowest";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(780, 356);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(270, 155);
            this.textBox1.TabIndex = 1;
            // 
            // dGV1
            // 
            this.dGV1.AllowUserToAddRows = false;
            this.dGV1.AllowUserToDeleteRows = false;
            this.dGV1.AutoGenerateColumns = false;
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.overallaverageDataGridViewTextBoxColumn,
            this.sellaverageDataGridViewTextBoxColumn,
            this.buyaverageDataGridViewTextBoxColumn,
            this.profitDataGridViewTextBoxColumn,
            this.totalprofitDataGridViewTextBoxColumn});
            this.dGV1.DataSource = this.rSItemBindingSource;
            this.dGV1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGV1.Location = new System.Drawing.Point(12, 12);
            this.dGV1.Name = "dGV1";
            this.dGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV1.Size = new System.Drawing.Size(749, 499);
            this.dGV1.TabIndex = 3;
            this.dGV1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV1_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // overallaverageDataGridViewTextBoxColumn
            // 
            this.overallaverageDataGridViewTextBoxColumn.DataPropertyName = "overall_average";
            this.overallaverageDataGridViewTextBoxColumn.HeaderText = "overall_average";
            this.overallaverageDataGridViewTextBoxColumn.Name = "overallaverageDataGridViewTextBoxColumn";
            // 
            // sellaverageDataGridViewTextBoxColumn
            // 
            this.sellaverageDataGridViewTextBoxColumn.DataPropertyName = "sell_average";
            this.sellaverageDataGridViewTextBoxColumn.HeaderText = "sell_average";
            this.sellaverageDataGridViewTextBoxColumn.Name = "sellaverageDataGridViewTextBoxColumn";
            // 
            // buyaverageDataGridViewTextBoxColumn
            // 
            this.buyaverageDataGridViewTextBoxColumn.DataPropertyName = "buy_average";
            this.buyaverageDataGridViewTextBoxColumn.HeaderText = "buy_average";
            this.buyaverageDataGridViewTextBoxColumn.Name = "buyaverageDataGridViewTextBoxColumn";
            // 
            // profitDataGridViewTextBoxColumn
            // 
            this.profitDataGridViewTextBoxColumn.DataPropertyName = "profit";
            this.profitDataGridViewTextBoxColumn.HeaderText = "profit";
            this.profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
            // 
            // totalprofitDataGridViewTextBoxColumn
            // 
            this.totalprofitDataGridViewTextBoxColumn.DataPropertyName = "total_profit";
            this.totalprofitDataGridViewTextBoxColumn.HeaderText = "total_profit";
            this.totalprofitDataGridViewTextBoxColumn.Name = "totalprofitDataGridViewTextBoxColumn";
            // 
            // rSItemBindingSource
            // 
            this.rSItemBindingSource.DataSource = typeof(RunescapeGEPrice.RSItem);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HighTB);
            this.groupBox1.Controls.Add(this.LowTB);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(780, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 119);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Margin";
            // 
            // HighTB
            // 
            this.HighTB.Location = new System.Drawing.Point(9, 72);
            this.HighTB.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.HighTB.Name = "HighTB";
            this.HighTB.Size = new System.Drawing.Size(100, 20);
            this.HighTB.TabIndex = 6;
            // 
            // LowTB
            // 
            this.LowTB.Location = new System.Drawing.Point(9, 32);
            this.LowTB.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.LowTB.Name = "LowTB";
            this.LowTB.Size = new System.Drawing.Size(100, 20);
            this.LowTB.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(9, 96);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Enable";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PriceRangeMax);
            this.groupBox2.Controls.Add(this.PriceRangeMin);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(932, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 119);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Price Range";
            // 
            // PriceRangeMax
            // 
            this.PriceRangeMax.Location = new System.Drawing.Point(9, 72);
            this.PriceRangeMax.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.PriceRangeMax.Name = "PriceRangeMax";
            this.PriceRangeMax.Size = new System.Drawing.Size(100, 20);
            this.PriceRangeMax.TabIndex = 8;
            // 
            // PriceRangeMin
            // 
            this.PriceRangeMin.Location = new System.Drawing.Point(9, 32);
            this.PriceRangeMin.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.PriceRangeMin.Name = "PriceRangeMin";
            this.PriceRangeMin.Size = new System.Drawing.Size(100, 20);
            this.PriceRangeMin.TabIndex = 8;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 96);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(59, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Enable";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Max";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ProfitRangeMax);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.ProfitRangeMin);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(780, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 119);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Profit Range";
            // 
            // ProfitRangeMax
            // 
            this.ProfitRangeMax.Location = new System.Drawing.Point(9, 72);
            this.ProfitRangeMax.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ProfitRangeMax.Name = "ProfitRangeMax";
            this.ProfitRangeMax.Size = new System.Drawing.Size(100, 20);
            this.ProfitRangeMax.TabIndex = 6;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(9, 96);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(59, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Enable";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // ProfitRangeMin
            // 
            this.ProfitRangeMin.Location = new System.Drawing.Point(9, 32);
            this.ProfitRangeMin.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ProfitRangeMin.Name = "ProfitRangeMin";
            this.ProfitRangeMin.Size = new System.Drawing.Size(100, 20);
            this.ProfitRangeMin.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Max";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.amountTB);
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(932, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(118, 91);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Amount Brought";
            // 
            // amountTB
            // 
            this.amountTB.Location = new System.Drawing.Point(6, 32);
            this.amountTB.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(103, 20);
            this.amountTB.TabIndex = 5;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 68);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(59, 17);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Enable";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(932, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 51);
            this.button2.TabIndex = 8;
            this.button2.Text = "Website";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 545);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dGV1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Lets Flip Engine";
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSItemBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HighTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowTB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceRangeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceRangeMin)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfitRangeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfitRangeMin)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown HighTB;
        private System.Windows.Forms.NumericUpDown LowTB;
        private System.Windows.Forms.NumericUpDown PriceRangeMax;
        private System.Windows.Forms.NumericUpDown PriceRangeMin;
        private System.Windows.Forms.NumericUpDown ProfitRangeMax;
        private System.Windows.Forms.NumericUpDown ProfitRangeMin;
        private System.Windows.Forms.NumericUpDown amountTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overallaverageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellaverageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyaverageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalprofitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rSItemBindingSource;
        private System.Windows.Forms.Button button2;
    }
}

