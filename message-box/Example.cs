using System;
using System.Windows.Forms;

namespace Example{

	public class Example{

		public Example (){
			System.Console.WriteLine("Quem?");
		}

		static void Main(string[] args){

			string message = "Do you like Visual Studio?";
			string caption = "Example";

			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result;

			// Displays the MessageBox.
			result = MessageBox.Show(message, caption, buttons);

			if (result == System.Windows.Forms.DialogResult.Yes){
				System.Console.WriteLine(args.Length);
			}
		}
	}
}

