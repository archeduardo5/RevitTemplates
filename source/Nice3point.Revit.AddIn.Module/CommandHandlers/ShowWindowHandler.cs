﻿using Nice3point.Revit.Toolkit.External;
using Nice3point.Revit.AddIn.Views;
#if (Modeless)
using Nice3point.Revit.AddIn.Utils;
using Microsoft.Extensions.DependencyInjection;
#endif

namespace Nice3point.Revit.AddIn.CommandHandlers;

/// <summary>
///     Command entry point invoked from the Revit AddIn Application
/// </summary>
#if (Modeless)
public class ShowWindowHandler(IServiceProvider serviceProvider)
#else
public class ShowWindowHandler(Nice3point.Revit.AddInView view)
#endif
{
    public void Execute(ExternalCommand shell)
    {
#if (Modeless)
        if (WindowController.Focus<Nice3point.Revit.AddInView>()) return;

        var view = serviceProvider.GetService<Nice3point.Revit.AddInView>();
        WindowController.Show(view, shell.UiApplication.MainWindowHandle);
#elseif (Modal)
        view.ShowDialog();
#endif
    }
}