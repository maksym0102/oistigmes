using ElectronNET.API;
using ElectronNET.API.Entities;

namespace oistigmes_desktop_app
{
    public class ElectronApp
    {
        public async static void ElectronBootstrap()
        {
            var browserWindow = await Electron.WindowManager.CreateWindowAsync(new BrowserWindowOptions
            {
                Show = false,
            });

            await browserWindow.WebContents.Session.ClearCacheAsync();
            browserWindow.OnReadyToShow += () => browserWindow.Show();

            browserWindow.LoadURL("https://oistigmes.foxnet-polska.pl/");
            browserWindow.SetTitle("OISTIGMES App");
            browserWindow.Maximize();
            browserWindow.RemoveMenu();
          
            browserWindow.OnClosed += () => Electron.App.Quit();
        }

    }
}
