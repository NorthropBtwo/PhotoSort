using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Imaging;
using System.IO;



namespace Fotosort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdstart_Click(object sender, EventArgs e)
        {
             List<CFotoelement> lisFotos = GetInfo(Directory.GetCurrentDirectory()); // Liste einlesen und sortieren
             changename(lisFotos);                                                   // Namen wechseln
             progressBar1.Increment(1);                                              // Fortschritt auf Maximum erhöhen
        }



        private void changename(List<CFotoelement> lisFotos)
        {
            lisDate.Text += "changeing names" + Environment.NewLine;
            for (int i = 0; i < lisFotos.Count; i++)
            {
                lisFotos[i].Newname = txtPrefix.Text + i.ToString("0000") + ".jpg";
                //lisDate.Text +=  lisFotos.Values[i].Newname + Environment.NewLine;
                File.Move(lisFotos[i].Oldname, lisFotos[i].Newname); //Umbenennen des Fotos
              //  File.Copy(lisFotos.Values[i].Oldname, lisFotos.Values[i].Newname);
            }
            lisDate.Text += "new names" + Environment.NewLine;
        }




        private List<CFotoelement> GetInfo(string ordnername)
        {
            DirectoryInfo Ordner = new DirectoryInfo(ordnername);   
            FileInfo[] DateiListe = Ordner.GetFiles();                  // Dateiliste wird instanziert und erstellt
            Encoding enc = Encoding.Default;

            String ADatum;

            textBoxTotFiles.Text = DateiListe.Length.ToString();        // Anzahl Files Ausgeben
            progressBar1.Maximum = DateiListe.Length;                   // Maximalwert für die Dauerausgabe anzeigen

            List<CFotoelement> listFotos = new List<CFotoelement>();    // Fotoelementliste wird hier instanziert

            for (int i = 0; i < DateiListe.Length; i++)                 // Dateiliste durchgehen
            {
                textBoxActImg.Text = i.ToString();                      // Aktuelle Nummer ausgeben
                progressBar1.Value = i;
                if (DateiListe[i].FullName.ToLower().EndsWith(".jpg"))  // nach .jpg absuchen
                {
                    ADatum = String.Empty;
                    Image img = Image.FromFile(DateiListe[i].FullName); // Bild laden


                    foreach (PropertyItem Info in img.PropertyItems)    // Bilddaten extrahieren und durchiterieren
                    {
                        switch (Info.Id.ToString("X"))                  // wozu diese Info ID ???
                        {
                            case "110":                                 // Wozu diese Aktion ???
                                break;
                            case "9003":                                // Entspricht dem Aufnahmendatum ?
                                ADatum = enc.GetString(Info.Value, 0, Info.Len - 1);
                                break;
                        }
                    }

                   
                    img.Dispose(); //Bild Schliessen
                    img = null;

                    

                   // lisDate.Text += ADatum + Environment.NewLine;
                    try
                    {
                        listFotos.Add(new CFotoelement(DateiListe[i].FullName, ADatum)); // in die Fotoelementliste einfügen
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            lisDate.Text += "sorting elements" + Environment.NewLine;
            listFotos.Sort();   // Liste sortieren

            return listFotos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
