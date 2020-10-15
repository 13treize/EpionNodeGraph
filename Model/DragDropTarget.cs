using GongSolutions.Wpf.DragDrop;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EpionNodeGraph.Model
{
	public class DragDropTarget : IDropTarget
	{
		public ObservableCollection<string> Files { get; set; }
		public DragDropTarget()
		{
			Files = new ObservableCollection<string>();
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
