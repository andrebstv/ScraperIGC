
namespace ScraperIGC
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_link = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ids = new System.Windows.Forms.TextBox();
            this.bt_puxa_ids = new System.Windows.Forms.Button();
            this.tb_igc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_puxa_igs = new System.Windows.Forms.Button();
            this.escolhe_pasta = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Link base para Scraping";
            // 
            // tb_link
            // 
            this.tb_link.Location = new System.Drawing.Point(15, 26);
            this.tb_link.Name = "tb_link";
            this.tb_link.Size = new System.Drawing.Size(324, 20);
            this.tb_link.TabIndex = 1;
            this.tb_link.Text = "http://xcbrasil.com.br/tracks/world/alltimes/brand:all,cat:0,class:all,xctype:all" +
    ",club:all,pilot:0_0,takeoff:10454&sortOrder=LINEAR_DISTANCE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lista de IDs de Voos";
            // 
            // tb_ids
            // 
            this.tb_ids.Location = new System.Drawing.Point(15, 84);
            this.tb_ids.Multiline = true;
            this.tb_ids.Name = "tb_ids";
            this.tb_ids.Size = new System.Drawing.Size(160, 337);
            this.tb_ids.TabIndex = 3;
            // 
            // bt_puxa_ids
            // 
            this.bt_puxa_ids.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_puxa_ids.FlatAppearance.BorderSize = 0;
            this.bt_puxa_ids.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_puxa_ids.Location = new System.Drawing.Point(345, 25);
            this.bt_puxa_ids.Name = "bt_puxa_ids";
            this.bt_puxa_ids.Size = new System.Drawing.Size(90, 23);
            this.bt_puxa_ids.TabIndex = 4;
            this.bt_puxa_ids.Text = "Puxe IDs!";
            this.bt_puxa_ids.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bt_puxa_ids.UseVisualStyleBackColor = false;
            this.bt_puxa_ids.Click += new System.EventHandler(this.bt_puxa_ids_Click);
            // 
            // tb_igc
            // 
            this.tb_igc.Location = new System.Drawing.Point(302, 84);
            this.tb_igc.Multiline = true;
            this.tb_igc.Name = "tb_igc";
            this.tb_igc.Size = new System.Drawing.Size(474, 337);
            this.tb_igc.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "ArquivoIGC";
            // 
            // bt_puxa_igs
            // 
            this.bt_puxa_igs.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_puxa_igs.FlatAppearance.BorderSize = 0;
            this.bt_puxa_igs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_puxa_igs.Location = new System.Drawing.Point(191, 193);
            this.bt_puxa_igs.Name = "bt_puxa_igs";
            this.bt_puxa_igs.Size = new System.Drawing.Size(90, 57);
            this.bt_puxa_igs.TabIndex = 7;
            this.bt_puxa_igs.Text = "Puxe IGCs ->";
            this.bt_puxa_igs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bt_puxa_igs.UseVisualStyleBackColor = false;
            this.bt_puxa_igs.Click += new System.EventHandler(this.bt_puxa_igs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_puxa_igs);
            this.Controls.Add(this.tb_igc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_puxa_ids);
            this.Controls.Add(this.tb_ids);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_link);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ScraperIGC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_link;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ids;
        private System.Windows.Forms.Button bt_puxa_ids;
        private System.Windows.Forms.TextBox tb_igc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_puxa_igs;
        private System.Windows.Forms.FolderBrowserDialog escolhe_pasta;
    }
}

