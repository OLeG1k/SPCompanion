using System;
using System.Linq;
using System.Collections.Generic;

namespace SportCompanion.Core.Models
{
    public class EnergyInfoCollection : List<EnergyInfo>
    {
        public EnergyInfoCollection() : base()
        {

        }

        public EnergyInfoCollection(int capacity) : base(capacity)
        {
        }

        public EnergyInfoCollection(IEnumerable<EnergyInfo> collection) : base(collection)
        {
        }

        public DateTime? MinDate 
        {
            get
            {
                if (!this.Any())
                {
                    return null;
                }

                return this.Min(s => s.Date);
            }
        }

        public DateTime? MaxDate
        {
            get
            {
                if (!this.Any())
                {
                    return null;
                }

                return this.Max(s => s.Date);
            }
        }
    }
}
