using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Appointment {    

    public int AppointmentId { get; set; }
    public string Title { get; set; }
    public string Date { get; set; }
    public int StylistId { get; set; }
    public int ClientId { get; set; }
    public virtual Stylist Stylist { get; set; }
    public virtual Stylist Client { get; set; }

    }
}