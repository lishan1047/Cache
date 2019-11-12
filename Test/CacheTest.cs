public class CacheTest
{
    public void Test(){
        int s = 1, i = 1;
        while(i <= 10){
            var p = eIvy.Common.CacheCompareValueExpiredPolicy.GetPolicy("somekey", s).SetNewValue(s);
            var x = eIvy.Common.Cache.Instance.GetValue<int>("somekey", ()=>
            {
                return 1 + 2;
            }, p);
            if(i % 5 == 0){
                s = i;
            }
            System.Console.WriteLine(x);
            i++;
        }
    }
}