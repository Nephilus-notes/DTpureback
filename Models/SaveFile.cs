﻿using DTpureback.Models.Resources;

namespace DTpureback.Models;

public class SaveFile : BaseEntity
{

    // Foreign Keys
    public string UserID { get; set; }
    public int PlayerCharacterID { get; set; }
    public string LocationID { get; set; }
    public string CharacterName { get; set; }
    //public virtual PlayerCharacter Character { get; set; }
}

