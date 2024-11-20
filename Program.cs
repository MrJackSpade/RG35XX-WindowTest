using RG35XX.Core.Drawing;
using RG35XX.Libraries;
using RG35XX.Libraries.Controls;

namespace WindowTest
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            Application application = new(640, 480);

            Window window = new()
            {
                Title = "Window Test",
                Bounds = new(0, 0, 1, 1)
            };

            IconView iconView = new();

            Bitmap iconImage = new("Images/IExplore.png");

            for (int i = 0; i < 42; i++)
            {
                Icon b = new()
                {
                    Text = $"Button {i}",
                    FontSize = 0.5f,
                    Image = iconImage,
                };

                iconView.AddControl(b);
            }

            Page page = new();

            page.AddControl(window);

            window.AddControl(iconView);

            application.OpenPage(page);

            await application.Execute();
        }
    }
}