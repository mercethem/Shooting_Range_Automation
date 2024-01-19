using System.Data;

namespace PoligonOtomasyonu
{
    public partial class GunsDisplay : Form
    {
        private List<Image> LoadedImages { get; set; }
        public GunsDisplay()
        {
            InitializeComponent();
        }

        private void GunsDisplay_Load(object sender, EventArgs e)
        {
            LoadImagesFromFolder();

            ImageList images = new ImageList();
            images.ImageSize = new Size(100, 80);

            foreach (var image in LoadedImages)
            {
                images.Images.Add(image);
            }
            imageList.LargeImageList = images;

            for (int itemIndex = 0; itemIndex < LoadedImages.Count; itemIndex++)
            {
                imageList.Items.Add(new ListViewItem($"", itemIndex));
            }
        }
        private void LoadImagesFromFolder()
        {
            LoadedImages = new List<Image>();

            var index = 0;
            var fileCount = (from file in Directory.EnumerateFiles(@"C:\ShootRangeAutomation\itemssorted", "*.png",
                SearchOption.AllDirectories)
                             select file).Count();
            while (index < fileCount)
            {
                string tempLocation = $@"C:\ShootRangeAutomation\itemssorted\{index}.png";
                var tempImage = Image.FromFile(tempLocation);
                LoadedImages.Add(tempImage);
                ++index;
            }
        }
        private void imageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imageList.SelectedIndices.Count > 0)
            {
                var selectedIndex = imageList.SelectedIndices[0];
                Image selectedImage_ = LoadedImages[selectedIndex];
                selectedImage.Image = selectedImage_;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
