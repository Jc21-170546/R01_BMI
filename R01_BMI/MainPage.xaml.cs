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
                double h = double.Parse(height.Text);
                double w = double.Parse(weight.Text);

                if (1 > h || 1 > w)
                    throw new ArgumentOutOfRangeException();

                string r = bmi.getBMI
                    (double.Parse(height.Text)/100.0, double.Parse(weight.Text));

                Result.Text = r;

            }
            //引数の書式が仕様に一致していない場合
            catch (FormatException)
            { Result.Text = "数値を入力してください"; }

            //引数がnullの場合
            catch (ArgumentNullException)
            { Result.Text = "値を入力してください"; }

            //メソッドの許容範囲外の値が引数として渡された場合
            catch (ArgumentOutOfRangeException)
            { Result.Text = "正しい値を入力してください"; }

        }
    }
}
 