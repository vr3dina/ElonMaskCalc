using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EM.Calc.WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Core.Calc Calc { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            Calc = new Core.Calc();
            string[] opers = Calc.Operations
                .Select(op => op.Name)
                .ToArray();


            cbOperation.Items.AddRange(
                Calc.Operations
                .Select(op => op.Name)
                .ToArray()
                );

            cbOperation.SelectedItem = cbOperation.Items[0];
            btnExec.Enabled = false;
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            //Replaces multiple spaces with one
            string strValues = Regex.Replace(tbInput.Text, @"\s+", " ");
            //Get operands
            var values = strValues
                .Trim(' ')
                .Split(' ')
                .Select(Convert.ToDouble)
                .ToArray();
            //Ger operation
            var operation = cbOperation.Text;

            var result = Calc.Calculate(operation, values);

            //Print result
            lblResult.Text = $"{result}";
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            lblResult.Text = "";
            if (IsCorrect(tbInput.Text))
            {
                lblInputErr.Text = "";
                btnExec.Enabled = true;
            }
            else
            {
                lblInputErr.Text = "Ошибка ввода операндов";
                btnExec.Enabled = false;
            }
        }

        /// <summary>
        /// if string is a correct sequence of numbers 
        /// returns true, else false
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private bool IsCorrect(string input)
        {
            //magic strings for parsing input
            string number = @"([-+]?\d+,?\d*)",
                pattern = $@"^(\s*{number}\s*(\s+{number}\s*)*)$";
            return (Regex.IsMatch(input, pattern));
        }
    }
}