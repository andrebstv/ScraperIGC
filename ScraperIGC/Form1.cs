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
using System.Text.RegularExpressions;

namespace ScraperIGC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public class Waypoint
        {
            public Waypoint() 
            {
                this.hora = new DateTime();
                this.latitude = new Coordenada();
                this.longitude = new Coordenada();
            }
            public DateTime hora;
            public Coordenada latitude;
            public Coordenada longitude;
            public float altura;

        }
        public class Coordenada
        {
            public int graus;
            public float minutos;
            public Coordenada()
            {
                graus = 0;
                minutos = 0;
            }
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

        private void bt_abre_igc_Click(object sender, EventArgs e)
        {
            string resultado = "name,code,country,lat,lon,elev,style,rwdir,rwlen,freq,desc\r\n";
            if (abridorIGCs.ShowDialog() == DialogResult.OK)
            {
                //tb_igc.Clear();
                int count_termais = 0;
                foreach (string arquivo in abridorIGCs.FileNames)
                {
                    tb_igc.Text = System.IO.File.ReadAllText(arquivo);
                    Regex rx = new Regex(@"B(\d{13})(\w{1}\d{8})(\w{2}\d{10})", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    MatchCollection linhasB = rx.Matches(tb_igc.Text);
                    int i = 0;
                    Waypoint[] termais = new Waypoint[2000];
                    Waypoint[] linhas = new Waypoint[int.Parse(tb_tempo_analise.Text)];
                    //B151230-1954998S-04028313-WA-00765-00816-39
                    bool flag_termal = true;
                    foreach (Match registros in linhasB)
                    {
                        linhas[i] = new Waypoint();
                        linhas[i].hora = new DateTime(2010, 1, 1, int.Parse(registros.ToString().Substring(1, 2)),
                                                                  int.Parse(registros.ToString().Substring(3, 2)),
                                                                  int.Parse(registros.ToString().Substring(5, 2)));

                        linhas[i].latitude.graus = int.Parse(registros.ToString().Substring(7, 2));
                        linhas[i].latitude.minutos = float.Parse(registros.ToString().Substring(9, 5))/(float)1000.0;

                        linhas[i].longitude.graus = int.Parse(registros.ToString().Substring(15, 3));
                        linhas[i].longitude.minutos = float.Parse(registros.ToString().Substring(18, 5)) / (float)1000.0;

                        linhas[i].altura = int.Parse(registros.ToString().Substring(25, 5));
                        if (((i % int.Parse(tb_tempo_analise.Text)) == 0) && i > 0)
                        {
                            if (((linhas[i].altura - linhas[i - 5].altura) > 7) && (flag_termal))
                            {
                                termais[count_termais] = linhas[i - 1];
                                count_termais++;
                                flag_termal = false; //Impede um novo registro.
                            }
                            else if ((linhas[i].altura - linhas[i - 5].altura) < 7)
                            {
                                flag_termal = true;
                            }
                        }
                        i++;
                        if (i > 10) i = 0;
                    }
                    //tb_igc.Clear();
                    for (int j = 0; j < count_termais; j++)
                    {

                        resultado = resultado + "T" + j + ",T" + j + ",,"
                                    + termais[j].latitude.graus + termais[j].latitude.minutos.ToString("G",System.Globalization.CultureInfo.InvariantCulture) + "S,0"
                                    + termais[j].longitude.graus + termais[j].longitude.minutos.ToString("G", System.Globalization.CultureInfo.InvariantCulture) + "W,"
                                    + termais[j].altura + ".0m,1,,,," + "T" + j +"\n\r";

                    }
                }
                tb_igc.Text = resultado;
                lb_termais.Text = "Termais:" + count_termais.ToString();
            }
        }
    }
}
