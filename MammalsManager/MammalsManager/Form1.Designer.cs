namespace MammalsManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtPopulation = new TextBox();
            txtLength = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(74, 29);
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 27);
            txtName.TabIndex = 0;
            // 
            // txtPopulation
            // 
            txtPopulation.Location = new Point(74, 72);
            txtPopulation.Name = "txtPopulation";
            txtPopulation.Size = new Size(283, 27);
            txtPopulation.TabIndex = 1;
            // 
            // txtLength
            // 
            txtLength.Location = new Point(74, 116);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(283, 27);
            txtLength.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 36);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 3;
            label1.Text = "Cins Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 79);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "Nüfus:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 123);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 5;
            label3.Text = "Boy:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(393, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(395, 409);
            dataGridView1.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(31, 220);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(93, 59);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "EKLE";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(190, 220);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 59);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "SİL";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(31, 315);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(93, 59);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "YENİLE";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(190, 315);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 59);
            btnSave.TabIndex = 10;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLength);
            Controls.Add(txtPopulation);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";            
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtPopulation;
        private TextBox txtLength;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
    }
}