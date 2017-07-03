namespace POSoftware
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataTB = new System.Windows.Forms.TextBox();
            this.razaoTB = new System.Windows.Forms.TextBox();
            this.obsTB = new System.Windows.Forms.TextBox();
            this.historicoGV = new System.Windows.Forms.DataGridView();
            this.pagamentoCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cnpjTB = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.filterCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.filterData = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(3, 32);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(820, 200);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.TabStop = false;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 70;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(87, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 50;
            this.button3.Text = "Inserir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataTB
            // 
            this.dataTB.Location = new System.Drawing.Point(225, 256);
            this.dataTB.Name = "dataTB";
            this.dataTB.ReadOnly = true;
            this.dataTB.Size = new System.Drawing.Size(210, 20);
            this.dataTB.TabIndex = 2;
            this.dataTB.TabStop = false;
            // 
            // razaoTB
            // 
            this.razaoTB.Location = new System.Drawing.Point(5, 298);
            this.razaoTB.Name = "razaoTB";
            this.razaoTB.Size = new System.Drawing.Size(430, 20);
            this.razaoTB.TabIndex = 3;
            // 
            // obsTB
            // 
            this.obsTB.Location = new System.Drawing.Point(5, 340);
            this.obsTB.Name = "obsTB";
            this.obsTB.Size = new System.Drawing.Size(430, 20);
            this.obsTB.TabIndex = 4;
            // 
            // historicoGV
            // 
            this.historicoGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historicoGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.historicoGV.Location = new System.Drawing.Point(443, 255);
            this.historicoGV.Name = "historicoGV";
            this.historicoGV.RowHeadersVisible = false;
            this.historicoGV.Size = new System.Drawing.Size(380, 177);
            this.historicoGV.TabIndex = 9;
            this.historicoGV.TabStop = false;
            // 
            // pagamentoCB
            // 
            this.pagamentoCB.FormattingEnabled = true;
            this.pagamentoCB.Items.AddRange(new object[] {
            "Dinheiro",
            "Credito",
            "Cheque",
            "Mixed"});
            this.pagamentoCB.Location = new System.Drawing.Point(305, 381);
            this.pagamentoCB.Name = "pagamentoCB";
            this.pagamentoCB.Size = new System.Drawing.Size(130, 21);
            this.pagamentoCB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "CNPJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Razao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pagamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Observacao";
            // 
            // cnpjTB
            // 
            this.cnpjTB.Location = new System.Drawing.Point(5, 255);
            this.cnpjTB.Mask = "00000000000000";
            this.cnpjTB.Name = "cnpjTB";
            this.cnpjTB.Size = new System.Drawing.Size(215, 20);
            this.cnpjTB.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(168, 409);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 60;
            this.button4.Text = "Salvar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // filterCNPJ
            // 
            this.filterCNPJ.Location = new System.Drawing.Point(355, 8);
            this.filterCNPJ.Mask = "00000000000000";
            this.filterCNPJ.Name = "filterCNPJ";
            this.filterCNPJ.Size = new System.Drawing.Size(215, 20);
            this.filterCNPJ.TabIndex = 66;
            this.filterCNPJ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "CNPJ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Data";
            // 
            // filterData
            // 
            this.filterData.Location = new System.Drawing.Point(614, 8);
            this.filterData.Mask = "00/00/00";
            this.filterData.Name = "filterData";
            this.filterData.Size = new System.Drawing.Size(209, 20);
            this.filterData.TabIndex = 71;
            this.filterData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filterData_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 440);
            this.Controls.Add(this.filterData);
            this.Controls.Add(this.filterCNPJ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cnpjTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pagamentoCB);
            this.Controls.Add(this.historicoGV);
            this.Controls.Add(this.obsTB);
            this.Controls.Add(this.razaoTB);
            this.Controls.Add(this.dataTB);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "POSoftware";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox dataTB;
        private System.Windows.Forms.TextBox razaoTB;
        private System.Windows.Forms.TextBox obsTB;
        private System.Windows.Forms.DataGridView historicoGV;
        private System.Windows.Forms.ComboBox pagamentoCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox cnpjTB;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MaskedTextBox filterCNPJ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox filterData;
    }
}

