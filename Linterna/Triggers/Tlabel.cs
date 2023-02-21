using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace Linterna.Triggers
{
    public class Tlabel : TriggerAction<Label>
    {
        public bool Indicador { get; set; }
        protected override async void Invoke(Label sender)
        {
            if (Indicador)
            {
                sender.TextColor = Color.FromHex("#FFE566");
                sender.Text = "Se hizo la luz";
                await Task.WhenAll(
                    sender.FadeTo(0.5, 600, Easing.BounceOut),
                    sender.FadeTo(1, 600, Easing.BounceOut),
                    sender.TranslateTo(0, -80, 700, Easing.BounceOut)
                    );
            }
            else
            {
                sender.TextColor = Color.FromHex("#6C7273");
                sender.Text = "Mi esposa es la luz en la oscuridad";
                await Task.WhenAll(
                    sender.FadeTo(0.5, 600, Easing.BounceOut),
                    sender.FadeTo(1, 600, Easing.BounceOut),
                    sender.TranslateTo(0, 0, 700, Easing.BounceOut)
                    );
            }
        }
    }
}
