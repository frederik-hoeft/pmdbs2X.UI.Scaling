# pmdbs2X.UI.Scaling
Allows dynamic scaling of an Avalonia Window and all of it's content.

_This is the solution to [this](https://stackoverflow.com/questions/63448372/avalonia-ui-scaling-issues) question on stackoverflow._

To use this code you have to:

 1. Derive your application main `Window` from `ScalableWindow` and set implement the resizing events [like in the provided example](https://github.com/frederik-hoeft/pmdbs2X.UI.Scaling/blob/main/pmdbs2X/UI/Views/MainWindow.axaml.cs).
 (I put a `Panel` in the bottom right corner of my window to be used for resizing, you'll figure it out.)

 2. Then implement `IViewModel` in the corresponding view model (see [the example](https://github.com/frederik-hoeft/pmdbs2X.UI.Scaling/blob/main/pmdbs2X/UI/ViewModels/MainWindowViewModel.cs)).

 3. Call `ScalingProvider.Register(window, viewModel);` on application startup (**after** Avalonia is done initializing.) 
 
 4. Now you can Rescale the window as follows:
    ```
    ScalingManager mainWindowManager = ScalingProvider.GetInstance<MainWindow>();
    mainWindowManager.SetScaling(1.5d);
    ```
    This would scale the window of type `MainWindow` to 150% of it's original size. Scaling is always in respect to the original size.
