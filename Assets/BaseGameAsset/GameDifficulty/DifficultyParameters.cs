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
    public int GermSlimeDifficultyOne { get; set; }
    public int GermSlimeDifficultyTen { get; set; }
    public int GermSpikeDifficultyOne { get; set; }
    public int GermSpikeDifficultyTen { get; set; }
    public float CuteVirusAttack { get; set; }
    public float CuteVirusHealth { get; set; }
    public float virusAttackDensity { get; set; }
    public float virusWalkSpeed { get; set; }
    public float GermSlimeAttack { get; set; }
    public float GermSlimeHealth { get; set; }
    public float GermSlimeAttackDensity { get; set; }
    public float GermSlimeWalkSpeed { get; set; }
    public float GermSpikeAttack { get; set; }
    public float GermSpikeHealth { get; set; }
    public float GermSpikeWalkSpeed { get; set; }
    public float CuteBacteriumAttack { get; set; }
    public float CuteBacteriumHealth { get; set; }
    public float CuteBacteriumWalkSpeed { get; set; }
}
