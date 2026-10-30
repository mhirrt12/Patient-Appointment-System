
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicAppointmentSystem.Forms;

public class LoginForm : Form
{
    private TextBox txtUsername = new();
    private TextBox txtPassword = new();

    public LoginForm()
    {
        Text = "Clinic Appointment System";
        Size = new Size(1100, 700);
        MinimumSize = new Size(900, 600);
        StartPosition = FormStartPosition.CenterScreen;
        BackColor = Color.FromArgb(20, 38, 65);
        FormBorderStyle = FormBorderStyle.Sizable;

        Panel card = new()
        {
            Size = new Size(480, 480),
            BackColor = Color.White,
            Location = new Point(310, 100),
            Anchor = AnchorStyles.None
        };

        Label title = new()
        {
            Text = "CLINIC APPOINTMENT SYSTEM",
            Font = new Font("Segoe UI", 19, FontStyle.Bold),
            ForeColor = Color.FromArgb(25, 55, 85),
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(30, 45),
            Size = new Size(420, 50)
        };

        Label subtitle = new()
        {
            Text = "Welcome back! Please sign in.",
            Font = new Font("Segoe UI", 11),
            ForeColor = Color.Gray,
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(30, 100),
            Size = new Size(420, 30)
        };

        Label lblUsername = new()
        {
            Text = "Username",
            Location = new Point(60, 165),
            AutoSize = true,
            Font = new Font("Segoe UI", 11)
        };

        txtUsername.SetBounds(60, 195, 360, 42);
        txtUsername.Font = new Font("Segoe UI", 12);

        Label lblPassword = new()
        {
            Text = "Password",
            Location = new Point(60, 255),
            AutoSize = true,
            Font = new Font("Segoe UI", 11)
        };

        txtPassword.SetBounds(60, 285, 360, 42);
        txtPassword.Font = new Font("Segoe UI", 12);
        txtPassword.UseSystemPasswordChar = true;

        Button btnLogin = new()
        {
            Text = "SIGN IN",
            Location = new Point(60, 360),
            Size = new Size(360, 50),
            BackColor = Color.FromArgb(0, 125, 140),
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 12, FontStyle.Bold),
            FlatStyle = FlatStyle.Flat,
            Cursor = Cursors.Hand
        };

        btnLogin.FlatAppearance.BorderSize = 0;
        btnLogin.Click += BtnLogin_Click;

        card.Controls.AddRange(new Control[]
        {
            title, subtitle,
            lblUsername, txtUsername,
            lblPassword, txtPassword,
            btnLogin
        });

        Controls.Add(card);

        Resize += (_, _) =>
        {
            card.Location = new Point(
                (ClientSize.Width - card.Width) / 2,
                (ClientSize.Height - card.Height) / 2
            );
        };
    }

    private void BtnLogin_Click(object? sender, EventArgs e)
    {
        if (txtUsername.Text == "admin" &&
            txtPassword.Text == "1234")
        {
            MessageBox.Show("Login successful!");

            Hide();
            using DashboardForm dashboard = new();
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
