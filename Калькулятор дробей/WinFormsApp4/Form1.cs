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
        /// button1_Click выполняет действие при нажатии кнопки "Рассчитать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = textBox2.ForeColor = textBox3.ForeColor = textBox4.ForeColor = textBox5.ForeColor = textBox6.ForeColor = textBox7.ForeColor = Color.Black;
            if (textBox6.Text == "")
            {
                textBox6.Text = "0"; // приравнивание целого числа 1 переменной к 0, если оно не введено
            }
            if (textBox7.Text == "")
            {
                textBox7.Text = "0"; // приравнивание целого числа 2 переменной к 0, если оно не введено
            }
            try
            {
                a = EvaluateExpression(textBox1); // приравнивание textBox1 к переменной a
                b = EvaluateExpression(textBox2); // приравнивание textBox2 к переменной b
                adown = EvaluateExpression(textBox4); // приравнивание textBox4 к переменной adown
                bdown = EvaluateExpression(textBox5); // приравнивание textBox5 к переменной bdown
                achel = EvaluateExpression(textBox6); // приравнивание textBox6 к переменной achel
                bchel = EvaluateExpression(textBox7); // приравнивание textBox7 к переменной bchel
                resulta = achel + a / adown; // расчет суммы целого числа 1-ой переменной с дробью
                resultb = bchel + b / bdown; // расчет суммы целого числа 2-ой переменной с дробью
                operand = comboBox1.Text; // операнд равен выбранной строке в comboBox1
                switch (operand)
                {
                    case "+":
                        result = (resulta + resultb); // сложение 1-ой переменной со 2-ой переменной
                        break;

                    case "-":
                        result = (resulta - resultb); // вычитание из 1-ой переменной 2-ую переменную
                        break;

                    case "*":
                        result = (resulta * resultb); // умножение 1-ой переменной на 2-ую переменную
                        break;

                    case "/":
                        result = (resulta / resultb); // деление 1-ой переменной на 2-ую
                        break;
                }
                textBox3.Text = Convert.ToString(result); // конвертация результата в string
            }
            catch
            {
                MessageBox.Show("Введите переменные"); // вывод сообщения об ошибке
            }
            if (textBox3.Text.Contains("\u221E"))
            {
                textBox3.Text = "На ноль делить нельзя"; // вывод сообщения в textBox3
            }
        }

        /// <summary>
        /// button2_Click выполняет действие при нажатии кнопки "Очистить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); // очистка числителя 1-ой переменной
            textBox4.Clear(); // очистка знаменателя 1-ой переменной
            textBox5.Clear(); // очистка знаменатель 2-ой переменной
            textBox2.Clear(); // очистка числитель 2-ой переменной
            textBox6.Text = "0"; // приравнивание целого числа 1-ой переменной к 0
            textBox7.Text = "0"; // приравнивание целого числа 2-ой переменной к 0
            textBox3.Clear(); // очистка результата
        }

        /// <summary>
        /// button3_Click выполняет действие при нажатии кнопки "Выйти"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); // закрытие формы
        }

        /// <summary>
        /// button4_Click выполняет действие при нажатии кнопки "Вывести в Word"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            button1.PerformClick(); // выполняет то же действие, что и кнопка "Рассчитать"
            Word.Application wordapp = new(); // создание объекта в Word
            Word.Document worddoc = wordapp.Documents.Add(); // создания нового документа в Word
            wordapp.Selection.TypeText("Первая переменная: " + textBox6.Text + " , " + textBox1.Text + " / " + textBox4.Text + "\n" + "Вторая переменная: " + textBox7.Text + " , " + textBox2.Text + " / " + textBox5.Text + "\n" + "Операнд: " + comboBox1.Text + "\n" + "Результат: " + textBox3.Text); // Вывод текста
            wordapp.Visible = true; // Открытие Word
        }

        /// <summary>
        /// button5_Click выполняет действие при нажатии кнопки "Вывести в Excel"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            button1.PerformClick(); // выполняет то же действие, что и кнопка "Рассчитать"
            Excel.Application excel = new(); // создание обхекта в Excel
            Workbook workbook = excel.Workbooks.Add(); // создание новой книги в Excel
            Worksheet worksheet = (Worksheet)workbook.Worksheets[1]; // создание листа в Excel
            worksheet.Name = "Дроби"; // название листа в Excel
            worksheet.Cells[1, 1] = "Первая переменная:"; // вывод данных в колонку А1
            worksheet.Cells[2, 1] = (textBox6.Text + " , " + textBox1.Text + " / " + textBox4.Text); // вывод данных в колонку А2
            worksheet.Cells[1, 3] = "Вторая переменная:"; // вывод данных в колонку С1
            worksheet.Cells[2, 3] = (textBox7.Text + " , " + textBox2.Text + " / " + textBox5.Text); // вывод данных в колонку С2
            worksheet.Cells[1, 2] = "Операнд:"; // вывод данных в колонку В1
            worksheet.Cells[2, 2] = comboBox1.Text; // вывод данных в колонку В2
            worksheet.Cells[1, 4] = "Результат:"; // вывод данных в колонку D1
            worksheet.Cells[2, 4] = textBox3.Text; // вывод данных в колонку D2
            Microsoft.Office.Interop.Excel.Range calculator = worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 6]]; // выделяем область в Excel
            calculator.EntireColumn.AutoFit(); // автоматическая настройка колонок под текст
            calculator.EntireRow.AutoFit(); // автоматическая настройка строк под текст
            excel.Visible = true; // открытие Excel
        }

        /// <summary>
        /// EvaluateExpression преобразует выражения в числа
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        private static double EvaluateExpression(System.Windows.Forms.TextBox expression)
        {
            try
            {
                expression.Text = expression.Text.Replace(" ", ""); // удаление пробелов из выражения
                System.Data.DataTable dt = new(); // создание объекта для вычисления математических выражений
                var result = dt.Compute(expression.Text, ""); // вычисление математических выражений
                return Convert.ToDouble(result); // возврат результата
            }
            catch (Exception ex)
            {
                expression.ForeColor = Color.Red;
                expression.Text = "0";
                MessageBox.Show($"Ошибка в {expression}: " + ex.Message + "Все поля с ошибками были заменены на 0"); // вывод ошибки
                return 0.0;
            }
        }

        /// <summary>
        /// textBox6_KeyPress выполняет действие при нажатии клавиш во время фокусировки на textBox6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // предотвращает дальнейшую обработку нажатия клавиши Enter
                textBox1.Focus(); // переводит фокус на другой TextBox
            }
        }

        /// <summary>
        /// textBox1_KeyPress выполняет действие при нажатии клавиш во время фокусировки на textBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // предотвращает дальнейшую обработку нажатия клавиши Enter
                textBox4.Focus(); // переводит фокус на другой TextBox
            }
        }

        /// <summary>
        /// textBox4_KeyPress выполняет действие при нажатии клавиш во время фокусировки на textBox4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // предотвращает дальнейшую обработку нажатия клавиши Enter
                comboBox1.Focus(); // переводит фокус на comboBox
            }
        }

        /// <summary>
        /// textBox7_KeyPress выполняет действие при нажатии клавиш во время фокусировки на textBox7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // предотвращает дальнейшую обработку нажатия клавиши Enter
                textBox2.Focus(); // переводит фокус на другой TextBox
            }
        }

        /// <summary>
        /// textBox2_KeyPress выполняет действие при нажатии клавиш во время фокусировки на textBox2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // предотвращает дальнейшую обработку нажатия клавиши Enter
                textBox5.Focus(); // переводит фокус на другой TextBox
            }
        }

        /// <summary>
        /// textBox5_KeyPress выполняет действие при нажатии клавиш во время фокусировки на textBox5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // предотвращает дальнейшую обработку нажатия клавиши Enter
                button1.Focus(); // переводит фокус на кнопку рассчитать
            }
        }

        /// <summary>
        /// comboBox1_KeyPress выполняет действие при нажатии клавиш во время фокусировки на comboBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // предотвращает дальнейшую обработку нажатия клавиши Enter
                textBox7.Focus(); // переводит фокус на другой textBox
            }
        }
    }
}