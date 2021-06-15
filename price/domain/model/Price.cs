using System;
class Price: IPrice{
    public int IdProduct;
    public int ProductPrice;
    public DateTime UpdateDate;

    public Price(int idProduct, int price, DateTime updateDate){
        IdProduct = idProduct;
        ProductPrice = price;
        UpdateDate = updateDate;
    }
    
    public int GetPrice(){
        return ProductPrice;
    }
}