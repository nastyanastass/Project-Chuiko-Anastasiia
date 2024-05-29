namespace Coursework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dateTimePickerDateStorage1 = new DateTimePicker();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripButton7 = new ToolStripButton();
            toolStripButton8 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            addProduct1 = new Button();
            textBoxName1 = new TextBox();
            name1 = new Label();
            allProduct1 = new Label();
            creator1 = new Label();
            datePost1 = new Label();
            buyCost = new Label();
            textBoxCost1 = new TextBox();
            save1 = new Label();
            dateTimePickerSave1 = new DateTimePicker();
            bindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            search1 = new Button();
            restart = new Button();
            Back = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            textBoxCreator1 = new TextBox();
            ClearButton1 = new Button();
            deleteIndex1 = new Button();
            monthNumber1 = new Button();
            textBoxMonthNumber1 = new TextBox();
            monthNumberLabel1 = new Label();
            textBoxCountProduct1 = new TextBox();
            deleteAllProduct1 = new Button();
            CountMonth1 = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerDateStorage1
            // 
            dateTimePickerDateStorage1.Format = DateTimePickerFormat.Short;
            dateTimePickerDateStorage1.Location = new Point(26, 147);
            dateTimePickerDateStorage1.Name = "dateTimePickerDateStorage1";
            dateTimePickerDateStorage1.Size = new Size(121, 23);
            dateTimePickerDateStorage1.TabIndex = 9;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton6, toolStripButton7, toolStripButton8, toolStripButton4, toolStripButton5 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(611, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "Головна";
            toolStripButton1.Click += toolStripButton1_Click_1;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "Товари";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "За місяць";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(23, 22);
            toolStripButton6.Text = "2 дні";
            toolStripButton6.Click += toolStripButton6_Click;
            // 
            // toolStripButton7
            // 
            toolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton7.Image = (Image)resources.GetObject("toolStripButton7.Image");
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(23, 22);
            toolStripButton7.Text = "Свіже";
            toolStripButton7.Click += toolStripButton7_Click;
            // 
            // toolStripButton8
            // 
            toolStripButton8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton8.Image = (Image)resources.GetObject("toolStripButton8.Image");
            toolStripButton8.ImageTransparentColor = Color.Magenta;
            toolStripButton8.Name = "toolStripButton8";
            toolStripButton8.Size = new Size(23, 22);
            toolStripButton8.Text = "Списання";
            toolStripButton8.Click += toolStripButton8_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 22);
            toolStripButton4.Text = "Зберегти xml файл";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(23, 22);
            toolStripButton5.Text = "Завантажити xml файл";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // addProduct1
            // 
            addProduct1.Location = new Point(29, 237);
            addProduct1.Name = "addProduct1";
            addProduct1.Size = new Size(118, 23);
            addProduct1.TabIndex = 1;
            addProduct1.Text = "Додати товар";
            addProduct1.UseVisualStyleBackColor = true;
            addProduct1.Click += addProduct1_Click;
            // 
            // textBoxName1
            // 
            textBoxName1.Location = new Point(26, 78);
            textBoxName1.Name = "textBoxName1";
            textBoxName1.Size = new Size(121, 23);
            textBoxName1.TabIndex = 2;
            // 
            // name1
            // 
            name1.AutoSize = true;
            name1.Location = new Point(26, 60);
            name1.Name = "name1";
            name1.Size = new Size(80, 15);
            name1.TabIndex = 3;
            name1.Text = "Введіть товар";
            // 
            // allProduct1
            // 
            allProduct1.AutoSize = true;
            allProduct1.Location = new Point(29, 107);
            allProduct1.Name = "allProduct1";
            allProduct1.Size = new Size(171, 15);
            allProduct1.TabIndex = 5;
            allProduct1.Text = "Інформація по всіх продуктах";
            // 
            // creator1
            // 
            creator1.AutoSize = true;
            creator1.Location = new Point(218, 60);
            creator1.Name = "creator1";
            creator1.Size = new Size(98, 15);
            creator1.TabIndex = 8;
            creator1.Text = "Фірма виробник";
            // 
            // datePost1
            // 
            datePost1.AutoSize = true;
            datePost1.Location = new Point(26, 129);
            datePost1.Name = "datePost1";
            datePost1.Size = new Size(107, 15);
            datePost1.TabIndex = 10;
            datePost1.Text = "Дата виробництва";
            // 
            // buyCost
            // 
            buyCost.AutoSize = true;
            buyCost.Location = new Point(218, 190);
            buyCost.Name = "buyCost";
            buyCost.Size = new Size(32, 15);
            buyCost.TabIndex = 12;
            buyCost.Text = "Ціна";
            // 
            // textBoxCost1
            // 
            textBoxCost1.Location = new Point(218, 208);
            textBoxCost1.Name = "textBoxCost1";
            textBoxCost1.Size = new Size(121, 23);
            textBoxCost1.TabIndex = 11;
            // 
            // save1
            // 
            save1.AutoSize = true;
            save1.Location = new Point(218, 129);
            save1.Name = "save1";
            save1.Size = new Size(114, 15);
            save1.TabIndex = 14;
            save1.Text = "Термін придатності";
            // 
            // dateTimePickerSave1
            // 
            dateTimePickerSave1.Format = DateTimePickerFormat.Short;
            dateTimePickerSave1.Location = new Point(218, 147);
            dateTimePickerSave1.Name = "dateTimePickerSave1";
            dateTimePickerSave1.Size = new Size(121, 23);
            dateTimePickerSave1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(541, 200);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // search1
            // 
            search1.Location = new Point(214, 78);
            search1.Name = "search1";
            search1.Size = new Size(118, 23);
            search1.TabIndex = 17;
            search1.Text = "Пошук товару";
            search1.UseVisualStyleBackColor = true;
            search1.Click += search1_Click;
            // 
            // restart
            // 
            restart.Location = new Point(150, 347);
            restart.Name = "restart";
            restart.Size = new Size(118, 23);
            restart.TabIndex = 18;
            restart.Text = "Оновити";
            restart.UseVisualStyleBackColor = true;
            restart.Click += restart_Click;
            // 
            // Back
            // 
            Back.Location = new Point(26, 347);
            Back.Name = "Back";
            Back.Size = new Size(118, 23);
            Back.TabIndex = 27;
            Back.Text = "На головну";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxCreator1
            // 
            textBoxCreator1.Location = new Point(218, 78);
            textBoxCreator1.Name = "textBoxCreator1";
            textBoxCreator1.Size = new Size(121, 23);
            textBoxCreator1.TabIndex = 7;
            // 
            // ClearButton1
            // 
            ClearButton1.Location = new Point(29, 207);
            ClearButton1.Name = "ClearButton1";
            ClearButton1.Size = new Size(118, 23);
            ClearButton1.TabIndex = 30;
            ClearButton1.Text = "Очистити";
            ClearButton1.UseVisualStyleBackColor = true;
            ClearButton1.Click += ClearButton1_Click;
            // 
            // deleteIndex1
            // 
            deleteIndex1.Location = new Point(284, 347);
            deleteIndex1.Name = "deleteIndex1";
            deleteIndex1.Size = new Size(190, 23);
            deleteIndex1.TabIndex = 31;
            deleteIndex1.Text = "Видалення продуктів";
            deleteIndex1.UseVisualStyleBackColor = true;
            deleteIndex1.Click += deleteIndex1_Click;
            // 
            // monthNumber1
            // 
            monthNumber1.Location = new Point(480, 103);
            monthNumber1.Name = "monthNumber1";
            monthNumber1.Size = new Size(118, 23);
            monthNumber1.TabIndex = 32;
            monthNumber1.Text = "Показати";
            monthNumber1.UseVisualStyleBackColor = true;
            monthNumber1.Click += monthNumber1_Click;
            // 
            // textBoxMonthNumber1
            // 
            textBoxMonthNumber1.Location = new Point(353, 103);
            textBoxMonthNumber1.Name = "textBoxMonthNumber1";
            textBoxMonthNumber1.Size = new Size(121, 23);
            textBoxMonthNumber1.TabIndex = 33;
            // 
            // monthNumberLabel1
            // 
            monthNumberLabel1.AutoSize = true;
            monthNumberLabel1.Location = new Point(353, 78);
            monthNumberLabel1.Name = "monthNumberLabel1";
            monthNumberLabel1.Size = new Size(85, 15);
            monthNumberLabel1.TabIndex = 34;
            monthNumberLabel1.Text = "Номер місяця";
            // 
            // textBoxCountProduct1
            // 
            textBoxCountProduct1.Location = new Point(449, 104);
            textBoxCountProduct1.Name = "textBoxCountProduct1";
            textBoxCountProduct1.ReadOnly = true;
            textBoxCountProduct1.Size = new Size(121, 23);
            textBoxCountProduct1.TabIndex = 35;
            // 
            // deleteAllProduct1
            // 
            deleteAllProduct1.Location = new Point(150, 347);
            deleteAllProduct1.Name = "deleteAllProduct1";
            deleteAllProduct1.Size = new Size(118, 23);
            deleteAllProduct1.TabIndex = 36;
            deleteAllProduct1.Text = "Списати";
            deleteAllProduct1.UseVisualStyleBackColor = true;
            deleteAllProduct1.Click += deleteAllProduct1_Click;
            // 
            // CountMonth1
            // 
            CountMonth1.AutoSize = true;
            CountMonth1.Location = new Point(452, 74);
            CountMonth1.Name = "CountMonth1";
            CountMonth1.Size = new Size(67, 15);
            CountMonth1.TabIndex = 37;
            CountMonth1.Text = "Їх кількість";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 395);
            Controls.Add(CountMonth1);
            Controls.Add(deleteAllProduct1);
            Controls.Add(textBoxCountProduct1);
            Controls.Add(monthNumberLabel1);
            Controls.Add(textBoxMonthNumber1);
            Controls.Add(monthNumber1);
            Controls.Add(deleteIndex1);
            Controls.Add(ClearButton1);
            Controls.Add(Back);
            Controls.Add(restart);
            Controls.Add(search1);
            Controls.Add(dataGridView1);
            Controls.Add(save1);
            Controls.Add(dateTimePickerSave1);
            Controls.Add(buyCost);
            Controls.Add(textBoxCost1);
            Controls.Add(datePost1);
            Controls.Add(dateTimePickerDateStorage1);
            Controls.Add(creator1);
            Controls.Add(textBoxCreator1);
            Controls.Add(allProduct1);
            Controls.Add(name1);
            Controls.Add(textBoxName1);
            Controls.Add(addProduct1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Система обліку якості продуктів у магазині та терміном придатності";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private Button addProduct1;
        private TextBox textBoxName1;
        private Label name1;
        private Label allProduct1;
        private Label creator1;
        private Label datePost1;
        private Label buyCost;
        private TextBox textBoxCost1;
        private Label save1;
        private DateTimePicker dateTimePickerSave1;
        private BindingSource bindingSource1;
        private DataGridView dataGridView1;
        private Button search1;
        private Button restart;
        private Button Back;
        private ToolStripButton toolStripButton4;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripButton toolStripButton5;
        private TextBox textBoxCreator1;
        private DateTimePicker dateTimePickerDateStorage1;
        private Button ClearButton1;
        private Button deleteIndex1;
        private ToolStripButton toolStripButton1;
        private Button monthNumber1;
        private TextBox textBoxMonthNumber1;
        private ToolStripButton toolStripButton6;
        private Label monthNumberLabel1;
        private TextBox textBoxCountProduct1;
        private Button deleteAllProduct1;
        private Label CountMonth1;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton8;
    }
}