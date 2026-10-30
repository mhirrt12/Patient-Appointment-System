
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicAppointmentSystem.Forms;

public class DashboardForm : Form
{
    public DashboardForm()
    {
        Text = "Clinic Appointment System - Dashboard";
        Size = new Size(900, 600);
        StartPosition = FormStartPosition.CenterScreen;
        BackColor = Color.FromArgb(245, 248, 250);

        Label title = new()
        {
            Text = "Clinic Dashboard",
            Font = new Font("Segoe UI", 24, FontStyle.Bold),
            Location = new Point(40, 30),
            AutoSize = true,
            ForeColor = Color.FromArgb(25, 55, 85)
        };

        Button btnPatients = CreateButton("Manage Patients", 50, 150);
        Button btnAppointments = CreateButton("Manage Appointments", 300, 150);
        Button btnLogout = CreateButton("Logout", 50, 250);

        btnLogout.Click += (_, _) => Close();

        Controls.AddRange(new Control[]
        {
            title, btnPatients, btnAppointments, btnLogout
        });
    }

    private Button CreateButton(string text, int x, int y)
    {
        return new Button
        {
            Text = text,
            Location = new Point(x, y),
            Size = new Size(220, 65),
            BackColor = Color.FromArgb(0, 125, 140),
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 11, FontStyle.Bold),
            FlatStyle = FlatStyle.Flat
        };
    }
}
