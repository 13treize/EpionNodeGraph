﻿using GongSolutions.Wpf.DragDrop;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EpionNodeGraph
{
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	/// 


	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			this.DataContext = new ViewModel.ViewModel();

			NodeBase.NodeTabItem a = new NodeBase.NodeTabItem("Tab1");
			NodeBase.NodeTabItem b = new NodeBase.NodeTabItem("Tab2");
			Model.TextEditorTabItem c = new Model.TextEditorTabItem("TextEditor");
			this.TabWindow.Items.Add(a);
			this.TabWindow.Items.Add(b);
			this.TabWindow.Items.Add(c);
		}
	}
}
