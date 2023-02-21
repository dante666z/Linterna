using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Linterna.VistaModelo;

namespace Linterna.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class linterna : ContentPage
    {
        public linterna()
        {
            InitializeComponent();
            BindingContext = new VMLinterna();
        }
    }
}