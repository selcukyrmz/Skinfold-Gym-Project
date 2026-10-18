using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skinfold_Gym_Project
{
    // VucutOlcumleri tablosundaki bir satırı temsil eder
    public class VucutOlcumTanimlari
    {
        public int id { get; set; }

        public DateTime tarih { get; set; }

        public string uye_no { get; set; }

        public string ad { get; set; }

        public string soyad { get; set; }

        public int yas { get; set; }

        public string cinsiyet { get; set; }

        public string protokol { get; set; }

        public int toplam_sf_mm { get; set; }

        public double vucut_agirligi { get; set; }   // kg

        public double yag_yuzdesi { get; set; }

        public double yag_kg { get; set; }

        public double kas_kg { get; set; }

        public string kategori { get; set; }
    }
}