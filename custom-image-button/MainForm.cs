namespace custom_image_button
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            initButton();
        }

        private void initButton()
        {
            string path = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Images",
                "smiley.png");
            int square = buttonWithImage.Height - 4;
            Image resizedImage = 
                new Bitmap(
                    Bitmap.FromFile(path),
                    new Size(square, square));

            buttonWithImage.Image = resizedImage;
            buttonWithImage.ImageAlign = ContentAlignment.MiddleLeft;
            buttonWithImage.TextAlign = ContentAlignment.MiddleRight;
        }
    }
}