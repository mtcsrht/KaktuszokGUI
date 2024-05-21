namespace KaktuszokGUI
{
    partial class FrmMain
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
            dgvCactus = new DataGridView();
            btnDelete = new Button();
            id = new DataGridViewTextBoxColumn();
            koznapi_nev = new DataGridViewTextBoxColumn();
            vizigeny = new DataGridViewTextBoxColumn();
            fenyigeny = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCactus).BeginInit();
            SuspendLayout();
            // 
            // dgvCactus
            // 
            dgvCactus.AllowUserToAddRows = false;
            dgvCactus.AllowUserToDeleteRows = false;
            dgvCactus.AllowUserToResizeColumns = false;
            dgvCactus.AllowUserToResizeRows = false;
            dgvCactus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvCactus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCactus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCactus.Columns.AddRange(new DataGridViewColumn[] { id, koznapi_nev, vizigeny, fenyigeny });
            dgvCactus.Location = new Point(12, 12);
            dgvCactus.Name = "dgvCactus";
            dgvCactus.RowHeadersVisible = false;
            dgvCactus.RowTemplate.Height = 25;
            dgvCactus.Size = new Size(776, 340);
            dgvCactus.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(12, 367);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(776, 71);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Törlés";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // id
            // 
            id.FillWeight = 20.30457F;
            id.HeaderText = "ID";
            id.Name = "id";
            // 
            // koznapi_nev
            // 
            koznapi_nev.FillWeight = 126.56514F;
            koznapi_nev.HeaderText = "Köznapi név";
            koznapi_nev.Name = "koznapi_nev";
            // 
            // vizigeny
            // 
            vizigeny.FillWeight = 126.56514F;
            vizigeny.HeaderText = "Vízigény";
            vizigeny.Name = "vizigeny";
            // 
            // fenyigeny
            // 
            fenyigeny.FillWeight = 126.56514F;
            fenyigeny.HeaderText = "Fényigény";
            fenyigeny.Name = "fenyigeny";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(dgvCactus);
            Name = "FrmMain";
            Text = "Kaktuszok";
            ((System.ComponentModel.ISupportInitialize)dgvCactus).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCactus;
        private Button btnDelete;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn koznapi_nev;
        private DataGridViewTextBoxColumn vizigeny;
        private DataGridViewTextBoxColumn fenyigeny;
    }
}
