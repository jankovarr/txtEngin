using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextCompare.resetStat();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string c = richTextBox1.Text;


            string[] rows = c.Split('\n');
            string result = string.Empty;
            foreach (string line in rows)
            {
             
                string row = line ;
                // Timestamp case:
                if ((line.Split('.').Length >= 4 && !line.Contains(',')) || (line.Split(',').Length >= 4) )
                {
                    row = line.Replace(".", "");
                    row = row.Replace(",", "");
                        //string s = c.Replace("\\", "");
                        //List<string> rows;
                        //rows = ;
                        
                        //foreach (string row in clip)
                        {
                            //20.180.726.230.246
                            //if (row.Length >= 14)
                            {


                                int i = 4 + 2 + 2 + 2 + 2 + 2;
                                int l = row.Length;
                                result += row.TrimEnd().Substring(0, 4) + "." + row.Substring(4, 2) + "." + row.Substring(6, 2) + "\t";
                                result += row.Substring(8, 2) + ":" + row.Substring(10, 2) + ":" + row.Substring(12, 2)
                                     + row.Substring(14, l - i) + '\n';
                                // + c.Substring()
                                //result += row.
                            }
                            
                        }
                    
                        // copy to clip board ??
                }
                else if (line.Length > 0 && line.Split('.').Length >= 0 && line.Split(',').Length >=0 && line.Split('-').Length >=0 )
                {
                    // Obsahuje taby \t ? 
                    // Ne:
                    foreach (string tab in line.Split('\t'))
                    {
                        row = tab.Replace(".", "");
                        if (row.Contains("-"))
                        {
                            row = "-" + row.Replace("-", "");

                        }
                        result += row + '\t';
                    }
                    string show = result.Substring(result.Length - 2, 1);
                    if (show == "\t")
                        result = result.Remove(result.Length-2, 1); // remove last tab?
                    
                    result += '\n';
                }
                else if (line.Length > 0)
                {
                    
                                result += row + '\n';
                }
                
                

            }

            richTextBox2.Text = result;

            bool isDiff = result != Clipboard.GetText() + "\n";
            if (result != "" && isDiff && chbBackToClip.Checked) Clipboard.SetText(result);





        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            if (chbHoo.Checked)
            {
                int len = Clipboard.GetText().Length;
              //  chbHooAddsTest.Enabled = true;
                if (chbHooAddsTest.Checked)
                    richTextBox1.Text += Clipboard.GetText() + (len == 0 ? "": "\n");
                else
                    richTextBox1.Text = Clipboard.GetText() + (len == 0 ? "" : "\n");
            }
            //else
               // chbHooAddsTest.Enabled = false;
           // chbHooAddsTest.Refresh();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_MouseHover(object sender, EventArgs e)
        {
            //Form1_MouseHover(null, null);
        }

        private void richTextBox1_MouseHover(object sender, EventArgs e)
        {
           Form1_MouseHover(null, null);
        }

        private void chbHoo_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbHoo.Checked)
            {
                
                chbHooAddsTest.Enabled = true;
              
            }
            else
                chbHooAddsTest.Enabled = false;
            chbHooAddsTest.Refresh();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            //Form1_MouseHover(null, null);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if  (e.KeyCode == Keys.D)
            {
                richTextBox1.Text = "";
            }
        }

        private void groupBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                richTextBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void btnDuplicates_Click(object sender, EventArgs e)
        {
            var list = new List<string>();
            foreach (var l in  richTextBox1.Lines)
            {
                list.Add(l);
            }

            if (TextCompare.AreDups(list))
                richTextBox2.Text = TextCompare.GetOutList();
            else
                richTextBox2.Text = "No duplicates";


        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            if ('r' == TextCompare.AddLeftRight(prepList()))
            {
                var list = TextCompare.GetDiffList();
                string st = string.Empty;
                foreach (string s in list)
                    { st += s + "\n"; }
                richTextBox2.Text = st;
            }
            else
            {
                richTextBox2.Text = "Paste Customer's Note List";
                richTextBox3.Clear(); 
            }
                

        }

        List<string> prepList()
        {
            var retList = new List<string>();
            foreach (string s in richTextBox3.Lines)
                retList.Add(s);
            return retList;
        }
    }
}
