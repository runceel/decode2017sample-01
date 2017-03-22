using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DecodeSampleApp01.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string inputText;

        public string InputText
        {
            get { return this.inputText; }
            set { this.SetProperty(ref this.inputText, value); }
        }

        private string outputText;

        public string OutputText
        {
            get { return this.outputText; }
            set { this.SetProperty(ref this.outputText, value); }
        }

        public DelegateCommand ExecuteCommand { get; }

        public MainPageViewModel()
        {
            this.ExecuteCommand = new DelegateCommand(() =>
            {
                var tokens = this.InputText.Split(',');
                this.OutputText = $"{tokens[1]},{tokens[0]}";
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }
    }
}
