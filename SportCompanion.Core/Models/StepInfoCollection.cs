using System;
using System.Linq;
using System.Collections.Generic;

namespace SportCompanion.Core.Models
{
    public class StepInfoCollection : List<StepInfo>
    {
        public StepInfoCollection() : base()
        {

        }

        public StepInfoCollection(int capacity) : base(capacity)
        {
        }

        public StepInfoCollection(IEnumerable<StepInfo> collection) : base(collection)
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
