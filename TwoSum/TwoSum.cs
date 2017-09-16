using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    class TwoSum
    {
        public int[] FindTwoSum(int[] nums,int target)
        {
            var map = new Dictionary<int, int>();
            for(int i=0;i<=nums.Length;i++)
            {
                int complement = target - nums[i];
                if(map.ContainsKey(complement))
                {
                    return new int[] {map[complement] , nums[i] };
                }
                map.Add(complement, i);
            }
            throw new NotFiniteNumberException("There no sum match");
        }
    }
}
