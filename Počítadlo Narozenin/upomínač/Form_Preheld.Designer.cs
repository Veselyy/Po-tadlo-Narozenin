namespace upomínač
{
    partial class Form_Prehled
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
            this.button_odebrat = new System.Windows.Forms.Button();
            this.listBox_osoby = new System.Windows.Forms.ListBox();
            this.label_dnes = new System.Windows.Forms.Label();
            this.monthCalendar_narozeniny = new System.Windows.Forms.MonthCalendar();
            this.button_pridat = new System.Windows.Forms.Button();
            this.label_narozeniny = new System.Windows.Forms.Label();
            this.label_vek = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_odebrat
            // 
            this.button_odebrat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_odebrat.Image = global::upomínač.Properties.Resources.odebrat;
            this.button_odebrat.Location = new System.Drawing.Point(221, 317);
            this.button_odebrat.Name = "button_odebrat";
            this.button_odebrat.Size = new System.Drawing.Size(94, 43);
            this.button_odebrat.TabIndex = 24;
            this.button_odebrat.Text = "Odebrat";
            this.button_odebrat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_odebrat.UseVisualStyleBackColor = true;
            this.button_odebrat.Click += new System.EventHandler(this.button_odebrat_Click);
            // 
            // listBox_osoby
            // 
            this.listBox_osoby.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_osoby.FormattingEnabled = true;
            this.listBox_osoby.ItemHeight = 15;
            this.listBox_osoby.Location = new System.Drawing.Point(15, 83);
            this.listBox_osoby.Name = "listBox_osoby";
            this.listBox_osoby.Size = new System.Drawing.Size(125, 214);
            this.listBox_osoby.Sorted = true;
            this.listBox_osoby.TabIndex = 23;
            this.listBox_osoby.SelectedIndexChanged += new System.EventHandler(this.listBox_osoby_SelectedIndexChanged);
            // 
            // label_dnes
            // 
            this.label_dnes.AutoSize = true;
            this.label_dnes.Location = new System.Drawing.Point(175, 35);
            this.label_dnes.Name = "label_dnes";
            this.label_dnes.Size = new System.Drawing.Size(0, 15);
            this.label_dnes.TabIndex = 22;
            // 
            // monthCalendar_narozeniny
            // 
            this.monthCalendar_narozeniny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar_narozeniny.Enabled = false;
            this.monthCalendar_narozeniny.Location = new System.Drawing.Point(175, 133);
            this.monthCalendar_narozeniny.MaxSelectionCount = 1;
            this.monthCalendar_narozeniny.Name = "monthCalendar_narozeniny";
            this.monthCalendar_narozeniny.ShowToday = false;
            this.monthCalendar_narozeniny.TabIndex = 21;
            // 
            // button_pridat
            // 
            this.button_pridat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_pridat.Image = global::upomínač.Properties.Resources.přidat;
            this.button_pridat.Location = new System.Drawing.Point(89, 317);
            this.button_pridat.Name = "button_pridat";
            this.button_pridat.Size = new System.Drawing.Size(94, 43);
            this.button_pridat.TabIndex = 20;
            this.button_pridat.Text = "Přidat";
            this.button_pridat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_pridat.UseVisualStyleBackColor = true;
            this.button_pridat.Click += new System.EventHandler(this.button_pridat_Click);
            // 
            // label_narozeniny
            // 
            this.label_narozeniny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_narozeniny.AutoSize = true;
            this.label_narozeniny.Location = new System.Drawing.Point(258, 83);
            this.label_narozeniny.Name = "label_narozeniny";
            this.label_narozeniny.Size = new System.Drawing.Size(0, 15);
            this.label_narozeniny.TabIndex = 19;
            // 
            // label_vek
            // 
            this.label_vek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_vek.AutoSize = true;
            this.label_vek.Location = new System.Drawing.Point(258, 108);
            this.label_vek.Name = "label_vek";
            this.label_vek.Size = new System.Drawing.Size(0, 15);
            this.label_vek.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Věk:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Narozeniny:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dnes je";
            // 
            // Form_Prehled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 394);
            this.Controls.Add(this.button_odebrat);
            this.Controls.Add(this.listBox_osoby);
            this.Controls.Add(this.label_dnes);
            this.Controls.Add(this.monthCalendar_narozeniny);
            this.Controls.Add(this.button_pridat);
            this.Controls.Add(this.label_narozeniny);
            this.Controls.Add(this.label_vek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form_Prehled";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_odebrat;
        private ListBox listBox_osoby;
        private Label label_dnes;
        private MonthCalendar monthCalendar_narozeniny;
        private Button button_pridat;
        private Label label_narozeniny;
        private Label label_vek;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}