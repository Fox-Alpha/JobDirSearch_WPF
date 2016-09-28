using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
//using PropertyChanged;
using Stylet;
using StyletIoC;

namespace JobDirSearch_WPF.Views
{
	/// <summary>
	/// Interaktionslogik für MainView.xaml
	/// </summary>
	public partial class MainView : Window
	{

        public MainView ()
		{
			InitializeComponent ();
		}

		private void buttSerachJobDir_Click (object sender, RoutedEventArgs e)
		{
			//	Suche durchführen
		}

		private void buttCopyJobNo_Click (object sender, RoutedEventArgs e)
		{
			//	Kopieren der Jobnummer aus dem Eingabefeld
		}

		private void buttPasteJobNo_Click (object sender, RoutedEventArgs e)
		{
			//	Einfügen einer Jobnummer in das Eingabefeld
		}

		private void buttShowOptions_Click (object sender, RoutedEventArgs e)
		{
			//	Anzeigen des Optionen Dialogs
		}
	}
}
