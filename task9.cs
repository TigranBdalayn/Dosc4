// Task 9: Game Character System
// Task: Create a partial class.
// Create a partial class Character in two separate files:
// One part contains fields characterName and level.
// The other contains a method ShowCharacterInfo().
// In Main(), create a Character object and call ShowCharacterInfo().

using System;


public partial class  Character {

    public string CharacterName;
    public int Level;

    public Character (string name, int level) {
        CharacterName = name;
        Level = level;
    }

}

public partial class Character {

    public void ShowCharacterinfo () {
        Console.WriteLine ($"\nCharacter: {CharacterName}\nLevel: {Level}\n");
    }
}




class Program {
    static void Main (string [] args) {
        
        Character ch = new Character ("X", 5);
        ch.ShowCharacterinfo ();
    }
}