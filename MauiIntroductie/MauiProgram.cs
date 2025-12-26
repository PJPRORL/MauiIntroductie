using MauiIntroductie.Views;
using MauiIntroductie.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiIntroductie
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            // VoorbeeldPage
            builder.Services.AddSingleton<VoorbeeldPage>();
            builder.Services.AddSingleton<PersoonViewModel>();

            // LabelsPage
            builder.Services.AddSingleton<LabelsPage>();
            builder.Services.AddSingleton<LabelsViewModel>();

            // StacklayoutPage
            builder.Services.AddSingleton<StackLayoutPage>();
            builder.Services.AddSingleton<StackLayoutViewModel>();

            builder.Services.AddSingleton<FotoPage>();
            builder.Services.AddSingleton<FotoViewModel>();

            builder.Services.AddTransient<NamenPage>();
            builder.Services.AddSingleton<NamenViewModel>();

            return builder.Build();
         }
    }
}
