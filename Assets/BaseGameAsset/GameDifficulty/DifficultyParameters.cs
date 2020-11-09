using Assets.Creator_Kit___FPS.Scenes.BurakÇalışma.GameDifficulty.ParamatersAbstrack;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyParameters : ICuteBacterium, ICuteMushy, ICuteVirus, IGermSlime, IGermSpike
{
    
    public int CuteBacteriumDifficultyOne { get; set; }
    public int CuteBacteriumDifficultyTen { get; set; }
    public int CuteMushyDifficultyOne { get; set; }
    public int CuteMushyDifficultyTen { get; set; }
    public int CuteVirusDifficultyOne { get; set; }
    public int CuteVirusDifficultyTen { get; set; }
    public int CuteVirusLevel { get; set; }
    public int CuteVirusAttackFrequency { get; set; }
    public int GermSlimeDifficultyOne { get; set; }
    public int GermSlimeDifficultyTen { get; set; }
    public int GermSlimeLevel { get; set; }
    public int GermSlimeAttackFrequency { get; set; }
    public int GermSpikeDifficultyOne { get; set; }
    public int GermSpikeDifficultyTen { get; set; }
}
