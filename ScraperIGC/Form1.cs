using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace ScraperIGC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_puxa_ids_Click(object sender, EventArgs e)
        {
            WebClient leitorweb = new WebClient();
            String htmlCode = leitorweb.DownloadString(tb_link.Text);
            String[] ocorrencias;
            String separador = "href='/flight/";
            // Split de strings: https://stackoverflow.com/questions/2245442/split-a-string-by-another-string-in-c-sharp
            ocorrencias = htmlCode.Split(new String[] { separador }, StringSplitOptions.None);
            for (int i = 1; i< ocorrencias.Length -3; i++) //https://stackoverflow.com/questions/16512161/using-a-foreach-loop-with-stringarray-in-c-sharp
            {
                tb_ids.Text += ocorrencias[i].Split('\'')[0] + "\r\n";
            }                     
        }

        private void bt_puxa_igs_Click(object sender, EventArgs e)
        {
            String[] igcs;
            igcs = tb_ids.Text.Split(new String[] { "\r\n" }, StringSplitOptions.None);
            WebClient leitorigc = new WebClient();
            String link;
            link = "http://xcbrasil.com.br/flight/" + igcs[0] + "/igc/&lang=brazilian&w=2&c=FFFFFF&an=2";
            tb_igc.Text = leitorigc.DownloadString(link);

            DialogResult result = escolhe_pasta.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(escolhe_pasta.SelectedPath))
            {
                int i = 0;
                foreach (string s_igc in igcs)
                {
                    i++;
                    link = "http://xcbrasil.com.br/flight/" + s_igc + "/igc/&lang=brazilian&w=2&c=FFFFFF&an=2";
                    File.WriteAllText(escolhe_pasta.SelectedPath + '\\' + "arquivo" + i + ".igc", leitorigc.DownloadString(link));
                }
            }

        }
    }
}
