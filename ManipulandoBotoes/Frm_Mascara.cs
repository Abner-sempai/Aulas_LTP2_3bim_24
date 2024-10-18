using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ManipulandoBotoes
{
    public partial class Frm_Mascara : Form
    {
        public Frm_Mascara()
        {
            InitializeComponent();
        }

        private void Btn_Hora_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;

            Lbl_Conteudo.Text = "";

            Msk_TextBox.Mask = "00:00";

            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;

            Msk_TextBox.Text = "";

            Msk_TextBox.Focus();
            Msk_TextBox.RightToLeft = RightToLeft.No;
        }

        private void Btn_VerConteudo_Click(object sender, EventArgs e)
        {
            string input = Msk_TextBox.Text;

            
            if (Msk_TextBox.Mask == "00:00")
            {
                if (TimeSpan.TryParse(input, out TimeSpan time) && time.TotalHours < 24)
                {
                    Lbl_Conteudo.Text = Msk_TextBox.Text; 
                }
                else
                {
                    MessageBox.Show("Hora inválida. Por favor, insira uma hora válida entre 00:00 e 23:59.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Msk_TextBox.Focus();
                }
            }

            
            else if (Msk_TextBox.Mask == "00/00/0000")
            {
                if (DateTime.TryParse(input, out DateTime date))
                {
                    Lbl_Conteudo.Text = Msk_TextBox.Text; 
                }
                else
                {
                    MessageBox.Show("Data inválida. Por favor, insira uma data válida no formato DD/MM/AAAA.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Msk_TextBox.Focus();
                }
            }

          
            else if (Msk_TextBox.UseSystemPasswordChar)
            {
                bool isValidPassword = input.Length >= 8 &&
                                       input.Any(char.IsUpper) &&
                                       input.Any(char.IsLower) &&
                                       input.Any(char.IsDigit) &&
                                       input.Any(ch => "!@#$%^&*()-_=+[]{}|;:'\",.<>?/\\`~".Contains(ch));

                if (!isValidPassword)
                {
                    MessageBox.Show("Senha inválida! A senha deve ter no mínimo 8 caracteres, contendo: uma letra maiúscula, uma letra minúscula, um número e um caractere especial.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Msk_TextBox.Focus();
                }
                else
                {
                    Lbl_Conteudo.Text = Msk_TextBox.Text; 
                }
            }

            
            else
            {
                Lbl_Conteudo.Text = Msk_TextBox.Text; 
            }
        }

        private void Btn_CEP_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;

            Lbl_Conteudo.Text = "";

            Msk_TextBox.Mask = "00000-000";

            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;

            Msk_TextBox.Text = "";

            Msk_TextBox.Focus();
            Msk_TextBox.RightToLeft = RightToLeft.No;
        }

        private void Btn_Moeda_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;

            Lbl_Conteudo.Text = "";

            Msk_TextBox.Mask = "$ 000,000,000.00";

            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;

            Msk_TextBox.Text = "";

            Msk_TextBox.Focus();
            Msk_TextBox.RightToLeft = RightToLeft.Yes;
        }

        private void Btn_Data_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;

            Lbl_Conteudo.Text = "";

            Msk_TextBox.Mask = "00/00/0000";

            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;

            Msk_TextBox.Text = "";

            Msk_TextBox.Focus();
            Msk_TextBox.RightToLeft = RightToLeft.No;
        }

        private void Btn_Senha_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = true;

            Lbl_Conteudo.Text = "";

            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;

            Msk_TextBox.Text = "";

            Msk_TextBox.Focus();
            Msk_TextBox.RightToLeft = RightToLeft.No;
        }

        private void Btn_Telefone_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;

            Lbl_Conteudo.Text = "";

            Msk_TextBox.Mask = "(00) 0000-0000";

            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;

            Msk_TextBox.Text = "";

            Msk_TextBox.Focus();
            Msk_TextBox.RightToLeft = RightToLeft.Yes;
        }
    }
}
