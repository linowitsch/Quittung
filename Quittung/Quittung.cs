using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;


namespace Quittung
{
    class Quittung
    {
       private float _betrag;
       private string _name;
       private string _verwendung;
       private DateTime _datum;
      
    public Quittung (float betrag, string name, string verwendung, DateTime datum)
    {
        _betrag = betrag;
        _name = name;
        _verwendung = verwendung;
        _datum = datum;
    }

    public Quittung (float betrag, string name, string verwendung)
    {
        _betrag = betrag;
        _name = name;
        _verwendung = verwendung;
        _datum = DateTime.Today;
    }

    public void speichern()
    {
       /*if nicht da, erstelle, sonst nix
        XDocument save = new XDocument("Quittungen.xml");
        */
        XElement quittung =   new XElement("Quittung", 
                                    new XElement("Betrag", this._betrag), 
                                    new XElement("Name", this._name), 
                                    new XElement("Verwendungszweck", this._verwendung), 
                                    new XElement("Datum", this._datum));
        XDocument a = new XDocument(quittung);
        a.Save("D:/Judokan/Quittung_Cs/Quittung/test.xml");
        XDocument b = XDocument.Load("D:/Judokan/Quittung_Cs/Quittung/test.xml");
        b.add(quittung);
        //b.Add(quittung);
        
        
        
        
    }
    }
}
