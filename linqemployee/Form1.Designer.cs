
namespace linqemployee
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
            this.name_txtbx = new System.Windows.Forms.TextBox();
            this.city_txtbx = new System.Windows.Forms.TextBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_txtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // name_txtbx
            // 
            this.name_txtbx.Location = new System.Drawing.Point(91, 19);
            this.name_txtbx.Name = "name_txtbx";
            this.name_txtbx.Size = new System.Drawing.Size(100, 20);
            this.name_txtbx.TabIndex = 0;
            // 
            // city_txtbx
            // 
            this.city_txtbx.Location = new System.Drawing.Point(91, 61);
            this.city_txtbx.Name = "city_txtbx";
            this.city_txtbx.Size = new System.Drawing.Size(100, 20);
            this.city_txtbx.TabIndex = 1;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(91, 186);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(91, 139);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "City";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(201, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(379, 436);
            this.dataGridView1.TabIndex = 6;
            // 
            // id_txtbx
            // 
            this.id_txtbx.Location = new System.Drawing.Point(91, 104);
            this.id_txtbx.Name = "id_txtbx";
            this.id_txtbx.Size = new System.Drawing.Size(39, 20);
            this.id_txtbx.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Id";
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(91, 227);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 9;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(91, 268);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 10;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "R";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.add_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id_txtbx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.city_txtbx);
            this.Controls.Add(this.name_txtbx);
            this.Name = "Form1";
            this.Text = "Employee Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_txtbx;
        private System.Windows.Forms.TextBox city_txtbx;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox id_txtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button button5;
    }
}

