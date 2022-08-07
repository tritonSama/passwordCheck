using System.Collections;

namespace passwordCheck
{
    public class Class1
    {
        private string v;

        public List<string> reasons { get; set; }
        public bool V1 { get; }

        public Class1(string v)
        {
            this.v = v;
            reasons = new List<string>();
        }

        public Class1(string v, bool v1) : this(v)
        {
            V1 = v1;
        }

        public bool testLengh()
        {
            if (this.V1 == true)
            {
                if (v.Length <= 10)
                {
                    reasons.Add("Too short");
                    return false;
                }
                else
                {
                    return true;
                }

            }
            else
            { 
                if (v.Length <= 7)
                {
                    reasons.Add("Too short");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public bool testAlpha()
        {
            foreach (char c in v)
            {
                if ((c >= 'A' && c <= 'Z') |
                        (c >= 'a' && c <= 'z'))
                       
                {
                    
                    return true;
                }
            }
            reasons.Add("missing alpha");
            return false;
            
        }

        public bool testNum()
        {
            foreach (char c in v)
            {
                if (c >= '0' && c <= '9')

                {
                   
                    return true;
                }
            }
            reasons.Add("missing num");
            return false;
        }

        public bool test()
        {
           if(testAlpha() & testLengh() & testNum())
            {
                return true;
            }
           else
            {
                return false;
            }
        }
    }
}