using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testApp{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class bubbleSortPage : ContentPage{
		public bubbleSortPage (){
			InitializeComponent ();
		}

        public void Sort(object sender, EventArgs e){
            int[] mass = new int[] {    Convert.ToInt32(En1.Text),
                                        Convert.ToInt32(En2.Text),
                                        Convert.ToInt32(En3.Text),
                                        Convert.ToInt32(En4.Text),
                                        Convert.ToInt32(En5.Text),
                                        Convert.ToInt32(En6.Text)
            };
            for (int i = 1; i < 6; i++){
                if (mass[i-1]>mass[i]){
                    int buf = mass[i];
                    mass[i] = mass[i - 1];
                    mass[i - 1] = buf;
                }
            }
            En1.Text = Convert.ToString(mass[0]);
            En2.Text = Convert.ToString(mass[1]);
            En3.Text = Convert.ToString(mass[2]);
            En4.Text = Convert.ToString(mass[3]);
            En5.Text = Convert.ToString(mass[4]);
            En6.Text = Convert.ToString(mass[5]);
        }
    }
}