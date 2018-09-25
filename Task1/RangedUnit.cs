﻿using System;
using System.IO;

namespace Task1
{
    public class RangedUnit : Unit
    {
        public RangedUnit(int xPos, int yPos, int HP, int maxHP, int speed, int attack, int atkRange, string team, string symbol, string name) : base(xPos, yPos, HP, maxHP, speed, attack, atkRange, team, symbol, name)
        {

        }

        public override void Attack()
        {
            HP -= attack;
        }

        public override bool inRange(int enemyX, int enemyY)
        {
            bool value = false;
            int x = Math.Abs(xPos - enemyX);
            int y = Math.Abs(yPos - enemyY);

            if ((x + y) <= atkRange)
            {
                value = true;
            }
            return value;
        }

        public override bool isDead()
        {
            bool value = false;
            if (HP <= 0)
            {
                value = true;
            }
            return value;
        }

        public override string ToString()
        {
            if (HP <= 0)
            {
                Symbol = "Dead";
            }
            return name + "," + symbol + "," + team + "," + xPos + "," + yPos + "," + HP;
        }

        public override void SaveUnit()
        {
            if (Directory.Exists("saves") != true)
            {
                Directory.CreateDirectory("saves");
            }

            FileStream file = new FileStream("saves/UnitSave.file", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(ToString());
            writer.Close();
            file.Close();
        }
    }
}
