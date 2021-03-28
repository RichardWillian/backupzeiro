using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                buttonStart.Enabled = false;
                buttonStart.BackColor = Color.Green;
                buttonStart.Text = "Backup Iniciado";

                new Thread(FazerBackup2).Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        void FazerBackup1()
        {
            var dataAtual = DateTime.Now.ToString("yyyy-MM-dd");
            var servidor = !String.IsNullOrEmpty(textBoxServidor.Text) ? textBoxServidor.Text : "127.0.0.1";
            var usuario = !String.IsNullOrEmpty(textBoxUsuario.Text) ? textBoxUsuario.Text : "root";
            var senha = !String.IsNullOrEmpty(textBoxSenha.Text) ? textBoxSenha.Text : String.Empty;
            var dataBase = !String.IsNullOrEmpty(textBoxDataBase.Text) ? textBoxDataBase.Text : "vrp";
            var nomeArquivo = !String.IsNullOrEmpty(textBoxNomeArquivo.Text) ? textBoxNomeArquivo.Text : @"backup";
            var pathInicial = (!String.IsNullOrEmpty(textBoxPath.Text) ? textBoxPath.Text : @"C:\Backup\FiveM\");
            var path = pathInicial + dataAtual;
            var tempo = !String.IsNullOrEmpty(textBoxTempo.Text) ? Int32.Parse(textBoxTempo.Text) : 10;

            var connectionString = $"server={servidor};user={usuario};pwd={senha};database={dataBase};";


            for (; ; )
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    DirectoryInfo dInfo = new DirectoryInfo(path);
                    DirectorySecurity dSecurity = dInfo.GetAccessControl();
                    dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
                    dInfo.SetAccessControl(dSecurity);
                }

                var contador = RecuperarUltimoContador(nomeArquivo, path);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            new Form();
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(path + "\\" + nomeArquivo + "-" + contador + ".sql");
                            conn.Close();
                        }
                        contador++;
                        Thread.Sleep(tempo * 60000);
                    }
                }

                if (dataAtual != DateTime.Now.ToString("yyyy-MM-dd"))
                {
                    dataAtual = DateTime.Now.ToString("yyyy-MM-dd");
                    path = pathInicial + dataAtual;
                }
            }
        }

        void FazerBackup2()
        {
            var dataAtual = DateTime.Now.ToString("yyyy-MM-dd");
            var servidor = !String.IsNullOrEmpty(textBoxServidor.Text) ? textBoxServidor.Text : "127.0.0.1";
            var usuario = !String.IsNullOrEmpty(textBoxUsuario.Text) ? textBoxUsuario.Text : "root";
            var senha = !String.IsNullOrEmpty(textBoxSenha.Text) ? textBoxSenha.Text : String.Empty;
            var dataBase = !String.IsNullOrEmpty(textBoxDataBase.Text) ? textBoxDataBase.Text : "vrp";
            var nomeArquivo = !String.IsNullOrEmpty(textBoxNomeArquivo.Text) ? textBoxNomeArquivo.Text : @"backup";
            var pathInicial = (!String.IsNullOrEmpty(textBoxPath.Text) ? textBoxPath.Text : @"C:\Backup\FiveM\");
            var path = pathInicial + dataAtual;
            var tempo = !String.IsNullOrEmpty(textBoxTempo.Text) ? Int32.Parse(textBoxTempo.Text) : 10;
            var caminhoMySQL = !String.IsNullOrEmpty(textBoxCaminhoMySQL.Text) ? textBoxCaminhoMySQL.Text : @"C:\xampp\mysql\bin\";

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            var contador = 0;
            for (; ; )
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    DirectoryInfo dInfo = new DirectoryInfo(path);
                    DirectorySecurity dSecurity = dInfo.GetAccessControl();
                    dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
                    dInfo.SetAccessControl(dSecurity);
                }

                contador = RecuperarUltimoContador(nomeArquivo, path);

                var nomeArquivoFormatado = path + "\\" + nomeArquivo + "-" + contador + ".sql";

                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = $"/C {caminhoMySQL}" + @"\mysqldump.exe " + $"--user=root --password={senha} {dataBase} --extended-insert=TRUE > {nomeArquivoFormatado}";
                process.StartInfo = startInfo;
                process.Start();

                if (dataAtual != DateTime.Now.ToString("yyyy-MM-dd"))
                {
                    dataAtual = DateTime.Now.ToString("yyyy-MM-dd");
                    path = pathInicial + dataAtual;
                }

                Thread.Sleep(tempo * 60000);
            }
        }

        private int RecuperarUltimoContador(string nomeArquivo, string path)
        {
            var arquivosPasta = Directory.GetFiles(path);
            var listaNumeros = new List<int>();
            foreach (var arquivoPasta in arquivosPasta)
            {
                var nomeArquivoPasta = arquivoPasta.Replace(path, String.Empty).ToString();
                var informacoesArquivo = nomeArquivoPasta.Split('-');
                var prefixo = informacoesArquivo[0].Replace("\\", String.Empty);

                if (prefixo == nomeArquivo)
                {
                    listaNumeros.Add(Int32.Parse(informacoesArquivo[1].Replace(".sql", String.Empty)));
                }
            }

            return listaNumeros.Count() > 0 ? listaNumeros.OrderBy(x => x).Last() + 1 : 1;
        }
    }
}
