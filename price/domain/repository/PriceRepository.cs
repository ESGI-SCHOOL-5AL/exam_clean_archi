using System;

class PriceRepository{

    public static IPrice[] GetProductPrice(int idProduct){
        return new Price[]{
            new Price(idProduct, 10, DateTime.Now),
            new Price(idProduct, 20, DateTime.Now),
        };
    }
}