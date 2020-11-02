using Avalonia.Controls;
using pmdbs2X.Exceptions;
using pmdbs2X.Threading;
using pmdbs2X.UI.Frames;
using pmdbs2X.UI.Frames.OverlayFrames;
using pmdbs2X.UI.Views;
using ReactiveUI;
using System;
using System.Threading.Tasks;

namespace pmdbs2X.UI.ViewModels
{
    /// <summary>
    /// Contains all the data bindings and acts as the view model for the <see cref="MainWindow"/>.
    /// </summary>
    public class MainWindowViewModel : IViewModel
    {
        private bool isResizing = false;
		
        public bool IsResizing
        {
            get => isResizing;
            set => this.RaiseAndSetIfChanged(ref isResizing, value);
        }
    }
}