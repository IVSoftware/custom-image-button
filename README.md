Your question is **how to scale image in button when it's too big** and one way to do this with a standard Winforms `Button` is to use the `Bitmap(Image original, Size newSize)` constructor to scale the image to the size you want (based on the size of the button). Then you can assign it to the `Button.Image` property and set the positions of Image and Text:

[![button with scaled image][1]][1]

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
                "folder.png");
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



***
One way of making sure that the image file can be located.

[![copy if newer][2]][2]


  [1]: https://i.stack.imgur.com/o2OKP.png
  [2]: https://i.stack.imgur.com/KKtIZ.png