using System;

class PriceCalculatorService {
    IUser User;
    bool IsLogged;
    ProductCatalogRepository ProductCatalogRepository;
    PriceRepository PriceRepository;
    SellHistoryRepository SellHistoryRepository;

    public PriceCalculatorService(
        IUser user, 
        bool isLogged, 
        ProductCatalogRepository productCatalogRepository, 
        PriceRepository priceRepository,
        SellHistoryRepository sellHistoryRepository
        ){
        User = user;
        IsLogged = isLogged;
        ProductCatalogRepository = productCatalogRepository;
        PriceRepository = priceRepository;
        SellHistoryRepository = sellHistoryRepository;
    }

    public (IProductCatalog, double) GetDisplay(int idProduct){
        ProductCatalog product = ProductCatalogRepository.GetProductById(idProduct);

        if(!IsLogged) {
            return (product, PriceRepository.GetProductPrice(idProduct)[0].GetPrice());
        }

        double total = PriceRepository.GetProductPrice(idProduct)[0].GetPrice();

        if(SellHistoryRepository.GetPurchaseCountExcludingId(idProduct, DateTime.Now) >= 3){
            total *= Discount.MinusTenPercent;
        }

        if(SellHistoryRepository.GetPurchaseCountById(idProduct, DateTime.Now) > 5){
            total *= Discount.PlusFivePercent;
        }

        return (product, total);
    }

}