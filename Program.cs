using System;

namespace cleancode
{
public class Program
    {
        public static void Main(string[] args)
        {
            bool isLogged = false;
            int userId = 0;

            if(args.Length > 1){
                isLogged = true;
                userId = int.Parse(args[1]);
            }

            ILogger logger = new Logger();

            LogginService logginService = new LogginService(userId, "jean", "dupont", isLogged);
            ProductCatalogRepository productCatalogRepository = new ProductCatalogRepository();
            PriceRepository priceRepository = new PriceRepository();
            SellHistoryRepository sellHistoryRepository = new SellHistoryRepository();

            PriceCalculatorService priceCalculatorService = new PriceCalculatorService(
                logginService.User, 
                logginService.IsLoggedIn, 
                productCatalogRepository, 
                priceRepository, 
                sellHistoryRepository
                );

            (IProductCatalog product, double finalPrice) = priceCalculatorService.GetDisplay(int.Parse(args[0]));
            logger.Display(product.ProductInfo());
            logger.Display("[Price]: " + finalPrice.ToString());
        }
    }
}
