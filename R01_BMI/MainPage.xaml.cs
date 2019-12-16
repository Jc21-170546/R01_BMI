using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R01_BMI
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //button
        private void Button_Clicked(object sender, EventArgs e)
        {
            BMI bmi = new BMI();
            try
            {
                string r = bmi.getBMI
                    (double.Parse(height.Text)/100.0, double.Parse(weight.Text));

                Result.Text = r;

            }
            catch (FormatException)
            { Result.Text = "値を入力してください"; }
            catch (ArgumentOutOfRangeException)
            { Result.Text = "正しい値を入力してください"; }

        }
    }
}
 