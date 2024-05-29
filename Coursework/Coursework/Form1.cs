using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;
using System.Xml;
using System.Reflection;
using System.Security.Cryptography;

namespace Coursework
{
    public partial class Form1 : Form
    {
        public struct User
        {
            public string Name { get; set; }
            public DateTime Save { get; set; }
            public string Creator { get; set; }
            public int Cost { get; set; }
            public DateTime Storage { get; set; }

            public User(string name, DateTime save, string creator, int cost, DateTime storage)
            {
                Name = name;
                Save = save;
                Creator = creator;
                Cost = cost;
                Storage = storage;
            }
        }

        List<User> users = new List<User>();
        List<User> foundUser = new List<User>();
        DataTable table = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }
        static int BinarySearch(List<User> users, string searchName)
        {
            int left = 0;
            int right = users.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int compareResult = string.Compare(users[mid].Name, searchName);

                if (compareResult == 0)
                {
                    return mid; // Знайдено
                }
                else if (compareResult < 0)
                {
                    left = mid + 1; // Шукати у правій половині
                }
                else
                {
                    right = mid - 1; // Шукати у лівій половині
                }
            }

            return -1; // Не знайдений
        }
        public void Search()
        {

            SortTable();
            foundUser.Clear();
            string searchName = textBoxName1.Text;
            int index = BinarySearch(users, searchName);
            if (index != -1)
            {
                // Знаходимо всі товари із заданим ім'ям
                while (index > 0 && users[index - 1].Name == searchName)
                {
                    index--;
                }

                //Додаємо знайдені товари до списку
                while (index < users.Count && users[index].Name == searchName)
                {
                    foundUser.Add(users[index]);
                    index++;
                }
                User freshestProduct = foundUser[0];
                foreach (var foundProduct in foundUser)
                {
                    if (foundProduct.Storage > freshestProduct.Storage)
                    {
                        freshestProduct = foundProduct;
                    }
                }
                table.Rows.Add(freshestProduct.Name, freshestProduct.Save, freshestProduct.Creator, freshestProduct.Cost, freshestProduct.Storage);
            }
            else
            {
                MessageBox.Show("Заповніть дані!!!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Objct
            name1.Visible = true;
            textBoxName1.Visible = true;
            datePost1.Visible = true;
            dateTimePickerDateStorage1.Visible = true;
            save1.Visible = true;
            dateTimePickerSave1.Visible = true;
            creator1.Visible = true;
            textBoxCreator1.Visible = true;
            buyCost.Visible = true;
            textBoxCost1.Visible = true;
            ClearButton1.Visible = true;
            addProduct1.Visible = true;
            search1.Visible = false;
            deleteIndex1.Visible = false;
            Back.Visible = false;
            restart.Visible = false;
            monthNumber1.Visible = false;
            monthNumberLabel1.Visible = false;
            textBoxMonthNumber1.Visible = false;
            textBoxCountProduct1.Visible = false;
            deleteAllProduct1.Visible = false;
            dataGridView1.Visible = false;
            allProduct1.Visible = false;
            CountMonth1.Visible = false;

            // Створюємо структуру таблиці
            table.Columns.Add("Назва товару", typeof(string));
            table.Columns.Add("Термін придатності", typeof(DateTime));
            table.Columns.Add("Фірма виробник", typeof(string));
            table.Columns.Add("Ціна", typeof(int));
            table.Columns.Add("Дата виробництва", typeof(DateTime));
            // Встановлюємо джерело даних для DataGridView
            dataGridView1.DataSource = table;

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addProduct1_Click(object sender, EventArgs e)
        {
            if (textBoxCost1.Text == "" || textBoxCreator1.Text == "" || textBoxCost1.Text == "")
            {
                MessageBox.Show("Заповніть дані!!!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Додаємо дані до списку
                User user = new User();
                user.Name = textBoxName1.Text;
                user.Save = dateTimePickerSave1.Value;
                user.Creator = textBoxCreator1.Text;
                user.Cost = Convert.ToInt32(textBoxCost1.Text);
                user.Storage = dateTimePickerDateStorage1.Value;
                users.Add(user);
                // Додаємо дані до таблиці
                table.Rows.Add(user.Name, user.Save, user.Creator, user.Cost, user.Storage);

                // Оновлюємо DataGridView
                dataGridView1.Refresh();
            }

        }

        private void sortButton1_Click(object sender, EventArgs e)
        {
            // Сортування Шелла
            int n = users.Count;
            int gap = n / 2;
            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    User temp = users[i];
                    int j = i;
                    while (j >= gap && string.Compare(users[j - gap].Name, temp.Name) > 0)
                    {
                        users[j] = users[j - gap];
                        j -= gap;
                    }
                    users[j] = temp;
                }
                gap /= 2;
            }

            // Очищення таблиці
            table.Clear();

            // Заповнення таблиці відсортованими даними
            foreach (var user in users)
            {
                table.Rows.Add(user.Name, user.Save, user.Creator, user.Cost, user.Storage);
            }

            // Оновлення DataGridView
            dataGridView1.Refresh();
        }

        private void search1_Click(object sender, EventArgs e)
        {
            // Очищаємо попередні результати
            table.Clear();
            Search();

            // Оновлюємо DataGridView
            dataGridView1.Refresh();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            SortTable();
            table.Clear();
            foreach (var user in users)
            {
                table.Rows.Add(user.Name, user.Save, user.Creator, user.Cost, user.Storage);
            }
            dataGridView1.Refresh();
        }

        private void order_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SortTable();
            table.Clear();
            foreach (var user in users)
            {
                table.Rows.Add(user.Name, user.Save, user.Creator, user.Cost, user.Storage);
            }
            allProduct1.Text = "Інформація по всіх продуктах";
            name1.Visible = false;
            textBoxName1.Visible = false;
            datePost1.Visible = false;
            dateTimePickerDateStorage1.Visible = false;
            save1.Visible = false;
            dateTimePickerSave1.Visible = false;
            creator1.Visible = false;
            textBoxCreator1.Visible = false;
            buyCost.Visible = false;
            textBoxCost1.Visible = false;
            ClearButton1.Visible = false;
            addProduct1.Visible = false;
            search1.Visible = false;
            deleteIndex1.Visible = true;
            Back.Visible = true;
            restart.Visible = true;
            monthNumber1.Visible = false;
            monthNumberLabel1.Visible = false;
            textBoxMonthNumber1.Visible = false;
            CountMonth1.Visible = false;
            textBoxCountProduct1.Visible = false;
            deleteAllProduct1.Visible = false;
            dataGridView1.Visible = true;
            allProduct1.Visible = true;

        }
        public void SortTable()
        {
            // Сортування Шелла
            int count = users.Count;
            int half = count / 2;
            while (half > 0)
            {
                for (int i = half; i < count; i++)
                {
                    User temp = users[i];
                    int j = i;
                    while (j >= half && string.Compare(users[j - half].Name, temp.Name) > 0)
                    {
                        users[j] = users[j - half];
                        j -= half;
                    }
                    users[j] = temp;
                }
                half /= 2;
            }
        }
        public void SortTableDate()
        {
            // Сортування Шелла від більшого до меншого
            int count = users.Count;
            int half = count / 2;
            while (half > 0)
            {
                for (int i = half; i < count; i++)
                {
                    User temp = users[i];
                    int j = i;
                    while (j >= half && DateTime.Compare(users[j - half].Storage, temp.Storage) < 0)
                    {
                        users[j] = users[j - half];
                        j -= half;
                    }
                    users[j] = temp;
                }
                half /= 2;
            }
        }

        private void sortButton2_Click(object sender, EventArgs e)
        {

            SortTable();

            // Очищення таблиці
            table.Clear();
            DateTime currentDate = DateTime.Now;

            // Заповнення таблиці відсортованими даними
            foreach (var user in users)
            {
                table.Rows.Add(user.Name, user.Save, user.Creator, user.Cost, user.Storage);
            }

            // Оновлення DataGridView
            dataGridView1.Refresh();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            name1.Visible = true;
            textBoxName1.Visible = true;
            datePost1.Visible = true;
            dateTimePickerDateStorage1.Visible = true;
            save1.Visible = true;
            dateTimePickerSave1.Visible = true;
            creator1.Visible = true;
            textBoxCreator1.Visible = true;
            buyCost.Visible = true;
            textBoxCost1.Visible = true;
            ClearButton1.Visible = true;
            addProduct1.Visible = true;
            search1.Visible = false;
            deleteIndex1.Visible = false;
            Back.Visible = false;
            restart.Visible = false;
            monthNumber1.Visible = false;
            monthNumberLabel1.Visible = false;
            textBoxMonthNumber1.Visible = false;
            textBoxCountProduct1.Visible = false;
            deleteAllProduct1.Visible = false;
            dataGridView1.Visible = false;
            allProduct1.Visible = false;
            CountMonth1.Visible = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SortTable();
            table.Clear();
            foreach (var user in users)
            {
                table.Rows.Add(user.Name, user.Save, user.Creator, user.Cost, user.Storage);
            }

            allProduct1.Text = "Товари, що вироблині в цьому місяці поточному року";
            name1.Visible = false;
            textBoxName1.Visible = false;
            datePost1.Visible = false;
            dateTimePickerDateStorage1.Visible = false;
            save1.Visible = false;
            dateTimePickerSave1.Visible = false;
            creator1.Visible = false;
            textBoxCreator1.Visible = false;
            buyCost.Visible = false;
            textBoxCost1.Visible = false;
            ClearButton1.Visible = false;
            addProduct1.Visible = false;
            search1.Visible = false;
            deleteIndex1.Visible = false;
            Back.Visible = true;
            restart.Visible = false;
            monthNumber1.Visible = true;
            monthNumberLabel1.Visible = true;
            textBoxMonthNumber1.Visible = true;
            textBoxCountProduct1.Visible = false;
            deleteAllProduct1.Visible = false;
            dataGridView1.Visible = true;
            allProduct1.Visible = true;
            CountMonth1.Visible = false;

        }

        private void Back1_Click(object sender, EventArgs e)
        {
            table.Clear();
            DateTime currentDate = DateTime.Now;
            foreach (var user in users)
            {
                if (user.Save > currentDate)
                {
                    table.Rows.Add(user.Name, user.Save, user.Creator, user.Cost, user.Storage);
                }
            }

        }

        private void deletProduct_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            int index = 0;

            // Створюємо копію колекції users для видалення прострочених товарів із основної колекції
            List<User> usersToRemove = new List<User>();

            // Перебираємо користувачів
            foreach (var user in users.ToList()) // Створюємо копію users для безпечного видалення елементів у циклі
            {
                // Якщо дата збереження товару менша за поточну дату
                if (user.Save < currentDate)
                {
                    // Додаємо дані про прострочений товар до таблиці
                    table.Rows.Add(user.Name, user.Save, user.Creator, user.Cost, user.Storage);

                    // Додаємо прострочений товар до списку для видалення з основної колекції
                    usersToRemove.Add(user);
                }
                index++;
            }

            // Видаляємо прострочені товари з основної колекції
            foreach (var userToRemove in usersToRemove)
            {
                users.Remove(userToRemove);
            }
            table.Clear();
            // Оновлюємо відображення DataGridView
            dataGridView1.Refresh();
        }
        private void SaveXML(string filePath, List<User> users)
        {
            // Створюємо екземпляр XmlSerializer
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));

            // Створюємо файловий потік для запису в XML файл
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                // Серіалізуємо список користувачів та записуємо його у файл
                serializer.Serialize(fs, users);
            }

            MessageBox.Show("Данные успешно сохранены в XML файл: " + filePath);
        }
        private void LoadXML(string filePath, List<User> users)
        {
            // Перевіряємо існування файлу
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл не найден: " + filePath);
                return;
            }

            // Створюємо екземпляр XmlSerializer
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));

            // Створюємо файловий потік для читання з файлу XML
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                // Десеріалізуємо дані з файлу до списку користувачів
                List<User> loadedUsers = (List<User>)serializer.Deserialize(fs);

                // Очищаємо існуючий список користувачів та додаємо завантажені дані
                users.Clear();
                users.AddRange(loadedUsers);
            }

            MessageBox.Show("Данные успешно загружены из XML файла: " + filePath);
        }


        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveXML(saveFileDialog.FileName, users);
            }
        }


        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadXML(openFileDialog.FileName, users);
            }
        }

        private void ClearButton1_Click(object sender, EventArgs e)
        {
            textBoxName1.Clear();
            textBoxCreator1.Clear();
            textBoxCost1.Clear();
        }

        private void deleteIndex1_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.SelectedRows.Count > 0 ? dataGridView1.SelectedRows[0].Index : -1;
            if (selectedIndex != -1)
            {
                dataGridView1.Rows.RemoveAt(selectedIndex);
                users.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Будь ласка, веберіть рядок!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void monthNumber1_Click(object sender, EventArgs e)
        {
            if (textBoxMonthNumber1.Text == "")
            {
                MessageBox.Show("Будь ласка, ведіть номер місяця!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Шукаємо товари, які відповідають поточному року та місяцю
                DateTime currentDate = DateTime.Now;
                int currentMonth = Convert.ToInt32(textBoxMonthNumber1.Text);
                table.Clear();
                // Додаємо лише товари, які відповідають поточному року та місяцю
                foreach (User user in users)
                {
                    if (user.Storage.Year == currentDate.Year && user.Storage.Month == currentMonth)
                    {
                        table.Rows.Add(user.Name, user.Save, user.Creator, user.Cost, user.Storage);
                    }
                }

                // Встановлюємо джерело даних для DataGridView
                dataGridView1.DataSource = table;
            }

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            name1.Visible = true;
            textBoxName1.Visible = true;
            datePost1.Visible = true;
            dateTimePickerDateStorage1.Visible = true;
            save1.Visible = true;
            dateTimePickerSave1.Visible = true;
            creator1.Visible = true;
            textBoxCreator1.Visible = true;
            buyCost.Visible = true;
            textBoxCost1.Visible = true;
            ClearButton1.Visible = true;
            addProduct1.Visible = true;
            search1.Visible = false;
            deleteIndex1.Visible = false;
            Back.Visible = false;
            restart.Visible = false;
            monthNumber1.Visible = false;
            monthNumberLabel1.Visible = false;
            textBoxMonthNumber1.Visible = false;
            textBoxCountProduct1.Visible = false;
            deleteAllProduct1.Visible = false;
            dataGridView1.Visible = false;
            allProduct1.Visible = false;
            CountMonth1.Visible = false;
        }

        private void deleteAllProduct1_Click(object sender, EventArgs e)
        {
            int index = 0;

            // Створюємо копію колекції users для видалення прострочених товарів із основної колекції
            List<User> usersToRemove = new List<User>();

            // Перебираємо користувачів
            foreach (var user in users.ToList()) // Створюємо копію users для безпечного видалення елементів у циклі
            {
                // Якщо дата збереження товару менша за поточну дату
                if (user.Save <= user.Storage)
                {
                    // Додаємо дані про прострочений товар до таблиці
                    table.Rows.Add(user.Name, user.Save, user.Creator, user.Cost, user.Storage);

                    // Додаємо прострочений товар до списку для видалення з основної колекції
                    usersToRemove.Add(user);
                }
                index++;
            }

            // Видаляємо прострочені товари з основної колекції
            foreach (var userToRemove in usersToRemove)
            {
                users.Remove(userToRemove);
            }
            table.Clear();
            // Оновлюємо відображення DataGridView
            dataGridView1.Refresh();

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            table.Clear();
            SortTable();
            int i = 0;

            // Шукаємо товари, термін придатності яких закінчується через два дні
            foreach (User user in users)
            {
                if (user.Save <= user.Storage.AddDays(2) && user.Storage < user.Save)
                {
                    // Додаємо ці товари до таблиці
                    table.Rows.Add(user.Name, user.Save, user.Creator, user.Cost, user.Storage);
                    i++;
                }
            }
            textBoxCountProduct1.Text = i.ToString();
            // Оновлюємо інтерфейс DataGridView з новими знайденими товарами
            dataGridView1.DataSource = table;

            allProduct1.Text = "Товари, термін придатності яких закінчується через 2 дні";
            name1.Visible = false;
            textBoxName1.Visible = false;
            datePost1.Visible = false;
            dateTimePickerDateStorage1.Visible = false;
            save1.Visible = false;
            dateTimePickerSave1.Visible = false;
            creator1.Visible = false;
            textBoxCreator1.Visible = false;
            buyCost.Visible = false;
            textBoxCost1.Visible = false;
            ClearButton1.Visible = false;
            addProduct1.Visible = false;
            search1.Visible = false;
            deleteIndex1.Visible = false;
            Back.Visible = false;
            restart.Visible = false;
            monthNumber1.Visible = false;
            monthNumberLabel1.Visible = false;
            textBoxMonthNumber1.Visible = false;
            deleteAllProduct1.Visible = false;
            dataGridView1.Visible = true;
            allProduct1.Visible = true;
            textBoxCountProduct1.Visible = true;
            CountMonth1.Visible = true;

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            SortTable();
            table.Clear();
            foreach (var user in users)
            {
                table.Rows.Add(user.Name, user.Save, user.Creator, user.Cost, user.Storage);
            }
            allProduct1.Text = "Найсвіжіший товар";
            name1.Visible = true;
            textBoxName1.Visible = true;
            datePost1.Visible = false;
            dateTimePickerDateStorage1.Visible = false;
            save1.Visible = false;
            dateTimePickerSave1.Visible = false;
            creator1.Visible = false;
            textBoxCreator1.Visible = false;
            buyCost.Visible = false;
            textBoxCost1.Visible = false;
            ClearButton1.Visible = false;
            addProduct1.Visible = false;
            search1.Visible = true;
            deleteIndex1.Visible = false;
            Back.Visible = true;
            restart.Visible = false;
            monthNumber1.Visible = false;
            monthNumberLabel1.Visible = false;
            textBoxMonthNumber1.Visible = false;
            textBoxCountProduct1.Visible = false;
            deleteAllProduct1.Visible = false;
            dataGridView1.Visible = true;
            allProduct1.Visible = true;
            CountMonth1.Visible = false;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            SortTable();
            table.Clear();
            foreach (var user in users)
            {
                if (user.Save <= user.Storage)
                {
                    table.Rows.Add(user.Name, user.Save, user.Creator, user.Cost, user.Storage);
                }
            }
            allProduct1.Text = "Товари, термін придатності яких закінчився";
            name1.Visible = false;
            textBoxName1.Visible = false;
            datePost1.Visible = false;
            dateTimePickerDateStorage1.Visible = false;
            save1.Visible = false;
            dateTimePickerSave1.Visible = false;
            creator1.Visible = false;
            textBoxCreator1.Visible = false;
            buyCost.Visible = false;
            textBoxCost1.Visible = false;
            ClearButton1.Visible = false;
            addProduct1.Visible = false;
            search1.Visible = false;
            deleteIndex1.Visible = false;
            Back.Visible = true;
            restart.Visible = false;
            monthNumber1.Visible = false;
            monthNumberLabel1.Visible = false;
            textBoxMonthNumber1.Visible = false;
            deleteAllProduct1.Visible = true;
            dataGridView1.Visible = true;
            allProduct1.Visible = true;
            textBoxCountProduct1.Visible = false;
            CountMonth1.Visible = false;

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

