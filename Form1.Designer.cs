namespace MaBanque_1._0._0
{
    partial class Transaction
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
            panel1 = new Panel();
            label1 = new Label();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox5 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox6 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox7 = new MaterialSkin.Controls.MaterialTextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1433, 93);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(209, 48);
            label1.TabIndex = 0;
            label1.Text = "Ma banque";
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.Hint = "Saisir le matricule de l'etudiant...";
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(27, 132);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(472, 50);
            materialTextBox1.TabIndex = 2;
            materialTextBox1.Tag = "";
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(517, 132);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(237, 54);
            materialButton1.TabIndex = 3;
            materialButton1.Text = "Rechercher";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            materialButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(1096, 682);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(308, 44);
            materialButton2.TabIndex = 4;
            materialButton2.Text = "Valider la transaction";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.BackColor = Color.SteelBlue;
            flowLayoutPanel2.Controls.Add(dataGridView2);
            flowLayoutPanel2.Location = new Point(30, 545);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1377, 125);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(1324, 0);
            dataGridView2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "#id";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "NUMERO COMPTE";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "TYPE";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "FRAIS";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.FillWeight = 250F;
            dataGridViewTextBoxColumn5.HeaderText = "LIBELLE";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 500;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 501);
            label2.Name = "label2";
            label2.Size = new Size(273, 30);
            label2.TabIndex = 5;
            label2.Text = "Historique des transactions";
            // 
            // materialTextBox2
            // 
            materialTextBox2.AnimateReadOnly = false;
            materialTextBox2.BorderStyle = BorderStyle.None;
            materialTextBox2.Depth = 0;
            materialTextBox2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox2.Hint = "Saisir le numero de compte...";
            materialTextBox2.LeadingIcon = null;
            materialTextBox2.Location = new Point(827, 136);
            materialTextBox2.MaxLength = 50;
            materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox2.Multiline = false;
            materialTextBox2.Name = "materialTextBox2";
            materialTextBox2.Size = new Size(311, 50);
            materialTextBox2.TabIndex = 6;
            materialTextBox2.Tag = "";
            materialTextBox2.Text = "";
            materialTextBox2.TrailingIcon = null;
            // 
            // materialButton3
            // 
            materialButton3.AutoSize = false;
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(1167, 128);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(237, 54);
            materialButton3.TabIndex = 7;
            materialButton3.Text = "Rechercher";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            // 
            // materialTextBox3
            // 
            materialTextBox3.AnimateReadOnly = false;
            materialTextBox3.BorderStyle = BorderStyle.None;
            materialTextBox3.Depth = 0;
            materialTextBox3.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox3.Hint = "Saisir le matricule de l'etudiant...";
            materialTextBox3.LeadingIcon = null;
            materialTextBox3.Location = new Point(30, 252);
            materialTextBox3.MaxLength = 50;
            materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox3.Multiline = false;
            materialTextBox3.Name = "materialTextBox3";
            materialTextBox3.Size = new Size(329, 50);
            materialTextBox3.TabIndex = 8;
            materialTextBox3.Tag = "";
            materialTextBox3.Text = "";
            materialTextBox3.TrailingIcon = null;
            // 
            // materialTextBox4
            // 
            materialTextBox4.AnimateReadOnly = false;
            materialTextBox4.BorderStyle = BorderStyle.None;
            materialTextBox4.Depth = 0;
            materialTextBox4.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox4.Hint = "Saisir le matricule de l'etudiant...";
            materialTextBox4.LeadingIcon = null;
            materialTextBox4.Location = new Point(27, 349);
            materialTextBox4.MaxLength = 50;
            materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox4.Multiline = false;
            materialTextBox4.Name = "materialTextBox4";
            materialTextBox4.Size = new Size(332, 50);
            materialTextBox4.TabIndex = 9;
            materialTextBox4.Tag = "";
            materialTextBox4.Text = "";
            materialTextBox4.TrailingIcon = null;
            // 
            // materialTextBox5
            // 
            materialTextBox5.AnimateReadOnly = false;
            materialTextBox5.BorderStyle = BorderStyle.None;
            materialTextBox5.Depth = 0;
            materialTextBox5.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox5.Hint = "Saisir le matricule de l'etudiant...";
            materialTextBox5.LeadingIcon = null;
            materialTextBox5.Location = new Point(422, 252);
            materialTextBox5.MaxLength = 50;
            materialTextBox5.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox5.Multiline = false;
            materialTextBox5.Name = "materialTextBox5";
            materialTextBox5.Size = new Size(332, 50);
            materialTextBox5.TabIndex = 10;
            materialTextBox5.Tag = "";
            materialTextBox5.Text = "";
            materialTextBox5.TrailingIcon = null;
            // 
            // materialTextBox6
            // 
            materialTextBox6.AnimateReadOnly = false;
            materialTextBox6.BorderStyle = BorderStyle.None;
            materialTextBox6.Depth = 0;
            materialTextBox6.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox6.Hint = "Saisir le matricule de l'etudiant...";
            materialTextBox6.LeadingIcon = null;
            materialTextBox6.Location = new Point(422, 349);
            materialTextBox6.MaxLength = 50;
            materialTextBox6.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox6.Multiline = false;
            materialTextBox6.Name = "materialTextBox6";
            materialTextBox6.Size = new Size(332, 50);
            materialTextBox6.TabIndex = 11;
            materialTextBox6.Tag = "";
            materialTextBox6.Text = "";
            materialTextBox6.TrailingIcon = null;
            // 
            // materialTextBox7
            // 
            materialTextBox7.AnimateReadOnly = false;
            materialTextBox7.BorderStyle = BorderStyle.None;
            materialTextBox7.Depth = 0;
            materialTextBox7.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox7.Hint = "Saisir le matricule de l'etudiant...";
            materialTextBox7.LeadingIcon = null;
            materialTextBox7.Location = new Point(836, 252);
            materialTextBox7.MaxLength = 50;
            materialTextBox7.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox7.Multiline = false;
            materialTextBox7.Name = "materialTextBox7";
            materialTextBox7.Size = new Size(568, 50);
            materialTextBox7.TabIndex = 12;
            materialTextBox7.Tag = "";
            materialTextBox7.Text = "";
            materialTextBox7.TrailingIcon = null;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 221);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 14;
            label3.Text = "Nom etudiant";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(422, 221);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 15;
            label4.Text = "Frais à payer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(836, 211);
            label5.Name = "label5";
            label5.Size = new Size(143, 25);
            label5.TabIndex = 16;
            label5.Text = "Montant de frais";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 315);
            label6.Name = "label6";
            label6.Size = new Size(168, 25);
            label6.TabIndex = 17;
            label6.Text = "Numero de compte";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(422, 319);
            label7.Name = "label7";
            label7.Size = new Size(157, 25);
            label7.TabIndex = 18;
            label7.Text = "Intitulé de compte";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(837, 317);
            label8.Name = "label8";
            label8.Size = new Size(101, 25);
            label8.TabIndex = 19;
            label8.Text = "Date valeur";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(836, 365);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(568, 31);
            dateTimePicker1.TabIndex = 20;
            // 
            // materialMultiLineTextBox1
            // 
            materialMultiLineTextBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialMultiLineTextBox1.BorderStyle = BorderStyle.None;
            materialMultiLineTextBox1.Depth = 0;
            materialMultiLineTextBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMultiLineTextBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialMultiLineTextBox1.Hint = "Saisir le libelle de l'operation...";
            materialMultiLineTextBox1.Location = new Point(27, 405);
            materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            materialMultiLineTextBox1.Size = new Size(1377, 73);
            materialMultiLineTextBox1.TabIndex = 21;
            materialMultiLineTextBox1.Text = "";
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 740);
            Controls.Add(materialMultiLineTextBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(materialTextBox7);
            Controls.Add(materialTextBox6);
            Controls.Add(materialTextBox5);
            Controls.Add(materialTextBox4);
            Controls.Add(materialTextBox3);
            Controls.Add(materialButton3);
            Controls.Add(materialTextBox2);
            Controls.Add(label2);
            Controls.Add(materialButton2);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(materialButton1);
            Controls.Add(materialTextBox1);
            Controls.Add(panel1);
            Name = "Transaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transaction";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private FlowLayoutPanel flowLayoutPanel2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label label2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox5;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox6;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox7;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
    }
}