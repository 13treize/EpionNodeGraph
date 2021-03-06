﻿using GongSolutions.Wpf.DragDrop;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace EpionNodeGraph.ViewModel
{
	public class ViewModel : IDropTarget
	{
		public ObservableCollection<string> Files { get; set; }

		public ViewModel()
		{
			Files = new ObservableCollection<string>();
		}
		public void MenuItem()
		{
			NodeBase.NodeMenu nodeMenu= new NodeBase.NodeMenu();
		}

		public void DragOver(IDropInfo dropInfo)
		{
			var dragFileList = ((DataObject)dropInfo.Data).GetFileDropList().Cast<string>();
			dropInfo.Effects = dragFileList.Any(_ =>
			{
				return IsEShader(_);
			}) ? DragDropEffects.Copy : DragDropEffects.None;
		}

		public void Drop(IDropInfo dropInfo)
		{
			var dragFileList = ((DataObject)dropInfo.Data).GetFileDropList().Cast<string>();
			dropInfo.Effects = dragFileList.Any(_ =>
			{
				return IsEShader(_);
			}) ? DragDropEffects.Copy : DragDropEffects.None;

			foreach (var file in dragFileList)
			{
				if (IsEShader(file))
				{
					Files.Add(file);
				}
			}
		}

		private bool IsEShader(string data)
		{
			var extension = Path.GetExtension(data);
			return extension != null && extension == ".eshader";
		}
	}
}
