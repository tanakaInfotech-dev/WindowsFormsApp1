using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //テキストボックスへテキストを設定、取得する。
        public string userId { get => userData_dgv.CurrentRow.Cells[0].Value.ToString(); }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=Test.db"))
                {
                    con.Open();

                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        //userTableとnumtableの存在チェック
                        cmd.CommandText = "SELECT COUNT(*) FROM sqlite_master WHERE TYPE='table' AND name='UserTable';";
                        long existsUser = (long)cmd.ExecuteScalar();
                        cmd.CommandText = "SELECT COUNT(*) FROM sqlite_master WHERE TYPE='table' AND name='NumericalTable';";
                        long existsNumerical = (long)cmd.ExecuteScalar();


                        if (existsUser == 0)
                        {
                            //table作成
                            cmd.CommandText = "CREATE TABLE UserTable(" +
                                              "UserId INTEGER primary key, UserName text" +
                                              ");";
                            cmd.ExecuteNonQuery();
                        }

                        if (existsNumerical == 0)
                        {
                            //table作成
                            cmd.CommandText = "CREATE TABLE NumericalTable(" +
                                              "NumericId INTEGER primary key, UserId INTEGER, Date text, Num REAL" +
                                              ");";
                            cmd.ExecuteNonQuery();
                        }

                        userData_dgv.ColumnCount = 2;
                        userData_dgv.MultiSelect = false;
                        userData_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        // カラム名を指定
                        userData_dgv.Columns[0].HeaderText = "Id";
                        userData_dgv.Columns[1].HeaderText = "名前";

                        //ユーザー情報抽出
                        cmd.CommandText = $"SELECT * FROM UserTable";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //TODO:ユーザ情報表示
                                var userId = int.Parse(reader["UserId"].ToString());
                                var userName = reader["userName"].ToString();
                                userData_dgv.Rows.Add(userId, userName);

                                //Console.WriteLine(reader.GetValues().Get("data"));
                            }
                        }

                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private void viewClose_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void userInsert_btn_Click(object sender, EventArgs e)
        {
            var insertId = 1;

            using (SQLiteConnection con = new SQLiteConnection("Data Source=Test.db"))
            {
                con.Open();

                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    try
                    {
                        string sql = $"SELECT count(UserId) FROM UserTable";

                        SQLiteCommand com = new SQLiteCommand(sql, con);
                        SQLiteDataReader sdr = com.ExecuteReader();
                        while (sdr.Read() == true)
                        {
                            insertId = int.Parse(sdr["count(UserId)"].ToString());
                        }

                        cmd.CommandText = "INSERT INTO UserTable VALUES(" + ++insertId + ", '" + inputUser_txt.Text + "')";
                        cmd.ExecuteNonQuery();

                        // DataGridView初期化（データクリア）
                        userData_dgv.Columns.Clear();
                        userData_dgv.Rows.Clear();
                        userData_dgv.ColumnCount = 2;
                        userData_dgv.MultiSelect = false;
                        userData_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        // カラム名を指定
                        userData_dgv.Columns[0].HeaderText = "Id";
                        userData_dgv.Columns[1].HeaderText = "名前";

                        cmd.CommandText = $"SELECT * FROM UserTable";

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var userId = int.Parse(reader["UserId"].ToString());
                                var userName = reader["userName"].ToString();
                                userData_dgv.Rows.Add(userId, userName);
                            }
                        }
                        inputUser_txt.Clear();
                    }
                    finally
                    {
                        con.Close();
                    }
                }


            }
        }

        private void selectUser_btn_Click(object sender, EventArgs e)
        {
            //var hoge = userData_dgv.CurrentRow.Cells[0].Value.ToString();
            using (var numForm = new NumericalView(this))
            {
                //Form2表示
                numForm.ShowDialog();
            }

        }
    }
}
