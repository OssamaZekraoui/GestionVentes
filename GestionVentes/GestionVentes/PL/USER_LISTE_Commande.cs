using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace GestionVentes.PL
{
    public partial class USER_LISTE_Commande : UserControl
    {
        private static USER_LISTE_Commande UserCommande;
        private dbVentesConext db;

        //Creer une instance pour le usercontrole
        public static USER_LISTE_Commande Instance
        {
            get
            {
                if (UserCommande == null)
                {
                    UserCommande = new USER_LISTE_Commande();
                }
                return UserCommande;
            }
        }
        public USER_LISTE_Commande()
        {
            InitializeComponent();
            db = new dbVentesConext();
        }

        private void USER_LISTE_Commande_Load(object sender, EventArgs e)
        {
            RemplirData();
        }

        //Remplir datagrid commande
        public void RemplirData()
        {
            dvgcommande.Rows.Clear();
            client c = new client();
            String NomPrenom;
            foreach (var L in db.commandes)
            {
                //Afficher nom et prenom de client
                c = db.clients.Single(s => s.numClient == L.numClient);
                NomPrenom = c.nomClient + "  " + c.prenomClient;
                dvgcommande.Rows.Add(L.numCommande,L.dateCommande,NomPrenom,L.Total_HT,L.TVA,L.Total_TTC);
            }
        }

        private void btnajouterCom_Click(object sender, EventArgs e)
        {
            PL.FRM_Details_Commande frmdc = new FRM_Details_Commande(this);
            frmdc.ShowDialog();
        }

        private void btnresearch_Click(object sender, EventArgs e)
        {
            //Rechercher entre deux dates
            var listecommande = db.commandes.ToList();//liste des commandes
            if (dvgcommande.Rows.Count!=0)
            {
                listecommande = listecommande.Where(s => s.dateCommande >= dateD.Value.Date && s.dateCommande <= dateF.Value.Date).ToList();
                //Remplir datagrid
                dvgcommande.Rows.Clear();
                client c = new client();
                String NomPrenom;
                foreach (var L in listecommande)
                {
                    //Afficher nom et prenom de client
                    c = db.clients.Single(s => s.numClient == L.numClient);
                    NomPrenom = c.nomClient + "  " + c.prenomClient;
                    dvgcommande.Rows.Add(L.numCommande, L.dateCommande, NomPrenom, L.Total_HT, L.TVA, L.Total_TTC);
                }
            }
        }

        private void btnimprimerFacture_Click(object sender, EventArgs e)
        {
            RAP.FRM_RAPPORT frp = new RAP.FRM_RAPPORT();
            db = new dbVentesConext();
            try
            {
                //Commande séléctionnée
                int IdCommande = (int)dvgcommande.CurrentRow.Cells[0].Value;
                var Commande = db.commandes.Single(s=>s.numCommande == IdCommande);
                //Client
                var Client = db.clients.Single(s => s.numClient == Commande.numClient );
                //Details de commande
                var listdetail = db.detailsCommandes.Where(s =>s.id == IdCommande);
                //Ajouter listdetail dans datasource de rapport
                frp.RPafficher.LocalReport.ReportEmbeddedResource = "GestionVentes.RAP.RPT_Commande.rdlc";
                frp.RPafficher.LocalReport.DataSources.Add(new ReportDataSource("dataCommande",listdetail));

                //Ajouter les informations de client
                ReportParameter NomPrenom = new ReportParameter("NomPrenomClient", Client.nomClient+" "+Client.prenomClient);
                ReportParameter Adresse = new ReportParameter("AdresseC",Client.adresseClient);
                ReportParameter Telephone = new ReportParameter("AdresseC", Client.teleClient);
                ReportParameter Email = new ReportParameter("AdresseC", Client.emailClient);

                //Ajouter info commande
                ReportParameter NumeroC = new ReportParameter("IDCommande", IdCommande.ToString());
                ReportParameter Datecommande = new ReportParameter("DateCommande", Commande.dateCommande.ToString());

                //Ajouter totalht tva ttc
                ReportParameter TotalHT = new ReportParameter("TotalHT", Commande.Total_HT);
                ReportParameter TVA = new ReportParameter("TVA", Commande.TVA);
                ReportParameter TotalTTC = new ReportParameter("TTC", Commande.Total_TTC);

                //Enregistrer les valeus
                frp.RPafficher.LocalReport.SetParameters(new ReportParameter[] { NomPrenom , Adresse ,
                    Telephone , Email, NumeroC , Datecommande, TotalHT, TVA, TotalTTC });
                frp.RPafficher.RefreshReport();
                frp.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
