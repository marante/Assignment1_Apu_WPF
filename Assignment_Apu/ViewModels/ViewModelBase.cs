using Caliburn.Micro;
using System.ComponentModel;
using System.Windows;

namespace Assignment_Apu.ViewModels
{
    public abstract class ViewModelBase
        : PropertyChangedBase
    {
        private static bool? _isInDesignMode;

        /// <summary>
        /// Gets a value indicating whether the control is in design mode (running in Blend
        /// or Visual Studio).
        /// </summary>
        public static bool IsInDesignModeStatic
        {
            get
            {
                if (_isInDesignMode.HasValue)
                    return _isInDesignMode.Value;
                var prop = DesignerProperties.IsInDesignModeProperty;
                _isInDesignMode
                    = (bool)DependencyPropertyDescriptor
                        .FromProperty(prop, typeof(FrameworkElement))
                        .Metadata.DefaultValue;

                return _isInDesignMode.Value;
            }
        }
    }
}