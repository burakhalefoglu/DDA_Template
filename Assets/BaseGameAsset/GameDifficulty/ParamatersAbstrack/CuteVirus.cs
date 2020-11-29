using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Creator_Kit___FPS.Scenes.BurakÇalışma.GameDifficulty.ParamatersAbstrack
{
    interface ICuteVirus
    {
        int CuteVirusDifficultyOne { get; set; }
        int CuteVirusDifficultyTen { get; set; }
        float CuteVirusAttack { get; set; }
        float CuteVirusHealth { get; set; }
        float virusAttackDensity { get; set; }
        float virusWalkSpeed { get; set; }


    }
}
