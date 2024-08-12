using ZeldaMonsters.Models;

namespace ZeldaMonsters.Services;

//we're gonna add an interface to our API
//Interface == contract that child class has to have for parent class
public interface InterZelda_db
{
    Task<Zelda_db> SearchMonster(string monsterName);
}
