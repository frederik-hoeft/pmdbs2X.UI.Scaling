using Avalonia.Controls;
using Avalonia.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace pmdbs2X.UI.Scaling
{
    /// <summary>
    /// Represents an avalonia <see cref="Window"/> that can be resized and scales it's content accordingly.
    /// </summary>
    public abstract class ScalableWindow : Window
    {
        public abstract event EventHandler<PointerPressedEventArgs> BeginResize;
        public abstract event EventHandler<PointerEventArgs> Resize;
        public abstract event EventHandler<PointerReleasedEventArgs> EndResize;
    }
}
