using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReactiveUI;
using WindowsFormsMVVMDemo.ViewModels;

namespace WindowsFormsMVVMDemo.Views
{
    public abstract class BaseForm<TViewModel> : Form, IViewFor<TViewModel> where TViewModel : class
    {
        public BaseForm()
        {
            MessageBus.Current.Listen<MessageBoxEventArgs>()
                .Where(a => a.ViewModel == this.ViewModel)
                .Subscribe(x => MessageBox.Show(x.Message, x.Title));
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (TViewModel)value;
        }

        public TViewModel ViewModel { get; set; }
    }
}
