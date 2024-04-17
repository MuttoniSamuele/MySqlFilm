using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySqlFilm
{
    public partial class Form2 : Form
    {
		MySqlConnection conn;
		Dictionary<string, int> genres;
		Action onSave;

		public Form2(MySqlConnection conn, Dictionary<string, int> genres, Action onSave)
        {
            InitializeComponent();
			this.conn = conn;
			this.genres = genres;
			this.onSave = onSave;
        }

		private void Form2_Load(object sender, EventArgs e)
		{
			cmbGenre.Items.Clear();
			foreach (string k in genres.Keys)
			{
				cmbGenre.Items.Add(k);
			}
			cmbGenre.SelectedIndex = 0;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			string synopsis = txtSynopsis.Text;
			TimeSpan duration = new TimeSpan((int)numHours.ValueNumber, (int)numMins.ValueNumber, 0);
			DateTime releaseDate = dateRelaseDate.Date;
			int genreId = genres[cmbGenre.Text];
			try
			{
				using (MySqlCommand cmd = new MySqlCommand(
					"INSERT INTO film (nome, trama, durata, data_uscita, id_genere) VALUES (@nome, @trama, @durata, @data_uscita, @id_genere)",
					conn
				))
				{
					cmd.Parameters.AddWithValue("@nome", name);
					cmd.Parameters.AddWithValue("@trama", synopsis);
					cmd.Parameters.AddWithValue("@durata", duration);
					cmd.Parameters.AddWithValue("@data_uscita", releaseDate);
					cmd.Parameters.AddWithValue("@id_genere", genreId);
					conn.Open();
					cmd.ExecuteNonQuery();
				}
			}
			catch { }
			finally {
				conn.Close();
				onSave();
				Close();
			}
		}
	}
}
