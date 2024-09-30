public interface IMedicine
{
    string GetMedicineName();

    string GetDose();

    List<string> GetSideEffect();

    bool IsExpeired(DateTime expiryDate);
    

    void Administer();
}