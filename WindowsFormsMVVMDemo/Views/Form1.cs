using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReactiveUI;
using WindowsFormsMVVMDemo.ViewModels;
using WindowsFormsMVVMDemo.Views;

namespace WindowsFormsMVVMDemo
{
    public partial class Form1 : BaseForm<MainViewModel>
    {
        public Form1()
        {
            InitializeComponent();

            this.WhenActivated(a =>
            {
                a(this.Bind(ViewModel, vm => vm.Text, v => v.textBox1.Text));
                a(this.OneWayBind(ViewModel, vm => vm.LabelText, v => v.label1.Text));
                a(this.Bind(ViewModel, vm => vm.IsChecked, v => v.checkBox1.Checked));

                a(this.Bind(ViewModel, vm => vm.Title, v => v.Text));
                a(this.Bind(ViewModel, vm => vm.List, v => v.listBox1.DataSource));
                a(this.BindCommand(ViewModel, vm => vm.ShowAll, v => v.button1));
            });

            ViewModel = new MainViewModel();
        }
    }
}
