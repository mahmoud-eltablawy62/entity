namespace posts
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
            dgv = new DataGridView();
            title_lbl = new Label();
            desc_lbl = new Label();
            txt_title = new TextBox();
            txt_desc = new TextBox();
            btn_add = new Button();
            btn_update = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(-20, 220);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(591, 232);
            dgv.TabIndex = 0;
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.Location = new Point(64, 32);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(35, 20);
            title_lbl.TabIndex = 1;
            title_lbl.Text = "title";
            // 
            // desc_lbl
            // 
            desc_lbl.AutoSize = true;
            desc_lbl.Location = new Point(64, 80);
            desc_lbl.Name = "desc_lbl";
            desc_lbl.Size = new Size(87, 20);
            desc_lbl.TabIndex = 2;
            desc_lbl.Text = "descrabtion";
            // 
            // txt_title
            // 
            txt_title.Location = new Point(208, 34);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(125, 27);
            txt_title.TabIndex = 3;
            // 
            // txt_desc
            // 
            txt_desc.Location = new Point(208, 80);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(125, 27);
            txt_desc.TabIndex = 4;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(45, 164);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 5;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(154, 164);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 6;
            btn_update.Text = "delete";
            btn_update.UseVisualStyleBackColor = true;
     
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 450);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(txt_desc);
            Controls.Add(txt_title);
            Controls.Add(desc_lbl);
            Controls.Add(title_lbl);
            Controls.Add(dgv);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Label title_lbl;
        private Label desc_lbl;
        private TextBox txt_title;
        private TextBox txt_desc;
        private Button btn_add;
        private Button btn_update;
    }
}