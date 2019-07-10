using System;

namespace Trackr.Trackr.Helpers
{
    public class Easing
    {
        // t = current time, b = start val, c = change in val, d = duration
        public int QuadO(float t, float b, float c, float d)
        {
            t /= d;
            return (int)Math.Round(-c * t * (t - 2) + b);
        }
    }
}
