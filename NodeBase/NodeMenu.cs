using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace EpionNodeGraph.NodeBase
{
	public class NodeMenu
	{
		public WrapPanel WrapPanel { get; set; }

		public NodeMenu()
		{
			WrapPanel = new WrapPanel();

			Menu MainMenu = new Menu();
			MenuItem menuFile = new MenuItem();
			menuFile.Header = "File";
			{
				MenuItem menuFileQuit = new MenuItem();
				menuFileQuit.Header = "Quit";
				RoutedEventHandler EventClick = new RoutedEventHandler(this.Quit_Click);
				menuFileQuit.Click += EventClick;
				menuFile.Items.Add(menuFileQuit);
			}
			MenuItem menuEdit = new MenuItem();
			menuEdit.Header = "Edit";
			MenuItem menuOption = new MenuItem();
			menuOption.Header = "Option";

			MainMenu.Items.Add(menuFile);
			MainMenu.Items.Add(menuEdit);
			MainMenu.Items.Add(menuOption);
			WrapPanel.Children.Add(MainMenu);
		}

		private void Quit_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

	}

}
