using System.Text.RegularExpressions;

namespace ProyectoUno
{
    public partial class Init : Form
    {
        private string ruta;
        private int inicio = 0;


        public Init()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] list1 = listBox1.Items.OfType<string>().ToArray();
            string[] list2 = listBox2.Items.OfType<string>().ToArray();

            int total_items = list1.Count();
            int total_items2 = list2.Count();

            string this_path = textBox3.Text;

            // string oldfilename = this_path + old_name;
            // string newfilename = this_path + new_name;
            if (total_items > 0 && total_items2 > 0)
            {

                string message = "¿Confirmas el renombramiento de archivos?";
                string title = "Aviso.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    for (int i = 0; i < total_items; i++)
                    {
                        var old_file_name = this_path + "\\" + list1[i];
                        var new_file_name = this_path + "\\" + list2[i];
                        System.IO.File.Move(old_file_name, new_file_name);

                    }

                    MessageBox.Show("Archivos renombrados exitosamente", "Aviso");
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    textBox3.Text = "";

                }
                else
                {
                    this.Close();
                }

            }

            else
            {
                MessageBox.Show("Error. Falta algún dato", "Aviso");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD1 = new FolderBrowserDialog();
            if (FBD1.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = FBD1.SelectedPath;
                listBox1.Items.Clear();
                string[] files = Directory.GetFiles(FBD1.SelectedPath, "*.*", SearchOption.AllDirectories);
                foreach (string file in files)
                {

                    listBox1.Items.Add(Path.GetFileName(file));

                }

                listBox2.Items.Clear();
                string[] files_new = Directory.GetFiles(FBD1.SelectedPath);
                foreach (string file in files_new)
                {
                    string str = Path.GetFileName(file);
                    if (string.IsNullOrEmpty(textBox1.Text) == false && string.IsNullOrEmpty(textBox2.Text) == false)
                    {
                        string search = textBox1.Text;
                        string replace = textBox2.Text;

                        string new_name_file = str.Replace(search, replace);

                        listBox2.Items.Add(new_name_file);

                    }

                }

            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                string[] clist = listBox1.Items.OfType<string>().ToArray();
                listBox2.Items.Clear();
                foreach (string c in clist)
                {
                    string str = c;
                    if (string.IsNullOrEmpty(textBox1.Text) == false && string.IsNullOrEmpty(textBox2.Text) == false)
                    {
                        string search = textBox1.Text;
                        string replace = textBox2.Text;


                        string new_name_file = str.Replace(search, replace);

                        listBox2.Items.Add(new_name_file);
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                string[] clist = listBox1.Items.OfType<string>().ToArray();
                listBox2.Items.Clear();
                foreach (string c in clist)
                {
                    string str = c;
                    if (string.IsNullOrEmpty(textBox1.Text) == false && string.IsNullOrEmpty(textBox2.Text) == false)
                    {
                        string search = textBox1.Text;
                        string replace = textBox2.Text;

                        string new_name_file = str.Replace(search, replace);

                        listBox2.Items.Add(new_name_file);
                    }
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}