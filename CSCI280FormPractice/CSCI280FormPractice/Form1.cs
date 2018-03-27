using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI280FormPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtRules.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LinkedList<KeyValuePair<string, object>> variables = new LinkedList<KeyValuePair<string, object>>();

            int ITEM_NO = 10;

            variables.AddLast(new KeyValuePair<string, object>("ITEM_NO", ITEM_NO));

            txtRules.Text = txtRules.Text.ToUpper();
            string[] token = txtRules.Text.Split(' ');

            if(! token[0].Equals("IF"))
            {
                throw new EvaluateException("IF statement not well formed.");
            }

            KeyValuePair<string, object> kvp;
            kvp = new KeyValuePair<string, object>("ITEM_NO", null);

            bool found = false;

            foreach(KeyValuePair<string, object> k in variables)
            {
                if(kvp.Key.Equals(token[1]))
                {
                  obj = kvp.object;
                    found = true;

                }
            }

            if(!found)
            {
                throw new KeyNotFoundException($"'{token[1]}' varialbe not found.");
            }

            //token[1] // ITEM_NO

            switch(token[2])
            {
                case "IS":
                    if( int.Parse(obj.ToString()) == int.Parse(token[3]))
                    {
                        MessageBox.Show("Equals!");
                    }
                    break;

                default:

                    throw new EvaluateException("Invalid comparison operator");
            }
        }
    }
}
