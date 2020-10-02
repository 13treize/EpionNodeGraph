using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpionNodeGraph.NodeBase
{
	public class NodeMenu
	{
		public string Name { get; set; }
		public List<NodeMenu> Child { get; set; }
	}

	public class NodeMenuTreeView
	{
		public List<NodeMenu> treeview { get; set; }
		public void Init()
		{

			this.treeview = new List<NodeMenu>
			{
				new NodeMenu
				{
					Name = "田中　太郎",
					Child = new List<NodeMenu>
					{
						new NodeMenu { Name = "田中　花子" },
						new NodeMenu { Name = "田中　一郎" },
						new NodeMenu
						{
							Name = "木村　貫太郎",
							Child = new List<NodeMenu>
							{
								new NodeMenu { Name = "木村　はな" },
								new NodeMenu { Name = "木村　梅" },
							}
						}
					}
				},
				new NodeMenu
				{
					Name = "田中　次郎",
					Child = new List<NodeMenu>
					{
						new NodeMenu { Name = "田中　三郎" }
					}
				}
			};

		}
	}
}
