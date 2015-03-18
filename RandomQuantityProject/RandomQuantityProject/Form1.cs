using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RandomQuantityProject
{
    public partial class Form1 : Form
    {
        DataTable autoTable = new DataTable();
        RandomQFunc obj ;

        public Form1()
        {
            InitializeComponent();
            autoTable.Columns.Add(quantities);
            autoTable.Columns.Add(frequency);
            autoTable.Columns.Add(relativeFrequency);
            dataGridView1.DataSource = autoTable;
        }
            DataColumn quantities = new DataColumn("Случайная величина");
            DataColumn frequency = new DataColumn("Частота");
            DataColumn relativeFrequency = new DataColumn("Относительная частота");

            private void button1_Click(object sender, EventArgs e)
            {
                textBox1.Text = "";
                int count = 1;
                int countFull = 0;
                List<int> summRQ = new List<int>();
                List<int> countOfRQ = new List<int>();
                List<int> RQList = new List<int>();

                obj = new RandomQFunc(Convert.ToInt32(textBoxShoter.Text), Convert.ToInt32(textBoxShot.Text));
                textBox1.Text=obj.setRandomForShoters();
                summRQ.Clear();
                for (int j = 0; j < Convert.ToInt32(TextBoxCountOfIter.Text); j++)
                {
                    summRQ.Add(obj.getRandomQuantityForShoter());
                }
                summRQ.Sort();
                autoTable.Clear();
                int result = summRQ[0];
                for( int i = 1; i < summRQ.Count; i++)
                {
                    if (result.Equals(summRQ[i]))
                    {
                        count++;
                        summRQ.RemoveAt(i);
                        i--;
                    }
                    else 
                    {
                            countOfRQ.Add(count);
                            count = 1;
                            result = summRQ[i];
                    }
                    if(i == summRQ.Count-1)
                    {
                         countOfRQ.Add(count);
                    }  
               }
                for (int i = 0; i < summRQ.Count; i++)
                {
                    TableComponent tableRQ = new TableComponent(summRQ[i], countOfRQ[i], Math.Round(Convert.ToDouble(countOfRQ[i]) / Convert.ToDouble(TextBoxCountOfIter.Text), 7));
                    autoTable.Rows.Add(tableRQ.randomQuantity, tableRQ.frequency, tableRQ.relativeFrequency);
                }

            }
       
        }
}
