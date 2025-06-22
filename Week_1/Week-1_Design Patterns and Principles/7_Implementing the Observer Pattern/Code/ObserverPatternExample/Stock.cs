public interface Stock
{
    void RegisterObserver(Observer observer);
    void DeregisterObserver(Observer observer);
    void NotifyObservers();
}
