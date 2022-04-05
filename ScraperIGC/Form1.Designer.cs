
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
            this.bt_abre_igc = new System.Windows.Forms.Button();
            this.abridorIGCs = new System.Windows.Forms.OpenFileDialog();
            this.lb_termais = new System.Windows.Forms.Label();
            this.tb_vel_term = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_tempo_analise = new System.Windows.Forms.TextBox();
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
            this.tb_igc.Size = new System.Drawing.Size(376, 337);
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
            // bt_abre_igc
            // 
            this.bt_abre_igc.BackColor = System.Drawing.SystemColors.Control;
            this.bt_abre_igc.BackgroundImage = global::ScraperIGC.Properties.Resources.pngwing_com;
            this.bt_abre_igc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_abre_igc.FlatAppearance.BorderSize = 0;
            this.bt_abre_igc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_abre_igc.Location = new System.Drawing.Point(697, 84);
            this.bt_abre_igc.Name = "bt_abre_igc";
            this.bt_abre_igc.Size = new System.Drawing.Size(95, 80);
            this.bt_abre_igc.TabIndex = 8;
            this.bt_abre_igc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bt_abre_igc.UseVisualStyleBackColor = false;
            this.bt_abre_igc.Click += new System.EventHandler(this.bt_abre_igc_Click);
            // 
            // abridorIGCs
            // 
            this.abridorIGCs.Filter = "Arquivos IGC (*.igc)|*.igc";
            this.abridorIGCs.Multiselect = true;
            // 
            // lb_termais
            // 
            this.lb_termais.AutoSize = true;
            this.lb_termais.Location = new System.Drawing.Point(697, 181);
            this.lb_termais.Name = "lb_termais";
            this.lb_termais.Size = new System.Drawing.Size(47, 13);
            this.lb_termais.TabIndex = 9;
            this.lb_termais.Text = "Termais:";
            this.lb_termais.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_vel_term
            // 
            this.tb_vel_term.Location = new System.Drawing.Point(795, 210);
            this.tb_vel_term.Name = "tb_vel_term";
            this.tb_vel_term.Size = new System.Drawing.Size(27, 20);
            this.tb_vel_term.TabIndex = 10;
            this.tb_vel_term.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(697, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Valor Minimo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(822, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "m/s";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(822, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "s";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(691, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tempo Analise";
            // 
            // tb_tempo_analise
            // 
            this.tb_tempo_analise.Location = new System.Drawing.Point(795, 234);
            this.tb_tempo_analise.Name = "tb_tempo_analise";
            this.tb_tempo_analise.Size = new System.Drawing.Size(27, 20);
            this.tb_tempo_analise.TabIndex = 13;
            this.tb_tempo_analise.Text = "30";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_tempo_analise);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_vel_term);
            this.Controls.Add(this.lb_termais);
            this.Controls.Add(this.bt_abre_igc);
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
        private System.Windows.Forms.Button bt_abre_igc;
        private System.Windows.Forms.OpenFileDialog abridorIGCs;
        private System.Windows.Forms.Label lb_termais;
        private System.Windows.Forms.TextBox tb_vel_term;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_tempo_analise;
    }
}

