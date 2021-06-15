using System.Collections.Generic;
class ProductCatalogRepository{

    public static ProductCatalog[] GetAllProducts(){
        Dictionary<string, string> details = new Dictionary<string, string>();
        details.Add("color", "black");
        details.Add("texture", "mat");
        return new ProductCatalog[]{
            new ProductCatalog(1, "Produit1", "Description1", details),
            new ProductCatalog(2, "Produit2", "Description2", details)
        };
    }

    public static ProductCatalog GetProductById(int id){
        Dictionary<string, string> details = new Dictionary<string, string>();
        details.Add("color", "black");
        details.Add("texture", "mat");
        return new ProductCatalog(id, "Produit1", "Description1", details);
    }
}