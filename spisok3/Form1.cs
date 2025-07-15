using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace spisok3
{
    public partial class Spisok : Form
    {
        private LinkedList _list = new LinkedList();

        public Spisok()

        {
            InitializeComponent();
            this.BackColor = Color.Yellow; // Ƹ���� ��� �����
            this.Text = "������ �����";
            // ��������� TextBox
            txtNumber.BackColor = Color.Pink;
            txtNumber.Location = new Point(20, 20);
            txtNumber.Size = new Size(200, 30);

            // ��������� ListBox
            listBoxNumbers.BackColor = Color.Pink;
            listBoxNumbers.Location = new Point(20, 60);
            listBoxNumbers.Size = new Size(200, 150);

            // ��������� ������ "��������"
            btnAdd.BackColor = Color.Pink;
            btnAdd.Location = new Point(240, 20);
            btnAdd.Size = new Size(100, 30);
            btnAdd.Text = "��������";

            // ��������� ������ "������� (������� > 0.5)"
            btnRemove.BackColor = Color.Pink;
            btnRemove.Location = new Point(240, 60);
            btnRemove.Size = new Size(100, 30);
            btnRemove.Text = "�������";

            // ��������� ���������� �������
            this.ClientSize = new Size(400, 250);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] inputs = txtNumber.Text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            bool validInput = false;

            foreach (string input in inputs)
            {
                if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                {
                    _list.Add(number);
                    validInput = true;
                }
            }

            if (validInput)
            {
                UpdateListBox();
                txtNumber.Clear();
            }
            else
            {
                MessageBox.Show("������� ���������� �����!");
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            _list.RemoveWhereFractionGreaterThan05();
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBoxNumbers.Items.Clear();
            foreach (var number in _list.ToList())
            {
                listBoxNumbers.Items.Add(number);
            }
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            // ����� �������� ��������� �����, ���� �����
        }

        private void listBoxNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ����� �������� ������, ��������, ���������� ��������� �������
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
