namespace EpionNodeGraph
{
	using System;
	using System.Windows;
	class App : Application
	{
		private void InitializeComponent()
		{
			// StartupUri は使えないので Startup イベントを使う
			this.Startup += App_Startup;
		}
		private void App_Startup(object sender, StartupEventArgs e)
		{
			// ウィンドウを作成して表示させるコードを明示的に書く
			var w = new MainWindow();
			w.Show();
		}
		[STAThread]
		public static void Main(string[] args)
		{
			// App クラスを作成して初期化して実行
			var app = new App();
			app.InitializeComponent();
			app.Run();
		}
	}
}
