namespace Exercise5
{
    public class Objects
    {
        public Shop[] Shops { get; set; }
        private ILogger<Root> logger = new MyLogger<Root>().Logger;

        public void DisplayInfo()
        {
            foreach (var shop in Shops)
            {
                logger.LogInformation(
                    $"{shop.Id} - {shop.Name}\n\tDescription: {shop.Description}\n\tPhones available: {shop.PhonesCount()} (Android: {shop.AndroidPhonesCount()}, IOS: {shop.IosPhonesCount()})");
            }
        }
    }
}