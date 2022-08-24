using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Maui.Plugin.BaseBindingLibrary
{
    public class BaseNotifyProperty : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged<T>(ref T storage, T value, [CallerMemberName] string propertyName = "")
        {
            if (!IsEquals(storage, value))
            {
                storage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private static bool IsEquals<T>(T storage, T value)
        {
            if (typeof(T).IsValueType)
            { return storage.Equals(value); }
            else
            { return object.Equals(storage, value); }
        }
    }
}
