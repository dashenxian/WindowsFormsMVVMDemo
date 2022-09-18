using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsMVVMDemo.ViewModels;

namespace WindowsFormsMVVMDemo
{
    public class MessageBoxEventArgs
    {
        public MessageBoxEventArgs(BaseViewModel viewModel)
        {
            this.ViewModel = viewModel;
        }
        public string Title { get; set; }
        public string Message { get; set; }
        public BaseViewModel ViewModel { get; set; }
    }
}
