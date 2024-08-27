using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entitites
{
    public class Feature
    {
        public int FeatureID { get; set; }
        public int MyProperty { get; set; }
        public List<CarFeature> CarFeatures { get; set; }

    }
}
