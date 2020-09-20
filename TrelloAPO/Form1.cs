using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manatee.Trello;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TrelloAPO
{
    public partial class Form1 : Form
    {
        private ushort secretKey = 0x0088; // Секретный ключ (длина - 16 bit)
        protected string key;
        protected string token;
        protected string boardId = "anylCafN";
        protected bool authDone = false;
        protected TrelloAuthorization authData = new TrelloAuthorization();
        private static string EncodeDecrypt(string str, ushort secretKey)
        {
            var ch = str.ToArray(); //преобразуем строку в символы
            string newStr = "";      //переменная которая будет содержать зашифрованную строку
            foreach (var c in ch)  //выбираем каждый элемент из массива символов нашей строки
                newStr += TopSecret(c, secretKey);  //производим шифрование каждого отдельного элемента и сохраняем его в строку
            return newStr;
        }
        private static char TopSecret(char character, ushort secretKey)
        {
            character = (char)(character ^ secretKey); //Производим XOR операцию
            return character;
        }
        public class rowCol
        {
            public string nameOfList;
            public int row;
            public int col;
        }
        public List<rowCol> coord = new List<rowCol>();
        public Form1()
        {
            loadAuthParam();
            InitializeComponent();
            loadTrelloAsync();
        }
        public void loadAuthParam()
        {
            FileStream file = new FileStream("auth.txt",FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(file);
            
            if (file.Length > 0)
            {
                string keyStr = reader.ReadLine();
                authData.AppKey = EncodeDecrypt(keyStr, secretKey);
                string tokenStr = reader.ReadLine();
                authData.UserToken = EncodeDecrypt(tokenStr, secretKey);
                authDone = true;
            }
            else
            {
                auth authorization = new auth();
                if (authorization.ShowDialog() == DialogResult.OK)
                {   
                    authData.AppKey = authorization.key;
                    authData.UserToken = authorization.token;
                    authDone = true;

                    var cryptoKey = EncodeDecrypt(authData.AppKey, secretKey);
                    var cryptoToken = EncodeDecrypt(authData.UserToken, secretKey);

                    using (StreamWriter writer = new StreamWriter(file))
                    {
                        writer.WriteLine(cryptoKey);
                        writer.WriteLine(cryptoToken);
                    }
                }
                else
                {
                    authDone = false;   
                }
            }
            file.Close();
        }
        public async Task loadTrelloAsync()
        {
            if (authDone)
            {
                TrelloFactory factory = new TrelloFactory();
                var board = factory.Board(boardId, authData);
                await board.Refresh();
                btnBrdName.Text = board.Name;
                var lists = board.Lists;
                for (int i = 0; i < lists.Count(); i++)
                {
                    TabPage page = new TabPage();
                    page.Text = lists[i].Name;
                    page.Tag = i.ToString();
                    tcLists.TabPages.Add(page);
                    await lists[i].Refresh();

                    rowCol c = new rowCol();
                    c.nameOfList = lists[i].Name;
                    c.row = 0;
                    c.col = 0;
                    coord.Add(c);

                    var cards = lists[i].Cards;
                    if (cards.Count() > 0)
                    {
                        for (int j = 0; j < cards.Count(); j++)
                        {
                            Button task = new Button();
                            task.Text = cards[j].Name;
                            task.MinimumSize = new Size(360, 80);
                            if (80 * coord[i].row + 3 < tcLists.Size.Height - 80)
                            {
                                task.Location = new Point(360 * coord[i].col + 3, 80 * coord[i].row + 3);
                                coord[i].row++;
                            }
                            else
                            {
                                coord[i].col++;
                                coord[i].row = 0;
                                task.Location = new Point(360 * coord[i].col + 3, 80 * coord[i].row + 3);
                            }
                            task.AutoEllipsis = true;
                            tcLists.TabPages[i].Controls.Add(task);
                        }
                    }
                }
            }
            else
                MessageBox.Show("Вы не авторизовались. Для повторной попытки повторите запуск приложения!");
        }

        #region ListsClick
        private void btnCreateList_ClickAsync(object sender, EventArgs e)
        {
            createList();
        }
        private void btnRenameList_Click(object sender, EventArgs e)
        {
            if (tcLists.TabCount > 0)
                if (Convert.ToInt32(tcLists.SelectedTab.Tag) >= 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Вы действительно хотите переименовать выбранный список?", "Переименование списка", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        editListName();
                    }
                }
        }
        private void btnDeleteList_Click(object sender, EventArgs e)
        {
            if (tcLists.TabCount > 0)
                if (Convert.ToInt32(tcLists.SelectedTab.Tag) >= 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить выбранный список?", "Удаление списка", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        deleteList();
                    }
                }
        }
        protected async void createList()
        {
            crList create = new crList();
            if (create.ShowDialog() == DialogResult.OK)
            {
                TrelloFactory factory = new TrelloFactory();
                var board = factory.Board(boardId, authData);
                await board.Refresh();
                var newList = await board.Lists.Add(create.name);
                TabPage page = new TabPage();
                page.Text = create.name;
                tcLists.TabPages.Add(page);
            }
        }
        protected async void editListName()
        {
            editList edit = new editList();
            if (edit.ShowDialog() == DialogResult.OK)
            {
                TrelloFactory factory = new TrelloFactory();
                var board = factory.Board(boardId, authData);
                await board.Refresh();
                var list = board.Lists.FirstOrDefault(l => l.Name == tcLists.SelectedTab.Text);
                list.Name = edit.name;
                tcLists.SelectedTab.Text = edit.name;
            }
        }
        protected async void deleteList()
        {
            TrelloFactory factory = new TrelloFactory();
            var board = factory.Board(boardId, authData);
            await board.Refresh();
            var list = board.Lists.FirstOrDefault(l => l.Name == tcLists.SelectedTab.Text);
            await list.Refresh();
            list.IsArchived = true;
            tcLists.TabPages.Remove(tcLists.SelectedTab);
        }
        #endregion
    }
}
