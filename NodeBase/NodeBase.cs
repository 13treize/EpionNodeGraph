using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace EpionNodeGraph.NodeBase
{
	public class NodeBase 
	{
		public int Index { get; set; }
		public Point Position { get; set;}

		public int Size { get; set; }
		public Ellipse Object { get; set; }


		public NodeBase()
		{
			Object = new Ellipse
			{
				//Margin = new Thickness(pos.X, pos.Y, 0, 0),
				//Width = 100,
				//Height = 100
			};

			//Index = index;
		}
	}
}
