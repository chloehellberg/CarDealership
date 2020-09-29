namespace Calendar
{
  class Date
  {
    private int _month; // private field
    public int Day { get; set; } // public auto-implemented property

    public int Month // public property for _month
    {
      get { return _month; } // the getter, only returns month value
      set { // the setter, ensures the value being input is between 1-12
          if ( value < 0 || value > 12)
          {
            throw new ArgumentOutOfRangeException; // part of the System namespace (using System;)
          }
          else
          {
            _month = value; // value is the default parameter variable of a property
          }
      }
    }
  }
}