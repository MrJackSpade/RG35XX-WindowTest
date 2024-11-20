using RG35XX.Core.GamePads;
using RG35XX.Libraries.Controls;

namespace WindowTest
{
    internal class ButtonTestPage : Page
    {
        private readonly string _buttonText;

        public ButtonTestPage(string buttonText)
        {
            _buttonText = buttonText;

            Label label = new()
            {
                Text = _buttonText,
                FontSize = 1f,
                Bounds = new(0, 0, .5f, .1f)
            };

            this.AddControl(label);
        }

        public override void OnKey(GamepadKey key)
        {
            if (key == GamepadKey.B_DOWN)
            {
                this.Close();
            }

            base.OnKey(key);
        }
    }
}