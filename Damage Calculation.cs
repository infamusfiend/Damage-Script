Private int pAttack = 100;
Private int mAttack = 100;
Private int pDefense = 50;
Private int mDefense = 50;
Private int hpMax = 100;
Private int hpCurrent = 100;
Private int critChance = 5;
Private float dodgeChance = 5;
Private float blockChance = 5;
Private float critDamage = 1.5f;
Private float elementalBoost = 2f;
Private float elementalDecrease = .5f;
Private float elementalNull = 1f;
Private bool didDodge = false;
Private bool didBlock = false;
Private bool isCritical = false;
Private bool elementalUp = false;
Private bool elementalDown = false;
Private bool elementalNeutral = false;

Public float pDamage = (pAttack - pDefense);
Public float mDamage = (mAttack - mDefense);
Public float damageDealt = (pDamage + mDamage);


//crit
Crit = new Random();
Int Cri = Crit.next(1.101);
If (Cri <= critChance) damageDealt = (damageDealt x critDamage);
isCritical = true;

//dodge
Dodge = new Random();
Int Dodg = Dodge.Next(1, 101);
If (Dodg <= dodgeChance) damageDealt = 0;
didDodge = true;




//block
Block = new Random();
Int Blk = Dodge.Next(1, 101);
If (Blk <= blockChance) damageDealt = 0;
didBlock = true;

//elemental boost
If {
elementalAttack = {Fire} && elementalDefense = {Ice}

Then {
damageDealt = (damageDealt x elementalBoost);
}

}

If {
elementalAttack = {Water} && elementalDefense = {Fire}

Then {
damageDealt = (damageDealt x elementalBoost);
}

}

If {
elementalAttack = {Thunder} && elementalDefense = {Water}

Then {
damageDealt = (damageDealt x elementalBoost);
}

}

If {
elementalAttack = {Ice} && elementalDefense = {Earth}

Then {
damageDealt = (damageDealt x elementalBoost);
}

}

If {
elementalAttack = {Earth} && elementalDefense = {Thunder}

Then {
damageDealt = (damageDealt x elementalBoost);
}

}

If {
elementalAttack = {Light} && elementalDefense = {Darkness}

Then {
damageDealt = (damageDealt x elementalBoost);
}

}

If {
elementalAttack = {Darkness} && elementalDefense = {Light}

Then {
damageDealt = (damageDealt x elementalBoost);
}

}



//elemental decrease

If {
elementalAttack = {Thunder} && elementalDefense = {Earth}

Then {
damageDealt = (damageDealt x elementalDecrease);
}

}




If {
elementalAttack = {Earth} && elementalDefense = {Ice}

Then {
damageDealt = (damageDealt x elementalDecrease);
}

}

If {
elementalAttack = {Ice} && elementalDefense = {Fire}

Then {
damageDealt = (damageDealt x elementalDecrease);
}

}

If {
elementalAttack = {Fire} && elementalDefense = {Water}

Then {
damageDealt = (damageDealt x elementalDecrease);
}

}

If {
elementalAttack = {Water} && elementalDefense = {Thunder}

Then {
damageDealt = (damageDealt x elementalDecrease);
}

}



