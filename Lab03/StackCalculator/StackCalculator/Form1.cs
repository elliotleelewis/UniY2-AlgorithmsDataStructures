using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace StackCalculator
{
    public partial class Form1 : Form
    {
        private readonly IntStack stack = new IntStack();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Process(txtData.Text);
            txtTopStack.Text = stack.Peek().ToString();
            txtStackDisplay.Text = stack.Print();
        }
        private void Process(string input)
        {
            int rhs, lhs;
            switch (input) {
                case "+":
                    stack.Push(stack.Pop() + stack.Pop());
                    break;
                case "-":
                    rhs = stack.Pop();
                    lhs = stack.Pop();
                    stack.Push(lhs - rhs);
                    break;
                case "*":
                    stack.Push(stack.Pop() * stack.Pop());
                    break;
                case "/":
                    rhs = stack.Pop();
                    lhs = stack.Pop();
                    stack.Push(lhs / rhs);
                    break;
                case "<>":
                    rhs = stack.Pop();
                    lhs = stack.Pop();
                    stack.Push(rhs);
                    stack.Push(lhs);
                    break;
                default:
                    stack.Push(Convert.ToInt32(input));
                    break;
            }
        }
    }
}