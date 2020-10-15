using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace EpionNodeGraph.NodeBase
{
	public class NodeTabItem :TabItem
	{
		public NodeTabItem(string header_name)
		{
			this.Header = header_name;
			NodeMenu nodeMenu = new NodeMenu();

			SolidColorBrush ColorBrush = new SolidColorBrush();
			ColorBrush.Color = Color.FromRgb(200, 200, 200);

			SolidColorBrush mySolidColorBrush = new SolidColorBrush();
			mySolidColorBrush.Color = Color.FromRgb(20, 0, 200);
			NodeBase node = new NodeBase();
			node.Object.Width = 100;
			node.Object.Height = 100;
			node.Object.Fill = mySolidColorBrush;
			//this.Grid1.Children.Add(ellipse);

			Grid grid = new Grid();
			grid.Background = ColorBrush;
			grid.Children.Add(nodeMenu.WrapPanel);
			grid.Children.Add(node.Object);
			this.AddChild(grid);
		}
	}
}
