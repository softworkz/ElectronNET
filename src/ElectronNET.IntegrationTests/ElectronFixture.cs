namespace ElectronNET.IntegrationTests
{
    using System.Reflection;
    using ElectronNET.API;
    using ElectronNET.API.Entities;

    // Shared fixture that starts Electron runtime once
    public class ElectronFixture : IAsyncLifetime
    {
        public BrowserWindow MainWindow { get; private set; } = null!;

        public async Task InitializeAsync()
        {
            try
            {
                Console.Error.WriteLine("[ElectronFixture] InitializeAsync: start");
                AppDomain.CurrentDomain.SetData("ElectronTestAssembly", Assembly.GetExecutingAssembly());
                Console.Error.WriteLine("[ElectronFixture] Acquire RuntimeController");
                var runtimeController = ElectronNetRuntime.RuntimeController;
                Console.Error.WriteLine("[ElectronFixture] Starting Electron runtime...");
                await runtimeController.Start();
                Console.Error.WriteLine("[ElectronFixture] Waiting for Ready...");
                await runtimeController.WaitReadyTask;
                Console.Error.WriteLine("[ElectronFixture] Runtime Ready");

                // create hidden window for tests (avoid showing UI)
                Console.Error.WriteLine("[ElectronFixture] Creating hidden BrowserWindow");
                this.MainWindow = await Electron.WindowManager.CreateWindowAsync(new BrowserWindowOptions
                {
                    Show = false,
                    Width = 800,
                    Height = 600,
                }, "about:blank");

                Console.Error.WriteLine("[ElectronFixture] Clearing session cache");
                await this.MainWindow.WebContents.Session.ClearCacheAsync();
                Console.Error.WriteLine("[ElectronFixture] InitializeAsync: done");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("[ElectronFixture] InitializeAsync: exception");
                Console.Error.WriteLine(ex.ToString());
                throw;
            }
        }

        public async Task DisposeAsync()
        {
            var runtimeController = ElectronNetRuntime.RuntimeController;
            Console.Error.WriteLine("[ElectronFixture] Stopping Electron runtime...");
            await runtimeController.Stop();
            await runtimeController.WaitStoppedTask;
            Console.Error.WriteLine("[ElectronFixture] Runtime stopped");
        }
    }

    [CollectionDefinition("ElectronCollection")]
    public class ElectronCollection : ICollectionFixture<ElectronFixture>
    {
    }
}