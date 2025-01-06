﻿using ScoreBlog.Views;

namespace ScoreBlog
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
           return new Window(new StartPage());
        }
    }
}