public class User: IUser {
    public int Id;
    public string Name;
    public string Login;

    public User(int id, string name, string login){
        Id = id;
        Name = name;
        Login = login;
    }
}