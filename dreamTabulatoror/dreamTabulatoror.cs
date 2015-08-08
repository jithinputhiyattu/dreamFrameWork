using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Glx.Gui;

namespace dreamTabulatoror
{



    public partial class dreamTabulatoror : FormG
    {
        public class Minterm
        {
            string _sValue;
            int _nVaue;
            bool _bAdded;
            bool _bListed;

            public Minterm(int nValue_i)
            {
                _bAdded = false;
                _sValue = "";
                _nVaue = nValue_i;
                int nIndex = nValue_i;
                int nPower = 0;
                while (nIndex > 0)
                {
                    int nMode = nIndex % 2;
                    nIndex = nIndex / 2;
                    _sValue = _sValue.Insert(0, nMode.ToString());
                    nPower++;
                }

                while (nPower < 4)
                {
                    _sValue = _sValue.Insert(0, "0");
                    nPower++;
                }

            }
            public bool IsListed
            {
                get { return _bListed; }
                set { _bListed = value; }
            }


            public bool IsAdded
            {
                get { return _bAdded; }
                set { _bAdded = value; }
            }

            public string StringValue
            {
                get
                {
                    return _sValue;
                }
            }


            public int GetWeight()
            {
                int nCount = 0;
                for (int nIndex = 0; nIndex < _sValue.Length; nIndex++)
                {
                    if ('1' == _sValue[nIndex])
                    {
                        nCount++;
                    }
                }

                return nCount;
            }



        }

        Minterm[] minArray;
        public dreamTabulatoror()
        {
            InitializeComponent();
        }
        private void FindAndAdd()
        {


        }



        private void numberTextBoxG1_TextChanged(object sender, EventArgs e)
        {
            if (numberTextBoxG1.Text.Length != 0)
            {
                gelButton1.Enabled = true;
            }
            else
            {
                gelButton1.Enabled = false;
            }
        }

        private void gelButton1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(numberTextBoxG1.Text);
        }


        public Minterm[] SortMintermByWeight(Minterm[] minArray)
        {
            int nValue = -1;
            int nLowerIndex = 0;

            Minterm mint = new Minterm(0);
            for (int nIndex = 0; nIndex < minArray.Length - 1; nIndex++)
            {
                for (int nIndexB = nIndex + 1; nIndexB < minArray.Length; nIndexB++)
                {
                    if (minArray[nIndex].GetWeight() > minArray[nIndexB].GetWeight())
                    {
                        mint = minArray[nIndex];
                        minArray[nIndex] = minArray[nIndexB];
                        minArray[nIndexB] = mint;
                    }
                }
            }
            return minArray;
        }
        private void gelButton2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int nCount = listBox1.Items.Count;
            minArray = new Minterm[nCount];
            for (int nIndex = 0; nIndex < nCount; nIndex++)
            {
                minArray[nIndex] = new Minterm(
                Convert.ToInt32(listBox1.Items[nIndex].ToString()));
            }

            minArray = SortMintermByWeight(minArray);
            for (int nIndex = 0; nIndex < nCount; nIndex++)
            {

                listView1.Items.Add(minArray[nIndex].StringValue);

                if (0 == minArray[nIndex].GetWeight() % 2)
                {
                    listView1.Items[nIndex].ForeColor = Color.Yellow;
                    listView1.Items[nIndex].BackColor = Color.Black;
                }
                else
                {
                    listView1.Items[nIndex].ForeColor = Color.Black;
                    listView1.Items[nIndex].BackColor = Color.Yellow;
                }
            }
        }
    }
}