using System.Collections.Generic;

namespace Salon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string StylistName { get; set; }
    public string StylistDescription { get; set; }

    public List<Client> Clients { get; set; }

  }
}