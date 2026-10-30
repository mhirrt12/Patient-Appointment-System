
using System;
using System.Windows.Forms;
using ClinicAppointmentSystem.Forms;

namespace ClinicAppointmentSystem;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new LoginForm());
    }
}
