using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopPet
{
        /// <summary>
        /// Application options. Need a redesign, so it is not documented.
        /// </summary>
        /// <preliminary/>
    public partial class CareOptions : Form
    {
            /// <summary>
            /// Constructor
            /// </summary>
        public CareOptions()
        {
            InitializeComponent();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;
            
            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Use our own font.
            Font _tabFont;


            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background colour, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.White, e.Bounds);
                _tabFont = new Font(tabControl1.TabPages[e.Index].Font.FontFamily.ToString(), (float)11.0, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            else
            {
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.LightGray, e.Bounds);
                _tabFont = new Font(tabControl1.TabPages[e.Index].Font.FontFamily.ToString(), (float)10.0, FontStyle.Regular, GraphicsUnit.Pixel);
            }
            
            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, tabControl1.GetTabRect(e.Index), _stringFlags);
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
            totalWaterLabel.Text = "Total Water Drank: " + Program.MyData.GetTotalWaterDrank() + " oz";
        }

        private void waterValueAdded(object sender, EventArgs e)
        {
            string waterValue = waterValueInput.Text;

            Program.MyData.AddWater(waterValue);
            totalWaterLabel.Text = "Total Water Drank: " + Program.MyData.GetTotalWaterDrank() + " oz";
            string sqlCon = "Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database.mdf;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(sqlCon))
            {
                con.Open();

                string sql = @"INSERT INTO CareLog (DateTime, Event, Value) VALUES (GETDATE(),@Event,@Value)";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Event", "Water");
                    cmd.Parameters.AddWithValue("@Value", waterValue);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("HERE");
                    }
                    catch (SqlException exception)
                    {
                        Console.WriteLine(exception.Message.ToString());
                    }
                }

                string selectSql = @"SELECT * FROM CareLog WHERE Event=@Event";
                using (SqlCommand selectCmd = new SqlCommand(selectSql, con))
                {
                    selectCmd.Parameters.AddWithValue("@Event", "Water");
                    using (SqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(String.Format("{0} {1} {2} {3}", reader["id"], reader["DateTime"], reader["Event"], reader["Value"]));
                        }
                    }
                }

                con.Close();
            }
        }
    }
}
