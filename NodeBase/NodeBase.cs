using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
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

		private bool IsMouseDown;


		public NodeBase()
		{
			Object = new Ellipse();

			MouseButtonEventHandler mouseEvent = new MouseButtonEventHandler(this.MouseLeftButtonDown);
			Object.MouseLeftButtonDown += mouseEvent;

			MouseButtonEventHandler mouseEvent2 = new MouseButtonEventHandler(this.MouseLeftButtonUp);
			Object.MouseLeftButtonUp += mouseEvent2;

			MouseEventHandler eventHandler = new MouseEventHandler(this.MouseMoveObject);
			Object.MouseMove += eventHandler;
			MouseEventHandler eventHandler1 = new MouseEventHandler(this.MouseLeave);
			Object.MouseLeave += eventHandler1;

		}
		public void SetPos(Point point)
		{
			if (!IsMouseDown)
			{
				return;
			}

			Matrix matrix = ((MatrixTransform)Object.RenderTransform).Matrix;

			matrix.Translate(point.X,point.Y);

			Object.RenderTransform = new MatrixTransform(matrix);
		}

		public void SetPos(double x, double y)
		{
			if (!IsMouseDown)
			{
				return;
			}

			Matrix matrix = ((MatrixTransform)Object.RenderTransform).Matrix;

			matrix.Translate(x, y);

			Object.RenderTransform = new MatrixTransform(matrix);
		}

		public void MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			IsMouseDown = true;
			//e.Handled = true;
		}
		public void MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			IsMouseDown = false;
			//e.Handled = true;
		}

		public void MouseMoveObject(object sender, MouseEventArgs e)
		{
			IsMouseDown = true;
		}
		public void MouseLeave(object sender, MouseEventArgs e)
		{
			IsMouseDown = false;

			e.Handled = true;
		}
	}
}
