using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace WindowsFormsMVVMDemo.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            ShowAll = ReactiveCommand.Create(() =>
            {
                this.Text = "测试文本";
                this.Title = "测试标题";
                this.LabelText = "lAbelText";
                this.IsChecked = true;
                this.List = new ObservableCollection<string>(new List<string>
                {
                    "1", "2", "3"
                });
                MessageBus.Current.SendMessage(new MessageBoxEventArgs(this) { Title = "提示", Message = "这是提示" });
            });
        }
        [Reactive] public string Text { get; set; }
        [Reactive] public string LabelText { get; set; }
        [Reactive] public string Title { get; set; }
        [Reactive] public bool IsChecked { get; set; }
        public ReactiveCommand<Unit, Unit> ShowAll { get; set; }
        [Reactive] public ObservableCollection<string> List { get; set; }
    }
}
