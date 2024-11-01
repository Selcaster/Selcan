using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal;
public class Appointment
    {
        public int No { get; set; }
        public string Patient { get; set; }
        public string Doctor { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Appointment(int no, string patient, string doctor, DateTime startDate)
        {
            No = no;
            Patient = patient;
            Doctor = doctor;
            StartDate = startDate;
            EndDate = null;
        }
    }

public class Hospital
{
    private List<Appointment> Appointments = new List<Appointment>();

    public void AddAppointment(Appointment appointment)
    {
        Appointments.Add(appointment);
        Console.WriteLine("Appointment elave olundu");
    }

    public void EndAppointment(int no)
    {
        var appointment = GetAppointment(no);
        if (appointment != null && appointment.EndDate == null)
        {
            appointment.EndDate = DateTime.Now;
            Console.WriteLine($"Appointment {no} bitib");
        }
        else
        {
            Console.WriteLine("Appointment ya yoxdur ya da bitmeyib");
        }
    }

    public Appointment GetAppointment(int no)
    {
        return Appointments.FirstOrDefault(a => a.No == no);
    }

    public List<Appointment> GetAllAppointments()
    {
        return Appointments;
    }

    public List<Appointment> GetWeeklyAppointments()
    {
        DateTime startOfWeek = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek + 1);
        return Appointments.Where(a => a.StartDate >= startOfWeek && a.StartDate <= DateTime.Now).ToList();
    }

    public List<Appointment> GetTodaysAppointments()
    {
        DateTime today = DateTime.Today;
        return Appointments.Where(a => a.StartDate.Date == today).ToList();
    }

    public List<Appointment> GetAllContinuingAppointments()
    {
        return Appointments.Where(a => a.EndDate == null).ToList();
    }
}
