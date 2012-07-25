using Blake.NUI.WPF.Touch;
using Microsoft.Surface.Presentation.Controls;

namespace ScrollViewerBehaviorsToolkit
{
    public partial class SurfaceWindow1 : SurfaceWindow
    {
        public SurfaceWindow1()
        {
            InitializeComponent();

            // Promote mouse clicks to touch events.
            MouseTouchDevice.RegisterEvents(this);
        }

    }
}