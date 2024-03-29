﻿using System;
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
using System.Media;

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
            public double toDD()
            {
                return ((this.graus + this.minutos * 60.0)*-1.0);
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
                Waypoint[] termais = new Waypoint[2000];
                foreach (string arquivo in abridorIGCs.FileNames)
                {
                    tb_igc.Text = System.IO.File.ReadAllText(arquivo);
                    // 
                    Regex rx = new Regex(@"B(\d{13})(\w{1}\d{8})(\w{2}\d{10})", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    MatchCollection linhasB = rx.Matches(tb_igc.Text);
                    int i = 0;
                    Waypoint[] linhas = new Waypoint[int.Parse(tb_tempo_analise.Text)];
                    //B151230-1954998S-04028313-WA-00765-00816-39
                    bool flag_termal = true;
                    float angulo;

                    /*foreach (Match registros in linhasB)
                    {
                        linhas[i] = new Waypoint();
                        linhas[i].hora = new DateTime(2010, 1, 1, int.Parse(registros.ToString().Substring(1, 2)),
                                                                  int.Parse(registros.ToString().Substring(3, 2)),
                                                                  int.Parse(registros.ToString().Substring(5, 2)));

                        linhas[i].latitude.graus = int.Parse(registros.ToString().Substring(7, 2));
                        linhas[i].latitude.minutos = float.Parse(registros.ToString().Substring(9, 5)) / (float)1000.0;

                        linhas[i].longitude.graus = int.Parse(registros.ToString().Substring(15, 3));
                        linhas[i].longitude.minutos = float.Parse(registros.ToString().Substring(18, 5)) / (float)1000.0;

                        linhas[i].altura = int.Parse(registros.ToString().Substring(25, 5));
                        if (i == 5)
                        {
                            //Calcula angulo
                            double x, y;
                            //double angle = Math.PI * degrees / 180.0;
                            //X = cos θb * sin ∆L

                            x = Math.Cos(Math.PI * linhas[i].longitude.toDD() / 180.0) *
                                Math.Sin(Math.PI * (linhas[i].latitude.toDD() - linhas[0].latitude.toDD()) / 180.0);

                            //Y = cos θa * sin θb – sin θa * cos θb * cos ∆L



                            i = 0;
                        }
                        i++;
                    }*/

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
                        if (linhas[i].altura == 0 )
                            linhas[i].altura = int.Parse(registros.ToString().Substring(30, 5));

                        if (i == int.Parse(tb_tempo_analise.Text)-1)
                        {
                            if ((linhas[int.Parse(tb_tempo_analise.Text)-1].altura - linhas[0].altura) > (int.Parse(tb_tempo_analise.Text)*float.Parse(tb_vel_term.Text)) && (flag_termal))
                            {
                                termais[count_termais] = linhas[0];
                                count_termais++;
                                flag_termal = false; //Impede um novo registro.
                            }
                            else if ((linhas[int.Parse(tb_tempo_analise.Text) - 1].altura - linhas[0].altura) < (int.Parse(tb_tempo_analise.Text) * float.Parse(tb_vel_term.Text)))
                            {
                                flag_termal = true;
                            }
                            //for (int j = 0; j < i; j++)
                            //{
                              //  linhas[j] = linhas[j + 1];
                            //}
                        }
                        i++;
                        if (i > int.Parse(tb_tempo_analise.Text)-1) i = 0;
                    }
                    //tb_igc.Clear(); */
                }
                for (int j = 0; j < count_termais; j++)
                {

                    resultado = resultado + "T" + j + ",T" + j + ",,"
                                + termais[j].latitude.graus + termais[j].latitude.minutos.ToString("G",System.Globalization.CultureInfo.InvariantCulture) + "S,0"
                                + termais[j].longitude.graus + termais[j].longitude.minutos.ToString("G", System.Globalization.CultureInfo.InvariantCulture) + "W,"
                                + termais[j].altura + ".0m,1,,,," + "T" + j +"\n\r";

                }
                tb_igc.Text = resultado;
                lb_termais.Text = "Termais:" + count_termais.ToString();
            }
        }

        private void bt_puxa_rampa_Click(object sender, EventArgs e)
        {
            WebClient leitor_rampas = new WebClient();
            String pagina_baixada;
            Regex rx = new Regex(@"maps\.google\.com\/maps\?q=([a-zA-Z ]+)&ll=-(\d*\.?\d+\.\d+),-(\d*\.?\d+\.\d+)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Match acerto;
            SystemSounds.Asterisk.Play();
            foreach (String s in tb_ids.Lines)
            {

                pagina_baixada = leitor_rampas.DownloadString(tb_link_rampas.Text + s + "&lang=brazilian") + Environment.NewLine;
                acerto = rx.Match(pagina_baixada);
                tb_igc.Text += "RP - " + acerto.Groups[1] +
                                ";-" + acerto.Groups[2] +
                                ";-" + acerto.Groups[3] +
                                Environment.NewLine;

            }
            SystemSounds.Asterisk.Play();

        }
    }
}
