/***************************************************************************
 * x100 Open Source Project         June 2013                              *
 * Original code by Christopher Banyard                                    *
 * *Code may be replicated and manipulated under the Open Source lisencing *
 *  while retaining original name.                                         *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace x100

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
              try
            {
                if (checkBox1.Checked == true)  // Open .exe
                {
                    string[] filesList = Directory.GetFiles(@"C:\Program Files (x86)\", "*.exe", SearchOption.AllDirectories);

                    string[] filesList2 = Directory.GetFiles(@"C:\Program Files\", "*.exe", SearchOption.AllDirectories);

                    progressBar1.Maximum = filesList.Length + filesList2.Length;
                    progressBar1.Minimum = 0;
                    progressBar1.Step = 1;

                    #region
                    foreach (string location in filesList)
                    {
                        System.Diagnostics.Process.Start(@location);
                        System.Console.WriteLine(location);
                        textBox1.AppendText(location);
                        progressBar1.PerformStep();
                    }
                   
                    foreach (string location in filesList2)
                    {
                        System.Diagnostics.Process.Start(@location);
                        System.Console.WriteLine(location);
                        textBox1.AppendText(location);
                        progressBar1.PerformStep();
                    }
                    #endregion
                    MessageBox.Show("Successfully opened all files!");
                }
            

                else if (checkBox2.Checked == true)  // Open .jpg
                {
                    string[] filesList = Directory.GetFiles(@"C:\Users\", "*.jpg",
                                                 SearchOption.AllDirectories);

                    progressBar1.Maximum = filesList.Length;
                    progressBar1.Minimum = 0;
                    progressBar1.Step = 1;

                    #region
                    foreach (string location in filesList)
                    {
                        System.Diagnostics.Process.Start(@location);
                        System.Console.WriteLine(location);
                        textBox1.AppendText(location);
                        progressBar1.PerformStep();
                    }
                    MessageBox.Show("Successfully opened all files!");
                    #endregion
                }

                  else if (checkBox3.Checked == true)  // Open .png
                  {
                      string[] filesList = Directory.GetFiles(@"C:\Users\", "*.png",
                                                   SearchOption.AllDirectories);

                      progressBar1.Maximum = filesList.Length;
                      progressBar1.Minimum = 0;
                      progressBar1.Step = 1;

                      #region
                      foreach (string location in filesList)
                      {
                          System.Diagnostics.Process.Start(@location);
                          System.Console.WriteLine(location);
                          textBox1.AppendText(location);
                          progressBar1.PerformStep();
                      }
                      MessageBox.Show("Successfully opened all files!");
                      #endregion
                  }
                  else 
                      MessageBox.Show("Be sure to check off what file type you would like to open/list"); 
              }
            
            catch (Exception)
            {
                System.Console.WriteLine("Exception caught");
                MessageBox.Show("Failed!");
            }
            System.Console.WriteLine("Done");  
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)  // List .exe
                {
                    string[] filesList = Directory.GetFiles(@"C:\Program Files (x86)\", "*.exe", SearchOption.AllDirectories);

                    string[] filesList2 = Directory.GetFiles(@"C:\Program Files\", "*.exe", SearchOption.AllDirectories);

                    progressBar1.Maximum = filesList.Length + filesList2.Length;
                    progressBar1.Minimum = 0;
                    progressBar1.Step = 1;

                    #region
                    foreach (string location in filesList)
                    {
                        System.Console.WriteLine(location);
                        textBox1.AppendText(location);
                        progressBar1.PerformStep();
                    }
                 
                    foreach (string location2 in filesList2)
                    {
                        System.Console.WriteLine(location2);
                        textBox1.AppendText(location2);
                        progressBar1.PerformStep();
                    }
                    #endregion
                   
                    MessageBox.Show("Successfully listed all files!");
                }


                else if (checkBox2.Checked == true)   // List .jpg
                {
                    string[] filesList = Directory.GetFiles(@"C:\Users\", "*.jpg",
                                                 SearchOption.AllDirectories);

                    progressBar1.Maximum = filesList.Length;
                    progressBar1.Minimum = 0;
                    progressBar1.Step = 1;

                    #region
                    foreach (string location in filesList)
                    {
                        System.Console.WriteLine(location);
                        textBox1.AppendText(location);
                        progressBar1.PerformStep();
                    }
                    MessageBox.Show("Successfully opened all files!");
                    #endregion
                }

                else if (checkBox3.Checked == true)  // List .png
                {
                    string[] filesList = Directory.GetFiles(@"C:\Users\", "*.png",
                                                 SearchOption.AllDirectories);

                    progressBar1.Maximum = filesList.Length;
                    progressBar1.Minimum = 0;
                    progressBar1.Step = 1;

                    #region
                    foreach (string location in filesList)
                    {
                        System.Console.WriteLine(location);
                        textBox1.AppendText(location);
                        progressBar1.PerformStep();
                    }
                    MessageBox.Show("Successfully opened all files!");
                    #endregion

                }
                else 
                    MessageBox.Show("Be sure to check off what file type you would like to open/list!");
            }

            catch (Exception)
            {
                System.Console.WriteLine("Exception caught");
                MessageBox.Show("Failed!");
            }
            System.Console.WriteLine("Done");   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
