namespace AuthorApp;

using Application = Microsoft.Maui.Controls.Application;
public partial class App : Application
{
	public App()
	{
		try
		{

			InitializeComponent();
			AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
			{
				if (e.ExceptionObject is Exception exception && exception != null)
				{
					System.Diagnostics.Debug.WriteLine($"[UnhandledException] {exception?.Message}");
					throw exception ?? new Exception("Unhandled exception occurred, but exception object was null.");
				}
			};
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Error during app initialization: {ex.Message}");
		}
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
}