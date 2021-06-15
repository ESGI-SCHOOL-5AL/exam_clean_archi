using System;


class SellHistoryRepository{
    public static int GetPurchaseCountById(int idProduct, DateTime today){
        // Get number of times that customer purchased this item in a year period
        Random rnd = new Random();
        return rnd.Next();
    }

    public static int GetPurchaseCountExcludingId(int idProduct, DateTime today){
        // Get number of times that customer purchased other items except the one with id in parameter in a 6 months period
        Random rnd = new Random();
        return rnd.Next();
    }
}