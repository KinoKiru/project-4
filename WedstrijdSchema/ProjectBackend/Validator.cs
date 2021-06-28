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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="textBox"></param>
		/// <returns></returns>
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
	
		/// <summary>
		/// Checkt of de value een decimaal is
		/// </summary>
		/// <param name="textBox"></param>
		/// <returns></returns>
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

/// <summary>
/// Checkt of de value een int value is
/// </summary>
/// <param name="textBox"></param>
/// <returns></returns>
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

		/// <summary>
		/// checkt of de gegeven value binnen de min en max valt
		/// </summary>
		/// <param name="textBox">txtbox met de value</param>
		/// <param name="min">min value</param>
		/// <param name="max">max value</param>
		/// <returns></returns>
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

		/// <summary>
		/// checkt of de textbox een email is
		/// </summary>
		/// <param name="textbox"></param>
		/// <returns></returns>
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
