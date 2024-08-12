using ZeldaMonsters.Models;

namespace ZeldaMonsters.Services;

public class Zelda_dbService : InterZelda_db
{
    public async Task<Zelda_db> SearchMonster(string monsterName) //our async task 
    {
        //Vcreate URL as a string w/ all info necessaryV
        string url = $"https://zelda.fanapis.com/api/monsters?name={monsterName}"; 
        //Vcall API, GET response!V
        using (HttpClient client = new HttpClient()) //instantaneous connection that cuts off after request made
        {
            try
            {
                Zelda_db response = await client.GetFromJsonAsync<Zelda_db>(url);
                //^this code is telling us to GET the url outlined in our string, now turn into a c# obj

                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null; // logs what went wrong, returns an error message
            }
        }
    }
}
