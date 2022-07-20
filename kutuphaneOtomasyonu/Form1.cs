﻿using kutuphaneOtomasyonu.Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FrmKitaplar frm1;
        private void BtnKitaplar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // ana formdan kitaplar sekmesini bir kere açma ve açılıp kapatılmışsa tekrar açma şartı
            if(frm1 == null || frm1.IsDisposed) 
            {
               frm1 = new FrmKitaplar();
               frm1.MdiParent = this;
               frm1.Show();
            }
            
        }
    }
}