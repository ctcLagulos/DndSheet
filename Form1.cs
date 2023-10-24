using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Security.Policy;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace DndSheet
{
    public partial class Form1 : Form
    {
        Connection kon = new Connection();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);

            player.SoundLocation = "E:\\MMCM\\Files\\OOP\\source\\repos\\DndSheet\\VIDEO GAME.wav";
            player.PlayLooping();
            Mute.BackgroundImage = Image.FromFile("E:\\MMCM\\Files\\OOP\\source\\repos\\DndSheet\\musci note.png");
            Mute.BackgroundImageLayout = ImageLayout.Stretch;
            conn = kon.GetCon();
            conn.Open();

            cmd = new SqlCommand("select * from Table_2", conn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                dataGridView1.Rows.Add(
             rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(),
             rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString(), rdr[7].ToString(),
             rdr[8].ToString(), rdr[9].ToString(), rdr[10].ToString(), rdr[11].ToString(),
             rdr[12].ToString(), rdr[13].ToString()
                );
            }
            cmd.Dispose();
            rdr.Close();
            conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                return;  // Return early if the row is not valid or is a new row
            }

            CName.Enabled = false;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                CName.Text = row.Cells[0].Value.ToString();
                Lvl.Value = Convert.ToDecimal(row.Cells[1].Value);
                Hp.Value = Convert.ToDecimal(row.Cells[2].Value);
                Mp.Value = Convert.ToDecimal(row.Cells[3].Value);
                Gender.Text = row.Cells[4].Value.ToString();
                Faction.Text = row.Cells[5].Value.ToString();
                Race.Text = row.Cells[6].Value.ToString();
                Class.Text = row.Cells[7].Value.ToString();
                Str.Value = Convert.ToDecimal(row.Cells[8].Value);
                Dex.Value = Convert.ToDecimal(row.Cells[9].Value);
                Int.Value = Convert.ToDecimal(row.Cells[10].Value);
                Con.Value = Convert.ToDecimal(row.Cells[11].Value);
                Cha.Value = Convert.ToDecimal(row.Cells[12].Value);
                Luk.Value = Convert.ToDecimal(row.Cells[13].Value);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnReset()
        {
            CName.Text = "";
            Lvl.Value = 1;
            Hp.Value = 1; Mp.Value = 1;
            Gender.Text = ""; Faction.Text = "";
            Race.Text = ""; Class.Text = "";
            Str.Value = 0; Dex.Value = 0; Int.Value = 0; Con.Value = 0; Cha.Value = 0; Luk.Value = 0;
        }
        public void enableName()
        {
            dataGridView1.ClearSelection();
            CName.Enabled = true;
        }
        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Str_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Dex_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            CName.Enabled = true;
            conn = kon.GetCon();
            conn.Open();

            cmd = new SqlCommand("SELECT COUNT(*) FROM Table_2 WHERE cname = @CName", conn);
            cmd.Parameters.AddWithValue("@CName", CName.Text);
            int count = (int)cmd.ExecuteScalar();

            if (string.IsNullOrEmpty(CName.Text) || string.IsNullOrWhiteSpace(CName.Text))
            {
                MessageBox.Show("Character name cannot be empty!");
                return;
            }

            if (count > 0)
            {
                MessageBox.Show("Character name already exists!");
                cmd.Dispose();
                conn.Close();
                return;

            }
            cmd = new SqlCommand("insert into Table_2 values ('" + CName.Text + "','" + Lvl.Value + "','" + Hp.Value + "','" + Mp.Value + "'" +
                ",'" + Gender.Text + "','" + Faction.Text + "','" + Race.Text + "','" + Class.Text +
                "','" + Str.Value + "'," + "'" + Dex.Value + "','" + Int.Value + "','" + Con.Value + "','" + Cha.Value + "'," +
                "'" + Luk.Value + "')", conn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Character Saved");

            cmd = new SqlCommand("select * from Table_2", conn);
            rdr = cmd.ExecuteReader();

            dataGridView1.Rows.Clear();
            while (rdr.Read())
            {
                dataGridView1.Rows.Add(
             rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(),
             rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString(), rdr[7].ToString(),
             rdr[8].ToString(), rdr[9].ToString(), rdr[10].ToString(), rdr[11].ToString(),
             rdr[12].ToString(), rdr[13].ToString()
                );
            }

            rdr.Close();
            btnReset();

            enableName();
            cmd.Dispose();
            conn.Close();
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePictureBox();
        }

        private void Race_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePictureBox();
        }

        private void UpdatePictureBox()
        {
            string selectedItemComboBox1 = Gender.SelectedItem?.ToString();
            string selectedItemComboBox2 = Race.SelectedItem?.ToString();

            if (selectedItemComboBox1 != null && selectedItemComboBox2 != null)
            {
                switch (selectedItemComboBox1)
                {
                    case "Male":
                        switch (selectedItemComboBox2)
                        {
                            case "Human":
                                pictureBox1.Image = Image.FromFile("E:\\MMCM\\Files\\OOP\\source\\repos\\DndSheet\\Male\\Race\\Human\\MaleHuman.gif");
                                break;
                            case "Elf":
                                pictureBox1.Image = Image.FromFile("E:\\MMCM\\Files\\OOP\\source\\repos\\DndSheet\\Male\\Race\\Elf\\MaleElf.gif");
                                break;
                            default:
                                // pictureBox1.Image = null; // No matching image found.
                                break;
                        }
                        break;

                    case "Female":
                        switch (selectedItemComboBox2)
                        {
                            case "Human":
                                pictureBox1.Image = Image.FromFile("E:\\MMCM\\Files\\OOP\\source\\repos\\DndSheet\\Female\\Race\\Human\\FemaleHuman.gif");
                                break;
                            case "Elf":
                                pictureBox1.Image = Image.FromFile("E:\\MMCM\\Files\\OOP\\source\\repos\\DndSheet\\Female\\Race\\Elf\\FemaleElf.gif");
                                break;
                            default:
                                // pictureBox1.Image = null; // No matching image found.
                                break;
                        }
                        break;

                    default:
                        pictureBox1.Image = null; // No matching image found.
                        break;
                }
            }
            else
            {
                pictureBox1.Image = null; // One or both ComboBoxes have no selection.
            }

        }

        private bool isPlaying = true;
        private string soundLocation = "E:\\MMCM\\Files\\OOP\\source\\repos\\DndSheet\\VIDEO GAME.wav";

        private void Mute_Click(object sender, EventArgs e)
        {
            player.SoundLocation = soundLocation;

            if (isPlaying) // Check if the music is playing
            {
                player.Stop();
                isPlaying = false;
                Mute.BackgroundImage = System.Drawing.Image.FromFile("E:\\MMCM\\Files\\OOP\\source\\repos\\DndSheet\\mutee.png");
            }
            else
            {
                player.PlayLooping();
                isPlaying = true;
                Mute.BackgroundImage = System.Drawing.Image.FromFile("E:\\MMCM\\Files\\OOP\\source\\repos\\DndSheet\\musci note.png");
            }
            Mute.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CName.Text = "";
            btnReset();
            enableName();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                conn = kon.GetCon();
                conn.Open();

                cmd = new SqlCommand("UPDATE Table_2 SET cname = '" + CName.Text + "', clvl = '" + Lvl.Value + "', chealth = '" + Hp.Value + "'," +
                    "cmana = '" + Mp.Value + "', cgender = '" + Gender.Text + "', cfaction = '" + Faction.Text + "',crace = '" + Race.Text + "'," +
                    "cclass = '" + Class.Text + "', cstr = '" + Str.Value + "', cdex = '" + Dex.Value + "', cint = '" + Int.Value + "', ccon = '" + Con.Value + "'," +
                    "ccha = '" + Cha.Value + "',cluk = '" + Luk.Value + "' WHERE cname = '" + CName.Text + "'", conn);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Row Updated");

                cmd = new SqlCommand("select * from Table_2", conn);
                rdr = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (rdr.Read())
                {
                    dataGridView1.Rows.Add(
                        rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(),
                        rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString(), rdr[7].ToString(),
                        rdr[8].ToString(), rdr[9].ToString(), rdr[10].ToString(), rdr[11].ToString(),
                        rdr[12].ToString(), rdr[13].ToString()
                    );
                }
                btnReset();
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                enableName();
                cmd.Dispose();
                conn.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            conn = kon.GetCon();
            conn.Open();

            DialogResult result = MessageBox.Show("Are you sure you want to delete all characters?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                cmd = new SqlCommand("DELETE FROM Table_2", conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("All Characters Deleted.");

                cmd = new SqlCommand("select * from Table_2", conn);
                rdr = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (rdr.Read())
                {
                    dataGridView1.Rows.Add(
                        rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(),
                        rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString(), rdr[7].ToString(),
                        rdr[8].ToString(), rdr[9].ToString(), rdr[10].ToString(), rdr[11].ToString(),
                        rdr[12].ToString(), rdr[13].ToString()
                    );
                }
                enableName();

                rdr.Close();

                cmd.Dispose();
                conn.Close(); ;
                // Perform the action you want when the user chooses "Yes".
            }
            else
            {
                return;
                // Perform the action you want when the user chooses "No" or closes the dialog.
            }
        }



        private void Lvl_ValueChanged(object sender, EventArgs e)
        {

        }


        private void Delete_Click(object sender, EventArgs e)
        {
            conn = kon.GetCon();
            conn.Open();

            cmd = new SqlCommand("DELETE FROM Table_2 WHERE cname = '" + CName.Text + "'", conn);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("select * from Table_2", conn);
            rdr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (rdr.Read())
            {
                dataGridView1.Rows.Add(
                    rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(),
                    rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString(), rdr[7].ToString(),
                    rdr[8].ToString(), rdr[9].ToString(), rdr[10].ToString(), rdr[11].ToString(),
                    rdr[12].ToString(), rdr[13].ToString()
                );
            }
            enableName();

            rdr.Close();
            cmd.Dispose();
            conn.Close();
        }

        private void Faction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item from the ComboBox
            string selectedItem = Class.Text.ToString();

            // Create a switch statement to set the image in the PictureBox based on the selected item
            switch (selectedItem)
            {
                case "Warrior":
                    pictureBox2.Image = Image.FromFile("E:\\MMCM\\Files\\OOP\\source\\repos\\DndSheet\\Class\\Warrior.png");
                    break;
                case "Archer":
                    pictureBox2.Image = Image.FromFile("E:\\MMCM\\Files\\OOP\\source\\repos\\DndSheet\\Class\\Archer.png"); 
                    break;
                case "Mage":
                    pictureBox2.Image = Image.FromFile("E:\\MMCM\\Files\\OOP\\source\\repos\\DndSheet\\Class\\Mage.png");
                    break;
                case "Rogue":
                    pictureBox2.Image = Image.FromFile("E:\\MMCM\\Files\\OOP\\source\\repos\\DndSheet\\Class\\Rogue.png");
                    break;
                case "Cleric":
                    pictureBox2.Image = Image.FromFile("E:\\MMCM\\Files\\OOP\\source\\repos\\DndSheet\\Class\\Cleric.png");
                    break;

                // Add more cases for other ComboBox items as needed.
                default:
                    pictureBox2.Image = null; // Clear the PictureBox if no option matches.
                    break;
            }

        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}