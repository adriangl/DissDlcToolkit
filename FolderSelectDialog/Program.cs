using System;
using System.Windows.Forms;

namespace FolderSelect
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			Console.WriteLine(Environment.OSVersion.Platform.ToString());
			Console.WriteLine(Environment.OSVersion.Version.Major);

			{
				var fsd = new FolderSelectDialog();
				fsd.Title = "What to select";
				fsd.InitialDirectory = @"c:\";
				if (fsd.ShowDialog(IntPtr.Zero))
				{
					Console.WriteLine(fsd.FileName);
				}
			}
		}
	}
}
