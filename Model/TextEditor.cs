using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EpionNodeGraph.Model
{
	enum TextType
	{
		HLSL,
		GLSL
	}
	public class TextEditor :TextBox
	{
		public TextEditor()
		{
			this.IsReadOnly = true;
			this.Text = "Initial text contents of the TextBox.";
		}
	}
}
