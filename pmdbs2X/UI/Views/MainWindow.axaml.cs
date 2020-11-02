using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using pmdbs2X.Database;
using pmdbs2X.UI.Management;
using pmdbs2X.UI.Scaling;
using pmdbs2X.UI.ViewModels;
using System;
using System.Diagnostics;

namespace pmdbs2X.UI.Views
{
    /// <summary>
    /// Represents the main <see cref="Window"/> of the application.
    /// </summary>
    public class MainWindow : ScalableWindow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// <para>Note: each window should be unique and only exist once during the whole application lifetime.</para>
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        public override event EventHandler<PointerPressedEventArgs> BeginResize;

        public override event EventHandler<PointerEventArgs> Resize;

        public override event EventHandler<PointerReleasedEventArgs> EndResize;

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            WindowState = WindowState.Normal;
            Panel bottomRightCorner = this.FindControl<Panel>("BottomRightCorner");
            bottomRightCorner.PointerMoved += BottomRightCorner_PointerMoved;
            bottomRightCorner.PointerReleased += BottomRightCorner_PointerReleased;
            bottomRightCorner.PointerPressed += BottomRightCorner_PointerPressed;
        }

        private void BottomRightCorner_PointerReleased(object? sender, PointerReleasedEventArgs e)
        {
            EndResize?.Invoke(this, e);
        }

        private void BottomRightCorner_PointerPressed(object? sender, Avalonia.Input.PointerPressedEventArgs e)
        {
            BeginResize?.Invoke(this, e);
        }

        private void BottomRightCorner_PointerMoved(object? sender, Avalonia.Input.PointerEventArgs e)
        {
            Resize?.Invoke(this, e);
        }
    }
}