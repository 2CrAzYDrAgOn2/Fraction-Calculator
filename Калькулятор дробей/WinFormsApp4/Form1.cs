using Microsoft.Office.Interop.Excel;

using Excel = Microsoft.Office.Interop.Excel;

using Word = Microsoft.Office.Interop.Word;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public double a, b, adown, bdown, result, achel, bchel, resulta, resultb;
        public string operand = "+";

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        /// <summary>
        /// button1_Click ��������� �������� ��� ������� ������ "����������"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = textBox2.ForeColor = textBox3.ForeColor = textBox4.ForeColor = textBox5.ForeColor = textBox6.ForeColor = textBox7.ForeColor = Color.Black;
            if (textBox6.Text == "")
            {
                textBox6.Text = "0"; // ������������� ������ ����� 1 ���������� � 0, ���� ��� �� �������
            }
            if (textBox7.Text == "")
            {
                textBox7.Text = "0"; // ������������� ������ ����� 2 ���������� � 0, ���� ��� �� �������
            }
            try
            {
                a = EvaluateExpression(textBox1); // ������������� textBox1 � ���������� a
                b = EvaluateExpression(textBox2); // ������������� textBox2 � ���������� b
                adown = EvaluateExpression(textBox4); // ������������� textBox4 � ���������� adown
                bdown = EvaluateExpression(textBox5); // ������������� textBox5 � ���������� bdown
                achel = EvaluateExpression(textBox6); // ������������� textBox6 � ���������� achel
                bchel = EvaluateExpression(textBox7); // ������������� textBox7 � ���������� bchel
                resulta = achel + a / adown; // ������ ����� ������ ����� 1-�� ���������� � ������
                resultb = bchel + b / bdown; // ������ ����� ������ ����� 2-�� ���������� � ������
                operand = comboBox1.Text; // ������� ����� ��������� ������ � comboBox1
                switch (operand)
                {
                    case "+":
                        result = (resulta + resultb); // �������� 1-�� ���������� �� 2-�� ����������
                        break;

                    case "-":
                        result = (resulta - resultb); // ��������� �� 1-�� ���������� 2-�� ����������
                        break;

                    case "*":
                        result = (resulta * resultb); // ��������� 1-�� ���������� �� 2-�� ����������
                        break;

                    case "/":
                        result = (resulta / resultb); // ������� 1-�� ���������� �� 2-��
                        break;
                }
                textBox3.Text = Convert.ToString(result); // ����������� ���������� � string
            }
            catch
            {
                MessageBox.Show("������� ����������"); // ����� ��������� �� ������
            }
            if (textBox3.Text.Contains("\u221E"))
            {
                textBox3.Text = "�� ���� ������ ������"; // ����� ��������� � textBox3
            }
        }

        /// <summary>
        /// button2_Click ��������� �������� ��� ������� ������ "��������"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); // ������� ��������� 1-�� ����������
            textBox4.Clear(); // ������� ����������� 1-�� ����������
            textBox5.Clear(); // ������� ����������� 2-�� ����������
            textBox2.Clear(); // ������� ��������� 2-�� ����������
            textBox6.Text = "0"; // ������������� ������ ����� 1-�� ���������� � 0
            textBox7.Text = "0"; // ������������� ������ ����� 2-�� ���������� � 0
            textBox3.Clear(); // ������� ����������
        }

        /// <summary>
        /// button3_Click ��������� �������� ��� ������� ������ "�����"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); // �������� �����
        }

        /// <summary>
        /// button4_Click ��������� �������� ��� ������� ������ "������� � Word"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            button1.PerformClick(); // ��������� �� �� ��������, ��� � ������ "����������"
            Word.Application wordapp = new(); // �������� ������� � Word
            Word.Document worddoc = wordapp.Documents.Add(); // �������� ������ ��������� � Word
            wordapp.Selection.TypeText("������ ����������: " + textBox6.Text + " , " + textBox1.Text + " / " + textBox4.Text + "\n" + "������ ����������: " + textBox7.Text + " , " + textBox2.Text + " / " + textBox5.Text + "\n" + "�������: " + comboBox1.Text + "\n" + "���������: " + textBox3.Text); // ����� ������
            wordapp.Visible = true; // �������� Word
        }

        /// <summary>
        /// button5_Click ��������� �������� ��� ������� ������ "������� � Excel"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            button1.PerformClick(); // ��������� �� �� ��������, ��� � ������ "����������"
            Excel.Application excel = new(); // �������� ������� � Excel
            Workbook workbook = excel.Workbooks.Add(); // �������� ����� ����� � Excel
            Worksheet worksheet = (Worksheet)workbook.Worksheets[1]; // �������� ����� � Excel
            worksheet.Name = "�����"; // �������� ����� � Excel
            worksheet.Cells[1, 1] = "������ ����������:"; // ����� ������ � ������� �1
            worksheet.Cells[2, 1] = (textBox6.Text + " , " + textBox1.Text + " / " + textBox4.Text); // ����� ������ � ������� �2
            worksheet.Cells[1, 3] = "������ ����������:"; // ����� ������ � ������� �1
            worksheet.Cells[2, 3] = (textBox7.Text + " , " + textBox2.Text + " / " + textBox5.Text); // ����� ������ � ������� �2
            worksheet.Cells[1, 2] = "�������:"; // ����� ������ � ������� �1
            worksheet.Cells[2, 2] = comboBox1.Text; // ����� ������ � ������� �2
            worksheet.Cells[1, 4] = "���������:"; // ����� ������ � ������� D1
            worksheet.Cells[2, 4] = textBox3.Text; // ����� ������ � ������� D2
            Microsoft.Office.Interop.Excel.Range calculator = worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 6]]; // �������� ������� � Excel
            calculator.EntireColumn.AutoFit(); // �������������� ��������� ������� ��� �����
            calculator.EntireRow.AutoFit(); // �������������� ��������� ����� ��� �����
            excel.Visible = true; // �������� Excel
        }

        /// <summary>
        /// EvaluateExpression ����������� ��������� � �����
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        private static double EvaluateExpression(System.Windows.Forms.TextBox expression)
        {
            try
            {
                expression.Text = expression.Text.Replace(" ", ""); // �������� �������� �� ���������
                System.Data.DataTable dt = new(); // �������� ������� ��� ���������� �������������� ���������
                var result = dt.Compute(expression.Text, ""); // ���������� �������������� ���������
                return Convert.ToDouble(result); // ������� ����������
            }
            catch (Exception ex)
            {
                expression.ForeColor = Color.Red;
                expression.Text = "0";
                MessageBox.Show($"������ � {expression}: " + ex.Message + "��� ���� � �������� ���� �������� �� 0"); // ����� ������
                return 0.0;
            }
        }

        /// <summary>
        /// textBox6_KeyPress ��������� �������� ��� ������� ������ �� ����� ����������� �� textBox6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // ������������� ���������� ��������� ������� ������� Enter
                textBox1.Focus(); // ��������� ����� �� ������ TextBox
            }
        }

        /// <summary>
        /// textBox1_KeyPress ��������� �������� ��� ������� ������ �� ����� ����������� �� textBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // ������������� ���������� ��������� ������� ������� Enter
                textBox4.Focus(); // ��������� ����� �� ������ TextBox
            }
        }

        /// <summary>
        /// textBox4_KeyPress ��������� �������� ��� ������� ������ �� ����� ����������� �� textBox4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // ������������� ���������� ��������� ������� ������� Enter
                comboBox1.Focus(); // ��������� ����� �� comboBox
            }
        }

        /// <summary>
        /// textBox7_KeyPress ��������� �������� ��� ������� ������ �� ����� ����������� �� textBox7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // ������������� ���������� ��������� ������� ������� Enter
                textBox2.Focus(); // ��������� ����� �� ������ TextBox
            }
        }

        /// <summary>
        /// textBox2_KeyPress ��������� �������� ��� ������� ������ �� ����� ����������� �� textBox2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // ������������� ���������� ��������� ������� ������� Enter
                textBox5.Focus(); // ��������� ����� �� ������ TextBox
            }
        }

        /// <summary>
        /// textBox5_KeyPress ��������� �������� ��� ������� ������ �� ����� ����������� �� textBox5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // ������������� ���������� ��������� ������� ������� Enter
                button1.Focus(); // ��������� ����� �� ������ ����������
            }
        }

        /// <summary>
        /// comboBox1_KeyPress ��������� �������� ��� ������� ������ �� ����� ����������� �� comboBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // ������������� ���������� ��������� ������� ������� Enter
                textBox7.Focus(); // ��������� ����� �� ������ textBox
            }
        }
    }
}