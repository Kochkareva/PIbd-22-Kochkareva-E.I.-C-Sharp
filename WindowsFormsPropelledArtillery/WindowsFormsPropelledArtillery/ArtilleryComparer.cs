using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPropelledArtillery
{
    public class ArtilleryComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is CombatVehicle && y is SelfPropelledArtillery)
            {
               return 1;
            }
            if (x is SelfPropelledArtillery && x is CombatVehicle)
            {
                return -1;
            }
            if (y is SelfPropelledArtillery && y is SelfPropelledArtillery)
            {
                return 0;
            }
            return 0;
        }
        private int ComparerCombatVehicle(CombatVehicle x, CombatVehicle y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerSelfPropelledArtillery(SelfPropelledArtillery x, SelfPropelledArtillery y)
        {
            var res = ComparerCombatVehicle(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Ammunition != y.Ammunition)
            {
                return x.Ammunition.CompareTo(y.Ammunition);
            }
            if (x.Gun != y.Gun)
            {
                return x.Gun.CompareTo(y.Gun);
            }
            return 0;
        }
    }
}
