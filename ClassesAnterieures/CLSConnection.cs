using Gestion_Note.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Note.ClassesAnterieures
{
    class CLSConnection
    {
        //Fonction pour vérifier la connection
        /* public bool Connexion(BdContext bd, string Nom, string Motdepasse, string Nature)
         {
             Compte C = new Compte();

             C.Profile_actuel = Nom;
             C.Pswd_initial = Motdepasse;
             C.Pswd_definitif = Nature;

             if (bd.Comptes.SingleOrDefault(c => c.Profile_actuel == Nom/*Profile_actuel==Nom && c.Pswd_initial == Motdepasse && c.Pswd_definitif==Nature)!=null )//n'est pas null
             {
                 return true;
             }else
             {
                 return false;
             }
         }*/
        public bool Connexion(BdContext bd, string mail, string Motdepasse, string statut)
        {
            Employe E = new Employe();

            E.Email_employe = mail;
           E.Motdepasse = Motdepasse;
           E.statut = statut;

            if (bd.Employes.SingleOrDefault(e => e.Email_employe == mail/*Profile_actuel==Nom*/ && e.Motdepasse == Motdepasse && e.statut == statut) != null)//n'est pas null
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool ConnexionD(BdContext bd, string Motdepasse)
        {
            Compte C = new Compte();
            C.Pswd_initial = Motdepasse;
            if (bd.Comptes.SingleOrDefault(c => c.Pswd_initial == Motdepasse) != null)//n'est pas null
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
