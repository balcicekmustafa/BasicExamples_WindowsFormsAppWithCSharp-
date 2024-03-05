using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Konut : Site
    {
    public int DaireNo { get; set; }
    public int BlokNo { get; set; }
    public List<Bolum> OzelBolumler { get; set; }

    public Konut(int daireNo, Site site, int blokNo) : base(site.DaireSayisi, site.Isim)
    {
        DaireNo = daireNo;
        BlokNo = blokNo;
        OzelBolumler = new List<Bolum>();
    }

    public void OzelBolumEkle(Bolum bolum)
    {
        OzelBolumler.Add(bolum);
    }

    public double GetAlan()
    {
        double topAlan = 0;
        foreach (Bolum bolum in OzelBolumler)
        {
            topAlan += bolum.Alan;
        }
        return topAlan;
    }

    public double GetBrutAlan()
    {
        double netAlan = GetAlan();
        double ortakAlan = base.GetOrtakAlan();
        double brutAlan = netAlan + (ortakAlan * DaireSayisi / (double)DaireNo));
        return brutAlan;
    }
}