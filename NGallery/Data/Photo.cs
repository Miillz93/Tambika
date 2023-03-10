namespace NGallery.Data;

public class Photo {
    public int id {get;set;}
    public int Name {get;set;}
    public int Path {get;set;}
    List<Category> Categories {get;set;}
}