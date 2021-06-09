using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBackend
{
    class Validator
    {
		private static string title = "Entry Error";

		public static string Title
		{
			get
			{
				return title;
			}
			set
			{
				title = value;
			}
		}

		public static bool IsPresent(TextBox textBox)
		{
			if (textBox.Text == "")
			{
				MessageBox.Show(textBox.Tag + " is a required field.", Title);
				textBox.Focus();
				return false;
			}
			return true;
		}

		public static bool IsDecimal(TextBox textBox)
		{
			decimal number = 0m;
			if (Decimal.TryParse(textBox.Text, out number))
			{
				return true;
			}
			else
			{
				MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
				textBox.Focus();
				return false;
			}
		}

		// The IsInt32 and IsWithinRange methods were omitted from figure 12-15.
		public static bool IsInt32(TextBox textBox)
		{
			int number = 0;
			if (Int32.TryParse(textBox.Text, out number))
			{
				return true;
			}
			else
			{
				MessageBox.Show(textBox.Tag + " must be an integer.", Title);
				textBox.Focus();
				return false;
			}
		}

		public static bool IsWithinRange(TextBox textBox, decimal min, decimal max)
		{
			decimal number = Convert.ToDecimal(textBox.Text);
			if (number < min || number > max)
			{
				MessageBox.Show(textBox.Tag + " must be between " + min
					+ " and " + max + ".", Title);
				textBox.Focus();
				return false;
			}
			return true;
		}

		public static bool IsValidEmail(TextBox textbox)
		{

			if (textbox.Text.Contains("@") && (textbox.Text.Contains(".com") || textbox.Text.Contains(".nl")))
			{
				return true;
			}
			MessageBox.Show("Voer geldige email in", "Fout melding");
			return false;

		}
	}
}
