
namespace WinAppTraductor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Subpanel1 = new System.Windows.Forms.Panel();
            this.btnEsalQ = new System.Windows.Forms.Button();
            this.btnEalI = new System.Windows.Forms.Button();
            this.btnQalE = new System.Windows.Forms.Button();
            this.btnIalE = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.Subpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.Subpanel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 777);
            this.panel1.TabIndex = 0;
            // 
            // Subpanel1
            // 
            this.Subpanel1.Controls.Add(this.btnEsalQ);
            this.Subpanel1.Controls.Add(this.btnEalI);
            this.Subpanel1.Controls.Add(this.btnQalE);
            this.Subpanel1.Controls.Add(this.btnIalE);
            this.Subpanel1.Location = new System.Drawing.Point(10, 197);
            this.Subpanel1.Name = "Subpanel1";
            this.Subpanel1.Size = new System.Drawing.Size(237, 422);
            this.Subpanel1.TabIndex = 5;
            // 
            // btnEsalQ
            // 
            this.btnEsalQ.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEsalQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsalQ.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsalQ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEsalQ.Location = new System.Drawing.Point(2, 321);
            this.btnEsalQ.Name = "btnEsalQ";
            this.btnEsalQ.Size = new System.Drawing.Size(232, 75);
            this.btnEsalQ.TabIndex = 8;
            this.btnEsalQ.Text = "&4. Español 🠮 Quichua";
            this.btnEsalQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEsalQ.UseVisualStyleBackColor = false;
            this.btnEsalQ.Click += new System.EventHandler(this.btnEsalQ_Click);
            // 
            // btnEalI
            // 
            this.btnEalI.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEalI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEalI.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEalI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEalI.Location = new System.Drawing.Point(0, 120);
            this.btnEalI.Name = "btnEalI";
            this.btnEalI.Size = new System.Drawing.Size(234, 85);
            this.btnEalI.TabIndex = 6;
            this.btnEalI.Text = "&2. Español 🠮 Inglés";
            this.btnEalI.UseVisualStyleBackColor = false;
            this.btnEalI.Click += new System.EventHandler(this.btnEalI_Click);
            // 
            // btnQalE
            // 
            this.btnQalE.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQalE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQalE.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQalE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQalE.Location = new System.Drawing.Point(2, 222);
            this.btnQalE.Name = "btnQalE";
            this.btnQalE.Size = new System.Drawing.Size(232, 86);
            this.btnQalE.TabIndex = 7;
            this.btnQalE.Text = "&3. Quichua 🠮 Español";
            this.btnQalE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQalE.UseVisualStyleBackColor = false;
            this.btnQalE.Click += new System.EventHandler(this.btnQalE_Click);
            // 
            // btnIalE
            // 
            this.btnIalE.BackColor = System.Drawing.Color.SteelBlue;
            this.btnIalE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIalE.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIalE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIalE.Location = new System.Drawing.Point(2, 20);
            this.btnIalE.Name = "btnIalE";
            this.btnIalE.Size = new System.Drawing.Size(232, 83);
            this.btnIalE.TabIndex = 5;
            this.btnIalE.Text = "&1. Inglés 🠮 Español";
            this.btnIalE.UseVisualStyleBackColor = false;
            this.btnIalE.Click += new System.EventHandler(this.btnIalE_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(258, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 895);
            this.panel2.TabIndex = 1;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Black;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.btn_salir.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_salir.Image = global::WinAppTraductor.Properties.Resources.icon_Power;
            this.btn_salir.Location = new System.Drawing.Point(82, 654);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(89, 83);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinAppTraductor.Properties.Resources.traductor1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 777);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.Subpanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Subpanel1;
        private System.Windows.Forms.Button btnEsalQ;
        private System.Windows.Forms.Button btnEalI;
        private System.Windows.Forms.Button btnQalE;
        private System.Windows.Forms.Button btnIalE;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_salir;
    }
}

