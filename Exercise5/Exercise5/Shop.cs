using System.Collections.Generic;

namespace Exercise5
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Phone[] Phones { get; set; }
        public Phone[] B { get; set; }
        int i;
        int n;
        
        public int Info()
        {
            for (n = 0; n < Phones.Length; n++)
            {
                if (Phone.IsAvailable)
                {
                    B[i] = Phones[n];
                    i++;
                }
            }
            return i;
        }
    }
}