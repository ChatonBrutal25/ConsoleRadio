using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using AppliRadio.Commandes;
namespace AppliRadio
{
    class Program
    {
        public static string radioActuelle = "aucune";
        static void Main(string[] args)
        {
            #region parametre
            string com = "";
           
            WindowsMediaPlayer PlayMusic = new WMPLib.WindowsMediaPlayer();
            Commande commande = new Commande();
            List<string> ListC = new List<string>();
            List<string> ListEffC = new List<string>();
            List<string> ListSynthC = new List<string>();
            List<string> ListRad = new List<string>();
            commande.defineCommand(ListC);
            commande.defineEffectCommand(ListEffC);
            commande.defineSynthCommand(ListSynthC);
            commande.defineRad(ListRad);
            PlayMusic.settings.volume = 50;
            #endregion
            #region FONCTIONS

            void menu() {
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine("#help to show all command. Radio actuelle: "+ radioActuelle + " .");
                Console.WriteLine("---------------------------------------------------------------------------------------");
            }
            void allCommandeHelp()
            {
                for(int i=0; i<ListC.Count; i++)
                {
                    Console.WriteLine( ListC[i] + " : " +ListEffC[i]);
                }
                Console.ReadKey();
            }
            void allRad()
            {
                for (int i = 0; i < ListRad.Count; i++)
                {
                    Console.WriteLine( (i+1)+ "-"+ ListRad[i]);
                }
                Console.ReadKey();
            }
            #endregion

            menu();
            while (com!="#exit")
            {
                
                Console.Write("Enter command please: ");
                com = Console.ReadLine();
                #region commande Radio
                if (com.Length > 5)
                {
                    if (com.Substring(0, 5) == "#rad ")
                    {
                        if (com.Contains("RTL2"))
                        {
                            radioActuelle = "RTL2";
                            PlayMusic.URL = "http://streaming.radio.rtl2.fr/rtl2-1-44-128";
                            PlayMusic.controls.play();

                        }

                        if (com.Contains("NOVA"))
                        {
                            radioActuelle = "NOVA";
                            PlayMusic.URL = "http://broadcast.infomaniak.net/radionova-high.mp3";
                            PlayMusic.controls.play();

                        }
                        if (com.Contains("ALOUETTE"))
                        {
                            radioActuelle = "ALOUETTE";
                            PlayMusic.URL = "http://broadcast.infomaniak.net/alouette-high.mp3";
                            PlayMusic.controls.play();

                        }
                        if (com.Contains("CLASSIQUE"))
                        {
                            radioActuelle = "CLASSIQUE";
                            PlayMusic.URL = "http://broadcast.infomaniak.net/radioclassique-high.mp3";
                            PlayMusic.controls.play();

                        }
                        #region Nostalgie & derive
                        if (com.Contains("NOSTALGIE") && !com.Contains("60") && !com.Contains("70") && !com.Contains("80") && !com.Contains("FRANCAISE"))
                        {
                            radioActuelle = "NOSTALGIE";
                            PlayMusic.URL = "http://cdn.nrjaudio.fm/audio1/fr/30601/mp3_128.mp3?origine=fluxradios";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("NOSTALGIE") && com.Contains("60") && !com.Contains("70") && !com.Contains("80") && !com.Contains("FRANCAISE"))
                        {
                            radioActuelle = "NOSTALGIE BEST OF 60\'S";
                            PlayMusic.URL = "http://cdn.nrjaudio.fm/adwz1/fr/30615/mp3_128.mp3?origine=fluxradios";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("NOSTALGIE") && !com.Contains("60") && com.Contains("70") && !com.Contains("80") && !com.Contains("FRANCAISE"))
                        {
                            radioActuelle = "NOSTALGIE BEST OF 70\'S";
                            PlayMusic.URL = "http://cdn.nrjaudio.fm/adwz1/fr/30613/mp3_128.mp3?origine=fluxradios";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("NOSTALGIE") && !com.Contains("60") && !com.Contains("70") && com.Contains("80") && !com.Contains("FRANCAISE"))
                        {
                            radioActuelle = "NOSTALGIE BEST OF 80\'S";
                            PlayMusic.URL = "http://cdn.nrjaudio.fm/adwz1/fr/30605/mp3_128.mp3?origine=fluxradios";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("NOSTALGIE") && !com.Contains("60") && !com.Contains("70") && !com.Contains("80") && com.Contains("FRANCAISE"))
                        {
                            radioActuelle = "NOSTALGIE CHANSON FRANCAISE";
                            PlayMusic.URL = "http://cdn.nrjaudio.fm/adwz1/fr/30611/mp3_128.mp3?origine=fluxradios";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("NOSTALGIE") && !com.Contains("60") && !com.Contains("70") && !com.Contains("80") && !com.Contains("FRANCAISE") && com.Contains("DISCO FEVER"))
                        {
                            radioActuelle = "NOSTALGIE DISCO FEVER";
                            PlayMusic.URL = "http://cdn.nrjaudio.fm/adwz1/fr/30617/mp3_128.mp3?origine=fluxradios";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("NOSTALGIE") && !com.Contains("60") && !com.Contains("70") && !com.Contains("80") && !com.Contains("FRANCAISE") && !com.Contains("DISCO FEVER") &&com.Contains("ROUEN"))
                        {
                            radioActuelle = "NOSTALGIE ROUEN";
                            PlayMusic.URL = "http://cdn.nrjaudio.fm/audio1/fr/40040/aac_64.mp3";
                            PlayMusic.controls.play();
                        }
                        
                    }

                    #endregion
                    if (com.Contains("NRJ"))
                        {
                            radioActuelle = "NRJ";
                            PlayMusic.URL = "http://cdn.nrjaudio.fm/audio1/fr/30001/mp3_128.mp3?origine=fluxradios";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("CHERIE FM"))
                        {
                            radioActuelle = "CHERIE FM";
                            PlayMusic.URL = "http://fluxradios.blogspot.com/2014/07/flux-url-cherie-fm.html";
                            PlayMusic.controls.play();

                        }
                        if (com.Contains("RTL") && !com.Contains("RTL2"))
                        {
                            radioActuelle = "RTL";
                            PlayMusic.URL = "http://streaming.radio.rtl.fr/rtl-1-48-192";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("FRANCE INTER"))
                        {
                            radioActuelle = "FRANCE INTER";
                            PlayMusic.URL = "http://direct.franceinter.fr/live/franceinter-midfi.mp3";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("FRANCE MUSIQUE"))
                        {
                            radioActuelle = "FRANCE MUSIQUE";
                            PlayMusic.URL = "http://direct.francemusique.fr/live/francemusique-midfi.mp3";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("FRANCE CULTURE"))
                        {
                            radioActuelle = "FRANCE CULTURE";
                            PlayMusic.URL = "http://direct.franceculture.fr/live/franceculture-midfi.mp3";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("SKYROCK"))
                        {
                            radioActuelle = "SKYROCK";
                            PlayMusic.URL = "http://icecast.skyrock.net/s/natio_mp3_128k";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("JAZZ RADIO"))
                        {
                            radioActuelle = "JAZZ RADIO";
                            PlayMusic.URL = "http://jazzradio.ice.infomaniak.ch/jazzradio-high.mp3";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("FRANCE INFO"))
                        {
                            radioActuelle = "FRANCE INFO";
                            PlayMusic.URL = "http://direct.franceinfo.fr/live/franceinfo-midfi.mp3";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("RIRE ET CHANSON"))
                        {
                            radioActuelle = "RIRE ET CHANSON";
                            PlayMusic.URL = "http://cdn.nrjaudio.fm/audio1/fr/30401/mp3_128.mp3?origine=fluxradios";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("EUROPE 1"))
                        {
                            radioActuelle = "EUROPE1";
                            PlayMusic.URL = "http://mp3lg4.tdf-cdn.com/9240/lag_180945.mp3";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("PULSE RADIO"))
                        {
                            radioActuelle = "PULSE RADIO";
                            PlayMusic.URL = "http://stream.pulsradio.com:5000/";
                            PlayMusic.controls.play();
                        }
                        #region VIRGIN RADIO
                        if (com.Contains("VIRGIN RADIO") && !com.Contains("PARIS") && !com.Contains("ROUEN"))
                        {
                            radioActuelle = "VIRGIN RADIO";
                            PlayMusic.URL = "http://vr-live-mp3-128.scdn.arkena.com/virginradio.mp3";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("VIRGIN RADIO") && com.Contains("PARIS") && !com.Contains("ROUEN"))
                        {
                            radioActuelle = "VIRGIN RADIO PARIS";
                            PlayMusic.URL = "http://vr-75000-mp3-128.scdn.arkena.com/virginradio.mp3";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("VIRGIN RADIO") && !com.Contains("PARIS") && com.Contains("ROUEN"))
                        {
                            radioActuelle = "VIRGIN RADIO ROUEN";
                            PlayMusic.URL = "http://vr-76000-mp3-128.scdn.arkena.com/virginradio.mp3";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("VIRGIN RADIO") && !com.Contains("PARIS") && !com.Contains("ROUEN") && com.Contains("BORDEAUX"))
                        {
                            radioActuelle = "VIRGIN RADIO BORDEAUX";
                            PlayMusic.URL = "http://vr-33000-mp3-128.scdn.arkena.com/virginradio.mp3";
                            PlayMusic.controls.play();
                        }
                        #endregion
                        #region AUTOROUTE INFO
                        if (com.Contains("AUTOROUTE INFO NORD"))
                        {
                            radioActuelle = "AUTOROUTE INFO NORD";
                            PlayMusic.URL = "http://media.autorouteinfo.fr:8000/direct_nord.mp3";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("AUTOROUTE INFO SUD"))
                        {
                            radioActuelle = "AUTOROUTE INFO SUD";
                            PlayMusic.URL = "http://media.autorouteinfo.fr:8000/direct_sud.mp3";
                            PlayMusic.controls.play();
                        }
                        #endregion
                        if (com.Contains("LFM"))
                        {
                            radioActuelle = "LFM";
                            PlayMusic.URL = "http://players.creacast.com/creacast/lfm/playlist.m3u";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("RADIO FONTAINE"))
                        {
                            radioActuelle = "RADIO FONTAINE";
                            PlayMusic.URL = "http://live.francra.org:8000/RadioFontaine";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("RADIO GALAXIE"))
                        {
                            radioActuelle = "RADIO GALAXIE";
                            PlayMusic.URL = "http://149.202.186.120/RADIOGALAXIE";
                            PlayMusic.controls.play();
                        }
                        if (com.Contains("FUN RADIO"))
                        {
                            radioActuelle = "FUN RADIO";
                            PlayMusic.URL = "http://streaming.radio.funradio.fr/fun-1-48-192";
                            PlayMusic.controls.play();
                        }
                    if (com.Contains("RADIO CRISTAL"))
                    {
                        radioActuelle = "RADIO CRISTAL";
                        PlayMusic.URL = "http://radiocristal.ice.infomaniak.ch/radiocristal-high.mp3";
                        PlayMusic.controls.play();
                    }
                    if (com.Contains("TENDANCE OUEST SEINE-MARITIME"))
                    {
                        radioActuelle = "TENDANCE OUEST SEINE-MARITIME";
                        PlayMusic.URL = "http://streaming.tendanceouest.com/torouen.mp3";
                        PlayMusic.controls.play();
                    }
                    if (com.Contains("TENDANCE OUEST EURE"))
                    {
                        radioActuelle = "TENDANCE OUEST EURE";
                        PlayMusic.URL = "http://streaming.tendanceouest.com/tobernay.mp3";
                        PlayMusic.controls.play();
                    }
                    
                }
                #endregion
                if (com == "#exit") break;
                if (com == "#stop") { PlayMusic.controls.stop(); radioActuelle = "aucune"; }
                #region SYNTH
                if (com == "#synth") { Console.WriteLine(ListC[2] + " | " + ListSynthC[2]);
                    Console.WriteLine("   write #synth ALL or #synth * for see all commands");
                    Console.ReadKey(); }
                if(com=="#synth ALL" || com== "#synth *")
                {
                    for(int i =0; i< ListC.Count; i++)
                    {
                        Console.WriteLine(ListC[i] + " | " + ListSynthC[i]);
                    }
                    Console.ReadKey();
                }
                if (com.Length > 8) {
                    if (com.Substring(0, 6) == "#synth")
                    {
                        if (com.Substring(7) == ListC[0]) { Console.WriteLine(ListC[0] + " | " + ListSynthC[0]); }
                        if (com.Substring(7) == ListC[1]) { Console.WriteLine(ListC[1] + " | " + ListSynthC[1]); }
                        if (com.Substring(7) == ListC[2]) { Console.WriteLine(ListC[2] + " | " + ListSynthC[2]); }
                        if (com.Substring(7) == ListC[3]) { Console.WriteLine(ListC[3] + " | " + ListSynthC[3]); }
                        if (com.Substring(7) == ListC[4]) { Console.WriteLine(ListC[4] + " | " + ListSynthC[4]); }
                        if (com.Substring(7) == ListC[5]) { Console.WriteLine(ListC[5] + " | " + ListSynthC[5]); ; }
                        if (com.Substring(7) == ListC[6]) { Console.WriteLine(ListC[6] + " | " + ListSynthC[6]); }
                        Console.ReadKey();
                    }
                    }
                if(com=="#squalala")
                {
                    PlayMusic.launchURL("https://www.youtube.com/watch?v=t5os3WnnCA4");
                    
                }
                if (com == "#exterminatus")
                {
                    PlayMusic.launchURL("https://www.youtube.com/watch?v=jN3Qmq7YJmU");
                }
                #endregion
                if (com == "#help")
                {
                    allCommandeHelp();
                }
                if (com == "#showAllRad") allRad();
                if (com.Length >= 4 && com.Length <= 7)
                {
                    if (com.Substring(0, 4) == "#vol")
                    {
                        try { 
                            int V = int.Parse(com.Substring(4));
                            if (V >= 0 && V <= 100)
                            {
                            PlayMusic.settings.volume = V;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("invalid argument or synthax");
                            Console.Read();
                        }
                    }
                }
                
                Console.Clear();
                menu();
            }
           
        }
    }
}
