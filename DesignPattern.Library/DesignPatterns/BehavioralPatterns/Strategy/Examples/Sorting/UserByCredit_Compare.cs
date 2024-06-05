using System.Collections;

namespace DesignPatterns.BehavioralPatterns.Strategy.Examples.Sorting
{
    public class UserByCredit_Compare : IComparer<User<long>>
    {
        public int Compare(User<long>? x, User<long>? y)
        {
            if (x.Credit > y.Credit)
                return 1;
            else if (x.Credit == y.Credit)
                return 0;
            else
                return -1;
        }
    }
    public class UserId_Compare : IComparer<User<long>>
    {
        public int Compare(User<long>? x, User<long>? y)
        {
            if (x.Id > y.Id)
                return 1;
            else if (x.Id == y.Id)
                return 0;
            else
                return -1;
        }
    }
}
