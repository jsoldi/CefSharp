﻿using System.ComponentModel;
using System.Windows.Input;

namespace CefSharp.Wpf
{
    public interface IWpfWebBrowser : IWebBrowser, INotifyPropertyChanged
    {
        /// <summary>
        /// The address (URL) which the browser control is currently displaying. Can be set to a simplified URL
        /// (e.g. www.google.com) or a full URL (e.g. http://www.google.com). Will automatically be updated as the user
        /// navigates to another page (e.g. by clickig on a link).
        /// </summary>
        /// <remarks>This property is a Dependency Property and fully supports data binding.</remarks>
        string Address { get; set; }

        /// <summary>
        /// The title of the web page being currently displayed.
        /// </summary>
        /// <remarks>This property is a Dependency Property and fully supports data binding.</remarks>
        string Title { get; }

        /// <summary>
        /// Command which navigates to the previous page in the browser history. Will automatically be enabled/disabled depending
        /// on the availability of the command.
        /// </summary>
        ICommand BackCommand { get; }

        /// <summary>
        /// Command which navigates to the next page in the browser history. Will automatically be enabled/disabled depending on
        /// the availability of the command.
        /// </summary>
        ICommand ForwardCommand { get; }
    }
}
