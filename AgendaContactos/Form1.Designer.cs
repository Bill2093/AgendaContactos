using System.Data;
using System.Text;

namespace AgendaContactos
{
    public partial class Form1 : Form
    {
        private DataTable _tabla = new();

        public Form1()
        {
            InitializeComponent();
            SqliteDb.EnsureCreated();
            CargarTabla();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.MultiSelect = false;

            dgv.CellClick += (s, e) => CargarDesdeGrid();
            txtBuscar.TextChanged += (s, e) =>
                dgv.DataSource = string.IsNullOrWhiteSpace(txtBuscar.Text)
                    ? _tabla
                    : SqliteDb.Search(txtBuscar.Text);
        }

        private void CargarTabla()
        {
            _tabla = SqliteDb.GetAll();
            dgv.DataSource = _tabla;
            dgv.Columns["Id"].Width = 60;
        }

        private Contacto LeerFormulario() => new()
        {
            Id = string.IsNullOrWhiteSpace(txtId.Text) ? 0 : int.Parse(txtId.Text),
            Nombre = txtNombre.Text.Trim(),
            Telefono = txtTelefono.Text.Trim(),
            Correo = txtCorreo.Text.Trim(),
            Direccion = txtDireccion.Text.Trim()
        };

        private void Limpiar()
        {
            txtId.Clear(); txtNombre.Clear(); txtTelefono.Clear();
            txtCorreo.Clear(); txtDireccion.Clear();
            txtNombre.Focus();
        }

        private void CargarDesdeGrid()
        {
            if (dgv.CurrentRow == null) return;
            var row = dgv.CurrentRow;
            txtId.Text = row.Cells["Id"].Value?.ToString();
            txtNombre.Text = row.Cells["Nombre"].Value?.ToString();
            txtTelefono.Text = row.Cells["Telefono"].Value?.ToString();
            txtCorreo.Text = row.Cells["Correo"].Value?.ToString();
            txtDireccion.Text = row.Cells["Direccion"].Value?.ToString();
        }

        // --- Botones ---
        private void btnNuevo_Click(object sender, EventArgs e) => Limpiar();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var c = LeerFormulario();
            if (string.IsNullOrWhiteSpace(c.Nombre))
            {
                MessageBox.Show("Nombre es obligatorio.");
                return;
            }

            if (c.Id == 0) SqliteDb.Insert(c);
            else SqliteDb.Update(c);

            CargarTabla();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text)) return;
            if (MessageBox.Show("¿Eliminar contacto?", "Confirmar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqliteDb.Delete(int.Parse(txtId.Text));
                CargarTabla();
                Limpiar();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => Limpiar();

        private void btnExportar_Click(object sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog
            {
                Filter = "CSV (*.csv)|*.csv",
                FileName = $"contactos_{DateTime.Now:yyyyMMdd_HHmm}.csv"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportarCsv((DataTable)dgv.DataSource!, sfd.FileName);
                MessageBox.Show("Exportado correctamente.");
            }
        }

        private static void ExportarCsv(DataTable dt, string path)
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Join(",", dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName)));
            foreach (DataRow r in dt.Rows)
            {
                var campos = dt.Columns.Cast<DataColumn>()
                    .Select(c => EscapeCsv(r[c]?.ToString() ?? ""));
                sb.AppendLine(string.Join(",", campos));
            }
            File.WriteAllText(path, sb.ToString(), Encoding.UTF8);

            static string EscapeCsv(string s)
            {
                if (s.Contains(',') || s.Contains('"') || s.Contains('\n'))
                    return "\"" + s.Replace("\"", "\"\"") + "\"";
                return s;
            }
        }
    }
}
