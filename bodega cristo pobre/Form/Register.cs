using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SimpleCrypto;
using System.Text.RegularExpressions;


namespace bodega_cristo_pobre
{
    public partial class Registro : Form
    {
        
        public static bool validato(String NumDOc)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select NumDoc from Personal where Numdoc = '" + NumDOc + "'", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Documento ya existente", "Advertencia", MessageBoxButtons.OK);
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool validarUsuario(String usuario)
        {
            SqlDataAdapter da = new SqlDataAdapter("select usuario from Personal where usuario = '" + usuario + "'", Varpublic.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Usuario existente,Ingrese otro Usuario", "Advertencia", MessageBoxButtons.OK);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Email_Valido(String email)
        {
            String validando;
            validando = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, validando))
            {
                if (Regex.Replace(email, validando, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public Registro()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }
                if (ctrl is ComboBox)
                {
                    ComboBox cmb = ctrl as ComboBox;
                    cmb.SelectedIndex = -1;
                }
            }
            txtNombres.Select();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ICryptoService cryptoService = new PBKDF2();

            //GENERAR ALGORITMO DE INCRIPTACION
            string salt = cryptoService.GenerateSalt();
            string contraseñaincriptada = cryptoService.Compute(txtPassword.Text.Trim());

            if (txtNombres.Text != String.Empty && txtApellidos.Text != String.Empty && txtTelefono.Text != String.Empty)
            {
                if (Email_Valido(txtemail.Text))
                {
                    BtnAgregar.Enabled = true;
                    if ((txtTelefono.Text.Length) <= 9 && (txtTelefono.Text.Length) >= 9)
                    {
                        if (Registro.validato(txtNumDoc.Text) == false)
                        {
                            if (Registro.validarUsuario(txtusuario.Text) == false)
                            {
                                try
                                {
                                   

                                    SqlDataAdapter da = new SqlDataAdapter("Sp_InsPersonal '" + txtNombres.Text.ToUpper()
                                    + "','" + txtApellidos.Text.ToUpper() + "','" + txtTelefono.Text + "','" + txtCarg.Text.ToUpper() + "','" + txtNumDoc.Text + "','" + txttipdoc.Text.ToUpper()  + "','" + txtusuario.Text.ToUpper().Trim()  + "','" + contraseñaincriptada +
                                    "','" + salt + "','" + txtemail.Text.Trim() + "'", Varpublic.cadconex);
                                    DataTable dt = new DataTable();
                                    da.Fill(dt);
                                    da.Dispose();
                                    MessageBox.Show("Registro insertado exitosamente");
                                }
                                catch
                                {
                                    MessageBox.Show("Error, no se insertó registro");
                                }
                            }
                            else
                            {
                                txtusuario.Clear();

                            }
                        }
                        else
                        {
                            txtNumDoc.Clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Ingrese Correctamente el Numero");
                        txtTelefono.Clear();
                    }
                }
                else
                {



                    MessageBox.Show("Ingrese un Email Válido");
                    txtemail.Clear();
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            txtTelefono.MaxLength = 9;
        }
    }
}

