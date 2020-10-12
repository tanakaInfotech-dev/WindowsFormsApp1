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
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class NumericalView : Form
    {
        //Form1インスタンス格納用
        private Form1 form1Instance;
        private string userIdString;

        public NumericalView(Form1 form1Instance)
        {
            InitializeComponent();

            //Form1のインスタンスを取得
            this.form1Instance = form1Instance;
            userIdString = this.form1Instance.userId;

            try
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=Test.db"))
                {
                    con.Open();

                    using (SQLiteCommand cmd = con.CreateCommand())
                    {

                        cmd.CommandText = $"SELECT * FROM UserTable where UserId = '" + userIdString + "'";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UserLabel.Text = reader["userName"].ToString();
                            }
                        }

                        // カラム名を指定
                        numeric_dgv.Columns.Clear();
                        numeric_dgv.Rows.Clear();
                        numeric_dgv.ColumnCount = 2;
                        numeric_dgv.Columns[0].HeaderText = "Id";
                        numeric_dgv.Columns[1].HeaderText = "名前";
                        numeric_dgv.MultiSelect = false;
                        numeric_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        // clear
                        numeric_chart.Series.Clear();
                        numeric_chart.Series.Add("数値");
                        numeric_chart.Series["数値"].ChartType = SeriesChartType.Line;

                        numeric_chart.Series["数値"].XValueType = ChartValueType.String;
                        //numeric_chart.Series["series1"].Points.AddXY("", 165);

                        //sqlite
                        cmd.CommandText = $"select * from NumericalTable where UserId = '" + userIdString + "' ORDER BY Date ASC";
                        var selectDic = new Dictionary<string, double>();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //UserLabel.Text = reader["userName"].ToString();
                                selectDic.Add(reader["Date"].ToString(), double.Parse(reader["Num"].ToString()));
                            }
                        }
                        foreach (var dic in selectDic)
                        {
                            numeric_chart.Series["数値"].Points.AddXY(dic.Key, dic.Value);
                        }
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                numeric_dgv.Rows.Add(reader["Date"].ToString(), reader["Num"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void insert_btn_Click(object sender, EventArgs e)
        {
            var insertId = 1;
            using (SQLiteConnection con = new SQLiteConnection("Data Source=Test.db"))
            {
                con.Open();

                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    try
                    {
                        if (double.TryParse(numeric_txtbox.Text,out double result) && numeric_txtbox.Text.Length >= 1 && numDate_dt.Value <= DateTime.Now)
                        {
                            string sql = $"SELECT count(NumericId) FROM NumericalTable";

                            SQLiteCommand com = new SQLiteCommand(sql, con);
                            SQLiteDataReader sdr = com.ExecuteReader();
                            while (sdr.Read() == true)
                            {
                                insertId = int.Parse(sdr["count(NumericId)"].ToString());
                            }
                            //(" + 6 + ", " + userId + ", '" + date + "', '" + num + ")";
                            cmd.CommandText = "INSERT INTO NumericalTable VALUES(" + ++insertId + ", " + int.Parse(userIdString) + ",'" + numDate_dt.Value.ToString() + "'," + double.Parse(numeric_txtbox.Text) + ")";
                            cmd.ExecuteNonQuery();

                            // DataGridView初期化（データクリア）
                            numeric_dgv.Columns.Clear();
                            numeric_dgv.Rows.Clear();
                            numeric_dgv.ColumnCount = 2;
                            numeric_dgv.MultiSelect = false;
                            numeric_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            // カラム名を指定
                            numeric_dgv.Columns[0].HeaderText = "Id";
                            numeric_dgv.Columns[1].HeaderText = "名前";

                            numeric_chart.Series.Clear();
                            numeric_chart.Series.Add("数値");
                            numeric_chart.Series["数値"].ChartType = SeriesChartType.Line;

                            numeric_chart.Series["数値"].XValueType = ChartValueType.String;
                            //numeric_chart.Series["series1"].Points.AddXY("", 165);

                            //cmd.CommandText = $"SELECT * FROM NumericalTable";
                            cmd.CommandText = $"select * from NumericalTable where UserId = '" + userIdString + "' ORDER BY Date ASC";
                            var selectDic = new Dictionary<string, double>();
                            using (var reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    //UserLabel.Text = reader["userName"].ToString();
                                    selectDic.Add(reader["Date"].ToString(), double.Parse(reader["Num"].ToString()));
                                }
                            }

                            foreach (var dic in selectDic)
                            {
                                numeric_dgv.Rows.Add(dic.Key, dic.Value);
                                numeric_chart.Series["数値"].Points.AddXY(dic.Key, dic.Value);
                            }
                            numeric_txtbox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("数値を入力してください","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void NumericalView_Load(object sender, EventArgs e)
        {

        }

        private void NumericalView_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void NumericalView_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
