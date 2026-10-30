
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicAppointmentSystem.Forms;

public class LoginForm : Form
{
    private TextBox txtUsername = new();
    private TextBox txtPassword = new();
    private Button btnLogin = new();

    public LoginForm()
    {
        Text = "Clinic Appointment System - Login";
        Size = new Size(450, 400);
        StartPosition = FormStartPosition.CenterScreen;
        BackColor = Color.White;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;

        Label title = new()
        {
            Text = "CLINIC APPOINTMENT SYSTEM",
            Font = new Font("Segoe UI", 16, FontStyle.Bold),
            ForeColor = Color.FromArgb(25, 55, 85),
            AutoSize = true,
            Location = new Point(55, 40)
        };

        Label lblUsername = new()
        {
            Text = "Username",
            Location = new Point(60, 120),
            AutoSize = true
        };

        txtUsername.SetBounds(60, 145, 310, 35);

        Label lblPassword = new()
        {
            Text = "Password",
            Location = new Point(60, 195),
            AutoSize = true
        };

        txtPassword.SetBounds(60, 220, 310, 35);
        txtPassword.UseSystemPasswordChar = true;

        btnLogin = new Button
        {
            Text = "LOGIN",
            Location = new Point(60, 285),
            Size = new Size(310, 40),
            BackColor = Color.FromArgb(0, 125, 140),
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat
        };

        btnLogin.Click += BtnLogin_Click;

        Controls.AddRange(new Control[]
        {
            title, lblUsername, txtUsername,
            lblPassword, txtPassword, btnLogin
        });
    }

    private void BtnLogin_Click(object? sender, EventArgs e)
    {
        if (txtUsername.Text == "admin" &&
            txtPassword.Text == "1234")
        {
            MessageBox.Show("Login successful!");

            Hide();

            DashboardForm dashboard = new();
            dashboard.ShowDialog();

            Close();
        }
        else
        {
            MessageBox.Show(
                "Invalid username or password.",
                "Login Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
    }
}
