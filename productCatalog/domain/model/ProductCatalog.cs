using System.Collections.Generic;

class ProductCatalog: IProductCatalog {
    int Id;
    string Name;
    string Description;
    Dictionary<string, string> Details;

    public ProductCatalog(int id, string name, string description, Dictionary<string, string> details){
        Id = id;
        Name = name;
        Description = description;
        Details = details;
    }

    public string ProductInfo(){

        string details = "";

        foreach(KeyValuePair < string, string > keyValues in Details) {  
            details += keyValues.Key + " : " + keyValues.Value + ", ";  
        }
        details = details.TrimEnd(',', ' '); 

        return $"[Nom]: {Name}, [Description]: {Description}, [Details]: {details}";
    }
}
