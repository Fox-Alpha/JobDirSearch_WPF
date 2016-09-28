using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobDirSearch_WPF.ViewModels;
using Stylet;
using StyletIoC;

namespace JobDirSearch_WPF
{
	class Bootstrapper : Bootstrapper<MainViewModel>
	{
		protected override void OnStart ()
		{
			// This is called just after the application is started, but before the IoC container is set up.
			// Set up things like logging, this.Assemblies, etc
		}

		protected override void ConfigureIoC (IStyletIoCBuilder builder)
		{
			// Bind your own types. Concrete types are automatically self-bound.
			//builder.Bind<SettingsService> ().ToSelf ().InSingletonScope ();
			//builder.Bind<ServerManagementService> ().ToSelf ().InSingletonScope ();

			/*builder.Bind<SettingsViewModel>().ToFactory(x => new SettingsViewModel()).InSingletonScope();
            builder.Bind<ServerDetailViewModel>().ToFactory(x => new ServerDetailViewModel()).InSingletonScope();*/
		}

		protected override void Configure ()
		{
			// This is called after Stylet has created the IoC container, so this.Container exists, but before the
			// Root ViewModel is launched.
			// Configure your services, etc, in here
			//var settings = Container.Get<SettingsService> ();
			//settings.LoadSettings ();
			//var servermanagement = Container.Get<ServerManagementService> ();
			//servermanagement.LoadServerList (settings.LastServerList);
			//servermanagement.LoadServerTags (settings.ServerTagsPath);
		}

		protected override void OnLaunch ()
		{
			// This is called just after the root ViewModel has been launched
			// Something like a version check that displays a dialog might be launched from here
		}

		//protected override void OnExit (ExitEventArgs e)
		//{
		//	// Called on Application.Exit
		//	//Container.Get<SettingsService> ().SaveSettings ();
		//	//Container.Get<ServerManagementService> ().SaveServerList (Container.Get<SettingsService> ().LastServerList);
		//}

		//protected override void OnUnhandledException (DispatcherUnhandledExceptionEventArgs e)
		//{
		//	// Called on Application.DispatcherUnhandledException
		//	//Container.Get<IWindowManager> ().ShowMessageBox ($"An unhandled Exception occurred:\n{e.Exception.ToString ()}");
		//}
	}
}
