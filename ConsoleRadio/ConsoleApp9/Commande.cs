using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliRadio.Commandes
{
    public class Commande
    {
        public Commande() { }
        public void defineCommand(List<string> C)
        {
            C.Add("#help");
            C.Add("#showAllRad");
            C.Add("#synth");
            C.Add("#vol");
            C.Add("#rad");
            C.Add("#stop");
            C.Add("#exit");
        }
        public void defineEffectCommand(List<string> EC)
        {
            EC.Add("affiche toutes les commandes");
            EC.Add("affiche toutes les radios");
            EC.Add("affiche la synthaxe d'une commande");
            EC.Add("modifie le volume entre 0 et 100 compris");
            EC.Add("joue une radio");
            EC.Add("stop le lecteur");
            EC.Add("ferme l'application");
        }
        public void defineSynthCommand(List<string> SC)
        {
            SC.Add("#help");
            SC.Add("#showAllRad");
            SC.Add("#synth [nomCommande]");
            SC.Add("#vol[nbr]");
            SC.Add("#rad [nomRadio]");
            SC.Add("#stop");
            SC.Add("#exterminatus");
            SC.Add("#squalala");            
            SC.Add("#exit");
        }
        public void defineRad(List<string> R)
        {
            
            R.Add("ALOUETTE");
            R.Add("AUTOROUTE INFO NORD");
            R.Add("AUTOROUTE INFO SUD");
            R.Add("CHERIE FM");
            R.Add("EUROPE 1");            
            R.Add("FRANCE CULTURE");
            R.Add("FRANCE INFO");
            R.Add("FRANCE INTER");
            R.Add("FRANCE MUSIQUE");
            
            R.Add("FUN RADIO");
            R.Add("JAZZ RADIO");
            R.Add("LFM");
            R.Add("PULSE RADIO");
            R.Add("NOSTALGIE");
            R.Add("NOSTALGIE BEST OF 60\'S");
            R.Add("NOSTALGIE BEST OF 70\'S");
            R.Add("NOSTALGIE BEST OF 80\'S");
            R.Add("NOSTALGIE CHANSON FRANCAISE");
            R.Add("NOSTALGIE DISCO FEVER");
            R.Add("NOSTALGIE ROUEN");
            R.Add("NOVA");
            R.Add("NRJ");
            R.Add("RADIO CRISTAL");
            R.Add("RADIO FONTAINE");
            R.Add("RADIO GALAXIE");
            R.Add("RIRE ET CHANSON");
            R.Add("RTL");
            R.Add("RTL2");
            R.Add("SKYROCK");
            R.Add("TENDANCE OUEST SEINE-MARITIME");
            R.Add("TENDANCE OUEST");
            R.Add("VIRGIN RADIO");
            R.Add("VIRGIN RADIO PARIS");
            R.Add("VIRGIN RADIO ROUEN");
            R.Add("VIRGIN RADIO BORDEAUX");
            
            
        }
    }
}
