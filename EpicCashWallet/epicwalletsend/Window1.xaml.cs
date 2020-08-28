/*
 * Created by SharpDevelop.
 * User: Milena
 * Date: 28.08.2020
 * Time: 19:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Diagnostics;
using System.Globalization;



namespace epicwalletsend
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
		}
		void button1_Click(object sender, RoutedEventArgs e)
		{
			
			
						
			Process p = new Process();
	        //ProcessStartInfo startInfo = new ProcessStartInfo();
	        p.StartInfo.CreateNoWindow = false;
	        p.StartInfo.UseShellExecute = true;
	       // p.StartInfo.RedirectStandardOutput = true;
	       // p.StartInfo.RedirectStandardError = true;
	       
	        //p.StartInfo.RedirectStandardInput = true;
	        
	      
	        p.StartInfo.FileName = "epic-wallet.exe";
	        p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;

	        

	        try {
	        	
	        	String amout1 = amount.Text.Replace('.',',');
				double value = double.Parse(amout1);
				const string specifier = "G";
				CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");

	        	p.StartInfo.Arguments ="-r "+ server.Text + " send -d "+ where.Text + "  " + value.ToString(specifier, culture) + " -g " + "\""+message.Text+"\"";
	        
	        	Debug.WriteLine(p.StartInfo.Arguments);
       	
	        	
	        	bool result = p.Start();
	                      
	        	
	        } catch (Exception ex) {
	        	
	        	//
	        	Debug.WriteLine(ex.Message);
	        	//label1.Text = "error";

	        }
		}
	}
}