using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace EpionNodeGraph.NodeBase
{
	public class NodeTabItem :TabItem
	{
		// マウス押下中フラグ
		private bool IsMouseDown;

		// マウスの移動が開始されたときの座標
		private Point StartPoint;

		// マウスの現在位置座標
		private Point CurrentPoint;
		private Canvas canvas;
		private List<NodeBase> node;
		public NodeTabItem(string header_name)
		{
			this.Header = header_name;
			NodeMenu nodeMenu = new NodeMenu();

			SolidColorBrush ColorBrush = new SolidColorBrush();
			ColorBrush.Color = Color.FromRgb(200, 200, 200);

			SolidColorBrush mySolidColorBrush = new SolidColorBrush();
			mySolidColorBrush.Color = Color.FromRgb(20, 0, 200);
			SolidColorBrush mySolidColorBrush2 = new SolidColorBrush();
			mySolidColorBrush2.Color = Color.FromRgb(200, 0, 0);

			Ellipse e = new Ellipse();
			e.Width = 10;
			e.Height = 10;
			e.Fill = mySolidColorBrush2;
			node = new List<NodeBase>();
			node.Add(new NodeBase());
			node[0].Object.Width = 100;
			node[0].Object.Height = 100;

			node[0].Object.Fill = mySolidColorBrush;
			Canvas.SetTop(node[0].Object, 300);
			Canvas.SetLeft(node[0].Object, 600);

			//this.Grid1.Children.Add(ellipse);

			canvas = new Canvas();
			canvas.Name = "canvas";
			canvas.Background = ColorBrush;
			canvas.Children.Add(nodeMenu.WrapPanel);

			canvas.Children.Add(node[0].Object);
			canvas.Children.Add(e);

			MouseButtonEventHandler mouseEvent = new MouseButtonEventHandler(this.OperationArea_MouseLeftButtonDown);
			canvas.MouseLeftButtonDown += mouseEvent;

			MouseButtonEventHandler mouseEvent2 = new MouseButtonEventHandler(this.OperationArea_MouseLeftButtonUp);
			canvas.MouseLeftButtonUp += mouseEvent2;

			MouseEventHandler eventHandler = new MouseEventHandler(this.OperationArea_MouseMove);
			canvas.MouseMove += eventHandler;

			MouseEventHandler eventHandler1=new MouseEventHandler(this.OperationArea_MouseLeave);
			canvas.MouseLeave += eventHandler1;

			this.AddChild(canvas);
		}
		// マウス左ボタン押下イベントのイベントハンドラ
		private void OperationArea_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			IsMouseDown = true;
			StartPoint = e.GetPosition(canvas);
			node[0].MouseLeftButtonDown(sender, e);
			e.Handled = true;
		}
		private void OperationArea_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			IsMouseDown = false;
			node[0].MouseLeftButtonUp(sender, e);
			e.Handled = true;
		}

		private void OperationArea_MouseMove(object sender, MouseEventArgs e)
		{
			if (!IsMouseDown)
			{
				return;
			}

			CurrentPoint = e.GetPosition(canvas);

			Point offset =new Point(CurrentPoint.X - StartPoint.X, CurrentPoint.Y - StartPoint.Y);
			node[0].SetPos(offset);

			StartPoint = CurrentPoint;
			e.Handled = true;
		}
		private void OperationArea_MouseLeave(object sender, MouseEventArgs e)
		{
			IsMouseDown = false;

			e.Handled = true;
		}
	}
}
