using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Creator_Kit___FPS.Scenes.BurakÇalışma.GameDifficulty.ParamatersAbstrack
{
    interface ICuteBacterium
    {
        int CuteBacteriumDifficultyOne { get; set; }
        int CuteBacteriumDifficultyTen { get; set; }
        float CuteBacteriumAttack { get; set; }
        float CuteBacteriumHealth { get; set; }
        float CuteBacteriumWalkSpeed { get; set; }
    }
}
