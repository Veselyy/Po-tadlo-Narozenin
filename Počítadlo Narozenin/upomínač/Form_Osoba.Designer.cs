namespace upomínač
{
    partial class Form_Osoba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Osoba));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker_narozeniny = new System.Windows.Forms.DateTimePicker();
            this.textBox_jmeno = new System.Windows.Forms.TextBox();
            this.label_datumnarozeni = new System.Windows.Forms.Label();
            this.label_jmeno = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker_narozeniny
            // 
            this.dateTimePicker_narozeniny.Location = new System.Drawing.Point(126, 211);
            this.dateTimePicker_narozeniny.Name = "dateTimePicker_narozeniny";
            this.dateTimePicker_narozeniny.Size = new System.Drawing.Size(185, 23);
            this.dateTimePicker_narozeniny.TabIndex = 10;
            // 
            // textBox_jmeno
            // 
            this.textBox_jmeno.Location = new System.Drawing.Point(126, 169);
            this.textBox_jmeno.Name = "textBox_jmeno";
            this.textBox_jmeno.Size = new System.Drawing.Size(185, 23);
            this.textBox_jmeno.TabIndex = 9;
            // 
            // label_datumnarozeni
            // 
            this.label_datumnarozeni.AutoSize = true;
            this.label_datumnarozeni.Location = new System.Drawing.Point(17, 217);
            this.label_datumnarozeni.Name = "label_datumnarozeni";
            this.label_datumnarozeni.Size = new System.Drawing.Size(91, 15);
            this.label_datumnarozeni.TabIndex = 8;
            this.label_datumnarozeni.Text = "Datum narození";
            // 
            // label_jmeno
            // 
            this.label_jmeno.AutoSize = true;
            this.label_jmeno.Location = new System.Drawing.Point(17, 172);
            this.label_jmeno.Name = "label_jmeno";
            this.label_jmeno.Size = new System.Drawing.Size(42, 15);
            this.label_jmeno.TabIndex = 7;
            this.label_jmeno.Text = "Jméno";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(120, 271);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 6;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // Form_Osoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker_narozeniny);
            this.Controls.Add(this.textBox_jmeno);
            this.Controls.Add(this.label_datumnarozeni);
            this.Controls.Add(this.label_jmeno);
            this.Controls.Add(this.button_ok);
            this.Name = "Form_Osoba";
            this.Text = "Form_Osoba";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker_narozeniny;
        private TextBox textBox_jmeno;
        private Label label_datumnarozeni;
        private Label label_jmeno;
        private Button button_ok;
    }
}