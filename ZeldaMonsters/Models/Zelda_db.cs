using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ZeldaMonsters.Models;

public class Zelda_db
{
    public bool success { get; set; }
    public int count { get; set; }
    public List<MonsterData> data { get; set; }
}
