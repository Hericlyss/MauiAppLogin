using Microsoft.Extensions.DependencyInjection;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // 1. Cria a janela baseada no seu AppShell
            var window = new Window(new AppShell());

            // 2. Define as dimensões da janela
            window.Width = 350;
            window.Height = 600;

            // 3. Retorna a janela configurada
            return window;
        }

    }
    
}