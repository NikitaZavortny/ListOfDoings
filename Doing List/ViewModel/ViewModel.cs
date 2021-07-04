using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Doing_List.ViewModel
{
    class ViewModel : INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string PropertyName = null) 
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        public bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null) 
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged();
            return true;
        }


        public void Dispose()
        {
            Dispose(true);
        }

        private bool Disposing;
        protected virtual void Dispose(bool disposed) 
        {
            if (disposed || Disposing) return;
            Disposing = true;
        }
    }
}
