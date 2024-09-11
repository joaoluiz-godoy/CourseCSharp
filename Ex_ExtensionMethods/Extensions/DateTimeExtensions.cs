namespace System //criando em baixo do namespace System deixa com que o extension méthod seja usado mais facilmente
{
    public static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj) //intuito é calcular o tempo decorrido em relação ao now, hoje.
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj); 
            if(duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1") + "hours";
            }
            return duration.TotalDays.ToString("F1") + "days"; //lembrar que o "F1" limita os decimais até a primeira casa
        }
    }
}
