using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace EpionNodeGraph.Model
{
	public class TextEditorTabItem : TabItem
	{
		public TextEditorTabItem(string header_name)
		{
			this.Header = header_name;

			SolidColorBrush ColorBrush = new SolidColorBrush();
			ColorBrush.Color = Color.FromRgb(200, 200, 200);
			Grid grid = new Grid();
			grid.Background = ColorBrush;
			TextEditor textEditor = new TextEditor();
			grid.Children.Add(textEditor);
			this.AddChild(grid);

		}
	}
}
