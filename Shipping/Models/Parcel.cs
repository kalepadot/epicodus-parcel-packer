using System.Collections.Generic;

namespace Shipping.Models
{
  public class Parcel
  {
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Volume { get; set; }
    public int Cost { get; set; }
    private static List<Parcel> _instances = new List<Parcel> {};

    public Parcel (int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
      Volume = 0;
      Cost = 0;
      _instances.Add(this);
    }

    public void GetVolume()
    {
      Volume = (Width * Height * Length);
    }

    public void GetCost()
    {
      if (Volume <= 400)
      {
        Cost = 12;
      }
      else
      {
        Cost = (Volume * (Weight / 5));
      }
    }
    public static List<Parcel> GetAll()
    {
      return _instances;
    }
  }
}