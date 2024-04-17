using Google.Protobuf.WellKnownTypes;
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
using System.Xml.Linq;
using ReaLTaiizor.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MySqlFilm
{
    public partial class Form1 : Form
    {
		MySqlConnection conn = new MySqlConnection("Server=localhost;Database=film;Uid=root;Pwd=;");
        Film selectedFilm;
		Dictionary<string, int> genres = new Dictionary<string, int>();
		int? selectedId = null;

		public Form1()
        {
            InitializeComponent();
        }

        private void showError(string msg, bool warning = false)
        {
            notifyError.Text = msg;
            notifyError.Visible = true;
			notifyError.Type = warning ? HopeNotify.AlertType.Warning : HopeNotify.AlertType.Error;
        }

        private void enableInputs(bool enabled)
        {
			txtName.Enabled = enabled;
			txtSynopsis.Enabled = enabled;
			dateReleaseDate.Enabled = enabled;
			numHours.Enabled = enabled;
			numMins.Enabled = enabled;
            cmbGenre.Enabled = enabled;
            btnSave.Enabled = enabled;
		}

		private void loadFilms()
		{
			try
			{
				conn.Open();
				MySqlCommand cmd = new MySqlCommand("SELECT * FROM film;", conn);
				MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				dataGridViewFilms.DataSource = dt;
			}
			catch
			{
				showError("Impossibile comunicare con il database");
			}
			finally
			{
				conn.Close();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			enableInputs(false);
			loadFilms();
			try
			{
				conn.Open();
				MySqlCommand cmd = new MySqlCommand("SELECT id_genere, nome FROM generi;", conn);
				MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				cmbGenre.Items.Clear();
				foreach (DataRow dr in dt.Rows)
				{
					int id = int.Parse(dr["id_genere"].ToString());
					string name = dr["nome"].ToString();
					genres.Add(name, id);
					cmbGenre.Items.Add(name);
				}
			}
			catch
			{
				showError("Impossibile comunicare con il database");
			}
			finally
			{
				conn.Close();
			}
		}

		private void dataGridViewFilms_SelectionChanged(object sender, EventArgs e)
		{
            if (dataGridViewFilms.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow selectedRow = dataGridViewFilms.SelectedRows[0];
			int id;
			try
			{
				id = int.Parse(selectedRow.Cells["id_film"].Value.ToString());
			} catch
			{
				return;
			}
			string name = selectedRow.Cells["nome"].Value.ToString();
			string synopsis = selectedRow.Cells["trama"].Value.ToString();
			TimeSpan duration = TimeSpan.Parse(selectedRow.Cells["durata"].Value.ToString());
			DateTime releaseDate = DateTime.Parse(selectedRow.Cells["data_uscita"].Value.ToString());
			int genreId = int.Parse(selectedRow.Cells["id_genere"].Value.ToString());
            selectedFilm = new Film(id, name, synopsis, duration, releaseDate, genreId);
            txtName.Text = name;
            txtSynopsis.Text = synopsis;
            dateReleaseDate.Date = releaseDate;
            numHours.ValueNumber = duration.Hours;
            numMins.ValueNumber = duration.Minutes;
			foreach (string k in genres.Keys)
			{
				if (genres[k] == genreId)
				{
					cmbGenre.SelectedItem = k;
				}
			}
			enableInputs(false);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (dataGridViewFilms.SelectedRows.Count == 0)
			{
				selectedId = null;
				return;
			}
			DataGridViewRow selectedRow = dataGridViewFilms.SelectedRows[0];
			selectedId = int.Parse(selectedRow.Cells["id_film"].Value.ToString());
			enableInputs(true);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dataGridViewFilms.SelectedRows.Count == 0)
            {
                showError("Seleziona un film da eliminare", true);
                return;
            }
			int filmId = Convert.ToInt32(dataGridViewFilms.SelectedRows[0].Cells["id_film"].Value);
			try
			{
				using (MySqlCommand cmd = new MySqlCommand("DELETE FROM film WHERE id_film = @id_film", conn))
				{
					cmd.Parameters.AddWithValue("@id_film", filmId);
					conn.Open();
					cmd.ExecuteNonQuery();
				}
				dataGridViewFilms.Rows.RemoveAt(dataGridViewFilms.SelectedRows[0].Index);
				enableInputs(false);
			}
			catch
			{
				showError("Impossibile comunicare con il database");
			}
			finally
			{
				conn.Close();
			}
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			if (selectedId == null)
			{
				return;
			}
			string name = txtName.Text;
			string synopsis = txtSynopsis.Text;
			TimeSpan duration = new TimeSpan((int)numHours.ValueNumber, (int)numMins.ValueNumber, 0);
			DateTime releaseDate = dateReleaseDate.Date;
			int genreId = genres[cmbGenre.Text];
			try
			{
				using (MySqlCommand cmd = new MySqlCommand(
					"UPDATE film SET nome = @nome, trama = @trama, durata = @durata, data_uscita = @data_uscita, id_genere = @id_genere WHERE id_film = @id_film",
					conn
				))
				{
					cmd.Parameters.AddWithValue("@nome", name);
					cmd.Parameters.AddWithValue("@trama", synopsis);
					cmd.Parameters.AddWithValue("@durata", duration);
					cmd.Parameters.AddWithValue("@data_uscita", releaseDate);
					cmd.Parameters.AddWithValue("@id_genere", genreId);
					cmd.Parameters.AddWithValue("@id_film", selectedId);
					conn.Open();
					cmd.ExecuteNonQuery();
				}
			}
			catch
			{
				showError("Impossibile comunicare con il database");
			}
			finally
			{
				conn.Close();
				enableInputs(false);
				selectedId = null;
				loadFilms();
			}

		}

		private void hopeButton1_Click(object sender, EventArgs e)
		{
			enableInputs(false);
			Form2 f = new Form2(conn, genres, loadFilms);
			f.Show();
		}
	}
}
