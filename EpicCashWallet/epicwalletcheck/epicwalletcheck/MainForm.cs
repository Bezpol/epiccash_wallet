/*
 * Created by SharpDevelop.
 * User: Milena
 * Date: 25.08.2020
 * Time: 23:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Diagnostics;


namespace epicwalletcheck
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			
		}
		
		void Button1Click(object sender, EventArgs e)
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

	        p.StartInfo.Arguments ="-r "+textBox1.Text+ " check"  ;
       

	        try {
	        	
	        	bool result = p.Start();
	                      
	        	
	        } catch (Exception ex) {
	        	
	        	//
	        	Debug.WriteLine(ex.Message);
	        	//label1.Text = "error";

	        }
			
			
		}
	}
}
