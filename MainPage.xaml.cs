using System.Diagnostics;

namespace PaintPicker

{
    public partial class MainPage : ContentPage
    {
        bool isRandom;
        public MainPage()
        {
            InitializeComponent();
        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (!isRandom)
            {
                var red = sliderRed.Value;
                var green = sliderGreen.Value;
                var blue = sliderBlue.Value;

                Color color = Color.FromRgb(red, green, blue);

                SetColor(color);
            }
        }

        private void SetColor(Color color)
        {
            // Debug.WriteLine(color.ToString());
            btnRandom.Background = color;
            Container.Background = color;
            lblHex.Text = color.ToHex();
        }

        private void btnRandom_Clicked(object sender, EventArgs e)
        {
            isRandom = true;
            var random = new Random();

            var color = Color.FromRgb(
                random.Next(0, 256),
                random.Next(0, 256),
                random.Next(0, 256));

            SetColor(color);

            sliderRed.Value = color.Red;
            sliderGreen.Value = color.Green;
            sliderBlue.Value = color.Blue;
            isRandom = false;
        }
    }

}
