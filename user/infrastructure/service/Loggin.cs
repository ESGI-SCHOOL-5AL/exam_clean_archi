public class LogginService {
    public User User;
    public bool IsLoggedIn;

    public LogginService(int id, string name, string login, bool isLoggedIn){
        User = new User(id, name, login);
        IsLoggedIn = isLoggedIn;
    }

    public void SwapCurrentLogginStatus(){
        IsLoggedIn = !IsLoggedIn;
    }
}