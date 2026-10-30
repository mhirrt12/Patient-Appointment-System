
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicAppointmentSystem.Forms;

public class DashboardForm : Form
{
    public DashboardForm()
    {
        Text = "Clinic Appointment System - Dashboard";
        Size = new Size(1200, 750);
        MinimumSize = new Size(1000, 650);
        StartPosition = FormStartPosition.CenterScreen;
        BackColor = Color.FromArgb(245, 248, 252);

        Panel sidebar = new()
        {
            Dock = DockStyle.Left,
            Width = 240,
            BackColor = Color.FromArgb(20, 38, 65)
        };

        Label logo = new()
        {
            Text = "CLINIC\nMANAGEMENT",
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 18, FontStyle.Bold),
            Location = new Point(25, 35),
            Size = new Size(200, 75)
        };

        sidebar.Controls.Add(logo);

        AddMenuButton(sidebar, "Dashboard", 150);
        AddMenuButton(sidebar, "Patients", 215);
        AddMenuButton(sidebar, "Appointments", 280);
        AddMenuButton(sidebar, "Reports", 345);

        Button logout = AddMenuButton(sidebar, "Logout", 600);
        logout.Click += (_, _) => Close();

        Label heading = new()
        {
            Text = "Dashboard Overview",
            Font = new Font("Segoe UI", 25, FontStyle.Bold),
            ForeColor = Color.FromArgb(25, 55, 85),
            Location = new Point(285, 35),
            AutoSize = true
        };

        Controls.Add(sidebar);
        Controls.Add(heading);

        AddCard("TOTAL PATIENTS", "0", 290, 120);
        AddCard("APPOINTMENTS", "0", 590, 120);
        AddCard("PENDING", "0", 890, 120);

        Label welcome = new()
        {
            Text = "Welcome to the Clinic Appointment System",
            Font = new Font("Segoe UI", 17, FontStyle.Bold),
            Location = new Point(290, 300),
            AutoSize = true,
            ForeColor = Color.FromArgb(25, 55, 85)
        };

        Controls.Add(welcome);
    }

    private Button AddMenuButton(Panel parent, string text, int y)
    {
        Button button = new()
        {
            Text = text,
            Location = new Point(15, y),
            Size = new Size(210, 50),
            BackColor = Color.FromArgb(20, 38, 65),
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 12),
            FlatStyle = FlatStyle.Flat,
            TextAlign = ContentAlignment.MiddleLeft,
            Cursor = Cursors.Hand
        };

        button.FlatAppearance.BorderSize = 0;
        parent.Controls.Add(button);
        return button;
    }

    private void AddCard(string title, string value, int x, int y)
    {
        Panel card = new()
        {
            Location = new Point(x, y),
            Size = new Size(260, 130),
            BackColor = Color.White
        };

        Label heading = new()
        {
            Text = title,
            Location = new Point(20, 20),
            AutoSize = true,
            ForeColor = Color.Gray,
            Font = new Font("Segoe UI", 11, FontStyle.Bold)
        };

        Label number = new()
        {
            Text = value,
            Location = new Point(20, 55),
            AutoSize = true,
            ForeColor = Color.FromArgb(0, 125, 140),
            Font = new Font("Segoe UI", 27, FontStyle.Bold)
        };

        card.Controls.AddRange(new Control[] { heading, number });
        Controls.Add(card);
    }
}
