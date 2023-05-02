using System.Collections.Generic;

namespace l2
{
    public partial class Form1 : Form
    {
        LinkedList list = new LinkedList(new string[] { "hello", "world", "this", "is", "a", "test" });
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            rtxtList.Text = "";
            string add = txtString.Text;
            list.Add(add);
            Node current = list.Head;

            while (current != null)
            {
                rtxtList.Text += Convert.ToString(current.Data) + "  ";
                current = current.Next;
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            rtxtList.Text = "";
            string remove = txtString.Text;
            list.Remove(remove);
            Node current = list.Head;

            while (current != null)
            {
                rtxtList.Text += Convert.ToString(current.Data) + "  ";
                current = current.Next;
            }

        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            rtxtList.Text = "";
            list.RemoveAll();
            Node current = list.Head;

            while (current != null)
            {
                rtxtList.Text += Convert.ToString(current.Data) + "  ";
                current = current.Next;
            }
        }

        private void btnFrom_Click(object sender, EventArgs e)
        {
            rtxtList.Text = "";
            string remove = txtString.Text;
            list.RemoveAfter(remove);
            Node current = list.Head;

            while (current != null)
            {
                rtxtList.Text += Convert.ToString(current.Data) + "  ";
                current = current.Next;
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            rtxtList.Text = "";
            list.RemoveEnd();
            Node current = list.Head;

            while (current != null)
            {
                rtxtList.Text += Convert.ToString(current.Data) + "  ";
                current = current.Next;
            }
        }

        private void txtString_Click(object sender, EventArgs e)
        {
            txtString.Text = "";
        }
    }
}