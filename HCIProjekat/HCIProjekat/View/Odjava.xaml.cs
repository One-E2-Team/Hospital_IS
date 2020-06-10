﻿using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace HCIProjekat.View
{
	/// <summary>
	/// Interaction logic for Odjava.xaml
	/// </summary>
	public partial class Odjava : Window
	{
		public Odjava()
		{
			InitializeComponent();
			this.Left = (System.Windows.SystemParameters.PrimaryScreenWidth / 2) - (this.Width / 2);
			this.Top = (System.Windows.SystemParameters.PrimaryScreenHeight / 2) - (this.Height / 2);
		}

		private void OdjaviMe_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
			var s = new MainWindow();
			s.Show();
		}

		private void Otkazi_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
