﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App8_Estilo.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
    {
		public Master ()
		{
			InitializeComponent ();
		}

        private void GoPagina1(object sender, EventArgs args)
        {
            //Detail = new NavigationPage(new Pagina);
            IsPresented = false;
        }

    }
}