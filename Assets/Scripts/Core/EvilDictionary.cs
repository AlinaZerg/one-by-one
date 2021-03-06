﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilDictionary : MonoBehaviour
{
    public virtual string[] EvilNames()
    {
        return evilNames;
    }

    private string[] evilNames = {
        "Abomination", "Abuse", "Aggression", "Agony",
        "Bereavement", "Blame", "Betrayal", "Breakdown",
        "Catastrophe", "Chaos", "Conceit", "Conflict", "Crime", "Corruption", "Cheerless",
        "Danger", "Darkness", "Defect", "Derision", "Doubt", "Doom",
        "Dull", "Dolor", "Desperation", "Depression", "Dejection",
        "Egotism", "Epidemic", "Exhausted", "Enragement", "Excruciation", "Envy", "Evil",
        "Fail", "Fake", "Fatal", "Fear", "Filth", "Fury", "Fall", "Frustration",
        "Gloomy", "Grumpy", "Grudge", "Grief",
        "Harassment", "Harmful", "Hatred", "Havoc", "Horrid",
        "Idiotic", "Ignore", "Impiety", "Impersonal", "Impolite", "Insanity",
        "Jaded", "Jarring", "Jeer", "Jobless", "Jittery",

        "Lack", "Lackadaisical", "Lawless", "Loneliness",
        "Mad", "Malaise", "Malign", "Manipulate", "Marginal", "Misery",
        "Mistake", "Madness", "Mirthless",
        "Negation", "Nervous", "Niggles", "Nonsense", "Not for me",
        "Objection", "Obuse", "Obscene", "Obstruct", "Omission",
        "Pain", "Panic", "Paranoia", "Peeve", "Pollution", "Prejudice",
        "Qualm", "Quandary", "Quarrel", "Questionable", "Quitter",
        "Rabid", "Racism", "Rage", "Rascal", "Repugnant",
        "Sad", "Sass", "Scam", "Scare", "Selfish", "Sorrow", "Sinister",
        "Tantrum", "Tease", "Terrible", "Tired", "Thwart",
        "Ugly","Uncaring", "Uncivil", "Unemployment", "Underdog",
        "Vague", "Vain", "Venomous", "Vex", "Violent",
        "Wail", "Wasted", "Wrath", "Weak", "Wicked", "Who am I?",
        "Zap", "Zealous",
        ":(", ":'("
    };
}