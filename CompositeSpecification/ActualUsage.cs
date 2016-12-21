using System.Collections.Generic;

namespace CompositeSpecification
{
    public class ActualUsage
    {
        public void DoSomething()
        {
            var mobiles = new List<Mobile>
                            {
                                new Mobile { BrandName = "Samsung", Type = MobileType.basic, Cost = 1000},
                                new Mobile { BrandName = "htc", Type = MobileType.smart, Cost = 5000}
                            };

            #region Create rules
            //We can define our RUlES here
            ISpecification<Mobile> samsungExpSpecification = new ExpressionSpecification<Mobile>(mobile=> string.Equals(mobile.BrandName, "Samsung"));
            //Another Rule
            ISpecification<Mobile> htcExpSpecification = new ExpressionSpecification<Mobile>(mobile => string.Equals(mobile.BrandName, "htc"));
            ISpecification<Mobile> samsungLowPrice = new ExpressionSpecification<Mobile>(mobile => mobile.Cost > 1000);
            #endregion

            #region Rules executing sample

            //Execute the rules
            var samsungMobiles = mobiles.FindAll(mobile => samsungExpSpecification.IsSatisfiedBy(mobile));
            var htcMobiles = mobiles.FindAll(mobile => htcExpSpecification.IsSatisfiedBy(mobile));

            //Execute complex rule
            var allButSamsungMobiles = mobiles.FindAll(mobile => samsungExpSpecification.Not().IsSatisfiedBy(mobile));

            var allMobiles = mobiles.FindAll(mobile => samsungExpSpecification.Or(htcExpSpecification).IsSatisfiedBy(mobile));

            var samAndHTC = mobiles.FindAll(mobile => samsungExpSpecification.And(samsungLowPrice).And(htcExpSpecification).IsSatisfiedBy(mobile));

            #endregion
        }
    }
}
