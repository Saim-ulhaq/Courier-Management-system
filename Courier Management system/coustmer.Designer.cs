namespace Courier_Management_system
{
    partial class coustmer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coustmer));
            this.textid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button77 = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.textcname = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.Label();
            this.button79 = new System.Windows.Forms.Button();
            this.button78 = new System.Windows.Forms.Button();
            this.dataGridView56 = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label51 = new System.Windows.Forms.Label();
            this.textadress = new System.Windows.Forms.Label();
            this.textcaddress = new System.Windows.Forms.TextBox();
            this.textphone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView56)).BeginInit();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(16, 327);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(92, 20);
            this.textid.TabIndex = 136;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 135;
            this.label2.Text = "CoustmerId:";
            // 
            // button77
            // 
            this.button77.BackColor = System.Drawing.Color.Red;
            this.button77.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button77.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button77.Location = new System.Drawing.Point(176, 386);
            this.button77.Name = "button77";
            this.button77.Size = new System.Drawing.Size(75, 33);
            this.button77.TabIndex = 134;
            this.button77.Text = "Save";
            this.button77.UseVisualStyleBackColor = false;
            this.button77.Click += new System.EventHandler(this.button77_Click);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(577, 327);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(127, 20);
            this.Email.TabIndex = 133;
            // 
            // textcname
            // 
            this.textcname.Location = new System.Drawing.Point(144, 327);
            this.textcname.Name = "textcname";
            this.textcname.Size = new System.Drawing.Size(133, 20);
            this.textcname.TabIndex = 132;
            this.textcname.TextChanged += new System.EventHandler(this.SName_TextChanged);
            // 
            // textemail
            // 
            this.textemail.AutoSize = true;
            this.textemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textemail.Location = new System.Drawing.Point(573, 304);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(85, 20);
            this.textemail.TabIndex = 131;
            this.textemail.Text = "CustEmail:";
            // 
            // textname
            // 
            this.textname.AutoSize = true;
            this.textname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textname.ForeColor = System.Drawing.Color.DarkGreen;
            this.textname.Location = new System.Drawing.Point(140, 304);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(88, 20);
            this.textname.TabIndex = 130;
            this.textname.Text = "CustName:";
            // 
            // button79
            // 
            this.button79.BackColor = System.Drawing.Color.Red;
            this.button79.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button79.ForeColor = System.Drawing.Color.Ivory;
            this.button79.Location = new System.Drawing.Point(514, 386);
            this.button79.Name = "button79";
            this.button79.Size = new System.Drawing.Size(75, 33);
            this.button79.TabIndex = 129;
            this.button79.Text = "Delete";
            this.button79.UseVisualStyleBackColor = false;
            this.button79.Click += new System.EventHandler(this.button79_Click_1);
            // 
            // button78
            // 
            this.button78.BackColor = System.Drawing.Color.Red;
            this.button78.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button78.ForeColor = System.Drawing.Color.Ivory;
            this.button78.Location = new System.Drawing.Point(331, 386);
            this.button78.Name = "button78";
            this.button78.Size = new System.Drawing.Size(85, 33);
            this.button78.TabIndex = 128;
            this.button78.Text = "Update";
            this.button78.UseVisualStyleBackColor = false;
            this.button78.Click += new System.EventHandler(this.button78_Click);
            // 
            // dataGridView56
            // 
            this.dataGridView56.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView56.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView56.Location = new System.Drawing.Point(0, 58);
            this.dataGridView56.Name = "dataGridView56";
            this.dataGridView56.Size = new System.Drawing.Size(720, 215);
            this.dataGridView56.TabIndex = 127;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Controls.Add(this.label51);
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(730, 52);
            this.panel12.TabIndex = 126;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label51.Location = new System.Drawing.Point(307, 18);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(99, 24);
            this.label51.TabIndex = 0;
            this.label51.Text = "Coustmer";
            this.label51.Click += new System.EventHandler(this.label51_Click);
            // 
            // textadress
            // 
            this.textadress.AutoSize = true;
            this.textadress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textadress.Location = new System.Drawing.Point(316, 304);
            this.textadress.Name = "textadress";
            this.textadress.Size = new System.Drawing.Size(59, 20);
            this.textadress.TabIndex = 137;
            this.textadress.Text = "Adress";
            // 
            // textcaddress
            // 
            this.textcaddress.Location = new System.Drawing.Point(303, 327);
            this.textcaddress.Name = "textcaddress";
            this.textcaddress.Size = new System.Drawing.Size(148, 20);
            this.textcaddress.TabIndex = 138;
            // 
            // textphone
            // 
            this.textphone.Location = new System.Drawing.Point(462, 326);
            this.textphone.Name = "textphone";
            this.textphone.Size = new System.Drawing.Size(100, 20);
            this.textphone.TabIndex = 139;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(462, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 140;
            this.label5.Text = "Phoneno";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(272, 463);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(52, 50);
            this.pictureBox6.TabIndex = 146;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(564, 455);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.TabIndex = 145;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(464, 455);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 50);
            this.pictureBox4.TabIndex = 144;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(363, 455);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 50);
            this.pictureBox3.TabIndex = 143;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(187, 466);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 50);
            this.pictureBox2.TabIndex = 142;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 466);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 47);
            this.pictureBox1.TabIndex = 141;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // coustmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 515);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textphone);
            this.Controls.Add(this.textcaddress);
            this.Controls.Add(this.textadress);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button77);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.textcname);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.button79);
            this.Controls.Add(this.button78);
            this.Controls.Add(this.dataGridView56);
            this.Controls.Add(this.panel12);
            this.Name = "coustmer";
            this.Text = "coustmer";
            this.Load += new System.EventHandler(this.coustmer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView56)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button77;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox textcname;
        private System.Windows.Forms.Label textemail;
        private System.Windows.Forms.Label textname;
        private System.Windows.Forms.Button button79;
        private System.Windows.Forms.Button button78;
        private System.Windows.Forms.DataGridView dataGridView56;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label textadress;
        private System.Windows.Forms.TextBox textcaddress;
        private System.Windows.Forms.TextBox textphone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}